
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabKeyFldV2BL
 表名:vPrjTabKeyFldV2(00050612)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:59
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
 框架-层名:业务逻辑层(CS)(BusinessLogic,0003)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using System.Globalization;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Xml;
using Newtonsoft.Json;
using com.taishsoft.file;
using com.taishsoft.common;
using com.taishsoft.commdb;
using com.taishsoft.comm_db_obj;
using com.taishsoft.json;
using com.taishsoft.dynamiccompiler;
using com.taishsoft.datetime;
using AGC.Entity;
using System.Data; 
using System.Data.SqlClient; 
using AGC.DAL;

namespace AGC.BusinessLogic
{
public static class  clsvPrjTabKeyFldV2BL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabKeyFldV2EN GetObj(this K_TabId_vPrjTabKeyFldV2 myKey)
{
clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = clsvPrjTabKeyFldV2BL.vPrjTabKeyFldV2DA.GetObjByTabId(myKey.Value);
return objvPrjTabKeyFldV2EN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetTabId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strTabId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strTabId, 8, convPrjTabKeyFldV2.TabId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strTabId, 8, convPrjTabKeyFldV2.TabId);
}
objvPrjTabKeyFldV2EN.TabId = strTabId; //表ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.TabId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.TabId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.TabId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetFldId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strFldId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFldId, convPrjTabKeyFldV2.FldId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFldId, 8, convPrjTabKeyFldV2.FldId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFldId, 8, convPrjTabKeyFldV2.FldId);
}
objvPrjTabKeyFldV2EN.FldId = strFldId; //字段Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.FldId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.FldId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.FldId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetPrimaryTypeId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strPrimaryTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strPrimaryTypeId, convPrjTabKeyFldV2.PrimaryTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeId, 2, convPrjTabKeyFldV2.PrimaryTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strPrimaryTypeId, 2, convPrjTabKeyFldV2.PrimaryTypeId);
}
objvPrjTabKeyFldV2EN.PrimaryTypeId = strPrimaryTypeId; //主键类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.PrimaryTypeId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.PrimaryTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetKeyFldName(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strKeyFldName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strKeyFldName, 300, convPrjTabKeyFldV2.KeyFldName);
}
objvPrjTabKeyFldV2EN.KeyFldName = strKeyFldName; //关键字段名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.KeyFldName) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.KeyFldName, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.KeyFldName] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetPrimaryTypeName(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strPrimaryTypeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strPrimaryTypeName, 30, convPrjTabKeyFldV2.PrimaryTypeName);
}
objvPrjTabKeyFldV2EN.PrimaryTypeName = strPrimaryTypeName; //主键类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.PrimaryTypeName) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.PrimaryTypeName, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeName] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetFieldTypeId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strFieldTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFieldTypeId, 2, convPrjTabKeyFldV2.FieldTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFieldTypeId, 2, convPrjTabKeyFldV2.FieldTypeId);
}
objvPrjTabKeyFldV2EN.FieldTypeId = strFieldTypeId; //字段类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.FieldTypeId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.FieldTypeId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.FieldTypeId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjTabKeyFldV2EN SetCmPrjId(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN, string strCmPrjId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCmPrjId, convPrjTabKeyFldV2.CmPrjId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCmPrjId, 6, convPrjTabKeyFldV2.CmPrjId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCmPrjId, 6, convPrjTabKeyFldV2.CmPrjId);
}
objvPrjTabKeyFldV2EN.CmPrjId = strCmPrjId; //Cm工程Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjTabKeyFldV2EN.dicFldComparisonOp.ContainsKey(convPrjTabKeyFldV2.CmPrjId) == false)
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp.Add(convPrjTabKeyFldV2.CmPrjId, strComparisonOp);
}
else
{
objvPrjTabKeyFldV2EN.dicFldComparisonOp[convPrjTabKeyFldV2.CmPrjId] = strComparisonOp;
}
}
return objvPrjTabKeyFldV2EN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2ENS">源对象</param>
 /// <param name = "objvPrjTabKeyFldV2ENT">目标对象</param>
 public static void CopyTo(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENS, clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENT)
{
try
{
objvPrjTabKeyFldV2ENT.TabId = objvPrjTabKeyFldV2ENS.TabId; //表ID
objvPrjTabKeyFldV2ENT.FldId = objvPrjTabKeyFldV2ENS.FldId; //字段Id
objvPrjTabKeyFldV2ENT.PrimaryTypeId = objvPrjTabKeyFldV2ENS.PrimaryTypeId; //主键类型ID
objvPrjTabKeyFldV2ENT.KeyFldName = objvPrjTabKeyFldV2ENS.KeyFldName; //关键字段名
objvPrjTabKeyFldV2ENT.PrimaryTypeName = objvPrjTabKeyFldV2ENS.PrimaryTypeName; //主键类型名
objvPrjTabKeyFldV2ENT.FieldTypeId = objvPrjTabKeyFldV2ENS.FieldTypeId; //字段类型Id
objvPrjTabKeyFldV2ENT.CmPrjId = objvPrjTabKeyFldV2ENS.CmPrjId; //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000166)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyTo)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2ENS">源对象</param>
 /// <returns>目标对象=>clsvPrjTabKeyFldV2EN:objvPrjTabKeyFldV2ENT</returns>
 public static clsvPrjTabKeyFldV2EN CopyTo(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENS)
{
try
{
 clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENT = new clsvPrjTabKeyFldV2EN()
{
TabId = objvPrjTabKeyFldV2ENS.TabId, //表ID
FldId = objvPrjTabKeyFldV2ENS.FldId, //字段Id
PrimaryTypeId = objvPrjTabKeyFldV2ENS.PrimaryTypeId, //主键类型ID
KeyFldName = objvPrjTabKeyFldV2ENS.KeyFldName, //关键字段名
PrimaryTypeName = objvPrjTabKeyFldV2ENS.PrimaryTypeName, //主键类型名
FieldTypeId = objvPrjTabKeyFldV2ENS.FieldTypeId, //字段类型Id
CmPrjId = objvPrjTabKeyFldV2ENS.CmPrjId, //Cm工程Id
};
 return objvPrjTabKeyFldV2ENT;
}
catch (Exception objException)
{
string strMsg = string.Format("(errid:Busi000167)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN)
{
 clsvPrjTabKeyFldV2BL.vPrjTabKeyFldV2DA.CheckProperty4Condition(objvPrjTabKeyFldV2EN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2Cond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.TabId) == true)
{
string strComparisonOpTabId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.TabId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.TabId, objvPrjTabKeyFldV2Cond.TabId, strComparisonOpTabId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.FldId) == true)
{
string strComparisonOpFldId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.FldId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.FldId, objvPrjTabKeyFldV2Cond.FldId, strComparisonOpFldId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.PrimaryTypeId) == true)
{
string strComparisonOpPrimaryTypeId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.PrimaryTypeId, objvPrjTabKeyFldV2Cond.PrimaryTypeId, strComparisonOpPrimaryTypeId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.KeyFldName) == true)
{
string strComparisonOpKeyFldName = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.KeyFldName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.KeyFldName, objvPrjTabKeyFldV2Cond.KeyFldName, strComparisonOpKeyFldName);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.PrimaryTypeName) == true)
{
string strComparisonOpPrimaryTypeName = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.PrimaryTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.PrimaryTypeName, objvPrjTabKeyFldV2Cond.PrimaryTypeName, strComparisonOpPrimaryTypeName);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.FieldTypeId) == true)
{
string strComparisonOpFieldTypeId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.FieldTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.FieldTypeId, objvPrjTabKeyFldV2Cond.FieldTypeId, strComparisonOpFieldTypeId);
}
if (objvPrjTabKeyFldV2Cond.IsUpdated(convPrjTabKeyFldV2.CmPrjId) == true)
{
string strComparisonOpCmPrjId = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[convPrjTabKeyFldV2.CmPrjId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjTabKeyFldV2.CmPrjId, objvPrjTabKeyFldV2Cond.CmPrjId, strComparisonOpCmPrjId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjTabKeyFldV2
{
public virtual bool UpdRelaTabDate(string strTabId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPrjTabKeyFldV2(vPrjTabKeyFldV2)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjTabKeyFldV2BL
{
public static RelatedActions_vPrjTabKeyFldV2 relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjTabKeyFldV2DA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjTabKeyFldV2DA vPrjTabKeyFldV2DA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjTabKeyFldV2DA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjTabKeyFldV2BL()
 {
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSpecSQLObj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public static clsSpecSQLforSql GetSpecSQLObj() 
{
if (clsSysParaEN.objLog == null)
{
throw new Exception("请初始化用于记录日志的clsSysParaEN.objLog对象!");
}
if (clsSysParaEN.objErrorLog == null)
{
throw new Exception("请初始化用于记录错误日志的clsSysParaEN.objErrorLog对象!");
}
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName == true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsvPrjTabKeyFldV2EN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabKeyFldV2EN._ConnectString);
}
return objSQL;
}



 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_vPrjTabKeyFldV2(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable_vPrjTabKeyFldV2(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000005)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable(strWhereCond);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000006)获取表数据出错!(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTable)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable(strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000007)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}), {2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable(strWhereCond, strTabName);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000061)获取表数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByTabName)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable(string strWhereCond, string strTabName, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable(strWhereCond, strTabName, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000062)获取表数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTable_Top(stuTopPara objTopPara)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable_Top(objTopPara);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000009)获取表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
objTopPara.whereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopDataTable)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTable_Top(int intTopSize, string strWhereCond, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000010)获取表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表,用DataTable表示</returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000012)获取分页表顶数据出错!(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时可以排除一些关键字不检查
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetDataTableByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public static DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
DataTable objDT;
try
{
objDT = vPrjTabKeyFldV2DA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
return objDT;
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000013)获取分页表顶数据出错!(排除的检查字符串列表)(strWhereCond = {1}),{2}.({0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 获取数据表的DataTable


 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据关键字列表获取相关对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLst)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByTabIdLst(List<string> arrTabIdLst)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrTabIdLst, true);
 string strWhereCond = string.Format("TabId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrTabIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjTabKeyFldV2EN> GetObjLstByTabIdLstCache(List<string> arrTabIdLst, string strCmPrjId)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLst_Sel =
arrvPrjTabKeyFldV2ObjLstCache
.Where(x => arrTabIdLst.Contains(x.TabId));
return arrvPrjTabKeyFldV2ObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLst(string strWhereCond)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjTabKeyFldV2EN> GetSubObjLstCache(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2Cond)
{
 string strCmPrjId = objvPrjTabKeyFldV2Cond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvPrjTabKeyFldV2BL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabKeyFldV2EN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTabKeyFldV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabKeyFldV2._AttributeName)
{
if (objvPrjTabKeyFldV2Cond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabKeyFldV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldV2Cond[strFldName].ToString());
}
else
{
if (objvPrjTabKeyFldV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabKeyFldV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldV2Cond[strFldName]));
}
}
}
return arrObjLstSel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByTabName)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = GetObjLst(strWhereCond);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}
 /// <summary>
 /// 根据条件获取JSON对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetJSONObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static string GetJSONObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetTopObjLst(stuTopPara objTopPara)
{
 return GetTopObjLst( objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 stuTopPara objTopPara = new stuTopPara()
 {
 topSize = intTopSize,
 whereCond = strWhereCond,
 orderBy = strOrderBy
 };
 objDT = GetDataTable_Top(objTopPara);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByPager(stuPagerPara objPagerPara)
{
 return GetObjLstByPager(objPagerPara.pageIndex, objPagerPara.pageSize, objPagerPara.whereCond, objPagerPara.orderBy);
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}
 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strWhereCond">给定条件</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">查询条件中排除的标志列表</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjTabKeyFldV2EN> arrObjLst = new List<clsvPrjTabKeyFldV2EN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = new clsvPrjTabKeyFldV2EN();
try
{
objvPrjTabKeyFldV2EN.TabId = objRow[convPrjTabKeyFldV2.TabId].ToString().Trim(); //表ID
objvPrjTabKeyFldV2EN.FldId = objRow[convPrjTabKeyFldV2.FldId].ToString().Trim(); //字段Id
objvPrjTabKeyFldV2EN.PrimaryTypeId = objRow[convPrjTabKeyFldV2.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvPrjTabKeyFldV2EN.KeyFldName = objRow[convPrjTabKeyFldV2.KeyFldName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.KeyFldName].ToString().Trim(); //关键字段名
objvPrjTabKeyFldV2EN.PrimaryTypeName = objRow[convPrjTabKeyFldV2.PrimaryTypeName] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.PrimaryTypeName].ToString().Trim(); //主键类型名
objvPrjTabKeyFldV2EN.FieldTypeId = objRow[convPrjTabKeyFldV2.FieldTypeId] == DBNull.Value ? null : objRow[convPrjTabKeyFldV2.FieldTypeId].ToString().Trim(); //字段类型Id
objvPrjTabKeyFldV2EN.CmPrjId = objRow[convPrjTabKeyFldV2.CmPrjId].ToString().Trim(); //Cm工程Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjTabKeyFldV2EN.TabId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjTabKeyFldV2EN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjTabKeyFldV2(ref clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN)
{
bool bolResult = vPrjTabKeyFldV2DA.GetvPrjTabKeyFldV2(ref objvPrjTabKeyFldV2EN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjTabKeyFldV2EN GetObjByTabId(string strTabId)
{
if (strTabId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strTabId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strTabId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = vPrjTabKeyFldV2DA.GetObjByTabId(strTabId);
return objvPrjTabKeyFldV2EN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjTabKeyFldV2EN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = vPrjTabKeyFldV2DA.GetFirstObj(strWhereCond);
 return objvPrjTabKeyFldV2EN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000022)获取当前表满足条件的第一条记录数据出错!(strWhereCond = {1}),{2}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
strWhereCond,
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 把DataRow转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRow</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvPrjTabKeyFldV2EN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = vPrjTabKeyFldV2DA.GetObjByDataRow(objRow);
 return objvPrjTabKeyFldV2EN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000051)根据DataRow记录获取对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 把DataRowView转换成相关实体对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecValueObjByDataRow_S)
 /// </summary>
 /// <param name = "objRow">给定的DataRowView</param>
 /// <returns>返回相关的实体对象</returns>
public static clsvPrjTabKeyFldV2EN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN = vPrjTabKeyFldV2DA.GetObjByDataRow(objRow);
 return objvPrjTabKeyFldV2EN;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000052)通过DataRowView记录对象出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}

 /// <summary>
 /// 根据关键字获取相关对象, 从给定的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyFromList)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "lstvPrjTabKeyFldV2ObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabKeyFldV2EN GetObjByTabIdFromList(string strTabId, List<clsvPrjTabKeyFldV2EN> lstvPrjTabKeyFldV2ObjLst)
{
foreach (clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN in lstvPrjTabKeyFldV2ObjLst)
{
if (objvPrjTabKeyFldV2EN.TabId == strTabId)
{
return objvPrjTabKeyFldV2EN;
}
}
return null;
}


 #endregion 获取一个实体对象


 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public static string GetFirstID_S(string strWhereCond) 
{
 string strTabId;
 try
 {
 strTabId = new clsvPrjTabKeyFldV2DA().GetFirstID(strWhereCond);
 return strTabId;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000023)获取First关键字出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取一个关键字值


 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的关键字值列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetPrimaryKeyID_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回满足条件的关键字列表值</returns>
public static List<string> GetPrimaryKeyID_S(string strWhereCond) 
{
 List<string> arrList;
 try
 {
 arrList = vPrjTabKeyFldV2DA.GetID(strWhereCond);
 return arrList;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000026)获取关键字列表出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 获取多个关键字值列表


 #region 判断记录是否存在

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistRecord)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public static bool IsExistRecord(string strWhereCond)
{
//检测记录是否存在
bool bolIsExist = vPrjTabKeyFldV2DA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strTabId)
{
if (string.IsNullOrEmpty(strTabId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strTabId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjTabKeyFldV2DA.IsExist(strTabId);
return bolIsExist;
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable() 
{
 bool bolIsExist;
 try
 {
 bolIsExist = clsvPrjTabKeyFldV2DA.IsExistTable();
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000028)检查是否存在当前表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}
 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExistTable)
 /// </summary>
 /// <param name = "strTabName">给定表</param>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable(string strTabName) 
{
 bool bolIsExist;
 try
 {
 bolIsExist = vPrjTabKeyFldV2DA.IsExistTable(strTabName);
 return bolIsExist;
 }
 catch (Exception objException)
 {
var strMsg = string.Format("(errid:Busi000029)检查是否存在指定表(IsExistTable)出错, {1}.(from {0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
 }
}


 #endregion 判断记录是否存在


 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2ENS">源对象</param>
 /// <param name = "objvPrjTabKeyFldV2ENT">目标对象</param>
 public static void CopyTo(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENS, clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2ENT)
{
try
{
objvPrjTabKeyFldV2ENT.TabId = objvPrjTabKeyFldV2ENS.TabId; //表ID
objvPrjTabKeyFldV2ENT.FldId = objvPrjTabKeyFldV2ENS.FldId; //字段Id
objvPrjTabKeyFldV2ENT.PrimaryTypeId = objvPrjTabKeyFldV2ENS.PrimaryTypeId; //主键类型ID
objvPrjTabKeyFldV2ENT.KeyFldName = objvPrjTabKeyFldV2ENS.KeyFldName; //关键字段名
objvPrjTabKeyFldV2ENT.PrimaryTypeName = objvPrjTabKeyFldV2ENS.PrimaryTypeName; //主键类型名
objvPrjTabKeyFldV2ENT.FieldTypeId = objvPrjTabKeyFldV2ENS.FieldTypeId; //字段类型Id
objvPrjTabKeyFldV2ENT.CmPrjId = objvPrjTabKeyFldV2ENS.CmPrjId; //Cm工程Id
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:Busi000045)Copy表对象数据出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 设置修改标志,即根据字段修改标志字符串获取哪一个字段已经被修改
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_SetUpdFlag_S)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN)
{
try
{
objvPrjTabKeyFldV2EN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjTabKeyFldV2EN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjTabKeyFldV2.TabId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.TabId = objvPrjTabKeyFldV2EN.TabId; //表ID
}
if (arrFldSet.Contains(convPrjTabKeyFldV2.FldId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.FldId = objvPrjTabKeyFldV2EN.FldId; //字段Id
}
if (arrFldSet.Contains(convPrjTabKeyFldV2.PrimaryTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.PrimaryTypeId = objvPrjTabKeyFldV2EN.PrimaryTypeId; //主键类型ID
}
if (arrFldSet.Contains(convPrjTabKeyFldV2.KeyFldName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.KeyFldName = objvPrjTabKeyFldV2EN.KeyFldName == "[null]" ? null :  objvPrjTabKeyFldV2EN.KeyFldName; //关键字段名
}
if (arrFldSet.Contains(convPrjTabKeyFldV2.PrimaryTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.PrimaryTypeName = objvPrjTabKeyFldV2EN.PrimaryTypeName == "[null]" ? null :  objvPrjTabKeyFldV2EN.PrimaryTypeName; //主键类型名
}
if (arrFldSet.Contains(convPrjTabKeyFldV2.FieldTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.FieldTypeId = objvPrjTabKeyFldV2EN.FieldTypeId == "[null]" ? null :  objvPrjTabKeyFldV2EN.FieldTypeId; //字段类型Id
}
if (arrFldSet.Contains(convPrjTabKeyFldV2.CmPrjId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjTabKeyFldV2EN.CmPrjId = objvPrjTabKeyFldV2EN.CmPrjId; //Cm工程Id
}
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:001)设置表的修改标志出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}

 /// <summary>
 /// 处理从Web端传来的[null]的字段值,在WebApi端设置成null
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_AccessFldValueNull)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2EN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN)
{
try
{
if (objvPrjTabKeyFldV2EN.KeyFldName == "[null]") objvPrjTabKeyFldV2EN.KeyFldName = null; //关键字段名
if (objvPrjTabKeyFldV2EN.PrimaryTypeName == "[null]") objvPrjTabKeyFldV2EN.PrimaryTypeName = null; //主键类型名
if (objvPrjTabKeyFldV2EN.FieldTypeId == "[null]") objvPrjTabKeyFldV2EN.FieldTypeId = null; //字段类型Id
}
catch (Exception objException)
{
var strMsg = string.Format("(errid:002)处理从Web端传来的[null]的字段值出错,{1}.({0})",
clsStackTrace.GetCurrClassFunction(),
objException.Message); 
throw new Exception(strMsg); 
}
}


 #endregion 克隆复制对象


 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值在组织查询条件时是否合法,1)检查是否包含【 = 】【 and 】;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_CheckProperty4Condition)
 /// </summary>
public static void CheckProperty4Condition(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2EN)
{
 vPrjTabKeyFldV2DA.CheckProperty4Condition(objvPrjTabKeyFldV2EN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框


 #endregion 绑定下拉框


 #region 缓存操作

 /// <summary>
 /// 初始化列表缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_InitListCache)
 /// </summary>
public static void InitListCache()
{
//检查缓存刷新机制
string strMsg;
if (clsPrjTabFldBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabFldBL没有刷新缓存机制(clsPrjTabFldBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsPrimaryTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrimaryTypeBL没有刷新缓存机制(clsPrimaryTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFieldTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFieldTabBL没有刷新缓存机制(clsFieldTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by TabId");
//if (arrvPrjTabKeyFldV2ObjLstCache == null)
//{
//arrvPrjTabKeyFldV2ObjLstCache = vPrjTabKeyFldV2DA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strTabId">所给的关键字</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjTabKeyFldV2EN GetObjByTabIdCache(string strTabId, string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLst_Sel =
arrvPrjTabKeyFldV2ObjLstCache
.Where(x=> x.TabId == strTabId 
);
if (arrvPrjTabKeyFldV2ObjLst_Sel.Count() == 0)
{
   clsvPrjTabKeyFldV2EN obj = clsvPrjTabKeyFldV2BL.GetObjByTabId(strTabId);
   if (obj != null)
 {
if (obj.CmPrjId == strCmPrjId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", strTabId, strCmPrjId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvPrjTabKeyFldV2ObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetAllvPrjTabKeyFldV2ObjLstCache(string strCmPrjId)
{
//获取缓存中的对象列表
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = GetObjLstCache(strCmPrjId); 
return arrvPrjTabKeyFldV2ObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjTabKeyFldV2EN> GetObjLstCache(string strCmPrjId)
{

if (string.IsNullOrEmpty(strCmPrjId) == true)
{
  var strMsg = string.Format("参数:[strCmPrjId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
if (strCmPrjId.Length != 6)
{
var strMsg = string.Format("缓存分类变量:[strCmPrjId]的长度:[{0}]不正确!(In {1})", strCmPrjId.Length, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
string strCondition = string.Format("CmPrjId='{0}'", strCmPrjId);
List<clsvPrjTabKeyFldV2EN> arrvPrjTabKeyFldV2ObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvPrjTabKeyFldV2ObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strCmPrjId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvPrjTabKeyFldV2EN._CurrTabName, strCmPrjId);
CacheHelper.Remove(strKey);
clsvPrjTabKeyFldV2EN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
/// 获取最新的缓存刷新时间
/// </summary>
/// <returns>最新的缓存刷新时间，字符串型</returns>
public static string GetLastRefreshTime()
{
if (clsvPrjTabKeyFldV2EN._RefreshTimeLst.Count == 0) return "";
return clsvPrjTabKeyFldV2EN._RefreshTimeLst[clsvPrjTabKeyFldV2EN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-07-28
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <param name = "strCmPrjId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strTabId, string strCmPrjId)
{
if (strInFldName != convPrjTabKeyFldV2.TabId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjTabKeyFldV2._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjTabKeyFldV2._AttributeName));
throw new Exception(strMsg);
}
var objvPrjTabKeyFldV2 = clsvPrjTabKeyFldV2BL.GetObjByTabIdCache(strTabId, strCmPrjId);
if (objvPrjTabKeyFldV2 == null) return "";
return objvPrjTabKeyFldV2[strOutFldName].ToString();
}


 #region 有关JSON操作


 #endregion 有关JSON操作


 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
int intRecCount = clsvPrjTabKeyFldV2DA.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strWhereCond)
{
int intRecCount = clsvPrjTabKeyFldV2DA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjTabKeyFldV2DA.GetRecCount();
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCond)
 /// </summary>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond( string strWhereCond)
{
int intRecCount = clsvPrjTabKeyFldV2DA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjTabKeyFldV2Cond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjTabKeyFldV2EN objvPrjTabKeyFldV2Cond)
{
 string strCmPrjId = objvPrjTabKeyFldV2Cond.CmPrjId;
 if (string.IsNullOrEmpty(strCmPrjId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvPrjTabKeyFldV2BL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvPrjTabKeyFldV2EN> arrObjLstCache = GetObjLstCache(strCmPrjId);
IEnumerable <clsvPrjTabKeyFldV2EN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjTabKeyFldV2._AttributeName)
{
if (objvPrjTabKeyFldV2Cond.IsUpdated(strFldName) == false) continue;
if (objvPrjTabKeyFldV2Cond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldV2Cond[strFldName].ToString());
}
else
{
if (objvPrjTabKeyFldV2Cond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjTabKeyFldV2Cond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjTabKeyFldV2Cond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjTabKeyFldV2Cond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjTabKeyFldV2Cond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldV2Cond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjTabKeyFldV2Cond[strFldName]));
}
}
}
return arrObjLstSel.Count();
}

 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strWhereCond)
{
 List<string> arrList = clsvPrjTabKeyFldV2DA.GetFldValue(strTabName, strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValue)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValue(string strFldName, string strWhereCond)
{
 List<string> arrList = vPrjTabKeyFldV2DA.GetFldValue(strFldName, strWhereCond);
return arrList;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFldValueNoDistinct)
 /// </summary>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strWhereCond">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static List<string> GetFldValueNoDistinct(string strFldName, string strWhereCond)
{
 List<string> arrList = vPrjTabKeyFldV2DA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}