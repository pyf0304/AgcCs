
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFeatureFuncRela_GroupByTtlBL
 表名:vFeatureFuncRela_GroupByTtl(00050537)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:09:17
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
public static class  clsvFeatureFuncRela_GroupByTtlBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFuncRela_GroupByTtlEN GetObj(this K_FeatureId_vFeatureFuncRela_GroupByTtl myKey)
{
clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = clsvFeatureFuncRela_GroupByTtlBL.vFeatureFuncRela_GroupByTtlDA.GetObjByFeatureId(myKey.Value);
return objvFeatureFuncRela_GroupByTtlEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRela_GroupByTtlEN SetFeatureId(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN, string strFeatureId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFeatureId, 4, convFeatureFuncRela_GroupByTtl.FeatureId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFeatureId, 4, convFeatureFuncRela_GroupByTtl.FeatureId);
}
objvFeatureFuncRela_GroupByTtlEN.FeatureId = strFeatureId; //功能Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela_GroupByTtl.FeatureId) == false)
{
objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp.Add(convFeatureFuncRela_GroupByTtl.FeatureId, strComparisonOp);
}
else
{
objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp[convFeatureFuncRela_GroupByTtl.FeatureId] = strComparisonOp;
}
}
return objvFeatureFuncRela_GroupByTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRela_GroupByTtlEN SetApplicationTypeId(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN, int intApplicationTypeId, string strComparisonOp="")
	{
clsCheckSql.CheckFieldNotNull(intApplicationTypeId, convFeatureFuncRela_GroupByTtl.ApplicationTypeId);
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = intApplicationTypeId; //应用程序类型ID
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela_GroupByTtl.ApplicationTypeId) == false)
{
objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp.Add(convFeatureFuncRela_GroupByTtl.ApplicationTypeId, strComparisonOp);
}
else
{
objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp[convFeatureFuncRela_GroupByTtl.ApplicationTypeId] = strComparisonOp;
}
}
return objvFeatureFuncRela_GroupByTtlEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFeatureFuncRela_GroupByTtlEN SetFuncCount(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN, int? intFuncCount, string strComparisonOp="")
	{
objvFeatureFuncRela_GroupByTtlEN.FuncCount = intFuncCount; //函数数目
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp.ContainsKey(convFeatureFuncRela_GroupByTtl.FuncCount) == false)
{
objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp.Add(convFeatureFuncRela_GroupByTtl.FuncCount, strComparisonOp);
}
else
{
objvFeatureFuncRela_GroupByTtlEN.dicFldComparisonOp[convFeatureFuncRela_GroupByTtl.FuncCount] = strComparisonOp;
}
}
return objvFeatureFuncRela_GroupByTtlEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlENS">源对象</param>
 /// <param name = "objvFeatureFuncRela_GroupByTtlENT">目标对象</param>
 public static void CopyTo(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENS, clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENT)
{
try
{
objvFeatureFuncRela_GroupByTtlENT.FeatureId = objvFeatureFuncRela_GroupByTtlENS.FeatureId; //功能Id
objvFeatureFuncRela_GroupByTtlENT.ApplicationTypeId = objvFeatureFuncRela_GroupByTtlENS.ApplicationTypeId; //应用程序类型ID
objvFeatureFuncRela_GroupByTtlENT.FuncCount = objvFeatureFuncRela_GroupByTtlENS.FuncCount; //函数数目
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
 /// <param name = "objvFeatureFuncRela_GroupByTtlENS">源对象</param>
 /// <returns>目标对象=>clsvFeatureFuncRela_GroupByTtlEN:objvFeatureFuncRela_GroupByTtlENT</returns>
 public static clsvFeatureFuncRela_GroupByTtlEN CopyTo(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENS)
{
try
{
 clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENT = new clsvFeatureFuncRela_GroupByTtlEN()
{
FeatureId = objvFeatureFuncRela_GroupByTtlENS.FeatureId, //功能Id
ApplicationTypeId = objvFeatureFuncRela_GroupByTtlENS.ApplicationTypeId, //应用程序类型ID
FuncCount = objvFeatureFuncRela_GroupByTtlENS.FuncCount, //函数数目
};
 return objvFeatureFuncRela_GroupByTtlENT;
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
public static void CheckProperty4Condition(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN)
{
 clsvFeatureFuncRela_GroupByTtlBL.vFeatureFuncRela_GroupByTtlDA.CheckProperty4Condition(objvFeatureFuncRela_GroupByTtlEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFeatureFuncRela_GroupByTtlCond.IsUpdated(convFeatureFuncRela_GroupByTtl.FeatureId) == true)
{
string strComparisonOpFeatureId = objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp[convFeatureFuncRela_GroupByTtl.FeatureId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFeatureFuncRela_GroupByTtl.FeatureId, objvFeatureFuncRela_GroupByTtlCond.FeatureId, strComparisonOpFeatureId);
}
if (objvFeatureFuncRela_GroupByTtlCond.IsUpdated(convFeatureFuncRela_GroupByTtl.ApplicationTypeId) == true)
{
string strComparisonOpApplicationTypeId = objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp[convFeatureFuncRela_GroupByTtl.ApplicationTypeId];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFuncRela_GroupByTtl.ApplicationTypeId, objvFeatureFuncRela_GroupByTtlCond.ApplicationTypeId, strComparisonOpApplicationTypeId);
}
if (objvFeatureFuncRela_GroupByTtlCond.IsUpdated(convFeatureFuncRela_GroupByTtl.FuncCount) == true)
{
string strComparisonOpFuncCount = objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp[convFeatureFuncRela_GroupByTtl.FuncCount];
strWhereCond += string.Format(" And {0} {2} {1}", convFeatureFuncRela_GroupByTtl.FuncCount, objvFeatureFuncRela_GroupByTtlCond.FuncCount, strComparisonOpFuncCount);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFeatureFuncRela_GroupByTtl
{
public virtual bool UpdRelaTabDate(string strFeatureId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v功能函数关系_分类汇总(vFeatureFuncRela_GroupByTtl)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFeatureFuncRela_GroupByTtlBL
{
public static RelatedActions_vFeatureFuncRela_GroupByTtl relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFeatureFuncRela_GroupByTtlDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFeatureFuncRela_GroupByTtlDA vFeatureFuncRela_GroupByTtlDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFeatureFuncRela_GroupByTtlDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFeatureFuncRela_GroupByTtlBL()
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
if (string.IsNullOrEmpty(clsvFeatureFuncRela_GroupByTtlEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFeatureFuncRela_GroupByTtlEN._ConnectString);
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
public static DataTable GetDataTable_vFeatureFuncRela_GroupByTtl(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable_vFeatureFuncRela_GroupByTtl(strWhereCond);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable(strWhereCond);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable_Top(objTopPara);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFeatureFuncRela_GroupByTtlDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByFeatureIdLst(List<string> arrFeatureIdLst)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
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
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFeatureIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByFeatureIdLstCache(List<string> arrFeatureIdLst)
{
string strKey = string.Format("{0}", clsvFeatureFuncRela_GroupByTtlEN._CurrTabName);
List<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLst_Sel =
arrvFeatureFuncRela_GroupByTtlObjLstCache
.Where(x => arrFeatureIdLst.Contains(x.FeatureId));
return arrvFeatureFuncRela_GroupByTtlObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLst(string strWhereCond)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFeatureFuncRela_GroupByTtlEN> GetSubObjLstCache(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlCond)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRela_GroupByTtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureFuncRela_GroupByTtl._AttributeName)
{
if (objvFeatureFuncRela_GroupByTtlCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString());
}
else
{
if (objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRela_GroupByTtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRela_GroupByTtlCond[strFldName]));
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
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
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
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
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
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
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLst = new List<clsvFeatureFuncRela_GroupByTtlEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = new clsvFeatureFuncRela_GroupByTtlEN();
try
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objRow[convFeatureFuncRela_GroupByTtl.FeatureId].ToString().Trim(); //功能Id
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = Int32.Parse(objRow[convFeatureFuncRela_GroupByTtl.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objRow[convFeatureFuncRela_GroupByTtl.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFeatureFuncRela_GroupByTtl.FuncCount].ToString().Trim()); //函数数目
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFeatureFuncRela_GroupByTtlEN.FeatureId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFeatureFuncRela_GroupByTtlEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFeatureFuncRela_GroupByTtl(ref clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN)
{
bool bolResult = vFeatureFuncRela_GroupByTtlDA.GetvFeatureFuncRela_GroupByTtl(ref objvFeatureFuncRela_GroupByTtlEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFeatureId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFeatureFuncRela_GroupByTtlEN GetObjByFeatureId(string strFeatureId)
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
clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = vFeatureFuncRela_GroupByTtlDA.GetObjByFeatureId(strFeatureId);
return objvFeatureFuncRela_GroupByTtlEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFeatureFuncRela_GroupByTtlEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = vFeatureFuncRela_GroupByTtlDA.GetFirstObj(strWhereCond);
 return objvFeatureFuncRela_GroupByTtlEN;
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
public static clsvFeatureFuncRela_GroupByTtlEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = vFeatureFuncRela_GroupByTtlDA.GetObjByDataRow(objRow);
 return objvFeatureFuncRela_GroupByTtlEN;
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
public static clsvFeatureFuncRela_GroupByTtlEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN = vFeatureFuncRela_GroupByTtlDA.GetObjByDataRow(objRow);
 return objvFeatureFuncRela_GroupByTtlEN;
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
 /// <param name = "lstvFeatureFuncRela_GroupByTtlObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureFuncRela_GroupByTtlEN GetObjByFeatureIdFromList(string strFeatureId, List<clsvFeatureFuncRela_GroupByTtlEN> lstvFeatureFuncRela_GroupByTtlObjLst)
{
foreach (clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN in lstvFeatureFuncRela_GroupByTtlObjLst)
{
if (objvFeatureFuncRela_GroupByTtlEN.FeatureId == strFeatureId)
{
return objvFeatureFuncRela_GroupByTtlEN;
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
 strFeatureId = new clsvFeatureFuncRela_GroupByTtlDA().GetFirstID(strWhereCond);
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
 arrList = vFeatureFuncRela_GroupByTtlDA.GetID(strWhereCond);
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
bool bolIsExist = vFeatureFuncRela_GroupByTtlDA.IsExistCondRec(strWhereCond);
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
bool bolIsExist = vFeatureFuncRela_GroupByTtlDA.IsExist(strFeatureId);
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
 bolIsExist = clsvFeatureFuncRela_GroupByTtlDA.IsExistTable();
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
 bolIsExist = vFeatureFuncRela_GroupByTtlDA.IsExistTable(strTabName);
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
 /// <param name = "objvFeatureFuncRela_GroupByTtlENS">源对象</param>
 /// <param name = "objvFeatureFuncRela_GroupByTtlENT">目标对象</param>
 public static void CopyTo(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENS, clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlENT)
{
try
{
objvFeatureFuncRela_GroupByTtlENT.FeatureId = objvFeatureFuncRela_GroupByTtlENS.FeatureId; //功能Id
objvFeatureFuncRela_GroupByTtlENT.ApplicationTypeId = objvFeatureFuncRela_GroupByTtlENS.ApplicationTypeId; //应用程序类型ID
objvFeatureFuncRela_GroupByTtlENT.FuncCount = objvFeatureFuncRela_GroupByTtlENS.FuncCount; //函数数目
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
 /// <param name = "objvFeatureFuncRela_GroupByTtlEN">源简化对象</param>
 public static void SetUpdFlag(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN)
{
try
{
objvFeatureFuncRela_GroupByTtlEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFeatureFuncRela_GroupByTtlEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFeatureFuncRela_GroupByTtl.FeatureId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRela_GroupByTtlEN.FeatureId = objvFeatureFuncRela_GroupByTtlEN.FeatureId; //功能Id
}
if (arrFldSet.Contains(convFeatureFuncRela_GroupByTtl.ApplicationTypeId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId = objvFeatureFuncRela_GroupByTtlEN.ApplicationTypeId; //应用程序类型ID
}
if (arrFldSet.Contains(convFeatureFuncRela_GroupByTtl.FuncCount, new clsStrCompareIgnoreCase())  ==  true)
{
objvFeatureFuncRela_GroupByTtlEN.FuncCount = objvFeatureFuncRela_GroupByTtlEN.FuncCount; //函数数目
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
 /// <param name = "objvFeatureFuncRela_GroupByTtlEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN)
{
try
{
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
public static void CheckProperty4Condition(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlEN)
{
 vFeatureFuncRela_GroupByTtlDA.CheckProperty4Condition(objvFeatureFuncRela_GroupByTtlEN);
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
if (clsFeatureFuncRelaBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsFeatureFuncRelaBL没有刷新缓存机制(clsFeatureFuncRelaBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FeatureId");
//if (arrvFeatureFuncRela_GroupByTtlObjLstCache == null)
//{
//arrvFeatureFuncRela_GroupByTtlObjLstCache = vFeatureFuncRela_GroupByTtlDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFeatureId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFeatureFuncRela_GroupByTtlEN GetObjByFeatureIdCache(string strFeatureId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFeatureFuncRela_GroupByTtlEN._CurrTabName);
List<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLst_Sel =
arrvFeatureFuncRela_GroupByTtlObjLstCache
.Where(x=> x.FeatureId == strFeatureId 
);
if (arrvFeatureFuncRela_GroupByTtlObjLst_Sel.Count() == 0)
{
   clsvFeatureFuncRela_GroupByTtlEN obj = clsvFeatureFuncRela_GroupByTtlBL.GetObjByFeatureId(strFeatureId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFeatureFuncRela_GroupByTtlObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetAllvFeatureFuncRela_GroupByTtlObjLstCache()
{
//获取缓存中的对象列表
List<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLstCache = GetObjLstCache(); 
return arrvFeatureFuncRela_GroupByTtlObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFeatureFuncRela_GroupByTtlEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFeatureFuncRela_GroupByTtlEN._CurrTabName);
List<clsvFeatureFuncRela_GroupByTtlEN> arrvFeatureFuncRela_GroupByTtlObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFeatureFuncRela_GroupByTtlObjLstCache;
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
string strKey = string.Format("{0}", clsvFeatureFuncRela_GroupByTtlEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFeatureFuncRela_GroupByTtlEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFeatureFuncRela_GroupByTtlEN._RefreshTimeLst.Count == 0) return "";
return clsvFeatureFuncRela_GroupByTtlEN._RefreshTimeLst[clsvFeatureFuncRela_GroupByTtlEN._RefreshTimeLst.Count - 1];
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
if (strInFldName != convFeatureFuncRela_GroupByTtl.FeatureId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFeatureFuncRela_GroupByTtl._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFeatureFuncRela_GroupByTtl._AttributeName));
throw new Exception(strMsg);
}
var objvFeatureFuncRela_GroupByTtl = clsvFeatureFuncRela_GroupByTtlBL.GetObjByFeatureIdCache(strFeatureId);
if (objvFeatureFuncRela_GroupByTtl == null) return "";
return objvFeatureFuncRela_GroupByTtl[strOutFldName].ToString();
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
int intRecCount = clsvFeatureFuncRela_GroupByTtlDA.GetRecCount(strTabName);
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
int intRecCount = clsvFeatureFuncRela_GroupByTtlDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFeatureFuncRela_GroupByTtlDA.GetRecCount();
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
int intRecCount = clsvFeatureFuncRela_GroupByTtlDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFeatureFuncRela_GroupByTtlCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFeatureFuncRela_GroupByTtlEN objvFeatureFuncRela_GroupByTtlCond)
{
List<clsvFeatureFuncRela_GroupByTtlEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFeatureFuncRela_GroupByTtlEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFeatureFuncRela_GroupByTtl._AttributeName)
{
if (objvFeatureFuncRela_GroupByTtlCond.IsUpdated(strFldName) == false) continue;
if (objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString());
}
else
{
if (objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFeatureFuncRela_GroupByTtlCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFeatureFuncRela_GroupByTtlCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRela_GroupByTtlCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFeatureFuncRela_GroupByTtlCond[strFldName]));
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
 List<string> arrList = clsvFeatureFuncRela_GroupByTtlDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFeatureFuncRela_GroupByTtlDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFeatureFuncRela_GroupByTtlDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}