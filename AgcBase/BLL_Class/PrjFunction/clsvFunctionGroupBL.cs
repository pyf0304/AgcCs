
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunctionGroupBL
 表名:vFunctionGroup(00050326)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:02
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
public static class  clsvFunctionGroupBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionGroupEN GetObj(this K_FunctionGroupId_vFunctionGroup myKey)
{
clsvFunctionGroupEN objvFunctionGroupEN = clsvFunctionGroupBL.vFunctionGroupDA.GetObjByFunctionGroupId(myKey.Value);
return objvFunctionGroupEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetFunctionGroupId(this clsvFunctionGroupEN objvFunctionGroupEN, string strFunctionGroupId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupId, 4, convFunctionGroup.FunctionGroupId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFunctionGroupId, 4, convFunctionGroup.FunctionGroupId);
}
objvFunctionGroupEN.FunctionGroupId = strFunctionGroupId; //函数组Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.FunctionGroupId) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.FunctionGroupId, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.FunctionGroupId] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetFunctionGroupName(this clsvFunctionGroupEN objvFunctionGroupEN, string strFunctionGroupName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFunctionGroupName, convFunctionGroup.FunctionGroupName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFunctionGroupName, 50, convFunctionGroup.FunctionGroupName);
}
objvFunctionGroupEN.FunctionGroupName = strFunctionGroupName; //函数组名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.FunctionGroupName) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.FunctionGroupName, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.FunctionGroupName] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetProgLangTypeId(this clsvFunctionGroupEN objvFunctionGroupEN, string strProgLangTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeId, convFunctionGroup.ProgLangTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeId, 2, convFunctionGroup.ProgLangTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strProgLangTypeId, 2, convFunctionGroup.ProgLangTypeId);
}
objvFunctionGroupEN.ProgLangTypeId = strProgLangTypeId; //编程语言类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.ProgLangTypeId) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.ProgLangTypeId, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.ProgLangTypeId] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetProgLangTypeName(this clsvFunctionGroupEN objvFunctionGroupEN, string strProgLangTypeName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strProgLangTypeName, convFunctionGroup.ProgLangTypeName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strProgLangTypeName, 30, convFunctionGroup.ProgLangTypeName);
}
objvFunctionGroupEN.ProgLangTypeName = strProgLangTypeName; //编程语言类型名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.ProgLangTypeName) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.ProgLangTypeName, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.ProgLangTypeName] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetCreateUserId(this clsvFunctionGroupEN objvFunctionGroupEN, string strCreateUserId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strCreateUserId, convFunctionGroup.CreateUserId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strCreateUserId, 18, convFunctionGroup.CreateUserId);
}
objvFunctionGroupEN.CreateUserId = strCreateUserId; //建立用户Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.CreateUserId) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.CreateUserId, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.CreateUserId] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetUpdDate(this clsvFunctionGroupEN objvFunctionGroupEN, string strUpdDate, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdDate, 20, convFunctionGroup.UpdDate);
}
objvFunctionGroupEN.UpdDate = strUpdDate; //修改日期
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.UpdDate) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.UpdDate, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.UpdDate] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetUpdUser(this clsvFunctionGroupEN objvFunctionGroupEN, string strUpdUser, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strUpdUser, 20, convFunctionGroup.UpdUser);
}
objvFunctionGroupEN.UpdUser = strUpdUser; //修改者
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.UpdUser) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.UpdUser, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.UpdUser] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFunctionGroupEN SetMemo(this clsvFunctionGroupEN objvFunctionGroupEN, string strMemo, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strMemo, 1000, convFunctionGroup.Memo);
}
objvFunctionGroupEN.Memo = strMemo; //说明
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFunctionGroupEN.dicFldComparisonOp.ContainsKey(convFunctionGroup.Memo) == false)
{
objvFunctionGroupEN.dicFldComparisonOp.Add(convFunctionGroup.Memo, strComparisonOp);
}
else
{
objvFunctionGroupEN.dicFldComparisonOp[convFunctionGroup.Memo] = strComparisonOp;
}
}
return objvFunctionGroupEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFunctionGroupENS">源对象</param>
 /// <param name = "objvFunctionGroupENT">目标对象</param>
 public static void CopyTo(this clsvFunctionGroupEN objvFunctionGroupENS, clsvFunctionGroupEN objvFunctionGroupENT)
{
try
{
objvFunctionGroupENT.FunctionGroupId = objvFunctionGroupENS.FunctionGroupId; //函数组Id
objvFunctionGroupENT.FunctionGroupName = objvFunctionGroupENS.FunctionGroupName; //函数组名称
objvFunctionGroupENT.ProgLangTypeId = objvFunctionGroupENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupENT.ProgLangTypeName = objvFunctionGroupENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupENT.CreateUserId = objvFunctionGroupENS.CreateUserId; //建立用户Id
objvFunctionGroupENT.UpdDate = objvFunctionGroupENS.UpdDate; //修改日期
objvFunctionGroupENT.UpdUser = objvFunctionGroupENS.UpdUser; //修改者
objvFunctionGroupENT.Memo = objvFunctionGroupENS.Memo; //说明
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
 /// <param name = "objvFunctionGroupENS">源对象</param>
 /// <returns>目标对象=>clsvFunctionGroupEN:objvFunctionGroupENT</returns>
 public static clsvFunctionGroupEN CopyTo(this clsvFunctionGroupEN objvFunctionGroupENS)
{
try
{
 clsvFunctionGroupEN objvFunctionGroupENT = new clsvFunctionGroupEN()
{
FunctionGroupId = objvFunctionGroupENS.FunctionGroupId, //函数组Id
FunctionGroupName = objvFunctionGroupENS.FunctionGroupName, //函数组名称
ProgLangTypeId = objvFunctionGroupENS.ProgLangTypeId, //编程语言类型Id
ProgLangTypeName = objvFunctionGroupENS.ProgLangTypeName, //编程语言类型名
CreateUserId = objvFunctionGroupENS.CreateUserId, //建立用户Id
UpdDate = objvFunctionGroupENS.UpdDate, //修改日期
UpdUser = objvFunctionGroupENS.UpdUser, //修改者
Memo = objvFunctionGroupENS.Memo, //说明
};
 return objvFunctionGroupENT;
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
public static void CheckProperty4Condition(this clsvFunctionGroupEN objvFunctionGroupEN)
{
 clsvFunctionGroupBL.vFunctionGroupDA.CheckProperty4Condition(objvFunctionGroupEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFunctionGroupEN objvFunctionGroupCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.FunctionGroupId) == true)
{
string strComparisonOpFunctionGroupId = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.FunctionGroupId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.FunctionGroupId, objvFunctionGroupCond.FunctionGroupId, strComparisonOpFunctionGroupId);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.FunctionGroupName) == true)
{
string strComparisonOpFunctionGroupName = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.FunctionGroupName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.FunctionGroupName, objvFunctionGroupCond.FunctionGroupName, strComparisonOpFunctionGroupName);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.ProgLangTypeId) == true)
{
string strComparisonOpProgLangTypeId = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.ProgLangTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.ProgLangTypeId, objvFunctionGroupCond.ProgLangTypeId, strComparisonOpProgLangTypeId);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.ProgLangTypeName) == true)
{
string strComparisonOpProgLangTypeName = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.ProgLangTypeName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.ProgLangTypeName, objvFunctionGroupCond.ProgLangTypeName, strComparisonOpProgLangTypeName);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.CreateUserId) == true)
{
string strComparisonOpCreateUserId = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.CreateUserId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.CreateUserId, objvFunctionGroupCond.CreateUserId, strComparisonOpCreateUserId);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.UpdDate) == true)
{
string strComparisonOpUpdDate = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.UpdDate];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.UpdDate, objvFunctionGroupCond.UpdDate, strComparisonOpUpdDate);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.UpdUser) == true)
{
string strComparisonOpUpdUser = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.UpdUser];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.UpdUser, objvFunctionGroupCond.UpdUser, strComparisonOpUpdUser);
}
if (objvFunctionGroupCond.IsUpdated(convFunctionGroup.Memo) == true)
{
string strComparisonOpMemo = objvFunctionGroupCond.dicFldComparisonOp[convFunctionGroup.Memo];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFunctionGroup.Memo, objvFunctionGroupCond.Memo, strComparisonOpMemo);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFunctionGroup
{
public virtual bool UpdRelaTabDate(string strFunctionGroupId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v函数组(vFunctionGroup)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFunctionGroupBL
{
public static RelatedActions_vFunctionGroup relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFunctionGroupDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFunctionGroupDA vFunctionGroupDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFunctionGroupDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFunctionGroupBL()
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
if (string.IsNullOrEmpty(clsvFunctionGroupEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunctionGroupEN._ConnectString);
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
public static DataTable GetDataTable_vFunctionGroup(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFunctionGroupDA.GetDataTable_vFunctionGroup(strWhereCond);
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
objDT = vFunctionGroupDA.GetDataTable(strWhereCond);
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
objDT = vFunctionGroupDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFunctionGroupDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFunctionGroupDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFunctionGroupDA.GetDataTable_Top(objTopPara);
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
objDT = vFunctionGroupDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFunctionGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFunctionGroupDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFunctionGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLstByFunctionGroupIdLst(List<string> arrFunctionGroupIdLst)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFunctionGroupIdLst, true);
 string strWhereCond = string.Format("FunctionGroupId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFunctionGroupIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFunctionGroupEN> GetObjLstByFunctionGroupIdLstCache(List<string> arrFunctionGroupIdLst)
{
string strKey = string.Format("{0}", clsvFunctionGroupEN._CurrTabName);
List<clsvFunctionGroupEN> arrvFunctionGroupObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupEN> arrvFunctionGroupObjLst_Sel =
arrvFunctionGroupObjLstCache
.Where(x => arrFunctionGroupIdLst.Contains(x.FunctionGroupId));
return arrvFunctionGroupObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLst(string strWhereCond)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
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
public static List<clsvFunctionGroupEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFunctionGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFunctionGroupEN> GetSubObjLstCache(clsvFunctionGroupEN objvFunctionGroupCond)
{
List<clsvFunctionGroupEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionGroup._AttributeName)
{
if (objvFunctionGroupCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupCond[strFldName].ToString());
}
else
{
if (objvFunctionGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupCond[strFldName]));
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
public static List<clsvFunctionGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
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
public static List<clsvFunctionGroupEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
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
List<clsvFunctionGroupEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFunctionGroupEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFunctionGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
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
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
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
public static List<clsvFunctionGroupEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFunctionGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
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
public static List<clsvFunctionGroupEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFunctionGroupEN> arrObjLst = new List<clsvFunctionGroupEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN();
try
{
objvFunctionGroupEN.FunctionGroupId = objRow[convFunctionGroup.FunctionGroupId].ToString().Trim(); //函数组Id
objvFunctionGroupEN.FunctionGroupName = objRow[convFunctionGroup.FunctionGroupName].ToString().Trim(); //函数组名称
objvFunctionGroupEN.ProgLangTypeId = objRow[convFunctionGroup.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunctionGroupEN.ProgLangTypeName = objRow[convFunctionGroup.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunctionGroupEN.CreateUserId = objRow[convFunctionGroup.CreateUserId].ToString().Trim(); //建立用户Id
objvFunctionGroupEN.UpdDate = objRow[convFunctionGroup.UpdDate] == DBNull.Value ? null : objRow[convFunctionGroup.UpdDate].ToString().Trim(); //修改日期
objvFunctionGroupEN.UpdUser = objRow[convFunctionGroup.UpdUser] == DBNull.Value ? null : objRow[convFunctionGroup.UpdUser].ToString().Trim(); //修改者
objvFunctionGroupEN.Memo = objRow[convFunctionGroup.Memo] == DBNull.Value ? null : objRow[convFunctionGroup.Memo].ToString().Trim(); //说明
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFunctionGroupEN.FunctionGroupId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFunctionGroupEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFunctionGroupEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFunctionGroup(ref clsvFunctionGroupEN objvFunctionGroupEN)
{
bool bolResult = vFunctionGroupDA.GetvFunctionGroup(ref objvFunctionGroupEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFunctionGroupId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFunctionGroupEN GetObjByFunctionGroupId(string strFunctionGroupId)
{
if (strFunctionGroupId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFunctionGroupId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFunctionGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFunctionGroupId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFunctionGroupEN objvFunctionGroupEN = vFunctionGroupDA.GetObjByFunctionGroupId(strFunctionGroupId);
return objvFunctionGroupEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFunctionGroupEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFunctionGroupEN objvFunctionGroupEN = vFunctionGroupDA.GetFirstObj(strWhereCond);
 return objvFunctionGroupEN;
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
public static clsvFunctionGroupEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFunctionGroupEN objvFunctionGroupEN = vFunctionGroupDA.GetObjByDataRow(objRow);
 return objvFunctionGroupEN;
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
public static clsvFunctionGroupEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFunctionGroupEN objvFunctionGroupEN = vFunctionGroupDA.GetObjByDataRow(objRow);
 return objvFunctionGroupEN;
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
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <param name = "lstvFunctionGroupObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionGroupEN GetObjByFunctionGroupIdFromList(string strFunctionGroupId, List<clsvFunctionGroupEN> lstvFunctionGroupObjLst)
{
foreach (clsvFunctionGroupEN objvFunctionGroupEN in lstvFunctionGroupObjLst)
{
if (objvFunctionGroupEN.FunctionGroupId == strFunctionGroupId)
{
return objvFunctionGroupEN;
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
 string strFunctionGroupId;
 try
 {
 strFunctionGroupId = new clsvFunctionGroupDA().GetFirstID(strWhereCond);
 return strFunctionGroupId;
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
 arrList = vFunctionGroupDA.GetID(strWhereCond);
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
bool bolIsExist = vFunctionGroupDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFunctionGroupId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFunctionGroupId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFunctionGroupDA.IsExist(strFunctionGroupId);
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
 bolIsExist = clsvFunctionGroupDA.IsExistTable();
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
 bolIsExist = vFunctionGroupDA.IsExistTable(strTabName);
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
 /// <param name = "objvFunctionGroupENS">源对象</param>
 /// <param name = "objvFunctionGroupENT">目标对象</param>
 public static void CopyTo(clsvFunctionGroupEN objvFunctionGroupENS, clsvFunctionGroupEN objvFunctionGroupENT)
{
try
{
objvFunctionGroupENT.FunctionGroupId = objvFunctionGroupENS.FunctionGroupId; //函数组Id
objvFunctionGroupENT.FunctionGroupName = objvFunctionGroupENS.FunctionGroupName; //函数组名称
objvFunctionGroupENT.ProgLangTypeId = objvFunctionGroupENS.ProgLangTypeId; //编程语言类型Id
objvFunctionGroupENT.ProgLangTypeName = objvFunctionGroupENS.ProgLangTypeName; //编程语言类型名
objvFunctionGroupENT.CreateUserId = objvFunctionGroupENS.CreateUserId; //建立用户Id
objvFunctionGroupENT.UpdDate = objvFunctionGroupENS.UpdDate; //修改日期
objvFunctionGroupENT.UpdUser = objvFunctionGroupENS.UpdUser; //修改者
objvFunctionGroupENT.Memo = objvFunctionGroupENS.Memo; //说明
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
 /// <param name = "objvFunctionGroupEN">源简化对象</param>
 public static void SetUpdFlag(clsvFunctionGroupEN objvFunctionGroupEN)
{
try
{
objvFunctionGroupEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFunctionGroupEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFunctionGroup.FunctionGroupId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.FunctionGroupId = objvFunctionGroupEN.FunctionGroupId; //函数组Id
}
if (arrFldSet.Contains(convFunctionGroup.FunctionGroupName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.FunctionGroupName = objvFunctionGroupEN.FunctionGroupName; //函数组名称
}
if (arrFldSet.Contains(convFunctionGroup.ProgLangTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.ProgLangTypeId = objvFunctionGroupEN.ProgLangTypeId; //编程语言类型Id
}
if (arrFldSet.Contains(convFunctionGroup.ProgLangTypeName, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.ProgLangTypeName = objvFunctionGroupEN.ProgLangTypeName; //编程语言类型名
}
if (arrFldSet.Contains(convFunctionGroup.CreateUserId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.CreateUserId = objvFunctionGroupEN.CreateUserId; //建立用户Id
}
if (arrFldSet.Contains(convFunctionGroup.UpdDate, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.UpdDate = objvFunctionGroupEN.UpdDate == "[null]" ? null :  objvFunctionGroupEN.UpdDate; //修改日期
}
if (arrFldSet.Contains(convFunctionGroup.UpdUser, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.UpdUser = objvFunctionGroupEN.UpdUser == "[null]" ? null :  objvFunctionGroupEN.UpdUser; //修改者
}
if (arrFldSet.Contains(convFunctionGroup.Memo, new clsStrCompareIgnoreCase())  ==  true)
{
objvFunctionGroupEN.Memo = objvFunctionGroupEN.Memo == "[null]" ? null :  objvFunctionGroupEN.Memo; //说明
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
 /// <param name = "objvFunctionGroupEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFunctionGroupEN objvFunctionGroupEN)
{
try
{
if (objvFunctionGroupEN.UpdDate == "[null]") objvFunctionGroupEN.UpdDate = null; //修改日期
if (objvFunctionGroupEN.UpdUser == "[null]") objvFunctionGroupEN.UpdUser = null; //修改者
if (objvFunctionGroupEN.Memo == "[null]") objvFunctionGroupEN.Memo = null; //说明
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
public static void CheckProperty4Condition(clsvFunctionGroupEN objvFunctionGroupEN)
{
 vFunctionGroupDA.CheckProperty4Condition(objvFunctionGroupEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

public static void BindCbo_FunctionGroupId(System.Windows.Forms.ComboBox objComboBox )
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convFunctionGroup.FunctionGroupId); 
List<clsvFunctionGroupEN> arrObjLst = clsvFunctionGroupBL.GetObjLst(strCondition);
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvFunctionGroupEN objvFunctionGroupEN = new clsvFunctionGroupEN()
{
FunctionGroupId = "0",
FunctionGroupName = "选[v函数组]..."
};
arrObjLst.Insert(0, objvFunctionGroupEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convFunctionGroup.FunctionGroupId;
objComboBox.DisplayMember = convFunctionGroup.FunctionGroupName;
objComboBox.DataSource = arrObjLst;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

public static void BindDdl_FunctionGroupId(System.Web.UI.WebControls.DropDownList objDDL )
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v函数组]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convFunctionGroup.FunctionGroupId); 
IEnumerable<clsvFunctionGroupEN> arrObjLst = clsvFunctionGroupBL.GetObjLst(strCondition);
objDDL.DataValueField = convFunctionGroup.FunctionGroupId;
objDDL.DataTextField = convFunctionGroup.FunctionGroupName;
objDDL.DataSource = arrObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FunctionGroupIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[v函数组]...","0");
List<clsvFunctionGroupEN> arrvFunctionGroupObjLst = GetAllvFunctionGroupObjLstCache(); 
objDDL.DataValueField = convFunctionGroup.FunctionGroupId;
objDDL.DataTextField = convFunctionGroup.FunctionGroupName;
objDDL.DataSource = arrvFunctionGroupObjLst;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}


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
if (clsProgLangTypeBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsProgLangTypeBL没有刷新缓存机制(clsProgLangTypeBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
if (clsFunctionGroupBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFunctionGroupBL没有刷新缓存机制(clsFunctionGroupBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FunctionGroupId");
//if (arrvFunctionGroupObjLstCache == null)
//{
//arrvFunctionGroupObjLstCache = vFunctionGroupDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFunctionGroupEN GetObjByFunctionGroupIdCache(string strFunctionGroupId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFunctionGroupEN._CurrTabName);
List<clsvFunctionGroupEN> arrvFunctionGroupObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupEN> arrvFunctionGroupObjLst_Sel =
arrvFunctionGroupObjLstCache
.Where(x=> x.FunctionGroupId == strFunctionGroupId 
);
if (arrvFunctionGroupObjLst_Sel.Count() == 0)
{
   clsvFunctionGroupEN obj = clsvFunctionGroupBL.GetObjByFunctionGroupId(strFunctionGroupId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFunctionGroupObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFunctionGroupNameByFunctionGroupIdCache(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true) return "";
//获取缓存中的对象列表
clsvFunctionGroupEN objvFunctionGroup = GetObjByFunctionGroupIdCache(strFunctionGroupId);
if (objvFunctionGroup == null) return "";
return objvFunctionGroup.FunctionGroupName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFunctionGroupId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFunctionGroupIdCache(string strFunctionGroupId)
{
if (string.IsNullOrEmpty(strFunctionGroupId) == true) return "";
//获取缓存中的对象列表
clsvFunctionGroupEN objvFunctionGroup = GetObjByFunctionGroupIdCache(strFunctionGroupId);
if (objvFunctionGroup == null) return "";
return objvFunctionGroup.FunctionGroupName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionGroupEN> GetAllvFunctionGroupObjLstCache()
{
//获取缓存中的对象列表
List<clsvFunctionGroupEN> arrvFunctionGroupObjLstCache = GetObjLstCache(); 
return arrvFunctionGroupObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFunctionGroupEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFunctionGroupEN._CurrTabName);
List<clsvFunctionGroupEN> arrvFunctionGroupObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFunctionGroupObjLstCache;
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
string strKey = string.Format("{0}", clsvFunctionGroupEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFunctionGroupEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFunctionGroupEN._RefreshTimeLst.Count == 0) return "";
return clsvFunctionGroupEN._RefreshTimeLst[clsvFunctionGroupEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strFunctionGroupId)
{
if (strInFldName != convFunctionGroup.FunctionGroupId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFunctionGroup._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFunctionGroup._AttributeName));
throw new Exception(strMsg);
}
var objvFunctionGroup = clsvFunctionGroupBL.GetObjByFunctionGroupIdCache(strFunctionGroupId);
if (objvFunctionGroup == null) return "";
return objvFunctionGroup[strOutFldName].ToString();
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
int intRecCount = clsvFunctionGroupDA.GetRecCount(strTabName);
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
int intRecCount = clsvFunctionGroupDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFunctionGroupDA.GetRecCount();
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
int intRecCount = clsvFunctionGroupDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFunctionGroupCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFunctionGroupEN objvFunctionGroupCond)
{
List<clsvFunctionGroupEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFunctionGroupEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFunctionGroup._AttributeName)
{
if (objvFunctionGroupCond.IsUpdated(strFldName) == false) continue;
if (objvFunctionGroupCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupCond[strFldName].ToString());
}
else
{
if (objvFunctionGroupCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFunctionGroupCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFunctionGroupCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFunctionGroupCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFunctionGroupCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFunctionGroupCond[strFldName]));
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
 List<string> arrList = clsvFunctionGroupDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFunctionGroupDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFunctionGroupDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}