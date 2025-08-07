
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCacheUseStateBL
 表名:vCacheUseState(00050567)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:40
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:系统设置(SystemSet)
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
public static class  clsvCacheUseStateBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCacheUseStateEN GetObj(this K_mId_vCacheUseState myKey)
{
clsvCacheUseStateEN objvCacheUseStateEN = clsvCacheUseStateBL.vCacheUseStateDA.GetObjBymId(myKey.Value);
return objvCacheUseStateEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetmId(this clsvCacheUseStateEN objvCacheUseStateEN, long lngmId, string strComparisonOp="")
	{
objvCacheUseStateEN.mId = lngmId; //mId
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.mId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.mId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.mId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetUserId(this clsvCacheUseStateEN objvCacheUseStateEN, string strUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strUserId, convCacheUseState.UserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUserId, 18, convCacheUseState.UserId);
}
objvCacheUseStateEN.UserId = strUserId; //用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.UserId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.UserId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.UserId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeId(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeId, 2, convCacheUseState.CacheModeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strCacheModeId, 2, convCacheUseState.CacheModeId);
}
objvCacheUseStateEN.CacheModeId = strCacheModeId; //缓存方式Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeId) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeId, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeId] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeName(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeName, 50, convCacheUseState.CacheModeName);
}
objvCacheUseStateEN.CacheModeName = strCacheModeName; //缓存方式名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeName) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeName, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeName] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheModeENName(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheModeENName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheModeENName, 50, convCacheUseState.CacheModeENName);
}
objvCacheUseStateEN.CacheModeENName = strCacheModeENName; //缓存方式英文名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheModeENName) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheModeENName, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheModeENName] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheKey(this clsvCacheUseStateEN objvCacheUseStateEN, string strCacheKey, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCacheKey, 50, convCacheUseState.CacheKey);
}
objvCacheUseStateEN.CacheKey = strCacheKey; //缓存关键字
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheKey) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheKey, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheKey] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetCacheSize(this clsvCacheUseStateEN objvCacheUseStateEN, int? intCacheSize, string strComparisonOp="")
	{
objvCacheUseStateEN.CacheSize = intCacheSize; //缓存大小
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.CacheSize) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.CacheSize, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.CacheSize] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetUseDate(this clsvCacheUseStateEN objvCacheUseStateEN, string strUseDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUseDate, 20, convCacheUseState.UseDate);
}
objvCacheUseStateEN.UseDate = strUseDate; //使用日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.UseDate) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.UseDate, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.UseDate] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvCacheUseStateEN SetMemo(this clsvCacheUseStateEN objvCacheUseStateEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convCacheUseState.Memo);
}
objvCacheUseStateEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvCacheUseStateEN.dicFldComparisonOp.ContainsKey(convCacheUseState.Memo) == false)
{
objvCacheUseStateEN.dicFldComparisonOp.Add(convCacheUseState.Memo, strComparisonOp);
}
else
{
objvCacheUseStateEN.dicFldComparisonOp[convCacheUseState.Memo] = strComparisonOp;
}
}
return objvCacheUseStateEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvCacheUseStateENS">源对象</param>
 /// <param name = "objvCacheUseStateENT">目标对象</param>
 public static void CopyTo(this clsvCacheUseStateEN objvCacheUseStateENS, clsvCacheUseStateEN objvCacheUseStateENT)
{
try
{
objvCacheUseStateENT.mId = objvCacheUseStateENS.mId; //mId
objvCacheUseStateENT.UserId = objvCacheUseStateENS.UserId; //用户Id
objvCacheUseStateENT.CacheModeId = objvCacheUseStateENS.CacheModeId; //缓存方式Id
objvCacheUseStateENT.CacheModeName = objvCacheUseStateENS.CacheModeName; //缓存方式名
objvCacheUseStateENT.CacheModeENName = objvCacheUseStateENS.CacheModeENName; //缓存方式英文名
objvCacheUseStateENT.CacheKey = objvCacheUseStateENS.CacheKey; //缓存关键字
objvCacheUseStateENT.CacheSize = objvCacheUseStateENS.CacheSize; //缓存大小
objvCacheUseStateENT.UseDate = objvCacheUseStateENS.UseDate; //使用日期
objvCacheUseStateENT.Memo = objvCacheUseStateENS.Memo; //说明
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
 /// <param name = "objvCacheUseStateENS">源对象</param>
 /// <returns>目标对象=>clsvCacheUseStateEN:objvCacheUseStateENT</returns>
 public static clsvCacheUseStateEN CopyTo(this clsvCacheUseStateEN objvCacheUseStateENS)
{
try
{
 clsvCacheUseStateEN objvCacheUseStateENT = new clsvCacheUseStateEN()
{
mId = objvCacheUseStateENS.mId, //mId
UserId = objvCacheUseStateENS.UserId, //用户Id
CacheModeId = objvCacheUseStateENS.CacheModeId, //缓存方式Id
CacheModeName = objvCacheUseStateENS.CacheModeName, //缓存方式名
CacheModeENName = objvCacheUseStateENS.CacheModeENName, //缓存方式英文名
CacheKey = objvCacheUseStateENS.CacheKey, //缓存关键字
CacheSize = objvCacheUseStateENS.CacheSize, //缓存大小
UseDate = objvCacheUseStateENS.UseDate, //使用日期
Memo = objvCacheUseStateENS.Memo, //说明
};
 return objvCacheUseStateENT;
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
public static void CheckProperty4Condition(this clsvCacheUseStateEN objvCacheUseStateEN)
{
 clsvCacheUseStateBL.vCacheUseStateDA.CheckProperty4Condition(objvCacheUseStateEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvCacheUseStateEN objvCacheUseStateCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.mId) == true)
{
string strComparisonOpmId = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.mId];
strWhereCond += string.Format(" And {0} {2} {1}", convCacheUseState.mId, objvCacheUseStateCond.mId, strComparisonOpmId);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.UserId) == true)
{
string strComparisonOpUserId = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.UserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.UserId, objvCacheUseStateCond.UserId, strComparisonOpUserId);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheModeId) == true)
{
string strComparisonOpCacheModeId = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheModeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeId, objvCacheUseStateCond.CacheModeId, strComparisonOpCacheModeId);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheModeName) == true)
{
string strComparisonOpCacheModeName = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheModeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeName, objvCacheUseStateCond.CacheModeName, strComparisonOpCacheModeName);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheModeENName) == true)
{
string strComparisonOpCacheModeENName = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheModeENName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheModeENName, objvCacheUseStateCond.CacheModeENName, strComparisonOpCacheModeENName);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheKey) == true)
{
string strComparisonOpCacheKey = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheKey];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.CacheKey, objvCacheUseStateCond.CacheKey, strComparisonOpCacheKey);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.CacheSize) == true)
{
string strComparisonOpCacheSize = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.CacheSize];
strWhereCond += string.Format(" And {0} {2} {1}", convCacheUseState.CacheSize, objvCacheUseStateCond.CacheSize, strComparisonOpCacheSize);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.UseDate) == true)
{
string strComparisonOpUseDate = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.UseDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.UseDate, objvCacheUseStateCond.UseDate, strComparisonOpUseDate);
}
if (objvCacheUseStateCond.IsUpdated(convCacheUseState.Memo) == true)
{
string strComparisonOpMemo = objvCacheUseStateCond.dicFldComparisonOp[convCacheUseState.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convCacheUseState.Memo, objvCacheUseStateCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vCacheUseState
{
public virtual bool UpdRelaTabDate(long lngmId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vCacheUseState(vCacheUseState)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvCacheUseStateBL
{
public static RelatedActions_vCacheUseState relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvCacheUseStateDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvCacheUseStateDA vCacheUseStateDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvCacheUseStateDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvCacheUseStateBL()
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
if (string.IsNullOrEmpty(clsvCacheUseStateEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCacheUseStateEN._ConnectString);
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
public static DataTable GetDataTable_vCacheUseState(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vCacheUseStateDA.GetDataTable_vCacheUseState(strWhereCond);
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
objDT = vCacheUseStateDA.GetDataTable(strWhereCond);
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
objDT = vCacheUseStateDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vCacheUseStateDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vCacheUseStateDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vCacheUseStateDA.GetDataTable_Top(objTopPara);
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
objDT = vCacheUseStateDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vCacheUseStateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vCacheUseStateDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLstByMIdLst(List<long> arrMIdLst)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrMIdLst);
 string strWhereCond = string.Format("mId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrMIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvCacheUseStateEN> GetObjLstByMIdLstCache(List<long> arrMIdLst, string strUserId)
{
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrvCacheUseStateObjLst_Sel =
arrvCacheUseStateObjLstCache
.Where(x => arrMIdLst.Contains(x.mId));
return arrvCacheUseStateObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLst(string strWhereCond)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
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
public static List<clsvCacheUseStateEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvCacheUseStateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvCacheUseStateEN> GetSubObjLstCache(clsvCacheUseStateEN objvCacheUseStateCond)
{
 string strUserId = objvCacheUseStateCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000172)在表中,缓存分类字段值不能为空!(clsvCacheUseStateBL:GetSubObjLstCache)");
throw new Exception(strMsg);
}
List<clsvCacheUseStateEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCacheUseState._AttributeName)
{
if (objvCacheUseStateCond.IsUpdated(strFldName) == false) continue;
if (objvCacheUseStateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCacheUseStateCond[strFldName].ToString());
}
else
{
if (objvCacheUseStateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCacheUseStateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCacheUseStateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCacheUseStateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCacheUseStateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCacheUseStateCond[strFldName]));
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
public static List<clsvCacheUseStateEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
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
public static List<clsvCacheUseStateEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
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
List<clsvCacheUseStateEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvCacheUseStateEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvCacheUseStateEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
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
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
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
public static List<clsvCacheUseStateEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvCacheUseStateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
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
public static List<clsvCacheUseStateEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvCacheUseStateEN> arrObjLst = new List<clsvCacheUseStateEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCacheUseStateEN objvCacheUseStateEN = new clsvCacheUseStateEN();
try
{
objvCacheUseStateEN.mId = Int32.Parse(objRow[convCacheUseState.mId].ToString().Trim()); //mId
objvCacheUseStateEN.UserId = objRow[convCacheUseState.UserId].ToString().Trim(); //用户Id
objvCacheUseStateEN.CacheModeId = objRow[convCacheUseState.CacheModeId] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeId].ToString().Trim(); //缓存方式Id
objvCacheUseStateEN.CacheModeName = objRow[convCacheUseState.CacheModeName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeName].ToString().Trim(); //缓存方式名
objvCacheUseStateEN.CacheModeENName = objRow[convCacheUseState.CacheModeENName] == DBNull.Value ? null : objRow[convCacheUseState.CacheModeENName].ToString().Trim(); //缓存方式英文名
objvCacheUseStateEN.CacheKey = objRow[convCacheUseState.CacheKey] == DBNull.Value ? null : objRow[convCacheUseState.CacheKey].ToString().Trim(); //缓存关键字
objvCacheUseStateEN.CacheSize = objRow[convCacheUseState.CacheSize] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCacheUseState.CacheSize].ToString().Trim()); //缓存大小
objvCacheUseStateEN.UseDate = objRow[convCacheUseState.UseDate] == DBNull.Value ? null : objRow[convCacheUseState.UseDate].ToString().Trim(); //使用日期
objvCacheUseStateEN.Memo = objRow[convCacheUseState.Memo] == DBNull.Value ? null : objRow[convCacheUseState.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvCacheUseStateEN.mId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvCacheUseStateEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvCacheUseStateEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvCacheUseState(ref clsvCacheUseStateEN objvCacheUseStateEN)
{
bool bolResult = vCacheUseStateDA.GetvCacheUseState(ref objvCacheUseStateEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvCacheUseStateEN GetObjBymId(long lngmId)
{
clsvCacheUseStateEN objvCacheUseStateEN = vCacheUseStateDA.GetObjBymId(lngmId);
return objvCacheUseStateEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvCacheUseStateEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvCacheUseStateEN objvCacheUseStateEN = vCacheUseStateDA.GetFirstObj(strWhereCond);
 return objvCacheUseStateEN;
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
public static clsvCacheUseStateEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvCacheUseStateEN objvCacheUseStateEN = vCacheUseStateDA.GetObjByDataRow(objRow);
 return objvCacheUseStateEN;
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
public static clsvCacheUseStateEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvCacheUseStateEN objvCacheUseStateEN = vCacheUseStateDA.GetObjByDataRow(objRow);
 return objvCacheUseStateEN;
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
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "lstvCacheUseStateObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCacheUseStateEN GetObjBymIdFromList(long lngmId, List<clsvCacheUseStateEN> lstvCacheUseStateObjLst)
{
foreach (clsvCacheUseStateEN objvCacheUseStateEN in lstvCacheUseStateObjLst)
{
if (objvCacheUseStateEN.mId == lngmId)
{
return objvCacheUseStateEN;
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
public static long GetFirstID_S(string strWhereCond) 
{
 long lngmId;
 try
 {
 lngmId = new clsvCacheUseStateDA().GetFirstID(strWhereCond);
 return lngmId;
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
 arrList = vCacheUseStateDA.GetID(strWhereCond);
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
bool bolIsExist = vCacheUseStateDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(long lngmId)
{
//检测记录是否存在
bool bolIsExist = vCacheUseStateDA.IsExist(lngmId);
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
 bolIsExist = clsvCacheUseStateDA.IsExistTable();
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
 bolIsExist = vCacheUseStateDA.IsExistTable(strTabName);
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
 /// <param name = "objvCacheUseStateENS">源对象</param>
 /// <param name = "objvCacheUseStateENT">目标对象</param>
 public static void CopyTo(clsvCacheUseStateEN objvCacheUseStateENS, clsvCacheUseStateEN objvCacheUseStateENT)
{
try
{
objvCacheUseStateENT.mId = objvCacheUseStateENS.mId; //mId
objvCacheUseStateENT.UserId = objvCacheUseStateENS.UserId; //用户Id
objvCacheUseStateENT.CacheModeId = objvCacheUseStateENS.CacheModeId; //缓存方式Id
objvCacheUseStateENT.CacheModeName = objvCacheUseStateENS.CacheModeName; //缓存方式名
objvCacheUseStateENT.CacheModeENName = objvCacheUseStateENS.CacheModeENName; //缓存方式英文名
objvCacheUseStateENT.CacheKey = objvCacheUseStateENS.CacheKey; //缓存关键字
objvCacheUseStateENT.CacheSize = objvCacheUseStateENS.CacheSize; //缓存大小
objvCacheUseStateENT.UseDate = objvCacheUseStateENS.UseDate; //使用日期
objvCacheUseStateENT.Memo = objvCacheUseStateENS.Memo; //说明
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
 /// <param name = "objvCacheUseStateEN">源简化对象</param>
 public static void SetUpdFlag(clsvCacheUseStateEN objvCacheUseStateEN)
{
try
{
objvCacheUseStateEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvCacheUseStateEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convCacheUseState.mId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.mId = objvCacheUseStateEN.mId; //mId
}
if (arrFldSet.Contains(convCacheUseState.UserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.UserId = objvCacheUseStateEN.UserId; //用户Id
}
if (arrFldSet.Contains(convCacheUseState.CacheModeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.CacheModeId = objvCacheUseStateEN.CacheModeId == "[null]" ? null :  objvCacheUseStateEN.CacheModeId; //缓存方式Id
}
if (arrFldSet.Contains(convCacheUseState.CacheModeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.CacheModeName = objvCacheUseStateEN.CacheModeName == "[null]" ? null :  objvCacheUseStateEN.CacheModeName; //缓存方式名
}
if (arrFldSet.Contains(convCacheUseState.CacheModeENName, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.CacheModeENName = objvCacheUseStateEN.CacheModeENName == "[null]" ? null :  objvCacheUseStateEN.CacheModeENName; //缓存方式英文名
}
if (arrFldSet.Contains(convCacheUseState.CacheKey, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.CacheKey = objvCacheUseStateEN.CacheKey == "[null]" ? null :  objvCacheUseStateEN.CacheKey; //缓存关键字
}
if (arrFldSet.Contains(convCacheUseState.CacheSize, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.CacheSize = objvCacheUseStateEN.CacheSize; //缓存大小
}
if (arrFldSet.Contains(convCacheUseState.UseDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.UseDate = objvCacheUseStateEN.UseDate == "[null]" ? null :  objvCacheUseStateEN.UseDate; //使用日期
}
if (arrFldSet.Contains(convCacheUseState.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvCacheUseStateEN.Memo = objvCacheUseStateEN.Memo == "[null]" ? null :  objvCacheUseStateEN.Memo; //说明
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
 /// <param name = "objvCacheUseStateEN">源简化对象</param>
 public static void AccessFldValueNull(clsvCacheUseStateEN objvCacheUseStateEN)
{
try
{
if (objvCacheUseStateEN.CacheModeId == "[null]") objvCacheUseStateEN.CacheModeId = null; //缓存方式Id
if (objvCacheUseStateEN.CacheModeName == "[null]") objvCacheUseStateEN.CacheModeName = null; //缓存方式名
if (objvCacheUseStateEN.CacheModeENName == "[null]") objvCacheUseStateEN.CacheModeENName = null; //缓存方式英文名
if (objvCacheUseStateEN.CacheKey == "[null]") objvCacheUseStateEN.CacheKey = null; //缓存关键字
if (objvCacheUseStateEN.UseDate == "[null]") objvCacheUseStateEN.UseDate = null; //使用日期
if (objvCacheUseStateEN.Memo == "[null]") objvCacheUseStateEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvCacheUseStateEN objvCacheUseStateEN)
{
 vCacheUseStateDA.CheckProperty4Condition(objvCacheUseStateEN);
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
if (clsCacheModeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCacheModeBL没有刷新缓存机制(clsCacheModeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsCacheUseStateBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsCacheUseStateBL没有刷新缓存机制(clsCacheUseStateBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by mId");
//if (arrvCacheUseStateObjLstCache == null)
//{
//arrvCacheUseStateObjLstCache = vCacheUseStateDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "lngmId">所给的关键字</param>
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvCacheUseStateEN GetObjBymIdCache(long lngmId, string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//获取缓存中的对象列表
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrvCacheUseStateObjLst_Sel =
arrvCacheUseStateObjLstCache
.Where(x=> x.mId == lngmId 
);
if (arrvCacheUseStateObjLst_Sel.Count() == 0)
{
   clsvCacheUseStateEN obj = clsvCacheUseStateBL.GetObjBymId(lngmId);
   if (obj != null)
 {
if (obj.UserId == strUserId)
{
CacheHelper.Remove(strKey);
     return obj;
}
else
{
string strMsg = string.Format("错误: 关键字:{0}不属于分类:{1},请检查!(In {2})", lngmId, strUserId, clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
 }
return null;
}
return arrvCacheUseStateObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCacheUseStateEN> GetAllvCacheUseStateObjLstCache(string strUserId)
{
//获取缓存中的对象列表
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = GetObjLstCache(strUserId); 
return arrvCacheUseStateObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvCacheUseStateEN> GetObjLstCache(string strUserId)
{

if (string.IsNullOrEmpty(strUserId) == true)
{
  var strMsg = string.Format("参数:[strUserId]不能为空!(In {0})", clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
 throw new Exception (strMsg);
}
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
string strCondition = string.Format("UserId='{0}'", strUserId);
List<clsvCacheUseStateEN> arrvCacheUseStateObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst(strCondition); });
return arrvCacheUseStateObjLstCache;
}

 /// <summary>
 /// 刷新本类中的缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ReFreshThisCache)
 /// </summary>
public static void ReFreshThisCache(string strUserId = "")
{
string strMsg;
if (clsSysParaEN.spSetRefreshCacheOn == true)
{
string strKey = string.Format("{0}_{1}", clsvCacheUseStateEN._CurrTabName, strUserId);
CacheHelper.Remove(strKey);
clsvCacheUseStateEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvCacheUseStateEN._RefreshTimeLst.Count == 0) return "";
return clsvCacheUseStateEN._RefreshTimeLst[clsvCacheUseStateEN._RefreshTimeLst.Count - 1];
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
 /// <param name = "strUserId">缓存的分类字段</param>
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, long lngmId, string strUserId)
{
if (strInFldName != convCacheUseState.mId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convCacheUseState._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convCacheUseState._AttributeName));
throw new Exception(strMsg);
}
var objvCacheUseState = clsvCacheUseStateBL.GetObjBymIdCache(lngmId, strUserId);
if (objvCacheUseState == null) return "";
return objvCacheUseState[strOutFldName].ToString();
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
int intRecCount = clsvCacheUseStateDA.GetRecCount(strTabName);
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
int intRecCount = clsvCacheUseStateDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvCacheUseStateDA.GetRecCount();
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
int intRecCount = clsvCacheUseStateDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvCacheUseStateCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvCacheUseStateEN objvCacheUseStateCond)
{
 string strUserId = objvCacheUseStateCond.UserId;
 if (string.IsNullOrEmpty(strUserId) == true)
{
string strMsg = string.Format("(errid:Busi000174)在表中,缓存分类字段值不能为空!(clsvCacheUseStateBL:GetRecCountByCondCache)");
throw new Exception(strMsg);
}
List<clsvCacheUseStateEN> arrObjLstCache = GetObjLstCache(strUserId);
IEnumerable <clsvCacheUseStateEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convCacheUseState._AttributeName)
{
if (objvCacheUseStateCond.IsUpdated(strFldName) == false) continue;
if (objvCacheUseStateCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCacheUseStateCond[strFldName].ToString());
}
else
{
if (objvCacheUseStateCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvCacheUseStateCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvCacheUseStateCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvCacheUseStateCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvCacheUseStateCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvCacheUseStateCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvCacheUseStateCond[strFldName]));
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
 List<string> arrList = clsvCacheUseStateDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vCacheUseStateDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vCacheUseStateDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}