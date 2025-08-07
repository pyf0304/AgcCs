
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFuncModulePrjViewNumBL
 表名:vFuncModulePrjViewNum(00050288)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:33:29
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工程管理(PrjManage)
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
public static class  clsvFuncModulePrjViewNumBL_Static
{

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModulePrjViewNumEN GetObj(this K_FuncModuleAgcId_vFuncModulePrjViewNum myKey)
{
clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = clsvFuncModulePrjViewNumBL.vFuncModulePrjViewNumDA.GetObjByFuncModuleAgcId(myKey.Value);
return objvFuncModulePrjViewNumEN;
}

 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModulePrjViewNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModulePrjViewNumEN SetFuncModuleAgcId(this clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN, string strFuncModuleAgcId, string strComparisonOp="")
	{
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldLen(strFuncModuleAgcId, 8, convFuncModulePrjViewNum.FuncModuleAgcId);
}
if (strComparisonOp != "in")
{
clsCheckSql.CheckFieldForeignKey(strFuncModuleAgcId, 8, convFuncModulePrjViewNum.FuncModuleAgcId);
}
objvFuncModulePrjViewNumEN.FuncModuleAgcId = strFuncModuleAgcId; //功能模块Id
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModulePrjViewNumEN.dicFldComparisonOp.ContainsKey(convFuncModulePrjViewNum.FuncModuleAgcId) == false)
{
objvFuncModulePrjViewNumEN.dicFldComparisonOp.Add(convFuncModulePrjViewNum.FuncModuleAgcId, strComparisonOp);
}
else
{
objvFuncModulePrjViewNumEN.dicFldComparisonOp[convFuncModulePrjViewNum.FuncModuleAgcId] = strComparisonOp;
}
}
return objvFuncModulePrjViewNumEN;
	}
 /// <summary>
 /// /// 功能:为对象设置字段值
 /// /// 优点:1、可以实现函数节联,多个设置值联在一起写.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_SetFieldValue4OneField)
 /// </summary>
 /// <param name = "objvFuncModulePrjViewNumEN">需要设置字段值的实体对象</param>
 /// <param name = "strComparisonOp">比较运算符,如果有值,可用于组织条件串</param>
 /// <returns>返回对象,可以继续连写</returns>
public static clsvFuncModulePrjViewNumEN SetPrjViewNum(this clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN, int? intPrjViewNum, string strComparisonOp="")
	{
objvFuncModulePrjViewNumEN.PrjViewNum = intPrjViewNum; //PrjViewNum
if (string.IsNullOrEmpty(strComparisonOp) == false)
{
if (objvFuncModulePrjViewNumEN.dicFldComparisonOp.ContainsKey(convFuncModulePrjViewNum.PrjViewNum) == false)
{
objvFuncModulePrjViewNumEN.dicFldComparisonOp.Add(convFuncModulePrjViewNum.PrjViewNum, strComparisonOp);
}
else
{
objvFuncModulePrjViewNumEN.dicFldComparisonOp[convFuncModulePrjViewNum.PrjViewNum] = strComparisonOp;
}
}
return objvFuncModulePrjViewNumEN;
	}

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CopyObj)
 /// </summary>
 /// <param name = "objvFuncModulePrjViewNumENS">源对象</param>
 /// <param name = "objvFuncModulePrjViewNumENT">目标对象</param>
 public static void CopyTo(this clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumENS, clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumENT)
{
try
{
objvFuncModulePrjViewNumENT.FuncModuleAgcId = objvFuncModulePrjViewNumENS.FuncModuleAgcId; //功能模块Id
objvFuncModulePrjViewNumENT.PrjViewNum = objvFuncModulePrjViewNumENS.PrjViewNum; //PrjViewNum
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
 /// <param name = "objvFuncModulePrjViewNumENS">源对象</param>
 /// <returns>目标对象=>clsvFuncModulePrjViewNumEN:objvFuncModulePrjViewNumENT</returns>
 public static clsvFuncModulePrjViewNumEN CopyTo(this clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumENS)
{
try
{
 clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumENT = new clsvFuncModulePrjViewNumEN()
{
FuncModuleAgcId = objvFuncModulePrjViewNumENS.FuncModuleAgcId, //功能模块Id
PrjViewNum = objvFuncModulePrjViewNumENS.PrjViewNum, //PrjViewNum
};
 return objvFuncModulePrjViewNumENT;
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
public static void CheckProperty4Condition(this clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN)
{
 clsvFuncModulePrjViewNumBL.vFuncModulePrjViewNumDA.CheckProperty4Condition(objvFuncModulePrjViewNumEN);
 }

 /// <summary>
 /// 根据条件对象中的字段内容组合成一个条件串
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Static_CombineConditionByCondObj)
 /// </summary>
 /// <returns>条件串(strWhereCond)</returns>
public static string GetCombineCondition(this clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumCond)
{
//使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
//例如 1 = 1 && UserName = '张三'
string strWhereCond = " 1 = 1 ";
//如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
if (objvFuncModulePrjViewNumCond.IsUpdated(convFuncModulePrjViewNum.FuncModuleAgcId) == true)
{
string strComparisonOpFuncModuleAgcId = objvFuncModulePrjViewNumCond.dicFldComparisonOp[convFuncModulePrjViewNum.FuncModuleAgcId];
strWhereCond += string.Format(" And {0} {2} '{1}'", convFuncModulePrjViewNum.FuncModuleAgcId, objvFuncModulePrjViewNumCond.FuncModuleAgcId, strComparisonOpFuncModuleAgcId);
}
if (objvFuncModulePrjViewNumCond.IsUpdated(convFuncModulePrjViewNum.PrjViewNum) == true)
{
string strComparisonOpPrjViewNum = objvFuncModulePrjViewNumCond.dicFldComparisonOp[convFuncModulePrjViewNum.PrjViewNum];
strWhereCond += string.Format(" And {0} {2} {1}", convFuncModulePrjViewNum.PrjViewNum, objvFuncModulePrjViewNumCond.PrjViewNum, strComparisonOpPrjViewNum);
}
 return strWhereCond;
}
}
 /// <summary>
 /// /// 功能:当本表执行添加、修改、删除操作时,对相关表执行相应的操作,此处定义一个类,在外面可以扩展该类的相关函数,达到自定义操作
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_Class_RelatedActions)
 /// </summary>
 public abstract class RelatedActions_vFuncModulePrjViewNum
{
public virtual bool UpdRelaTabDate(string strFuncModuleAgcId, string strOpUser)
{
return true;
}
}
 /// <summary>
 /// v模块-界面数(vFuncModulePrjViewNum)
 /// 数据源类型:视图
 /// (AutoGCLib.BusinessLogic4CSharp:GeneCode)
 /// </summary>
public class clsvFuncModulePrjViewNumBL
{
public static RelatedActions_vFuncModulePrjViewNum relatedActions = null;

 /// <summary>
/// 单例模式:访问数据访问层的单例模式
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_DefineUniqueInstance4DAL)
/// </summary>
private static clsvFuncModulePrjViewNumDA uniqueInstance = null;
/// <summary>
/// 单例模式:访问数据访问层的单例模式,使数据访问层的访问不需要多次初始化。
/// </summary>
public static clsvFuncModulePrjViewNumDA vFuncModulePrjViewNumDA
{
    get
{
if (uniqueInstance == null)
{
uniqueInstance = new clsvFuncModulePrjViewNumDA();
}
return uniqueInstance;
}
}

 /// <summary>
 /// 类的构造函数
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_ClassConstructor1)
 /// </summary>
 public clsvFuncModulePrjViewNumBL()
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
if (string.IsNullOrEmpty(clsvFuncModulePrjViewNumEN._ConnectString) == true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFuncModulePrjViewNumEN._ConnectString);
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
public static DataTable GetDataTable_vFuncModulePrjViewNum(string strWhereCond)
{
DataTable objDT;
try
{
objDT = vFuncModulePrjViewNumDA.GetDataTable_vFuncModulePrjViewNum(strWhereCond);
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
objDT = vFuncModulePrjViewNumDA.GetDataTable(strWhereCond);
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
objDT = vFuncModulePrjViewNumDA.GetDataTable(strWhereCond, lstExclude);
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
objDT = vFuncModulePrjViewNumDA.GetDataTable(strWhereCond, strTabName);
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
objDT = vFuncModulePrjViewNumDA.GetDataTable(strWhereCond, strTabName, lstExclude);
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
objDT = vFuncModulePrjViewNumDA.GetDataTable_Top(objTopPara);
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
objDT = vFuncModulePrjViewNumDA.GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
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
objDT = vFuncModulePrjViewNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
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
objDT = vFuncModulePrjViewNumDA.GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
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
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetObjLstByFuncModuleAgcIdLst(List<string> arrFuncModuleAgcIdLst)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 string strSqlConditionStr = clsArray.GetSqlInStrByArray(arrFuncModuleAgcIdLst, true);
 string strWhereCond = string.Format("FuncModuleAgcId in ({0})", strSqlConditionStr);
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据关键字列表获取相关对象列表, 使用缓存.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByKeyLstCache)
 /// </summary>
 /// <param name = "arrFuncModuleAgcIdLst">所给的关键字列表</param>
 /// <returns>根据关键字列表获取的对象列表</returns>
public static IEnumerable<clsvFuncModulePrjViewNumEN> GetObjLstByFuncModuleAgcIdLstCache(List<string> arrFuncModuleAgcIdLst)
{
string strKey = string.Format("{0}", clsvFuncModulePrjViewNumEN._CurrTabName);
List<clsvFuncModulePrjViewNumEN> arrvFuncModulePrjViewNumObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModulePrjViewNumEN> arrvFuncModulePrjViewNumObjLst_Sel =
arrvFuncModulePrjViewNumObjLstCache
.Where(x => arrFuncModuleAgcIdLst.Contains(x.FuncModuleAgcId));
return arrvFuncModulePrjViewNumObjLst_Sel;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLst)
 /// </summary>
 /// <param name = "strWhereCond">给定条件</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetObjLst(string strWhereCond)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
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
public static List<clsvFuncModulePrjViewNumEN> GetObjLst(string strWhereCond, List<string> lstExclude)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetSubObjLstCache)
 /// </summary>
 /// <param name = "objvFuncModulePrjViewNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static IEnumerable<clsvFuncModulePrjViewNumEN> GetSubObjLstCache(clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumCond)
{
List<clsvFuncModulePrjViewNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModulePrjViewNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModulePrjViewNum._AttributeName)
{
if (objvFuncModulePrjViewNumCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModulePrjViewNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModulePrjViewNumCond[strFldName].ToString());
}
else
{
if (objvFuncModulePrjViewNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModulePrjViewNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModulePrjViewNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModulePrjViewNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModulePrjViewNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModulePrjViewNumCond[strFldName]));
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
public static List<clsvFuncModulePrjViewNumEN> GetObjLstByTabName(string strWhereCond, string strTabName)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
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
public static List<clsvFuncModulePrjViewNumEN> GetObjLstByTabName(string strWhereCond, string strTabName, List<string> lstExclude)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable(strWhereCond, strTabName, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
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
List<clsvFuncModulePrjViewNumEN> arrObjLst = GetObjLst(strWhereCond);
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
List<clsvFuncModulePrjViewNumEN> arrObjLst = GetObjLst(strWhereCond, lstExclude);
 string strJSON = clsJSON.GetJsonFromObjLst(arrObjLst);
 return strJSON;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetTopObjLst)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetTopObjLst(stuTopPara objTopPara)
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
public static List<clsvFuncModulePrjViewNumEN> GetTopObjLst(int intTopSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
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
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
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
public static List<clsvFuncModulePrjViewNumEN> GetTopObjLst(int intTopSize, string strWhereCond, List<string> lstExclude)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTable_Top(intTopSize, strWhereCond, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件分页获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstByPager)
 /// </summary>
 /// <param name = "objPagerPara">分页获取记录的参数对象</param>
 /// <returns>返回分页对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetObjLstByPager(stuPagerPara objPagerPara)
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
public static List<clsvFuncModulePrjViewNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
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
public static List<clsvFuncModulePrjViewNumEN> GetObjLstByPager(int intPageIndex, int intPageSize, string strWhereCond, string strOrderBy, List<string> lstExclude)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
System.Data.DataTable objDT; 
 objDT = GetDataTableByPager(intPageIndex, intPageSize, strWhereCond, strOrderBy, lstExclude);
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据提供的DataTable获取对象列表
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecObjLstFromDataTable)
 /// </summary>
 /// <param name = "objDT">提供的DataTable</param>
 /// <returns>返回对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetObjLstFromDataTable(DataTable objDT)
{
List<clsvFuncModulePrjViewNumEN> arrObjLst = new List<clsvFuncModulePrjViewNumEN>(); 
if (objDT.Rows.Count == 0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = new clsvFuncModulePrjViewNumEN();
try
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objRow[convFuncModulePrjViewNum.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvFuncModulePrjViewNumEN.PrjViewNum = objRow[convFuncModulePrjViewNum.PrjViewNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFuncModulePrjViewNum.PrjViewNum].ToString().Trim()); //PrjViewNum
}
catch (Exception objException)
{
string strMsg = string.Format("转换DataRow成对象出错, 关键字:[{0}]。{1}. (In {2})",
objvFuncModulePrjViewNumEN.FuncModuleAgcId, objException.Message, clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
	arrObjLst.Add(objvFuncModulePrjViewNumEN);
	}
return arrObjLst;
}


 #endregion 获取数据表的多个对象列表


 #region 获取一个实体对象

 /// <summary>
 /// 根据对象的关键字值,获取对象的全部属性
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecProperty4Object)
 /// </summary>
 /// <param name = "objvFuncModulePrjViewNumEN">相关对象</param>
/// <returns>是否成功</returns>
public static bool GetvFuncModulePrjViewNum(ref clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN)
{
bool bolResult = vFuncModulePrjViewNumDA.GetvFuncModulePrjViewNum(ref objvFuncModulePrjViewNumEN);
return bolResult;
}

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKey)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">表关键字</param>
 /// <returns>表对象</returns>
public static clsvFuncModulePrjViewNumEN GetObjByFuncModuleAgcId(string strFuncModuleAgcId)
{
if (strFuncModuleAgcId.IndexOf(' ') >=0)
{
var strMsg = string.Format("(errid:Busi000079)在表中,关键字[strFuncModuleAgcId]中不能有空格!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000020)在表中,关键字[strFuncModuleAgcId]不能为空!({0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = vFuncModulePrjViewNumDA.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
return objvFuncModulePrjViewNumEN;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的对象
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetFirstObject_S)
 /// </summary>
 /// <param name = "strWhereCond">条件串</param>
 /// <returns>返回的第一条记录的对象</returns>
public static clsvFuncModulePrjViewNumEN GetFirstObj_S(string strWhereCond) 
{
 try
 {
 clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = vFuncModulePrjViewNumDA.GetFirstObj(strWhereCond);
 return objvFuncModulePrjViewNumEN;
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
public static clsvFuncModulePrjViewNumEN GetObjByDataRow_S(DataRow objRow) 
{
 try
 {
 clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = vFuncModulePrjViewNumDA.GetObjByDataRow(objRow);
 return objvFuncModulePrjViewNumEN;
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
public static clsvFuncModulePrjViewNumEN GetObjByDataRow_S(DataRowView objRow) 
{
 try
 {
 clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN = vFuncModulePrjViewNumDA.GetObjByDataRow(objRow);
 return objvFuncModulePrjViewNumEN;
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
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <param name = "lstvFuncModulePrjViewNumObjLst">给定的对象列表</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModulePrjViewNumEN GetObjByFuncModuleAgcIdFromList(string strFuncModuleAgcId, List<clsvFuncModulePrjViewNumEN> lstvFuncModulePrjViewNumObjLst)
{
foreach (clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN in lstvFuncModulePrjViewNumObjLst)
{
if (objvFuncModulePrjViewNumEN.FuncModuleAgcId == strFuncModuleAgcId)
{
return objvFuncModulePrjViewNumEN;
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
 string strFuncModuleAgcId;
 try
 {
 strFuncModuleAgcId = new clsvFuncModulePrjViewNumDA().GetFirstID(strWhereCond);
 return strFuncModuleAgcId;
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
 arrList = vFuncModulePrjViewNumDA.GetID(strWhereCond);
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
bool bolIsExist = vFuncModulePrjViewNumDA.IsExistCondRec(strWhereCond);
return bolIsExist;
}

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_IsExist)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public static bool IsExist(string strFuncModuleAgcId)
{
if (string.IsNullOrEmpty(strFuncModuleAgcId) == true)
{
var strMsg = string.Format("(errid:Busi000027)在表中,关键字[strFuncModuleAgcId]不能为空!!(from {0})",
clsStackTrace.GetCurrClassFunction()); 
throw new Exception(strMsg); 
}
//检测记录是否存在
bool bolIsExist = vFuncModulePrjViewNumDA.IsExist(strFuncModuleAgcId);
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
 bolIsExist = clsvFuncModulePrjViewNumDA.IsExistTable();
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
 bolIsExist = vFuncModulePrjViewNumDA.IsExistTable(strTabName);
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
 /// <param name = "objvFuncModulePrjViewNumENS">源对象</param>
 /// <param name = "objvFuncModulePrjViewNumENT">目标对象</param>
 public static void CopyTo(clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumENS, clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumENT)
{
try
{
objvFuncModulePrjViewNumENT.FuncModuleAgcId = objvFuncModulePrjViewNumENS.FuncModuleAgcId; //功能模块Id
objvFuncModulePrjViewNumENT.PrjViewNum = objvFuncModulePrjViewNumENS.PrjViewNum; //PrjViewNum
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
 /// <param name = "objvFuncModulePrjViewNumEN">源简化对象</param>
 public static void SetUpdFlag(clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN)
{
try
{
objvFuncModulePrjViewNumEN.ClearUpdateState();
   string strsfUpdFldSetStr = objvFuncModulePrjViewNumEN.sfUpdFldSetStr;
    string[] sstrFldSet = strsfUpdFldSetStr.Split('|');
   List<string> arrFldSet = new List<string>(sstrFldSet);
if (arrFldSet.Contains(convFuncModulePrjViewNum.FuncModuleAgcId, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModulePrjViewNumEN.FuncModuleAgcId = objvFuncModulePrjViewNumEN.FuncModuleAgcId; //功能模块Id
}
if (arrFldSet.Contains(convFuncModulePrjViewNum.PrjViewNum, new clsStrCompareIgnoreCase())  ==  true)
{
objvFuncModulePrjViewNumEN.PrjViewNum = objvFuncModulePrjViewNumEN.PrjViewNum; //PrjViewNum
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
 /// <param name = "objvFuncModulePrjViewNumEN">源简化对象</param>
 public static void AccessFldValueNull(clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN)
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
public static void CheckProperty4Condition(clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumEN)
{
 vFuncModulePrjViewNumDA.CheckProperty4Condition(objvFuncModulePrjViewNumEN);
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
if (clsPrjTabBL.objCommFun4BL == null)
{
strMsg = string.Format("类clsPrjTabBL没有刷新缓存机制(clsPrjTabBL.objCommFun4BL == null), 请联系程序员!(from {0})", clsStackTrace.GetCurrClassFunction());
throw new Exception(strMsg);
}
//初始化列表缓存
//string strWhereCond = string.Format("1 = 1 order by FuncModuleAgcId");
//if (arrvFuncModulePrjViewNumObjLstCache == null)
//{
//arrvFuncModulePrjViewNumObjLstCache = vFuncModulePrjViewNumDA.GetObjLst(strWhereCond);
//}
}

 /// <summary>
 /// 根据关键字获取相关对象, 从缓存的对象列表中获取.没有就返回null.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjByKeyCache)
 /// </summary>
 /// <param name = "strFuncModuleAgcId">所给的关键字</param>
 /// <returns>根据关键字获取的对象</returns>
public static clsvFuncModulePrjViewNumEN GetObjByFuncModuleAgcIdCache(string strFuncModuleAgcId)
{
//获取缓存中的对象列表
string strKey = string.Format("{0}", clsvFuncModulePrjViewNumEN._CurrTabName);
List<clsvFuncModulePrjViewNumEN> arrvFuncModulePrjViewNumObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModulePrjViewNumEN> arrvFuncModulePrjViewNumObjLst_Sel =
arrvFuncModulePrjViewNumObjLstCache
.Where(x=> x.FuncModuleAgcId == strFuncModuleAgcId 
);
if (arrvFuncModulePrjViewNumObjLst_Sel.Count() == 0)
{
   clsvFuncModulePrjViewNumEN obj = clsvFuncModulePrjViewNumBL.GetObjByFuncModuleAgcId(strFuncModuleAgcId);
   if (obj != null)
 {
CacheHelper.Remove(strKey);
 }
return null;
}
return arrvFuncModulePrjViewNumObjLst_Sel.First();
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetAllRecObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetAllvFuncModulePrjViewNumObjLstCache()
{
//获取缓存中的对象列表
List<clsvFuncModulePrjViewNumEN> arrvFuncModulePrjViewNumObjLstCache = GetObjLstCache(); 
return arrvFuncModulePrjViewNumObjLstCache;
}

 /// <summary>
 /// 从缓存中获取所有对象列表.
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetObjLstCache)
 /// </summary>
 /// <returns>从缓存中获取的所有对象列表</returns>
public static List<clsvFuncModulePrjViewNumEN> GetObjLstCache()
{
//初始化列表缓存
//InitListCache(); 
string strKey = string.Format("{0}", clsvFuncModulePrjViewNumEN._CurrTabName);
List<clsvFuncModulePrjViewNumEN> arrvFuncModulePrjViewNumObjLstCache = CacheHelper.GetCache(strKey, () => { return GetObjLst("1=1"); });
return arrvFuncModulePrjViewNumObjLstCache;
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
string strKey = string.Format("{0}", clsvFuncModulePrjViewNumEN._CurrTabName);
CacheHelper.Remove(strKey);
clsvFuncModulePrjViewNumEN._RefreshTimeLst.Add(clsDateTime.getTodayDateTimeStr(0));
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
if (clsvFuncModulePrjViewNumEN._RefreshTimeLst.Count == 0) return "";
return clsvFuncModulePrjViewNumEN._RefreshTimeLst[clsvFuncModulePrjViewNumEN._RefreshTimeLst.Count - 1];
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
 /// <returns>返回一个输出字段值</returns>
public static string Func(string strInFldName, string strOutFldName, string strFuncModuleAgcId)
{
if (strInFldName != convFuncModulePrjViewNum.FuncModuleAgcId)
{
string strMsg = string.Format("输入字段名:[{0}]不正确!", strInFldName);
throw new Exception(strMsg);
}
if (convFuncModulePrjViewNum._AttributeName.Contains(strOutFldName) == false)
{
string strMsg = string.Format("输出字段名:[{0}]不正确,不在输出字段范围之内!({1})",
strInFldName, string.Join(", ", convFuncModulePrjViewNum._AttributeName));
throw new Exception(strMsg);
}
var objvFuncModulePrjViewNum = clsvFuncModulePrjViewNumBL.GetObjByFuncModuleAgcIdCache(strFuncModuleAgcId);
if (objvFuncModulePrjViewNum == null) return "";
return objvFuncModulePrjViewNum[strOutFldName].ToString();
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
int intRecCount = clsvFuncModulePrjViewNumDA.GetRecCount(strTabName);
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
int intRecCount = clsvFuncModulePrjViewNumDA.GetRecCountByCond(strTabName, strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount()
{
int intRecCount = clsvFuncModulePrjViewNumDA.GetRecCount();
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
int intRecCount = clsvFuncModulePrjViewNumDA.GetRecCountByCond(strWhereCond);
return intRecCount;
}


 /// <summary>
 /// 根据条件对象获取对象列表子集
 /// (AutoGCLib.BusinessLogic4CSharp:Gen_4BL_GetRecCountByCondObjCache)
 /// </summary>
 /// <param name = "objvFuncModulePrjViewNumCond">条件对象</param>
 /// <returns>对象列表子集</returns>
public static int GetRecCountByCondCache(clsvFuncModulePrjViewNumEN objvFuncModulePrjViewNumCond)
{
List<clsvFuncModulePrjViewNumEN> arrObjLstCache = GetObjLstCache();
IEnumerable <clsvFuncModulePrjViewNumEN> arrObjLstSel = arrObjLstCache;
foreach (string strFldName in convFuncModulePrjViewNum._AttributeName)
{
if (objvFuncModulePrjViewNumCond.IsUpdated(strFldName) == false) continue;
if (objvFuncModulePrjViewNumCond.dicFldComparisonOp == null)
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModulePrjViewNumCond[strFldName].ToString());
}
else
{
if (objvFuncModulePrjViewNumCond.dicFldComparisonOp.ContainsKey(strFldName) == false) continue;
string strComparisonOp = objvFuncModulePrjViewNumCond.dicFldComparisonOp[strFldName];
if (strComparisonOp == "=")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString() == objvFuncModulePrjViewNumCond[strFldName].ToString());
}
else if (strComparisonOp == "like")
{
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Contains(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length > int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not greater") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length <= int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length not less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length >= int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length less") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length < int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "length equal") {
arrObjLstSel = arrObjLstSel.Where(x => x[strFldName].ToString().Length == int.Parse(objvFuncModulePrjViewNumCond[strFldName].ToString()));
}
else if (strComparisonOp == "in")
{
var arrKeys = objvFuncModulePrjViewNumCond[strFldName].ToString().Split(",".ToCharArray());
arrObjLstSel = arrObjLstSel.Where(x => arrKeys.Contains(x[strFldName].ToString()));
}
else if (strComparisonOp == ">")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) > clsGeneralTab2.TransNullToDouble_S(objvFuncModulePrjViewNumCond[strFldName]));
}
else if (strComparisonOp == "<")
{
arrObjLstSel = arrObjLstSel.Where(x => clsGeneralTab2.TransNullToDouble_S(x[strFldName]) < clsGeneralTab2.TransNullToDouble_S(objvFuncModulePrjViewNumCond[strFldName]));
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
 List<string> arrList = clsvFuncModulePrjViewNumDA.GetFldValue(strTabName, strFldName, strWhereCond);
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
 List<string> arrList = vFuncModulePrjViewNumDA.GetFldValue(strFldName, strWhereCond);
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
 List<string> arrList = vFuncModulePrjViewNumDA.GetFldValueNoDistinct(strFldName, strWhereCond);
return arrList;
}



 #endregion 表操作常用函数
}
}