
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjFeatureSimBL
 表名:vPrjFeatureSim(00050637)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:02:59
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
public static class  clsvPrjFeatureSimBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFeatureSimEN GetObj(this K_FeatureId_vPrjFeatureSim myKey)
{
clsvPrjFeatureSimEN objvPrjFeatureSimEN = clsvPrjFeatureSimBL.vPrjFeatureSimDA.GetObjByFeatureId(myKey.Value);
return objvPrjFeatureSimEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetFeatureId(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convPrjFeatureSim.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convPrjFeatureSim.FeatureId);
}
objvPrjFeatureSimEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.FeatureId) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.FeatureId, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.FeatureId] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetFeatureName(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, string strFeatureName, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureName, convPrjFeatureSim.FeatureName);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureName, 100, convPrjFeatureSim.FeatureName);
}
objvPrjFeatureSimEN.FeatureName = strFeatureName; //功能名称
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.FeatureName) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.FeatureName, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.FeatureName] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetFeatureTypeId(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, string strFeatureTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strFeatureTypeId, convPrjFeatureSim.FeatureTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureTypeId, 2, convPrjFeatureSim.FeatureTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureTypeId, 2, convPrjFeatureSim.FeatureTypeId);
}
objvPrjFeatureSimEN.FeatureTypeId = strFeatureTypeId; //功能类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.FeatureTypeId) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.FeatureTypeId, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.FeatureTypeId] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetRegionTypeId(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, string strRegionTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(strRegionTypeId, convPrjFeatureSim.RegionTypeId);
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strRegionTypeId, 4, convPrjFeatureSim.RegionTypeId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strRegionTypeId, 4, convPrjFeatureSim.RegionTypeId);
}
objvPrjFeatureSimEN.RegionTypeId = strRegionTypeId; //区域类型Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.RegionTypeId) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.RegionTypeId, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.RegionTypeId] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetInUse(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, bool bolInUse, string strComparisonOp="")
	{
objvPrjFeatureSimEN.InUse = bolInUse; //是否在用
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.InUse) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.InUse, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.InUse] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetParentFeatureName(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, string strParentFeatureName, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureName, 500, convPrjFeatureSim.ParentFeatureName);
}
objvPrjFeatureSimEN.ParentFeatureName = strParentFeatureName; //父功能名
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.ParentFeatureName) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.ParentFeatureName, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.ParentFeatureName] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvPrjFeatureSimEN SetParentFeatureId(this clsvPrjFeatureSimEN objvPrjFeatureSimEN, string strParentFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strParentFeatureId, 4, convPrjFeatureSim.ParentFeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strParentFeatureId, 4, convPrjFeatureSim.ParentFeatureId);
}
objvPrjFeatureSimEN.ParentFeatureId = strParentFeatureId; //父功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvPrjFeatureSimEN.dicFldComparisonOp.ContainsKey(convPrjFeatureSim.ParentFeatureId) == false)
{
objvPrjFeatureSimEN.dicFldComparisonOp.Add(convPrjFeatureSim.ParentFeatureId, strComparisonOp);
}
else
{
objvPrjFeatureSimEN.dicFldComparisonOp[convPrjFeatureSim.ParentFeatureId] = strComparisonOp;
}
}
return objvPrjFeatureSimEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvPrjFeatureSimENS">源对象</param>
 /// <param name = "objvPrjFeatureSimENT">目标对象</param>
 public static void CopyTo(this clsvPrjFeatureSimEN objvPrjFeatureSimENS, clsvPrjFeatureSimEN objvPrjFeatureSimENT)
{
try
{
objvPrjFeatureSimENT.FeatureId = objvPrjFeatureSimENS.FeatureId; //功能Id
objvPrjFeatureSimENT.FeatureName = objvPrjFeatureSimENS.FeatureName; //功能名称
objvPrjFeatureSimENT.FeatureTypeId = objvPrjFeatureSimENS.FeatureTypeId; //功能类型Id
objvPrjFeatureSimENT.RegionTypeId = objvPrjFeatureSimENS.RegionTypeId; //区域类型Id
objvPrjFeatureSimENT.InUse = objvPrjFeatureSimENS.InUse; //是否在用
objvPrjFeatureSimENT.ParentFeatureName = objvPrjFeatureSimENS.ParentFeatureName; //父功能名
objvPrjFeatureSimENT.ParentFeatureId = objvPrjFeatureSimENS.ParentFeatureId; //父功能Id
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
 /// <param name = "objvPrjFeatureSimENS">源对象</param>
 /// <returns>目标对象=>clsvPrjFeatureSimEN:objvPrjFeatureSimENT</returns>
 public static clsvPrjFeatureSimEN CopyTo(this clsvPrjFeatureSimEN objvPrjFeatureSimENS)
{
try
{
 clsvPrjFeatureSimEN objvPrjFeatureSimENT = new clsvPrjFeatureSimEN()
{
FeatureId = objvPrjFeatureSimENS.FeatureId, //功能Id
FeatureName = objvPrjFeatureSimENS.FeatureName, //功能名称
FeatureTypeId = objvPrjFeatureSimENS.FeatureTypeId, //功能类型Id
RegionTypeId = objvPrjFeatureSimENS.RegionTypeId, //区域类型Id
InUse = objvPrjFeatureSimENS.InUse, //是否在用
ParentFeatureName = objvPrjFeatureSimENS.ParentFeatureName, //父功能名
ParentFeatureId = objvPrjFeatureSimENS.ParentFeatureId, //父功能Id
};
 return objvPrjFeatureSimENT;
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
public static void CheckProperty4Condition(this clsvPrjFeatureSimEN objvPrjFeatureSimEN)
{
 clsvPrjFeatureSimBL.vPrjFeatureSimDA.CheckProperty4Condition(objvPrjFeatureSimEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvPrjFeatureSimEN objvPrjFeatureSimCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.FeatureId) == true)
{
string strComparisonOpFeatureId = objvPrjFeatureSimCond.dicFldComparisonOp[convPrjFeatureSim.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeatureSim.FeatureId, objvPrjFeatureSimCond.FeatureId, strComparisonOpFeatureId);
}
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.FeatureName) == true)
{
string strComparisonOpFeatureName = objvPrjFeatureSimCond.dicFldComparisonOp[convPrjFeatureSim.FeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeatureSim.FeatureName, objvPrjFeatureSimCond.FeatureName, strComparisonOpFeatureName);
}
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.FeatureTypeId) == true)
{
string strComparisonOpFeatureTypeId = objvPrjFeatureSimCond.dicFldComparisonOp[convPrjFeatureSim.FeatureTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeatureSim.FeatureTypeId, objvPrjFeatureSimCond.FeatureTypeId, strComparisonOpFeatureTypeId);
}
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.RegionTypeId) == true)
{
string strComparisonOpRegionTypeId = objvPrjFeatureSimCond.dicFldComparisonOp[convPrjFeatureSim.RegionTypeId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeatureSim.RegionTypeId, objvPrjFeatureSimCond.RegionTypeId, strComparisonOpRegionTypeId);
}
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.InUse) == true)
{
if (objvPrjFeatureSimCond.InUse == true)
{
strWhereCond += string.Format(" And {0} = '1'", convPrjFeatureSim.InUse);
}
else
{
strWhereCond += string.Format(" And {0} = '0'", convPrjFeatureSim.InUse);
}
}
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.ParentFeatureName) == true)
{
string strComparisonOpParentFeatureName = objvPrjFeatureSimCond.dicFldComparisonOp[convPrjFeatureSim.ParentFeatureName];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeatureSim.ParentFeatureName, objvPrjFeatureSimCond.ParentFeatureName, strComparisonOpParentFeatureName);
}
if (objvPrjFeatureSimCond.IsUpdated(convPrjFeatureSim.ParentFeatureId) == true)
{
string strComparisonOpParentFeatureId = objvPrjFeatureSimCond.dicFldComparisonOp[convPrjFeatureSim.ParentFeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convPrjFeatureSim.ParentFeatureId, objvPrjFeatureSimCond.ParentFeatureId, strComparisonOpParentFeatureId);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vPrjFeatureSim
{
public virtual bool UpdRelaTabDate(string strFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// vPrjFeatureSim(vPrjFeatureSim)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvPrjFeatureSimBL
{
public static RelatedActions_vPrjFeatureSim relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvPrjFeatureSimDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvPrjFeatureSimDA vPrjFeatureSimDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvPrjFeatureSimDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvPrjFeatureSimBL()
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
if (string.IsNullOrEmpty(clsvPrjFeatureSimEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjFeatureSimEN._ConnectString);
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
public static DataTable GetDataTable_vPrjFeatureSim(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vPrjFeatureSimDA.GetDataTable_vPrjFeatureSim(strWhereCond);
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
objDT = vPrjFeatureSimDA.GetDataTable(strWhereCond);
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
objDT = vPrjFeatureSimDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vPrjFeatureSimDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vPrjFeatureSimDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vPrjFeatureSimDA.GetDataTable_Top(objTopPara);
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
objDT = vPrjFeatureSimDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vPrjFeatureSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vPrjFeatureSimDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetObjLstByFeatureIdLst(List<string> arrFeatureIdLst)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFeatureIdLst, true);
 string strWhereCond = string.Format("FeatureId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvPrjFeatureSimEN> GetObjLstByFeatureIdLstCache(List<string> arrFeatureIdLst)
{
string strKey = string.Format("{0}", clsvPrjFeatureSimEN._CurrTabName);
List<clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLst_Sel =
arrvPrjFeatureSimObjLstCache
.Where(x => arrFeatureIdLst.Contains(x.FeatureId));
return arrvPrjFeatureSimObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetObjLst(string strWhereCond)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
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
public static List<clsvPrjFeatureSimEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvPrjFeatureSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvPrjFeatureSimEN> GetSubObjLstCache(clsvPrjFeatureSimEN objvPrjFeatureSimCond)
{
List<clsvPrjFeatureSimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFeatureSim._AttributeName)
{
if (objvPrjFeatureSimCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFeatureSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureSimCond[strFldName].ToString());
}
else
{
if (objvPrjFeatureSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFeatureSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFeatureSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureSimCond[strFldName]));
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
public static List<clsvPrjFeatureSimEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
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
public static List<clsvPrjFeatureSimEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
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
List<clsvPrjFeatureSimEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvPrjFeatureSimEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvPrjFeatureSimEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
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
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
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
public static List<clsvPrjFeatureSimEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvPrjFeatureSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
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
public static List<clsvPrjFeatureSimEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvPrjFeatureSimEN> arrObjLst = new List<clsvPrjFeatureSimEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN();
try
{
objvPrjFeatureSimEN.FeatureId = objRow[convPrjFeatureSim.FeatureId].ToString().Trim(); //功能Id
objvPrjFeatureSimEN.FeatureName = objRow[convPrjFeatureSim.FeatureName].ToString().Trim(); //功能名称
objvPrjFeatureSimEN.FeatureTypeId = objRow[convPrjFeatureSim.FeatureTypeId].ToString().Trim(); //功能类型Id
objvPrjFeatureSimEN.RegionTypeId = objRow[convPrjFeatureSim.RegionTypeId].ToString().Trim(); //区域类型Id
objvPrjFeatureSimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convPrjFeatureSim.InUse].ToString().Trim()); //是否在用
objvPrjFeatureSimEN.ParentFeatureName = objRow[convPrjFeatureSim.ParentFeatureName] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureName].ToString().Trim(); //父功能名
objvPrjFeatureSimEN.ParentFeatureId = objRow[convPrjFeatureSim.ParentFeatureId] == DBNull.Value ? null : objRow[convPrjFeatureSim.ParentFeatureId].ToString().Trim(); //父功能Id
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvPrjFeatureSimEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvPrjFeatureSimEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvPrjFeatureSimEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvPrjFeatureSim(ref clsvPrjFeatureSimEN objvPrjFeatureSimEN)
{
bool bolResult = vPrjFeatureSimDA.GetvPrjFeatureSim(ref objvPrjFeatureSimEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvPrjFeatureSimEN GetObjByFeatureId(string strFeatureId)
{
if (strFeatureId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFeatureId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFeatureId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvPrjFeatureSimEN objvPrjFeatureSimEN = vPrjFeatureSimDA.GetObjByFeatureId(strFeatureId);
return objvPrjFeatureSimEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvPrjFeatureSimEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvPrjFeatureSimEN objvPrjFeatureSimEN = vPrjFeatureSimDA.GetFirstObj(strWhereCond);
 return objvPrjFeatureSimEN;
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
public static clsvPrjFeatureSimEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvPrjFeatureSimEN objvPrjFeatureSimEN = vPrjFeatureSimDA.GetObjByDataRow(objRow);
 return objvPrjFeatureSimEN;
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
public static clsvPrjFeatureSimEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvPrjFeatureSimEN objvPrjFeatureSimEN = vPrjFeatureSimDA.GetObjByDataRow(objRow);
 return objvPrjFeatureSimEN;
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
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <param name = "lstvPrjFeatureSimObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFeatureSimEN GetObjByFeatureIdFromList(string strFeatureId, List<clsvPrjFeatureSimEN> lstvPrjFeatureSimObjLst)
{
foreach (clsvPrjFeatureSimEN objvPrjFeatureSimEN in lstvPrjFeatureSimObjLst)
{
if (objvPrjFeatureSimEN.FeatureId == strFeatureId)
{
return objvPrjFeatureSimEN;
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
 string strFeatureId;
 try
 {
 strFeatureId = new clsvPrjFeatureSimDA().GetFirstID(strWhereCond);
 return strFeatureId;
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
 arrList = vPrjFeatureSimDA.GetID(strWhereCond);
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
bool bolIsExist = vPrjFeatureSimDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFeatureId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFeatureId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vPrjFeatureSimDA.IsExist(strFeatureId);
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
 bolIsExist = clsvPrjFeatureSimDA.IsExistTable();
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
 bolIsExist = vPrjFeatureSimDA.IsExistTable(strTabName);
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
 /// <param name = "objvPrjFeatureSimENS">源对象</param>
 /// <param name = "objvPrjFeatureSimENT">目标对象</param>
 public static void CopyTo(clsvPrjFeatureSimEN objvPrjFeatureSimENS, clsvPrjFeatureSimEN objvPrjFeatureSimENT)
{
try
{
objvPrjFeatureSimENT.FeatureId = objvPrjFeatureSimENS.FeatureId; //功能Id
objvPrjFeatureSimENT.FeatureName = objvPrjFeatureSimENS.FeatureName; //功能名称
objvPrjFeatureSimENT.FeatureTypeId = objvPrjFeatureSimENS.FeatureTypeId; //功能类型Id
objvPrjFeatureSimENT.RegionTypeId = objvPrjFeatureSimENS.RegionTypeId; //区域类型Id
objvPrjFeatureSimENT.InUse = objvPrjFeatureSimENS.InUse; //是否在用
objvPrjFeatureSimENT.ParentFeatureName = objvPrjFeatureSimENS.ParentFeatureName; //父功能名
objvPrjFeatureSimENT.ParentFeatureId = objvPrjFeatureSimENS.ParentFeatureId; //父功能Id
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
 /// <param name = "objvPrjFeatureSimEN">源简化对象</param>
 public static void SetUpdFlag(clsvPrjFeatureSimEN objvPrjFeatureSimEN)
{
try
{
objvPrjFeatureSimEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvPrjFeatureSimEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convPrjFeatureSim.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.FeatureId = objvPrjFeatureSimEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convPrjFeatureSim.FeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.FeatureName = objvPrjFeatureSimEN.FeatureName; //功能名称
}
if (arrFldSet.Contains(convPrjFeatureSim.FeatureTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.FeatureTypeId = objvPrjFeatureSimEN.FeatureTypeId; //功能类型Id
}
if (arrFldSet.Contains(convPrjFeatureSim.RegionTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.RegionTypeId = objvPrjFeatureSimEN.RegionTypeId; //区域类型Id
}
if (arrFldSet.Contains(convPrjFeatureSim.InUse, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.InUse = objvPrjFeatureSimEN.InUse; //是否在用
}
if (arrFldSet.Contains(convPrjFeatureSim.ParentFeatureName, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.ParentFeatureName = objvPrjFeatureSimEN.ParentFeatureName == "[null]" ? null :  objvPrjFeatureSimEN.ParentFeatureName; //父功能名
}
if (arrFldSet.Contains(convPrjFeatureSim.ParentFeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvPrjFeatureSimEN.ParentFeatureId = objvPrjFeatureSimEN.ParentFeatureId == "[null]" ? null :  objvPrjFeatureSimEN.ParentFeatureId; //父功能Id
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
 /// <param name = "objvPrjFeatureSimEN">源简化对象</param>
 public static void AccessFldValueNull(clsvPrjFeatureSimEN objvPrjFeatureSimEN)
{
try
{
if (objvPrjFeatureSimEN.ParentFeatureName == "[null]") objvPrjFeatureSimEN.ParentFeatureName = null; //父功能名
if (objvPrjFeatureSimEN.ParentFeatureId == "[null]") objvPrjFeatureSimEN.ParentFeatureId = null; //父功能Id
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
public static void CheckProperty4Condition(clsvPrjFeatureSimEN objvPrjFeatureSimEN)
{
 vPrjFeatureSimDA.CheckProperty4Condition(objvPrjFeatureSimEN);
 }


 #endregion 检查对象属性


 #region 绑定下拉框

 /// <summary>
 /// 绑定基于Win的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_ComboBoxBindFunction)
 /// </summary>
 /// <param name = "objComboBox">需要绑定当前表的下拉框</param>

 /// <param name = "strFeatureTypeId"></param>
public static void BindCbo_FeatureId(System.Windows.Forms.ComboBox objComboBox , string strFeatureTypeId)
{
//为数据源为表的下拉框设置内容
string strCondition = string.Format("1 =1 Order By {0}", convPrjFeatureSim.FeatureId); 
List<clsvPrjFeatureSimEN> arrObjLst = clsvPrjFeatureSimBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FeatureTypeId == strFeatureTypeId).ToList();
//初始化一个对象列表
//插入第0项。在第0项中插入“请选择...”,为了方便用户,与WEB方式类似。
clsvPrjFeatureSimEN objvPrjFeatureSimEN = new clsvPrjFeatureSimEN()
{
FeatureId = "0",
FeatureName = "选[vPrjFeatureSim]..."
};
arrObjLstSel.Insert(0, objvPrjFeatureSimEN);
//设置下拉框的数据源、以及设置值项、显示项
objComboBox.ValueMember = convPrjFeatureSim.FeatureId;
objComboBox.DisplayMember = convPrjFeatureSim.FeatureName;
objComboBox.DataSource = arrObjLstSel;
objComboBox.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_TabFeature_DdlBindFunction)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>

 /// <param name = "strFeatureTypeId"></param>
public static void BindDdl_FeatureId(System.Web.UI.WebControls.DropDownList objDDL , string strFeatureTypeId)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjFeatureSim]...","0");
string strCondition = string.Format("1 =1 Order By {0}", convPrjFeatureSim.FeatureId); 
IEnumerable<clsvPrjFeatureSimEN> arrObjLst = clsvPrjFeatureSimBL.GetObjLst(strCondition);
var arrObjLstSel = arrObjLst.Where(x=>x.FeatureTypeId == strFeatureTypeId).ToList();
objDDL.DataValueField = convPrjFeatureSim.FeatureId;
objDDL.DataTextField = convPrjFeatureSim.FeatureName;
objDDL.DataSource = arrObjLstSel;
objDDL.DataBind();
objDDL.Items.Insert(0, li);
objDDL.SelectedIndex = 0;
}

 /// <summary>
 /// 绑定基于Web的下拉框-使用Cache
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DdlBindFunctionCache)
 /// </summary>
 /// <param name = "objDDL">需要绑定当前表的下拉框</param>
public static void BindDdl_FeatureIdCache(System.Web.UI.WebControls.DropDownList objDDL)
{
//为数据源于表的下拉框设置内容
System.Web.UI.WebControls.ListItem li = new System.Web.UI.WebControls.ListItem("选[vPrjFeatureSim]...","0");
List<clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLst = GetAllvPrjFeatureSimObjLstCache(); 
objDDL.DataValueField = convPrjFeatureSim.FeatureId;
objDDL.DataTextField = convPrjFeatureSim.FeatureName;
objDDL.DataSource = arrvPrjFeatureSimObjLst;
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
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FeatureId");
//if (arrvPrjFeatureSimObjLstCache == null)
//{
//arrvPrjFeatureSimObjLstCache = vPrjFeatureSimDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvPrjFeatureSimEN GetObjByFeatureIdCache(string strFeatureId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvPrjFeatureSimEN._CurrTabName);
List<clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLst_Sel =
arrvPrjFeatureSimObjLstCache
.Where(x=> x.FeatureId == strFeatureId 
);
if (arrvPrjFeatureSimObjLst_Sel.Count() == 0)
{
   clsvPrjFeatureSimEN obj = clsvPrjFeatureSimBL.GetObjByFeatureId(strFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvPrjFeatureSimObjLst_Sel.First();
}

 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetFeatureNameByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return "";
//获取缓存中的对象列表
clsvPrjFeatureSimEN objvPrjFeatureSim = GetObjByFeatureIdCache(strFeatureId);
if (objvPrjFeatureSim == null) return "";
return objvPrjFeatureSim.FeatureName;
}
 /// <summary>
 /// 根据关键字获取相关名称, 从缓存的对象列表中获取.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecNameByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的名称</returns>
public static string GetNameByFeatureIdCache(string strFeatureId)
{
if (string.IsNullOrEmpty(strFeatureId) == true) return "";
//获取缓存中的对象列表
clsvPrjFeatureSimEN objvPrjFeatureSim = GetObjByFeatureIdCache(strFeatureId);
if (objvPrjFeatureSim == null) return "";
return objvPrjFeatureSim.FeatureName;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetAllvPrjFeatureSimObjLstCache()
{
//获取缓存中的对象列表
List<clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLstCache = GetObjLstCache(); 
return arrvPrjFeatureSimObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvPrjFeatureSimEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvPrjFeatureSimEN._CurrTabName);
List<clsvPrjFeatureSimEN> arrvPrjFeatureSimObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvPrjFeatureSimObjLstCache;
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
string strKey = string.Format("{0}", clsvPrjFeatureSimEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvPrjFeatureSimEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvPrjFeatureSimEN._RefreshTimeLst.Count == 0) return "";
return clsvPrjFeatureSimEN._RefreshTimeLst[clsvPrjFeatureSimEN._RefreshTimeLst.Count - 1];
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
public static string Func(string strInFldName, string strOutFldName, string strFeatureId)
{
if (strInFldName != convPrjFeatureSim.FeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convPrjFeatureSim._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convPrjFeatureSim._AttributeName));
throw new Exception(strMsg);
}
var objvPrjFeatureSim = clsvPrjFeatureSimBL.GetObjByFeatureIdCache(strFeatureId);
if (objvPrjFeatureSim == null) return "";
return objvPrjFeatureSim[strOutFldName].ToString();
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
int intRecCount = clsvPrjFeatureSimDA.GetRecCount(strTabName);
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
int intRecCount = clsvPrjFeatureSimDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvPrjFeatureSimDA.GetRecCount();
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
int intRecCount = clsvPrjFeatureSimDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvPrjFeatureSimCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvPrjFeatureSimEN objvPrjFeatureSimCond)
{
List<clsvPrjFeatureSimEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvPrjFeatureSimEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convPrjFeatureSim._AttributeName)
{
if (objvPrjFeatureSimCond.IsUpdated(strFldName) == false) continue;
if (objvPrjFeatureSimCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureSimCond[strFldName].ToString());
}
else
{
if (objvPrjFeatureSimCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvPrjFeatureSimCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvPrjFeatureSimCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvPrjFeatureSimCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvPrjFeatureSimCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureSimCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvPrjFeatureSimCond[strFldName]));
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
 List<string> arrList = clsvPrjFeatureSimDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vPrjFeatureSimDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vPrjFeatureSimDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}