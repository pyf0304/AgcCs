
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDict4GCBL
 表名:vDict4GC(00050353)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:12:43
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
public static class  clsvDict4GCBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDict4GCEN GetObj(this K_DictId_vDict4GC myKey)
{
clsvDict4GCEN objvDict4GCEN = clsvDict4GCBL.vDict4GCDA.GetObjByDictId(myKey.Value);
return objvDict4GCEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictId(this clsvDict4GCEN objvDict4GCEN, string strDictId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictId, 8, convDict4GC.DictId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDictId, 8, convDict4GC.DictId);
}
objvDict4GCEN.DictId = strDictId; //字典Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictId) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictId, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictId] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictValue(this clsvDict4GCEN objvDict4GCEN, string strDictValue, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictValue, convDict4GC.DictValue);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictValue, 500, convDict4GC.DictValue);
}
objvDict4GCEN.DictValue = strDictValue; //字典值
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictValue) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictValue, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictValue] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictTypeId(this clsvDict4GCEN objvDict4GCEN, string strDictTypeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictTypeId, 4, convDict4GC.DictTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strDictTypeId, 4, convDict4GC.DictTypeId);
}
objvDict4GCEN.DictTypeId = strDictTypeId; //字典类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictTypeId) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictTypeId, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictTypeId] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictTypeName(this clsvDict4GCEN objvDict4GCEN, string strDictTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictTypeName, convDict4GC.DictTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictTypeName, 50, convDict4GC.DictTypeName);
}
objvDict4GCEN.DictTypeName = strDictTypeName; //字典类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictTypeName) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictTypeName, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictTypeName] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictKey1(this clsvDict4GCEN objvDict4GCEN, string strDictKey1, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictKey1, convDict4GC.DictKey1);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictKey1, 50, convDict4GC.DictKey1);
}
objvDict4GCEN.DictKey1 = strDictKey1; //字典关键字1
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictKey1) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictKey1, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictKey1] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetDictKey2(this clsvDict4GCEN objvDict4GCEN, string strDictKey2, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strDictKey2, convDict4GC.DictKey2);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strDictKey2, 50, convDict4GC.DictKey2);
}
objvDict4GCEN.DictKey2 = strDictKey2; //字典关键字2
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.DictKey2) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.DictKey2, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.DictKey2] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetUpdDate(this clsvDict4GCEN objvDict4GCEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convDict4GC.UpdDate);
}
objvDict4GCEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.UpdDate) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.UpdDate, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.UpdDate] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetUpdUser(this clsvDict4GCEN objvDict4GCEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convDict4GC.UpdUser);
}
objvDict4GCEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.UpdUser) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.UpdUser, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.UpdUser] = strComparisonOp;
}
}
return objvDict4GCEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvDict4GCEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvDict4GCEN SetMemo(this clsvDict4GCEN objvDict4GCEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convDict4GC.Memo);
}
objvDict4GCEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvDict4GCEN.dicFldComparisonOp.ContainsKey(convDict4GC.Memo) == false)
{
objvDict4GCEN.dicFldComparisonOp.Add(convDict4GC.Memo, strComparisonOp);
}
else
{
objvDict4GCEN.dicFldComparisonOp[convDict4GC.Memo] = strComparisonOp;
}
}
return objvDict4GCEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvDict4GCENS">源对象</param>
 /// <param name = "objvDict4GCENT">目标对象</param>
 public static void CopyTo(this clsvDict4GCEN objvDict4GCENS, clsvDict4GCEN objvDict4GCENT)
{
try
{
objvDict4GCENT.DictId = objvDict4GCENS.DictId; //字典Id
objvDict4GCENT.DictValue = objvDict4GCENS.DictValue; //字典值
objvDict4GCENT.DictTypeId = objvDict4GCENS.DictTypeId; //字典类型Id
objvDict4GCENT.DictTypeName = objvDict4GCENS.DictTypeName; //字典类型名
objvDict4GCENT.DictKey1 = objvDict4GCENS.DictKey1; //字典关键字1
objvDict4GCENT.DictKey2 = objvDict4GCENS.DictKey2; //字典关键字2
objvDict4GCENT.UpdDate = objvDict4GCENS.UpdDate; //修改日期
objvDict4GCENT.UpdUser = objvDict4GCENS.UpdUser; //修改者
objvDict4GCENT.Memo = objvDict4GCENS.Memo; //说明
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
 /// <param name = "objvDict4GCENS">源对象</param>
 /// <returns>目标对象=>clsvDict4GCEN:objvDict4GCENT</returns>
 public static clsvDict4GCEN CopyTo(this clsvDict4GCEN objvDict4GCENS)
{
try
{
 clsvDict4GCEN objvDict4GCENT = new clsvDict4GCEN()
{
DictId = objvDict4GCENS.DictId, //字典Id
DictValue = objvDict4GCENS.DictValue, //字典值
DictTypeId = objvDict4GCENS.DictTypeId, //字典类型Id
DictTypeName = objvDict4GCENS.DictTypeName, //字典类型名
DictKey1 = objvDict4GCENS.DictKey1, //字典关键字1
DictKey2 = objvDict4GCENS.DictKey2, //字典关键字2
UpdDate = objvDict4GCENS.UpdDate, //修改日期
UpdUser = objvDict4GCENS.UpdUser, //修改者
Memo = objvDict4GCENS.Memo, //说明
};
 return objvDict4GCENT;
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
public static void CheckProperty4Condition(this clsvDict4GCEN objvDict4GCEN)
{
 clsvDict4GCBL.vDict4GCDA.CheckProperty4Condition(objvDict4GCEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvDict4GCEN objvDict4GCCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvDict4GCCond.IsUpdated(convDict4GC.DictId) == true)
{
string strComparisonOpDictId = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictId, objvDict4GCCond.DictId, strComparisonOpDictId);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictValue) == true)
{
string strComparisonOpDictValue = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictValue];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictValue, objvDict4GCCond.DictValue, strComparisonOpDictValue);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictTypeId) == true)
{
string strComparisonOpDictTypeId = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictTypeId, objvDict4GCCond.DictTypeId, strComparisonOpDictTypeId);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictTypeName) == true)
{
string strComparisonOpDictTypeName = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictTypeName, objvDict4GCCond.DictTypeName, strComparisonOpDictTypeName);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictKey1) == true)
{
string strComparisonOpDictKey1 = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictKey1];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictKey1, objvDict4GCCond.DictKey1, strComparisonOpDictKey1);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.DictKey2) == true)
{
string strComparisonOpDictKey2 = objvDict4GCCond.dicFldComparisonOp[convDict4GC.DictKey2];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.DictKey2, objvDict4GCCond.DictKey2, strComparisonOpDictKey2);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.UpdDate) == true)
{
string strComparisonOpUpdDate = objvDict4GCCond.dicFldComparisonOp[convDict4GC.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.UpdDate, objvDict4GCCond.UpdDate, strComparisonOpUpdDate);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.UpdUser) == true)
{
string strComparisonOpUpdUser = objvDict4GCCond.dicFldComparisonOp[convDict4GC.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.UpdUser, objvDict4GCCond.UpdUser, strComparisonOpUpdUser);
}
if (objvDict4GCCond.IsUpdated(convDict4GC.Memo) == true)
{
string strComparisonOpMemo = objvDict4GCCond.dicFldComparisonOp[convDict4GC.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convDict4GC.Memo, objvDict4GCCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vDict4GC
{
public virtual bool UpdRelaTabDate(string strDictId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v生成代码字典(vDict4GC)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvDict4GCBL
{
public static RelatedActions_vDict4GC relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvDict4GCDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvDict4GCDA vDict4GCDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvDict4GCDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvDict4GCBL()
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
if (string.IsNullOrEmpty(clsvDict4GCEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDict4GCEN._ConnectString);
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
public static DataTable GetDataTable_vDict4GC(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vDict4GCDA.GetDataTable_vDict4GC(strWhereCond);
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
objDT = vDict4GCDA.GetDataTable(strWhereCond);
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
objDT = vDict4GCDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vDict4GCDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vDict4GCDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vDict4GCDA.GetDataTable_Top(objTopPara);
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
objDT = vDict4GCDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vDict4GCDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vDict4GCDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrDictIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvDict4GCEN> GetObjLstByDictIdLst(List<string> arrDictIdLst)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrDictIdLst, true);
 string strWhereCond = string.Format("DictId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrDictIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvDict4GCEN> GetObjLstByDictIdLstCache(List<string> arrDictIdLst)
{
string strKey = string.Format("{0}", clsvDict4GCEN._CurrTabName);
List<clsvDict4GCEN> arrvDict4GCObjLstCache = GetObjLstCache();
IEnumerable <clsvDict4GCEN> arrvDict4GCObjLst_Sel =
arrvDict4GCObjLstCache
.Where(x => arrDictIdLst.Contains(x.DictId));
return arrvDict4GCObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDict4GCEN> GetObjLst(string strWhereCond)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
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
public static List<clsvDict4GCEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvDict4GCCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvDict4GCEN> GetSubObjLstCache(clsvDict4GCEN objvDict4GCCond)
{
List<clsvDict4GCEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDict4GCEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDict4GC._AttributeName)
{
if (objvDict4GCCond.IsUpdated(strFldName) == false) continue;
if (objvDict4GCCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDict4GCCond[strFldName].ToString());
}
else
{
if (objvDict4GCCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDict4GCCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDict4GCCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDict4GCCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDict4GCCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDict4GCCond[strFldName]));
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
public static List<clsvDict4GCEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
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
public static List<clsvDict4GCEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
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
List<clsvDict4GCEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvDict4GCEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDict4GCEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvDict4GCEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
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
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
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
public static List<clsvDict4GCEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvDict4GCEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvDict4GCEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
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
public static List<clsvDict4GCEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvDict4GCEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvDict4GCEN> arrObjLst = new List<clsvDict4GCEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDict4GCEN objvDict4GCEN = new clsvDict4GCEN();
try
{
objvDict4GCEN.DictId = objRow[convDict4GC.DictId].ToString().Trim(); //字典Id
objvDict4GCEN.DictValue = objRow[convDict4GC.DictValue].ToString().Trim(); //字典值
objvDict4GCEN.DictTypeId = objRow[convDict4GC.DictTypeId] == DBNull.Value ? null : objRow[convDict4GC.DictTypeId].ToString().Trim(); //字典类型Id
objvDict4GCEN.DictTypeName = objRow[convDict4GC.DictTypeName].ToString().Trim(); //字典类型名
objvDict4GCEN.DictKey1 = objRow[convDict4GC.DictKey1].ToString().Trim(); //字典关键字1
objvDict4GCEN.DictKey2 = objRow[convDict4GC.DictKey2].ToString().Trim(); //字典关键字2
objvDict4GCEN.UpdDate = objRow[convDict4GC.UpdDate] == DBNull.Value ? null : objRow[convDict4GC.UpdDate].ToString().Trim(); //修改日期
objvDict4GCEN.UpdUser = objRow[convDict4GC.UpdUser] == DBNull.Value ? null : objRow[convDict4GC.UpdUser].ToString().Trim(); //修改者
objvDict4GCEN.Memo = objRow[convDict4GC.Memo] == DBNull.Value ? null : objRow[convDict4GC.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvDict4GCEN.DictId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvDict4GCEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvDict4GCEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvDict4GC(ref clsvDict4GCEN objvDict4GCEN)
{
bool bolResult = vDict4GCDA.GetvDict4GC(ref objvDict4GCEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strDictId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvDict4GCEN GetObjByDictId(string strDictId)
{
if (strDictId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strDictId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strDictId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strDictId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvDict4GCEN objvDict4GCEN = vDict4GCDA.GetObjByDictId(strDictId);
return objvDict4GCEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvDict4GCEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvDict4GCEN objvDict4GCEN = vDict4GCDA.GetFirstObj(strWhereCond);
 return objvDict4GCEN;
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
public static clsvDict4GCEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvDict4GCEN objvDict4GCEN = vDict4GCDA.GetObjByDataRow(objRow);
 return objvDict4GCEN;
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
public static clsvDict4GCEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvDict4GCEN objvDict4GCEN = vDict4GCDA.GetObjByDataRow(objRow);
 return objvDict4GCEN;
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
 /// <param name = "strDictId">所给的关键字</param>
 /// <param name = "lstvDict4GCObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDict4GCEN GetObjByDictIdFromList(string strDictId, List<clsvDict4GCEN> lstvDict4GCObjLst)
{
foreach (clsvDict4GCEN objvDict4GCEN in lstvDict4GCObjLst)
{
if (objvDict4GCEN.DictId == strDictId)
{
return objvDict4GCEN;
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
 string strDictId;
 try
 {
 strDictId = new clsvDict4GCDA().GetFirstID(strWhereCond);
 return strDictId;
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
 arrList = vDict4GCDA.GetID(strWhereCond);
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
bool bolIsExist = vDict4GCDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strDictId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strDictId)
{
if (string.IsNullOrEmpty(strDictId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strDictId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vDict4GCDA.IsExist(strDictId);
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
 bolIsExist = clsvDict4GCDA.IsExistTable();
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
 bolIsExist = vDict4GCDA.IsExistTable(strTabName);
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
 /// <param name = "objvDict4GCENS">源对象</param>
 /// <param name = "objvDict4GCENT">目标对象</param>
 public static void CopyTo(clsvDict4GCEN objvDict4GCENS, clsvDict4GCEN objvDict4GCENT)
{
try
{
objvDict4GCENT.DictId = objvDict4GCENS.DictId; //字典Id
objvDict4GCENT.DictValue = objvDict4GCENS.DictValue; //字典值
objvDict4GCENT.DictTypeId = objvDict4GCENS.DictTypeId; //字典类型Id
objvDict4GCENT.DictTypeName = objvDict4GCENS.DictTypeName; //字典类型名
objvDict4GCENT.DictKey1 = objvDict4GCENS.DictKey1; //字典关键字1
objvDict4GCENT.DictKey2 = objvDict4GCENS.DictKey2; //字典关键字2
objvDict4GCENT.UpdDate = objvDict4GCENS.UpdDate; //修改日期
objvDict4GCENT.UpdUser = objvDict4GCENS.UpdUser; //修改者
objvDict4GCENT.Memo = objvDict4GCENS.Memo; //说明
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
 /// <param name = "objvDict4GCEN">源简化对象</param>
 public static void SetUpdFlag(clsvDict4GCEN objvDict4GCEN)
{
try
{
objvDict4GCEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvDict4GCEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convDict4GC.DictId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.DictId = objvDict4GCEN.DictId; //字典Id
}
if (arrFldSet.Contains(convDict4GC.DictValue, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.DictValue = objvDict4GCEN.DictValue; //字典值
}
if (arrFldSet.Contains(convDict4GC.DictTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.DictTypeId = objvDict4GCEN.DictTypeId == "[null]" ? null :  objvDict4GCEN.DictTypeId; //字典类型Id
}
if (arrFldSet.Contains(convDict4GC.DictTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.DictTypeName = objvDict4GCEN.DictTypeName; //字典类型名
}
if (arrFldSet.Contains(convDict4GC.DictKey1, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.DictKey1 = objvDict4GCEN.DictKey1; //字典关键字1
}
if (arrFldSet.Contains(convDict4GC.DictKey2, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.DictKey2 = objvDict4GCEN.DictKey2; //字典关键字2
}
if (arrFldSet.Contains(convDict4GC.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.UpdDate = objvDict4GCEN.UpdDate == "[null]" ? null :  objvDict4GCEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convDict4GC.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.UpdUser = objvDict4GCEN.UpdUser == "[null]" ? null :  objvDict4GCEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convDict4GC.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvDict4GCEN.Memo = objvDict4GCEN.Memo == "[null]" ? null :  objvDict4GCEN.Memo; //说明
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
 /// <param name = "objvDict4GCEN">源简化对象</param>
 public static void AccessFldValueNull(clsvDict4GCEN objvDict4GCEN)
{
try
{
if (objvDict4GCEN.DictTypeId == "[null]") objvDict4GCEN.DictTypeId = null; //字典类型Id
if (objvDict4GCEN.UpdDate == "[null]") objvDict4GCEN.UpdDate = null; //修改日期
if (objvDict4GCEN.UpdUser == "[null]") objvDict4GCEN.UpdUser = null; //修改者
if (objvDict4GCEN.Memo == "[null]") objvDict4GCEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvDict4GCEN objvDict4GCEN)
{
 vDict4GCDA.CheckProperty4Condition(objvDict4GCEN);
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
if (clsDict4GCBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDict4GCBL没有刷新缓存机制(clsDict4GCBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsDictType4GCBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsDictType4GCBL没有刷新缓存机制(clsDictType4GCBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by DictId");
//if (arrvDict4GCObjLstCache == null)
//{
//arrvDict4GCObjLstCache = vDict4GCDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strDictId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvDict4GCEN GetObjByDictIdCache(string strDictId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvDict4GCEN._CurrTabName);
List<clsvDict4GCEN> arrvDict4GCObjLstCache = GetObjLstCache();
IEnumerable <clsvDict4GCEN> arrvDict4GCObjLst_Sel =
arrvDict4GCObjLstCache
.Where(x=> x.DictId == strDictId 
);
if (arrvDict4GCObjLst_Sel.Count() == 0)
{
   clsvDict4GCEN obj = clsvDict4GCBL.GetObjByDictId(strDictId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvDict4GCObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDict4GCEN> GetAllvDict4GCObjLstCache()
{
//获取缓存中的对象列表
List<clsvDict4GCEN> arrvDict4GCObjLstCache = GetObjLstCache(); 
return arrvDict4GCObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvDict4GCEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvDict4GCEN._CurrTabName);
List<clsvDict4GCEN> arrvDict4GCObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvDict4GCObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache()
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}", clsvDict4GCEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvDict4GCEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvDict4GCEN._RefreshTimeLst.Count == 0) return "";
return clsvDict4GCEN._RefreshTimeLst[clsvDict4GCEN._RefreshTimeLst.Count - 1];
}


 #endregion 缓存操作


 #region 检查唯一性


 #endregion 检查唯一性

 /// <summary>
 /// 映射函数。根据表映射把输入字段值,映射成输出字段值
 /// 作者:pyf
 /// 日期:2025-08-09
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_func)
 /// </summary>
 /// <param name = "strInFldName">输入字段名</param>
 /// <param name = "strOutFldName">输出字段名</param>
 /// <param name = "strInValue">输入字段值</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strDictId)
{
if (strInFldName != convDict4GC.DictId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convDict4GC._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convDict4GC._AttributeName));
throw new Exception(strMsg);
}
var objvDict4GC = clsvDict4GCBL.GetObjByDictIdCache(strDictId);
if (objvDict4GC == null) return "";
return objvDict4GC[strOutFldName].ToString();
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
int intRecCount = clsvDict4GCDA.GetRecCount(strTabName);
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
int intRecCount = clsvDict4GCDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvDict4GCDA.GetRecCount();
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
int intRecCount = clsvDict4GCDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvDict4GCCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvDict4GCEN objvDict4GCCond)
{
List<clsvDict4GCEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvDict4GCEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convDict4GC._AttributeName)
{
if (objvDict4GCCond.IsUpdated(strFldName) == false) continue;
if (objvDict4GCCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDict4GCCond[strFldName].ToString());
}
else
{
if (objvDict4GCCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvDict4GCCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvDict4GCCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvDict4GCCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvDict4GCCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvDict4GCCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvDict4GCCond[strFldName]));
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
 List<string> arrList = clsvDict4GCDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vDict4GCDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vDict4GCDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}