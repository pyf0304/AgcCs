
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4CodeDA
 表名:Function4Code(00050386)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:48
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
 框架-层名:数据处理层(CS)(DALCode,0002)
 编程语言:CSharp
 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
        2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
 == == == == == == == == == == == == 
 **/
using System;
using System.Data; 
using System.Data.SqlClient;
using System.Text; 
using System.Collections; 
using System.Collections.Generic; 
using com.taishsoft.common;
using com.taishsoft.datetime;
using com.taishsoft.comm_db_obj;
using com.taishsoft.commdb;
using PrjCommBase;
using AGC.Entity;

namespace AGC.DAL
{
 /// <summary>
 /// 函数4Code(Function4Code)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFunction4CodeDA : clsCommBase4DA
{
 /// <summary>
 /// 错误信息
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected const string EXCEPTION_MSG = "出错:"; //there was an error in the method. please see the Application Log for details.";
 /// <summary>
 /// 模块名称
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
protected string mstrModuleName;
//以下是属性变量

 /// <summary>
 /// 当前表名
 /// </summary>
 public override string _CurrTabName
 {
 get
 {
 return clsFunction4CodeEN._CurrTabName;
 }
 }

 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.DALCode4CSharp:Gen_GetSpecSQLObj)
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
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
if (string.IsNullOrEmpty(clsFunction4CodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunction4CodeEN._ConnectString);
}
return objSQL;
}


 /// <summary>
 /// 获取SQL服务器连接对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetSpecSQLObj_Obj)
 /// </summary>
 /// <returns>SQL服务器连接对象</returns>
 public override clsSpecSQLforSql GetSpecSQLObj_Obj() 
{
 clsSpecSQLforSql objSQL;
 //1. 如果系统参数(SysPara)中设置使用连接串名,就用该连接串名所指定的连接串
 if (clsSysParaEN.bolIsUseConnectStrName  ==  true)
 {
 objSQL = new clsSpecSQLforSql(clsSysParaEN.strConnectStrName, true);
 return objSQL;
 }
 //2. 如果类所指定的连接串非空,就用该类所指定的连接串
 //3. 否则就用项目系统配置(web.config or app.config)中所指定的默认连接串
 if (string.IsNullOrEmpty(clsFunction4CodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunction4CodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncId4Code">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncId4Code)
{
strFuncId4Code = strFuncId4Code.Replace("'", "''");
if (strFuncId4Code.Length > 8)
{
throw new Exception("(errid:Data000001)在表:Function4Code中,检查关键字,长度不正确!(clsFunction4CodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId4Code)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Function4Code中,关键字不能为空 或 null!(clsFunction4CodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunction4CodeDA:CheckPrimaryKey)", objException.Message));
}
return true;
}

 #region 获取数据表的DataTable

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Function4Code(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable_Function4Code)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(给定表名)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByTabName_S_Exclude)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strTabName">表名</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable(string strCondition, string strTabName, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "objTopPara">获取顶部对象列表的参数对象</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(stuTopPara objTopPara)
{
 return GetDataTable_Top(objTopPara.topSize, objTopPara.whereCond, objTopPara.orderBy);
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Function4Code where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Function4Code where {1} order by {2}", intTopSize, strCondition, strOrderBy);
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取顶部记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_GetDataTable_Top_S_Exclude)
 /// </summary>
 /// <param name = "intTopSize">顶部记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTable_Top(int intTopSize, string strCondition, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Function4Code where {1}", intTopSize, strCondition);
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} Function4Code.* " + 
$"from Function4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Function4Code.FuncId4Code not in " + 
$"(Select top {intTop_In} Function4Code.FuncId4Code from Function4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Function4Code where {1} and FuncId4Code not in (Select top {2} FuncId4Code from Function4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Function4Code where {1} and FuncId4Code not in (Select top {3} FuncId4Code from Function4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 /// <summary>
 /// 根据条件获取分页记录的数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查(带排除)
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTableByPager_S_Exclude)
 /// </summary>
 /// <param name = "intPageIndex">页序号</param>
 /// <param name = "intPageSize">页记录数</param>
 /// <param name = "strCondition">条件串</param>
 /// <param name = "strOrderBy">排序方式</param>
 /// <param name = "lstExclude">排除的检查字符串列表</param>
 /// <returns></returns>
public System.Data.DataTable GetDataTableByPager(int intPageIndex, int intPageSize, string strCondition, string strOrderBy, List<string> lstExclude)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition, lstExclude);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunction4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
 int intTop_In = intPageSize * (intPageIndex - 1);//获取连接对象
int intPos_Dot = strOrderBy.IndexOf('|');
if (intPos_Dot > 0)
{
var sortInfo = clsSortLinkStrParse.ParseSortString(strOrderBy);
if (sortInfo.SortDirection == "" || sortInfo.SortField == "")
{
throw new Exception(string.Format("在带有特殊排序分页查询中,strOrderBy:[{0}]格式不正确,请检查!(in {1})",
strOrderBy, clsStackTrace.GetCurrClassFunction()));
}
string strLeftLinkStr = clsSortLinkStrParse.BuildLeftJoinClause(sortInfo.JoinTables, sortInfo.JoinConditions);
strSQL = $"Select Top {intPageSize} Function4Code.* " + 
$"from Function4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Function4Code.FuncId4Code not in " + 
$"(Select top {intTop_In} Function4Code.FuncId4Code from Function4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Function4Code where {1} and FuncId4Code not in (Select top {2} FuncId4Code from Function4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Function4Code where {1} and FuncId4Code not in (Select top {3} FuncId4Code from Function4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
 }
 }
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}

 #endregion 获取数据表的DataTable

 #region 获取数据表的多个对象列表

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLst)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回对象列表</returns>
public List<clsFunction4CodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunction4CodeDA:GetObjLst)", objException.Message));
}
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = TransNullToInt(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = TransNullToInt(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = TransNullToBool(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunction4CodeDA: GetObjLst)", objException.Message));
}
objFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}

 /// <summary>
 /// 根据条件获取对象列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetObjLstByTabName)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <param name = "strTabName">表名</param>
 /// <returns>返回对象列表</returns>
public List<clsFunction4CodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunction4CodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunction4CodeEN> arrObjLst = new List<clsFunction4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = TransNullToInt(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = TransNullToInt(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = TransNullToBool(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunction4CodeDA: GetObjLst)", objException.Message));
}
objFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunction4CodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunction4Code(ref clsFunction4CodeEN objFunction4CodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where FuncId4Code = " + "'"+ objFunction4CodeEN.FuncId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunction4CodeEN.FuncId4Code = objDT.Rows[0][conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objFunction4CodeEN.FuncName4Code = objDT.Rows[0][conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4CodeEN.FuncCHName4Code = objDT.Rows[0][conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objFunction4CodeEN.PrevFuncId = objDT.Rows[0][conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id(字段类型:char,字段长度:8,是否可空:True)
 objFunction4CodeEN.RootFuncId = objDT.Rows[0][conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id(字段类型:char,字段长度:8,是否可空:True)
 objFunction4CodeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objFunction4CodeEN.FuncGCTypeId = objDT.Rows[0][conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.FunctionSignature = objDT.Rows[0][conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4CodeEN.FunctionSignatureSim = objDT.Rows[0][conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4CodeEN.ReturnType = objDT.Rows[0][conFunction4Code.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4CodeEN.ClsName = objDT.Rows[0][conFunction4Code.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4CodeEN.ReturnTypeFullName = objDT.Rows[0][conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4CodeEN.ReturnTypeId = objDT.Rows[0][conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objFunction4CodeEN.ReturnTypeNameCustom = objDT.Rows[0][conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4CodeEN.CodeTypeId = objDT.Rows[0][conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4CodeEN.FuncAccessModeId = objDT.Rows[0][conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.TabName = objDT.Rows[0][conFunction4Code.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4CodeEN.TabId = objDT.Rows[0][conFunction4Code.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objFunction4CodeEN.FuncPurposeId = objDT.Rows[0][conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.FuncTypeId = objDT.Rows[0][conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.GetCustomAttributes = TransNullToInt(objDT.Rows[0][conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objFunction4CodeEN.SourceFunction = objDT.Rows[0][conFunction4Code.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4CodeEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objFunction4CodeEN.IsSysFunction = TransNullToBool(objDT.Rows[0][conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objFunction4CodeEN.OrderNum = TransNullToInt(objDT.Rows[0][conFunction4Code.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objFunction4CodeEN.PrjId = objDT.Rows[0][conFunction4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4CodeEN.IsTemplate = TransNullToBool(objDT.Rows[0][conFunction4Code.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objFunction4CodeEN.UpdDate = objDT.Rows[0][conFunction4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4CodeEN.UpdUser = objDT.Rows[0][conFunction4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4CodeEN.Memo = objDT.Rows[0][conFunction4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objFunction4CodeEN.UsedTimes = TransNullToInt(objDT.Rows[0][conFunction4Code.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunction4CodeDA: GetFunction4Code)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public clsFunction4CodeEN GetObjByFuncId4Code(string strFuncId4Code)
{
CheckPrimaryKey(strFuncId4Code);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where FuncId4Code = " + "'"+ strFuncId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
 objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id(字段类型:char,字段长度:8,是否可空:True)
 objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id(字段类型:char,字段长度:8,是否可空:True)
 objFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4CodeEN.GetCustomAttributes = Int32.Parse(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objFunction4CodeEN.OrderNum = Int32.Parse(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4CodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunction4CodeDA: GetObjByFuncId4Code)", objException.Message));
}
return objFunction4CodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunction4CodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunction4CodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN()
{
FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(), //函数名4Code
FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(), //函数中文名4Code
PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(), //前函数Id
RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(), //根函数Id
ApplicationTypeId = TransNullToInt(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(), //函数生成代码类型Id
FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(), //函数签名
FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(), //函数签名_Sim
ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(), //返回类型
ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(), //类名
ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(), //返回类型全名
ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(), //返回类型ID
ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(), //定制返回类型名
CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(), //代码类型Id
FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(), //函数操作模式Id
TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(), //表名
TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(), //表ID
FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(), //函数用途Id
FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(), //函数类型Id
GetCustomAttributes = TransNullToInt(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()), //GetCustomAttributes
SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(), //来源函数
IsAsyncFunc = TransNullToBool(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()), //是否异步函数
IsSysFunction = TransNullToBool(objRow[conFunction4Code.IsSysFunction].ToString().Trim()), //是否系统函数
OrderNum = TransNullToInt(objRow[conFunction4Code.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(), //工程Id
IsTemplate = TransNullToBool(objRow[conFunction4Code.IsTemplate].ToString().Trim()), //是否模板
UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(), //说明
UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4Code.UsedTimes].ToString().Trim()) //使用次数
};
objFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunction4CodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunction4CodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunction4CodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = TransNullToInt(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = TransNullToInt(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = TransNullToBool(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunction4CodeDA: GetObjByDataRowFunction4Code)", objException.Message));
}
objFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunction4CodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunction4CodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunction4CodeEN objFunction4CodeEN = new clsFunction4CodeEN();
try
{
objFunction4CodeEN.FuncId4Code = objRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4CodeEN.FuncName4Code = objRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objFunction4CodeEN.FuncCHName4Code = objRow[conFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objFunction4CodeEN.PrevFuncId = objRow[conFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objFunction4CodeEN.RootFuncId = objRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[conFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objFunction4CodeEN.FuncGCTypeId = objRow[conFunction4Code.FuncGCTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4CodeEN.FunctionSignature = objRow[conFunction4Code.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objFunction4CodeEN.FunctionSignatureSim = objRow[conFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objFunction4CodeEN.ReturnType = objRow[conFunction4Code.ReturnType] == DBNull.Value ? null : objRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objFunction4CodeEN.ClsName = objRow[conFunction4Code.ClsName] == DBNull.Value ? null : objRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objFunction4CodeEN.ReturnTypeFullName = objRow[conFunction4Code.ReturnTypeFullName] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objFunction4CodeEN.ReturnTypeId = objRow[conFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4CodeEN.ReturnTypeNameCustom = objRow[conFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objFunction4CodeEN.CodeTypeId = objRow[conFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objFunction4CodeEN.FuncAccessModeId = objRow[conFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objFunction4CodeEN.TabName = objRow[conFunction4Code.TabName] == DBNull.Value ? null : objRow[conFunction4Code.TabName].ToString().Trim(); //表名
objFunction4CodeEN.TabId = objRow[conFunction4Code.TabId] == DBNull.Value ? null : objRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objFunction4CodeEN.FuncPurposeId = objRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objFunction4CodeEN.FuncTypeId = objRow[conFunction4Code.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4CodeEN.GetCustomAttributes = TransNullToInt(objRow[conFunction4Code.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objFunction4CodeEN.SourceFunction = objRow[conFunction4Code.SourceFunction] == DBNull.Value ? null : objRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[conFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[conFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objFunction4CodeEN.OrderNum = TransNullToInt(objRow[conFunction4Code.OrderNum].ToString().Trim()); //序号
objFunction4CodeEN.PrjId = objRow[conFunction4Code.PrjId] == DBNull.Value ? null : objRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objFunction4CodeEN.IsTemplate = TransNullToBool(objRow[conFunction4Code.IsTemplate].ToString().Trim()); //是否模板
objFunction4CodeEN.UpdDate = objRow[conFunction4Code.UpdDate] == DBNull.Value ? null : objRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objFunction4CodeEN.UpdUser = objRow[conFunction4Code.UpdUser] == DBNull.Value ? null : objRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objFunction4CodeEN.Memo = objRow[conFunction4Code.Memo] == DBNull.Value ? null : objRow[conFunction4Code.Memo].ToString().Trim(); //说明
objFunction4CodeEN.UsedTimes = objRow[conFunction4Code.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4Code.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunction4CodeDA: GetObjByDataRow)", objException.Message));
}
objFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunction4CodeEN;
}

 #endregion 获取一个实体对象

 #region 获取一个关键字值

 /// <summary>
 /// 获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrID)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public static string GetMaxStrId()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunction4CodeEN._CurrTabName, conFunction4Code.FuncId4Code, 8, "");
return strMaxValue;
}

 /// <summary>
 /// 根据前缀获取当前表最大字符型关键字ID
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetMaxStrIdByPrefix)
 /// </summary>
 /// <returns>返回的最大关键字值ID</returns>
public string GetMaxStrIdByPrefix(string strPrefix)
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunction4CodeEN._CurrTabName, conFunction4Code.FuncId4Code, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId4Code from Function4Code where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
}

 #endregion 获取一个关键字值

 #region 获取多个关键字值列表

 /// <summary>
 /// 获取当前表满足条件的所有记录的关键字值列表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetPrimaryKeyID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的关键字值列表</returns>
public List<string> GetID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
List<string> arrList = new List<string>();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId4Code from Function4Code where " + strCondition;
try
{
objDT = objSQL.GetDataTable(strSQL);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}

if (objDT.Rows.Count  ==  0)
{
return null;
}
for (iRow = 0; iRow<=  objDT.Rows.Count - 1;iRow++)
{
strKeyValue = "";
for (iCol = 0; iCol<=  objDT.Columns.Count - 1;iCol++)
{
if (iCol  ==  0)
{
strKeyValue +=  objDT.Rows[iRow][iCol].ToString();
}
else
{
strKeyValue +=  "//" + objDT.Rows[iRow][iCol].ToString();
}
}
arrList.Add(strKeyValue);
}
return arrList;
}

 #endregion 获取多个关键字值列表

 #region 判断记录是否存在

 /// <summary>
 /// 判断当前表中是否存在给定关键字值的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExist_S)
 /// </summary>
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncId4Code)
{
CheckPrimaryKey(strFuncId4Code);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Function4Code", "FuncId4Code = " + "'"+ strFuncId4Code+"'"))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 功能:判断是否存在某一条件的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistCondRec_S)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>如果存在就返回TRUE,否则返回FALSE</returns>
public bool IsExistCondRec(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunction4CodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Function4Code", strCondition))
{
return true;
}
else
{
return false;
}
}

 /// <summary>
 /// 检查是否存在当前表
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenIsExistTable)
 /// </summary>
 /// <returns>存在就返回True,否则返回False</returns>
public static bool IsExistTable()
{
clsSpecSQLforSql objSQL;
//获取连接对象
objSQL = clsFunction4CodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Function4Code");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunction4CodeEN objFunction4CodeEN)
 {
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4CodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Function4Code");
objRow = objDS.Tables["Function4Code"].NewRow();
objRow[conFunction4Code.FuncId4Code] = objFunction4CodeEN.FuncId4Code; //函数Id4Code
objRow[conFunction4Code.FuncName4Code] = objFunction4CodeEN.FuncName4Code; //函数名4Code
 if (objFunction4CodeEN.FuncCHName4Code !=  "")
 {
objRow[conFunction4Code.FuncCHName4Code] = objFunction4CodeEN.FuncCHName4Code; //函数中文名4Code
 }
 if (objFunction4CodeEN.PrevFuncId !=  "")
 {
objRow[conFunction4Code.PrevFuncId] = objFunction4CodeEN.PrevFuncId; //前函数Id
 }
objRow[conFunction4Code.RootFuncId] = objFunction4CodeEN.RootFuncId; //根函数Id
objRow[conFunction4Code.ApplicationTypeId] = objFunction4CodeEN.ApplicationTypeId; //应用程序类型ID
 if (objFunction4CodeEN.FuncGCTypeId !=  "")
 {
objRow[conFunction4Code.FuncGCTypeId] = objFunction4CodeEN.FuncGCTypeId; //函数生成代码类型Id
 }
 if (objFunction4CodeEN.FunctionSignature !=  "")
 {
objRow[conFunction4Code.FunctionSignature] = objFunction4CodeEN.FunctionSignature; //函数签名
 }
 if (objFunction4CodeEN.FunctionSignatureSim !=  "")
 {
objRow[conFunction4Code.FunctionSignatureSim] = objFunction4CodeEN.FunctionSignatureSim; //函数签名_Sim
 }
 if (objFunction4CodeEN.ReturnType !=  "")
 {
objRow[conFunction4Code.ReturnType] = objFunction4CodeEN.ReturnType; //返回类型
 }
 if (objFunction4CodeEN.ClsName !=  "")
 {
objRow[conFunction4Code.ClsName] = objFunction4CodeEN.ClsName; //类名
 }
 if (objFunction4CodeEN.ReturnTypeFullName !=  "")
 {
objRow[conFunction4Code.ReturnTypeFullName] = objFunction4CodeEN.ReturnTypeFullName; //返回类型全名
 }
 if (objFunction4CodeEN.ReturnTypeId !=  "")
 {
objRow[conFunction4Code.ReturnTypeId] = objFunction4CodeEN.ReturnTypeId; //返回类型ID
 }
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  "")
 {
objRow[conFunction4Code.ReturnTypeNameCustom] = objFunction4CodeEN.ReturnTypeNameCustom; //定制返回类型名
 }
 if (objFunction4CodeEN.CodeTypeId !=  "")
 {
objRow[conFunction4Code.CodeTypeId] = objFunction4CodeEN.CodeTypeId; //代码类型Id
 }
 if (objFunction4CodeEN.FuncAccessModeId !=  "")
 {
objRow[conFunction4Code.FuncAccessModeId] = objFunction4CodeEN.FuncAccessModeId; //函数操作模式Id
 }
 if (objFunction4CodeEN.TabName !=  "")
 {
objRow[conFunction4Code.TabName] = objFunction4CodeEN.TabName; //表名
 }
 if (objFunction4CodeEN.TabId !=  "")
 {
objRow[conFunction4Code.TabId] = objFunction4CodeEN.TabId; //表ID
 }
objRow[conFunction4Code.FuncPurposeId] = objFunction4CodeEN.FuncPurposeId; //函数用途Id
 if (objFunction4CodeEN.FuncTypeId !=  "")
 {
objRow[conFunction4Code.FuncTypeId] = objFunction4CodeEN.FuncTypeId; //函数类型Id
 }
objRow[conFunction4Code.GetCustomAttributes] = objFunction4CodeEN.GetCustomAttributes; //GetCustomAttributes
 if (objFunction4CodeEN.SourceFunction !=  "")
 {
objRow[conFunction4Code.SourceFunction] = objFunction4CodeEN.SourceFunction; //来源函数
 }
objRow[conFunction4Code.IsAsyncFunc] = objFunction4CodeEN.IsAsyncFunc; //是否异步函数
objRow[conFunction4Code.IsSysFunction] = objFunction4CodeEN.IsSysFunction; //是否系统函数
objRow[conFunction4Code.OrderNum] = objFunction4CodeEN.OrderNum; //序号
 if (objFunction4CodeEN.PrjId !=  "")
 {
objRow[conFunction4Code.PrjId] = objFunction4CodeEN.PrjId; //工程Id
 }
objRow[conFunction4Code.IsTemplate] = objFunction4CodeEN.IsTemplate; //是否模板
 if (objFunction4CodeEN.UpdDate !=  "")
 {
objRow[conFunction4Code.UpdDate] = objFunction4CodeEN.UpdDate; //修改日期
 }
 if (objFunction4CodeEN.UpdUser !=  "")
 {
objRow[conFunction4Code.UpdUser] = objFunction4CodeEN.UpdUser; //修改者
 }
 if (objFunction4CodeEN.Memo !=  "")
 {
objRow[conFunction4Code.Memo] = objFunction4CodeEN.Memo; //说明
 }
objRow[conFunction4Code.UsedTimes] = objFunction4CodeEN.UsedTimes; //使用次数
objDS.Tables[clsFunction4CodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunction4CodeEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunction4CodeEN objFunction4CodeEN)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4CodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4CodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncId4Code);
 var strFuncId4Code = objFunction4CodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncName4Code);
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncCHName4Code);
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4Code + "'");
 }
 
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrevFuncId);
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrevFuncId + "'");
 }
 
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.RootFuncId);
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.ApplicationTypeId);
 arrValueListForInsert.Add(objFunction4CodeEN.ApplicationTypeId.ToString());
 
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignature);
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignatureSim);
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignatureSim + "'");
 }
 
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnType);
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objFunction4CodeEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ClsName);
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeFullName);
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeId);
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeNameCustom);
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeNameCustom + "'");
 }
 
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.CodeTypeId);
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncAccessModeId);
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncAccessModeId + "'");
 }
 
 if (objFunction4CodeEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabName);
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objFunction4CodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabId);
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncPurposeId);
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncTypeId);
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.GetCustomAttributes);
 arrValueListForInsert.Add(objFunction4CodeEN.GetCustomAttributes.ToString());
 
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.SourceFunction);
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.IsSysFunction);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.OrderNum);
 arrValueListForInsert.Add(objFunction4CodeEN.OrderNum.ToString());
 
 if (objFunction4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrjId);
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdDate);
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdUser);
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.Memo);
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UsedTimes);
 arrValueListForInsert.Add(objFunction4CodeEN.UsedTimes.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4Code");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunction4CodeEN objFunction4CodeEN)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4CodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4CodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncId4Code);
 var strFuncId4Code = objFunction4CodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncName4Code);
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncCHName4Code);
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4Code + "'");
 }
 
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrevFuncId);
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrevFuncId + "'");
 }
 
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.RootFuncId);
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.ApplicationTypeId);
 arrValueListForInsert.Add(objFunction4CodeEN.ApplicationTypeId.ToString());
 
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignature);
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignatureSim);
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignatureSim + "'");
 }
 
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnType);
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objFunction4CodeEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ClsName);
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeFullName);
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeId);
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeNameCustom);
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeNameCustom + "'");
 }
 
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.CodeTypeId);
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncAccessModeId);
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncAccessModeId + "'");
 }
 
 if (objFunction4CodeEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabName);
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objFunction4CodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabId);
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncPurposeId);
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncTypeId);
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.GetCustomAttributes);
 arrValueListForInsert.Add(objFunction4CodeEN.GetCustomAttributes.ToString());
 
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.SourceFunction);
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.IsSysFunction);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.OrderNum);
 arrValueListForInsert.Add(objFunction4CodeEN.OrderNum.ToString());
 
 if (objFunction4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrjId);
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdDate);
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdUser);
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.Memo);
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UsedTimes);
 arrValueListForInsert.Add(objFunction4CodeEN.UsedTimes.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4Code");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunction4CodeEN.FuncId4Code;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunction4CodeEN objFunction4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4CodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4CodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncId4Code);
 var strFuncId4Code = objFunction4CodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncName4Code);
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncCHName4Code);
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4Code + "'");
 }
 
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrevFuncId);
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrevFuncId + "'");
 }
 
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.RootFuncId);
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.ApplicationTypeId);
 arrValueListForInsert.Add(objFunction4CodeEN.ApplicationTypeId.ToString());
 
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignature);
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignatureSim);
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignatureSim + "'");
 }
 
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnType);
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objFunction4CodeEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ClsName);
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeFullName);
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeId);
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeNameCustom);
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeNameCustom + "'");
 }
 
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.CodeTypeId);
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncAccessModeId);
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncAccessModeId + "'");
 }
 
 if (objFunction4CodeEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabName);
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objFunction4CodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabId);
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncPurposeId);
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncTypeId);
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.GetCustomAttributes);
 arrValueListForInsert.Add(objFunction4CodeEN.GetCustomAttributes.ToString());
 
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.SourceFunction);
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.IsSysFunction);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.OrderNum);
 arrValueListForInsert.Add(objFunction4CodeEN.OrderNum.ToString());
 
 if (objFunction4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrjId);
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdDate);
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdUser);
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.Memo);
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UsedTimes);
 arrValueListForInsert.Add(objFunction4CodeEN.UsedTimes.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4Code");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunction4CodeEN.FuncId4Code;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunction4CodeEN objFunction4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4CodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4CodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncId4Code);
 var strFuncId4Code = objFunction4CodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncName4Code);
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4Code + "'");
 }
 
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncCHName4Code);
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4Code + "'");
 }
 
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrevFuncId);
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrevFuncId + "'");
 }
 
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.RootFuncId);
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootFuncId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.ApplicationTypeId);
 arrValueListForInsert.Add(objFunction4CodeEN.ApplicationTypeId.ToString());
 
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignature);
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FunctionSignatureSim);
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignatureSim + "'");
 }
 
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnType);
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objFunction4CodeEN.ClsName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ClsName);
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strClsName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeFullName);
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeId);
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.ReturnTypeNameCustom);
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeNameCustom + "'");
 }
 
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.CodeTypeId);
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeTypeId + "'");
 }
 
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncAccessModeId);
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncAccessModeId + "'");
 }
 
 if (objFunction4CodeEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabName);
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objFunction4CodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.TabId);
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncPurposeId);
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncPurposeId + "'");
 }
 
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.FuncTypeId);
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.GetCustomAttributes);
 arrValueListForInsert.Add(objFunction4CodeEN.GetCustomAttributes.ToString());
 
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.SourceFunction);
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.IsSysFunction);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conFunction4Code.OrderNum);
 arrValueListForInsert.Add(objFunction4CodeEN.OrderNum.ToString());
 
 if (objFunction4CodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.PrjId);
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4Code.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4CodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdDate);
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UpdUser);
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4CodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.Memo);
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4Code.UsedTimes);
 arrValueListForInsert.Add(objFunction4CodeEN.UsedTimes.ToString());
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4Code");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunction4Codes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where FuncId4Code = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Function4Code");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncId4Code = oRow[conFunction4Code.FuncId4Code].ToString().Trim();
if (IsExist(strFuncId4Code))
{
 string strResult = "关键字变量值为:" + string.Format("FuncId4Code = {0}", strFuncId4Code) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunction4CodeEN._CurrTabName ].NewRow();
objRow[conFunction4Code.FuncId4Code] = oRow[conFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objRow[conFunction4Code.FuncName4Code] = oRow[conFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objRow[conFunction4Code.FuncCHName4Code] = oRow[conFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objRow[conFunction4Code.PrevFuncId] = oRow[conFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objRow[conFunction4Code.RootFuncId] = oRow[conFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objRow[conFunction4Code.ApplicationTypeId] = oRow[conFunction4Code.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conFunction4Code.FuncGCTypeId] = oRow[conFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objRow[conFunction4Code.FunctionSignature] = oRow[conFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objRow[conFunction4Code.FunctionSignatureSim] = oRow[conFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objRow[conFunction4Code.ReturnType] = oRow[conFunction4Code.ReturnType].ToString().Trim(); //返回类型
objRow[conFunction4Code.ClsName] = oRow[conFunction4Code.ClsName].ToString().Trim(); //类名
objRow[conFunction4Code.ReturnTypeFullName] = oRow[conFunction4Code.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objRow[conFunction4Code.ReturnTypeId] = oRow[conFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objRow[conFunction4Code.ReturnTypeNameCustom] = oRow[conFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objRow[conFunction4Code.CodeTypeId] = oRow[conFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objRow[conFunction4Code.FuncAccessModeId] = oRow[conFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objRow[conFunction4Code.TabName] = oRow[conFunction4Code.TabName].ToString().Trim(); //表名
objRow[conFunction4Code.TabId] = oRow[conFunction4Code.TabId].ToString().Trim(); //表ID
objRow[conFunction4Code.FuncPurposeId] = oRow[conFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objRow[conFunction4Code.FuncTypeId] = oRow[conFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objRow[conFunction4Code.GetCustomAttributes] = oRow[conFunction4Code.GetCustomAttributes].ToString().Trim(); //GetCustomAttributes
objRow[conFunction4Code.SourceFunction] = oRow[conFunction4Code.SourceFunction].ToString().Trim(); //来源函数
objRow[conFunction4Code.IsAsyncFunc] = oRow[conFunction4Code.IsAsyncFunc].ToString().Trim(); //是否异步函数
objRow[conFunction4Code.IsSysFunction] = oRow[conFunction4Code.IsSysFunction].ToString().Trim(); //是否系统函数
objRow[conFunction4Code.OrderNum] = oRow[conFunction4Code.OrderNum].ToString().Trim(); //序号
objRow[conFunction4Code.PrjId] = oRow[conFunction4Code.PrjId].ToString().Trim(); //工程Id
objRow[conFunction4Code.IsTemplate] = oRow[conFunction4Code.IsTemplate].ToString().Trim(); //是否模板
objRow[conFunction4Code.UpdDate] = oRow[conFunction4Code.UpdDate].ToString().Trim(); //修改日期
objRow[conFunction4Code.UpdUser] = oRow[conFunction4Code.UpdUser].ToString().Trim(); //修改者
objRow[conFunction4Code.Memo] = oRow[conFunction4Code.Memo].ToString().Trim(); //说明
objRow[conFunction4Code.UsedTimes] = oRow[conFunction4Code.UsedTimes].ToString().Trim(); //使用次数
 objDS.Tables[clsFunction4CodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunction4CodeEN._CurrTabName);
}
catch(Exception objException) 
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
objSQL.SQLConnect.Close();
}
return true;
}

 #endregion 添加记录

 #region 修改记录

 /// <summary>
 /// 功能:通过ADO修改记录
 /// (AutoGCLib.DALCode4CSharp:GenUpdate)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunction4CodeEN objFunction4CodeEN)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4CodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4Code where FuncId4Code = " + "'"+ objFunction4CodeEN.FuncId4Code+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunction4CodeEN._CurrTabName);
if (objDS.Tables[clsFunction4CodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncId4Code = " + "'"+ objFunction4CodeEN.FuncId4Code+"'");
return false;
}
objRow = objDS.Tables[clsFunction4CodeEN._CurrTabName].Rows[0];
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncId4Code))
 {
objRow[conFunction4Code.FuncId4Code] = objFunction4CodeEN.FuncId4Code; //函数Id4Code
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncName4Code))
 {
objRow[conFunction4Code.FuncName4Code] = objFunction4CodeEN.FuncName4Code; //函数名4Code
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncCHName4Code))
 {
objRow[conFunction4Code.FuncCHName4Code] = objFunction4CodeEN.FuncCHName4Code; //函数中文名4Code
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrevFuncId))
 {
objRow[conFunction4Code.PrevFuncId] = objFunction4CodeEN.PrevFuncId; //前函数Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.RootFuncId))
 {
objRow[conFunction4Code.RootFuncId] = objFunction4CodeEN.RootFuncId; //根函数Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ApplicationTypeId))
 {
objRow[conFunction4Code.ApplicationTypeId] = objFunction4CodeEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncGCTypeId))
 {
objRow[conFunction4Code.FuncGCTypeId] = objFunction4CodeEN.FuncGCTypeId; //函数生成代码类型Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignature))
 {
objRow[conFunction4Code.FunctionSignature] = objFunction4CodeEN.FunctionSignature; //函数签名
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignatureSim))
 {
objRow[conFunction4Code.FunctionSignatureSim] = objFunction4CodeEN.FunctionSignatureSim; //函数签名_Sim
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnType))
 {
objRow[conFunction4Code.ReturnType] = objFunction4CodeEN.ReturnType; //返回类型
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ClsName))
 {
objRow[conFunction4Code.ClsName] = objFunction4CodeEN.ClsName; //类名
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeFullName))
 {
objRow[conFunction4Code.ReturnTypeFullName] = objFunction4CodeEN.ReturnTypeFullName; //返回类型全名
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeId))
 {
objRow[conFunction4Code.ReturnTypeId] = objFunction4CodeEN.ReturnTypeId; //返回类型ID
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeNameCustom))
 {
objRow[conFunction4Code.ReturnTypeNameCustom] = objFunction4CodeEN.ReturnTypeNameCustom; //定制返回类型名
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.CodeTypeId))
 {
objRow[conFunction4Code.CodeTypeId] = objFunction4CodeEN.CodeTypeId; //代码类型Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncAccessModeId))
 {
objRow[conFunction4Code.FuncAccessModeId] = objFunction4CodeEN.FuncAccessModeId; //函数操作模式Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabName))
 {
objRow[conFunction4Code.TabName] = objFunction4CodeEN.TabName; //表名
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabId))
 {
objRow[conFunction4Code.TabId] = objFunction4CodeEN.TabId; //表ID
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncPurposeId))
 {
objRow[conFunction4Code.FuncPurposeId] = objFunction4CodeEN.FuncPurposeId; //函数用途Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncTypeId))
 {
objRow[conFunction4Code.FuncTypeId] = objFunction4CodeEN.FuncTypeId; //函数类型Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.GetCustomAttributes))
 {
objRow[conFunction4Code.GetCustomAttributes] = objFunction4CodeEN.GetCustomAttributes; //GetCustomAttributes
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.SourceFunction))
 {
objRow[conFunction4Code.SourceFunction] = objFunction4CodeEN.SourceFunction; //来源函数
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsAsyncFunc))
 {
objRow[conFunction4Code.IsAsyncFunc] = objFunction4CodeEN.IsAsyncFunc; //是否异步函数
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsSysFunction))
 {
objRow[conFunction4Code.IsSysFunction] = objFunction4CodeEN.IsSysFunction; //是否系统函数
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.OrderNum))
 {
objRow[conFunction4Code.OrderNum] = objFunction4CodeEN.OrderNum; //序号
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrjId))
 {
objRow[conFunction4Code.PrjId] = objFunction4CodeEN.PrjId; //工程Id
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsTemplate))
 {
objRow[conFunction4Code.IsTemplate] = objFunction4CodeEN.IsTemplate; //是否模板
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdDate))
 {
objRow[conFunction4Code.UpdDate] = objFunction4CodeEN.UpdDate; //修改日期
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdUser))
 {
objRow[conFunction4Code.UpdUser] = objFunction4CodeEN.UpdUser; //修改者
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.Memo))
 {
objRow[conFunction4Code.Memo] = objFunction4CodeEN.Memo; //说明
 }
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UsedTimes))
 {
objRow[conFunction4Code.UsedTimes] = objFunction4CodeEN.UsedTimes; //使用次数
 }
try
{
objDA.Update(objDS, clsFunction4CodeEN._CurrTabName);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
return true;
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySql2)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunction4CodeEN objFunction4CodeEN)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Function4Code Set ");
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncName4Code))
 {
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName4Code, conFunction4Code.FuncName4Code); //函数名4Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncName4Code); //函数名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncCHName4Code))
 {
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCHName4Code, conFunction4Code.FuncCHName4Code); //函数中文名4Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncCHName4Code); //函数中文名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrevFuncId))
 {
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrevFuncId, conFunction4Code.PrevFuncId); //前函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.PrevFuncId); //前函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.RootFuncId))
 {
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootFuncId, conFunction4Code.RootFuncId); //根函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.RootFuncId); //根函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.ApplicationTypeId, conFunction4Code.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncGCTypeId))
 {
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncGCTypeId, conFunction4Code.FuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncGCTypeId); //函数生成代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignature))
 {
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conFunction4Code.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FunctionSignature); //函数签名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignatureSim))
 {
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignatureSim, conFunction4Code.FunctionSignatureSim); //函数签名_Sim
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FunctionSignatureSim); //函数签名_Sim
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnType))
 {
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnType, conFunction4Code.ReturnType); //返回类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnType); //返回类型
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ClsName))
 {
 if (objFunction4CodeEN.ClsName !=  null)
 {
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conFunction4Code.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ClsName); //类名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeFullName))
 {
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeFullName, conFunction4Code.ReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnTypeFullName); //返回类型全名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeId))
 {
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conFunction4Code.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeNameCustom))
 {
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeNameCustom, conFunction4Code.ReturnTypeNameCustom); //定制返回类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnTypeNameCustom); //定制返回类型名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.CodeTypeId))
 {
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conFunction4Code.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.CodeTypeId); //代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncAccessModeId))
 {
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncAccessModeId, conFunction4Code.FuncAccessModeId); //函数操作模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncAccessModeId); //函数操作模式Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabName))
 {
 if (objFunction4CodeEN.TabName !=  null)
 {
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conFunction4Code.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.TabName); //表名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabId))
 {
 if (objFunction4CodeEN.TabId !=  null)
 {
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conFunction4Code.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.TabId); //表ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncPurposeId))
 {
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncPurposeId, conFunction4Code.FuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncPurposeId); //函数用途Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncTypeId))
 {
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conFunction4Code.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncTypeId); //函数类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.GetCustomAttributes))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.GetCustomAttributes, conFunction4Code.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.SourceFunction))
 {
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceFunction, conFunction4Code.SourceFunction); //来源函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.SourceFunction); //来源函数
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4CodeEN.IsAsyncFunc == true?"1":"0", conFunction4Code.IsAsyncFunc); //是否异步函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsSysFunction))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4CodeEN.IsSysFunction == true?"1":"0", conFunction4Code.IsSysFunction); //是否系统函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.OrderNum, conFunction4Code.OrderNum); //序号
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrjId))
 {
 if (objFunction4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFunction4Code.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.PrjId); //工程Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4CodeEN.IsTemplate == true?"1":"0", conFunction4Code.IsTemplate); //是否模板
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdDate))
 {
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunction4Code.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UpdDate); //修改日期
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdUser))
 {
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunction4Code.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UpdUser); //修改者
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.Memo))
 {
 if (objFunction4CodeEN.Memo !=  null)
 {
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunction4Code.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.Memo); //说明
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UsedTimes))
 {
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.UsedTimes, conFunction4Code.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UsedTimes); //使用次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncId4Code = '{0}'", objFunction4CodeEN.FuncId4Code); 
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
string strMsg = string.Format("发生错误:[{0}].SQL:[{1}].({2})",
     objException.Message, sbSQL.ToString(), clsStackTrace.GetCurrClassFunction());
clsSysParaEN.objLog.WriteDebugLog(strMsg);
throw new Exception(strMsg);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是非优化方式,根据条件修改记录
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithCondition)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunction4CodeEN objFunction4CodeEN, string strCondition)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Function4Code Set ");
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncName4Code))
 {
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName4Code = '{0}',", strFuncName4Code); //函数名4Code
 }
 else
 {
 sbSQL.Append(" FuncName4Code = null,"); //函数名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncCHName4Code))
 {
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCHName4Code = '{0}',", strFuncCHName4Code); //函数中文名4Code
 }
 else
 {
 sbSQL.Append(" FuncCHName4Code = null,"); //函数中文名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrevFuncId))
 {
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrevFuncId = '{0}',", strPrevFuncId); //前函数Id
 }
 else
 {
 sbSQL.Append(" PrevFuncId = null,"); //前函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.RootFuncId))
 {
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootFuncId = '{0}',", strRootFuncId); //根函数Id
 }
 else
 {
 sbSQL.Append(" RootFuncId = null,"); //根函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objFunction4CodeEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncGCTypeId))
 {
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncGCTypeId = '{0}',", strFuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.Append(" FuncGCTypeId = null,"); //函数生成代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignature))
 {
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignatureSim))
 {
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignatureSim = '{0}',", strFunctionSignatureSim); //函数签名_Sim
 }
 else
 {
 sbSQL.Append(" FunctionSignatureSim = null,"); //函数签名_Sim
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnType))
 {
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnType = '{0}',", strReturnType); //返回类型
 }
 else
 {
 sbSQL.Append(" ReturnType = null,"); //返回类型
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ClsName))
 {
 if (objFunction4CodeEN.ClsName !=  null)
 {
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeFullName))
 {
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeFullName = '{0}',", strReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.Append(" ReturnTypeFullName = null,"); //返回类型全名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeId))
 {
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeNameCustom))
 {
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeNameCustom = '{0}',", strReturnTypeNameCustom); //定制返回类型名
 }
 else
 {
 sbSQL.Append(" ReturnTypeNameCustom = null,"); //定制返回类型名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.CodeTypeId))
 {
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncAccessModeId))
 {
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncAccessModeId = '{0}',", strFuncAccessModeId); //函数操作模式Id
 }
 else
 {
 sbSQL.Append(" FuncAccessModeId = null,"); //函数操作模式Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabName))
 {
 if (objFunction4CodeEN.TabName !=  null)
 {
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabId))
 {
 if (objFunction4CodeEN.TabId !=  null)
 {
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncPurposeId))
 {
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncPurposeId = '{0}',", strFuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.Append(" FuncPurposeId = null,"); //函数用途Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncTypeId))
 {
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.GetCustomAttributes))
 {
 sbSQL.AppendFormat(" GetCustomAttributes = {0},", objFunction4CodeEN.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.SourceFunction))
 {
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceFunction = '{0}',", strSourceFunction); //来源函数
 }
 else
 {
 sbSQL.Append(" SourceFunction = null,"); //来源函数
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" IsAsyncFunc = '{0}',", objFunction4CodeEN.IsAsyncFunc == true?"1":"0"); //是否异步函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsSysFunction))
 {
 sbSQL.AppendFormat(" IsSysFunction = '{0}',", objFunction4CodeEN.IsSysFunction == true?"1":"0"); //是否系统函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objFunction4CodeEN.OrderNum); //序号
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrjId))
 {
 if (objFunction4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFunction4CodeEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdDate))
 {
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdUser))
 {
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.Memo))
 {
 if (objFunction4CodeEN.Memo !=  null)
 {
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UsedTimes))
 {
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.UsedTimes, conFunction4Code.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UsedTimes); //使用次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString());
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式,根据条件修改记录.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithConditionTransaction)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunction4CodeEN objFunction4CodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Function4Code Set ");
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncName4Code))
 {
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName4Code = '{0}',", strFuncName4Code); //函数名4Code
 }
 else
 {
 sbSQL.Append(" FuncName4Code = null,"); //函数名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncCHName4Code))
 {
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCHName4Code = '{0}',", strFuncCHName4Code); //函数中文名4Code
 }
 else
 {
 sbSQL.Append(" FuncCHName4Code = null,"); //函数中文名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrevFuncId))
 {
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrevFuncId = '{0}',", strPrevFuncId); //前函数Id
 }
 else
 {
 sbSQL.Append(" PrevFuncId = null,"); //前函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.RootFuncId))
 {
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootFuncId = '{0}',", strRootFuncId); //根函数Id
 }
 else
 {
 sbSQL.Append(" RootFuncId = null,"); //根函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objFunction4CodeEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncGCTypeId))
 {
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncGCTypeId = '{0}',", strFuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.Append(" FuncGCTypeId = null,"); //函数生成代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignature))
 {
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignatureSim))
 {
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignatureSim = '{0}',", strFunctionSignatureSim); //函数签名_Sim
 }
 else
 {
 sbSQL.Append(" FunctionSignatureSim = null,"); //函数签名_Sim
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnType))
 {
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnType = '{0}',", strReturnType); //返回类型
 }
 else
 {
 sbSQL.Append(" ReturnType = null,"); //返回类型
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ClsName))
 {
 if (objFunction4CodeEN.ClsName !=  null)
 {
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ClsName = '{0}',", strClsName); //类名
 }
 else
 {
 sbSQL.Append(" ClsName = null,"); //类名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeFullName))
 {
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeFullName = '{0}',", strReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.Append(" ReturnTypeFullName = null,"); //返回类型全名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeId))
 {
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeNameCustom))
 {
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeNameCustom = '{0}',", strReturnTypeNameCustom); //定制返回类型名
 }
 else
 {
 sbSQL.Append(" ReturnTypeNameCustom = null,"); //定制返回类型名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.CodeTypeId))
 {
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeTypeId = '{0}',", strCodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.Append(" CodeTypeId = null,"); //代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncAccessModeId))
 {
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncAccessModeId = '{0}',", strFuncAccessModeId); //函数操作模式Id
 }
 else
 {
 sbSQL.Append(" FuncAccessModeId = null,"); //函数操作模式Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabName))
 {
 if (objFunction4CodeEN.TabName !=  null)
 {
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabId))
 {
 if (objFunction4CodeEN.TabId !=  null)
 {
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncPurposeId))
 {
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncPurposeId = '{0}',", strFuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.Append(" FuncPurposeId = null,"); //函数用途Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncTypeId))
 {
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.GetCustomAttributes))
 {
 sbSQL.AppendFormat(" GetCustomAttributes = {0},", objFunction4CodeEN.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.SourceFunction))
 {
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceFunction = '{0}',", strSourceFunction); //来源函数
 }
 else
 {
 sbSQL.Append(" SourceFunction = null,"); //来源函数
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" IsAsyncFunc = '{0}',", objFunction4CodeEN.IsAsyncFunc == true?"1":"0"); //是否异步函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsSysFunction))
 {
 sbSQL.AppendFormat(" IsSysFunction = '{0}',", objFunction4CodeEN.IsSysFunction == true?"1":"0"); //是否系统函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objFunction4CodeEN.OrderNum); //序号
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrjId))
 {
 if (objFunction4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFunction4CodeEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdDate))
 {
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdUser))
 {
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.Memo))
 {
 if (objFunction4CodeEN.Memo !=  null)
 {
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UsedTimes))
 {
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.UsedTimes, conFunction4Code.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UsedTimes); //使用次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where {0}", strCondition); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 /// <summary>
 /// /// 功能:通过SQL命令来修改记录,该方式是优化方式.(带事务处理)
 /// /// 优点:1、能够处理字段中的单撇问题；
 /// /// 2、能够处理脏字段,即只有修改过的字段才需要修改同步到数据库;
 /// /// 3、支持事务处理.
 /// (AutoGCLib.DALCode4CSharp:GenUpdateBySqlWithTransaction2)
 /// </summary>
 /// <param name = "objFunction4CodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunction4CodeEN objFunction4CodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunction4CodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4CodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4CodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Function4Code Set ");
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncName4Code))
 {
 if (objFunction4CodeEN.FuncName4Code !=  null)
 {
 var strFuncName4Code = objFunction4CodeEN.FuncName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName4Code, conFunction4Code.FuncName4Code); //函数名4Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncName4Code); //函数名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncCHName4Code))
 {
 if (objFunction4CodeEN.FuncCHName4Code !=  null)
 {
 var strFuncCHName4Code = objFunction4CodeEN.FuncCHName4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCHName4Code, conFunction4Code.FuncCHName4Code); //函数中文名4Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncCHName4Code); //函数中文名4Code
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrevFuncId))
 {
 if (objFunction4CodeEN.PrevFuncId !=  null)
 {
 var strPrevFuncId = objFunction4CodeEN.PrevFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrevFuncId, conFunction4Code.PrevFuncId); //前函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.PrevFuncId); //前函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.RootFuncId))
 {
 if (objFunction4CodeEN.RootFuncId !=  null)
 {
 var strRootFuncId = objFunction4CodeEN.RootFuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootFuncId, conFunction4Code.RootFuncId); //根函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.RootFuncId); //根函数Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.ApplicationTypeId, conFunction4Code.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncGCTypeId))
 {
 if (objFunction4CodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4CodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncGCTypeId, conFunction4Code.FuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncGCTypeId); //函数生成代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignature))
 {
 if (objFunction4CodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4CodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conFunction4Code.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FunctionSignature); //函数签名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FunctionSignatureSim))
 {
 if (objFunction4CodeEN.FunctionSignatureSim !=  null)
 {
 var strFunctionSignatureSim = objFunction4CodeEN.FunctionSignatureSim.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignatureSim, conFunction4Code.FunctionSignatureSim); //函数签名_Sim
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FunctionSignatureSim); //函数签名_Sim
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnType))
 {
 if (objFunction4CodeEN.ReturnType !=  null)
 {
 var strReturnType = objFunction4CodeEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnType, conFunction4Code.ReturnType); //返回类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnType); //返回类型
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ClsName))
 {
 if (objFunction4CodeEN.ClsName !=  null)
 {
 var strClsName = objFunction4CodeEN.ClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strClsName, conFunction4Code.ClsName); //类名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ClsName); //类名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeFullName))
 {
 if (objFunction4CodeEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objFunction4CodeEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeFullName, conFunction4Code.ReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnTypeFullName); //返回类型全名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeId))
 {
 if (objFunction4CodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4CodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conFunction4Code.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.ReturnTypeNameCustom))
 {
 if (objFunction4CodeEN.ReturnTypeNameCustom !=  null)
 {
 var strReturnTypeNameCustom = objFunction4CodeEN.ReturnTypeNameCustom.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeNameCustom, conFunction4Code.ReturnTypeNameCustom); //定制返回类型名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.ReturnTypeNameCustom); //定制返回类型名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.CodeTypeId))
 {
 if (objFunction4CodeEN.CodeTypeId !=  null)
 {
 var strCodeTypeId = objFunction4CodeEN.CodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeTypeId, conFunction4Code.CodeTypeId); //代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.CodeTypeId); //代码类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncAccessModeId))
 {
 if (objFunction4CodeEN.FuncAccessModeId !=  null)
 {
 var strFuncAccessModeId = objFunction4CodeEN.FuncAccessModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncAccessModeId, conFunction4Code.FuncAccessModeId); //函数操作模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncAccessModeId); //函数操作模式Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabName))
 {
 if (objFunction4CodeEN.TabName !=  null)
 {
 var strTabName = objFunction4CodeEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conFunction4Code.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.TabName); //表名
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.TabId))
 {
 if (objFunction4CodeEN.TabId !=  null)
 {
 var strTabId = objFunction4CodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conFunction4Code.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.TabId); //表ID
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncPurposeId))
 {
 if (objFunction4CodeEN.FuncPurposeId !=  null)
 {
 var strFuncPurposeId = objFunction4CodeEN.FuncPurposeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncPurposeId, conFunction4Code.FuncPurposeId); //函数用途Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncPurposeId); //函数用途Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.FuncTypeId))
 {
 if (objFunction4CodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4CodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conFunction4Code.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.FuncTypeId); //函数类型Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.GetCustomAttributes))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.GetCustomAttributes, conFunction4Code.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.SourceFunction))
 {
 if (objFunction4CodeEN.SourceFunction !=  null)
 {
 var strSourceFunction = objFunction4CodeEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceFunction, conFunction4Code.SourceFunction); //来源函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.SourceFunction); //来源函数
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4CodeEN.IsAsyncFunc == true?"1":"0", conFunction4Code.IsAsyncFunc); //是否异步函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsSysFunction))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4CodeEN.IsSysFunction == true?"1":"0", conFunction4Code.IsSysFunction); //是否系统函数
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.OrderNum, conFunction4Code.OrderNum); //序号
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.PrjId))
 {
 if (objFunction4CodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4CodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFunction4Code.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.PrjId); //工程Id
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4CodeEN.IsTemplate == true?"1":"0", conFunction4Code.IsTemplate); //是否模板
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdDate))
 {
 if (objFunction4CodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4CodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunction4Code.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UpdDate); //修改日期
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UpdUser))
 {
 if (objFunction4CodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4CodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunction4Code.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UpdUser); //修改者
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.Memo))
 {
 if (objFunction4CodeEN.Memo !=  null)
 {
 var strMemo = objFunction4CodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunction4Code.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.Memo); //说明
 }
 }
 
 if (objFunction4CodeEN.IsUpdated(conFunction4Code.UsedTimes))
 {
 if (objFunction4CodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4CodeEN.UsedTimes, conFunction4Code.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4Code.UsedTimes); //使用次数
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncId4Code = '{0}'", objFunction4CodeEN.FuncId4Code); 
try
{
 clsCheckSql.CheckSqlInjection4Update(sbSQL.ToString());
 return objSQL.ExecSql(sbSQL.ToString(), objSqlConnection, objSqlTransaction);
}
catch (Exception objException)
{
clsGeneralTab2. LogErrorS(objException, "");
throw new Exception(EXCEPTION_MSG + objException.Message, objException);
}
finally
{
}
}


 #endregion 修改记录

 #region 删除记录

 /// <summary>
 /// 功能:删除关键字所指定的记录,通过存储过程(SP)来删除。
 /// (AutoGCLib.DALCode4CSharp:GenDelRecordBySP)
 /// </summary>
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncId4Code) 
{
CheckPrimaryKey(strFuncId4Code);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncId4Code,
};
 objSQL.ExecSP("Function4Code_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncId4Code, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncId4Code);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
//删除Function4Code本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Function4Code where FuncId4Code = " + "'"+ strFuncId4Code+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunction4Code(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除Function4Code本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Function4Code where FuncId4Code in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncId4Code) 
{
CheckPrimaryKey(strFuncId4Code);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
//删除Function4Code本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Function4Code where FuncId4Code = " + "'"+ strFuncId4Code+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunction4Code(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunction4CodeDA: DelFunction4Code)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Function4Code where " + strCondition ;
}
int intRecoCount = objSQL.ExecSql2(strSQL);
return intRecoCount;
}



 /// <summary>
 /// 功能:删除满足条件的多条记录,同时处理事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRecWithTransaction)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回是否删除成功。</returns>
public bool DelFunction4CodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunction4CodeDA: DelFunction4CodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Function4Code where " + strCondition ;
}
 bool bolResult = objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
return bolResult;
}


 #endregion 删除记录

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objFunction4CodeENS">源对象</param>
 /// <param name = "objFunction4CodeENT">目标对象</param>
public void CopyTo(clsFunction4CodeEN objFunction4CodeENS, clsFunction4CodeEN objFunction4CodeENT)
{
objFunction4CodeENT.FuncId4Code = objFunction4CodeENS.FuncId4Code; //函数Id4Code
objFunction4CodeENT.FuncName4Code = objFunction4CodeENS.FuncName4Code; //函数名4Code
objFunction4CodeENT.FuncCHName4Code = objFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objFunction4CodeENT.PrevFuncId = objFunction4CodeENS.PrevFuncId; //前函数Id
objFunction4CodeENT.RootFuncId = objFunction4CodeENS.RootFuncId; //根函数Id
objFunction4CodeENT.ApplicationTypeId = objFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objFunction4CodeENT.FuncGCTypeId = objFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4CodeENT.FunctionSignature = objFunction4CodeENS.FunctionSignature; //函数签名
objFunction4CodeENT.FunctionSignatureSim = objFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objFunction4CodeENT.ReturnType = objFunction4CodeENS.ReturnType; //返回类型
objFunction4CodeENT.ClsName = objFunction4CodeENS.ClsName; //类名
objFunction4CodeENT.ReturnTypeFullName = objFunction4CodeENS.ReturnTypeFullName; //返回类型全名
objFunction4CodeENT.ReturnTypeId = objFunction4CodeENS.ReturnTypeId; //返回类型ID
objFunction4CodeENT.ReturnTypeNameCustom = objFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objFunction4CodeENT.CodeTypeId = objFunction4CodeENS.CodeTypeId; //代码类型Id
objFunction4CodeENT.FuncAccessModeId = objFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objFunction4CodeENT.TabName = objFunction4CodeENS.TabName; //表名
objFunction4CodeENT.TabId = objFunction4CodeENS.TabId; //表ID
objFunction4CodeENT.FuncPurposeId = objFunction4CodeENS.FuncPurposeId; //函数用途Id
objFunction4CodeENT.FuncTypeId = objFunction4CodeENS.FuncTypeId; //函数类型Id
objFunction4CodeENT.GetCustomAttributes = objFunction4CodeENS.GetCustomAttributes; //GetCustomAttributes
objFunction4CodeENT.SourceFunction = objFunction4CodeENS.SourceFunction; //来源函数
objFunction4CodeENT.IsAsyncFunc = objFunction4CodeENS.IsAsyncFunc; //是否异步函数
objFunction4CodeENT.IsSysFunction = objFunction4CodeENS.IsSysFunction; //是否系统函数
objFunction4CodeENT.OrderNum = objFunction4CodeENS.OrderNum; //序号
objFunction4CodeENT.PrjId = objFunction4CodeENS.PrjId; //工程Id
objFunction4CodeENT.IsTemplate = objFunction4CodeENS.IsTemplate; //是否模板
objFunction4CodeENT.UpdDate = objFunction4CodeENS.UpdDate; //修改日期
objFunction4CodeENT.UpdUser = objFunction4CodeENS.UpdUser; //修改者
objFunction4CodeENT.Memo = objFunction4CodeENS.Memo; //说明
objFunction4CodeENT.UsedTimes = objFunction4CodeENS.UsedTimes; //使用次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunction4CodeEN objFunction4CodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunction4CodeEN.FuncName4Code, conFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldNotNull(objFunction4CodeEN.RootFuncId, conFunction4Code.RootFuncId);
clsCheckSql.CheckFieldNotNull(objFunction4CodeEN.ApplicationTypeId, conFunction4Code.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objFunction4CodeEN.FuncPurposeId, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldNotNull(objFunction4CodeEN.GetCustomAttributes, conFunction4Code.GetCustomAttributes);
clsCheckSql.CheckFieldNotNull(objFunction4CodeEN.OrderNum, conFunction4Code.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncId4Code, 8, conFunction4Code.FuncId4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncName4Code, 100, conFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncCHName4Code, 200, conFunction4Code.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.PrevFuncId, 8, conFunction4Code.PrevFuncId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.RootFuncId, 8, conFunction4Code.RootFuncId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FunctionSignature, 500, conFunction4Code.FunctionSignature);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FunctionSignatureSim, 500, conFunction4Code.FunctionSignatureSim);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnType, 500, conFunction4Code.ReturnType);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ClsName, 100, conFunction4Code.ClsName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeFullName, 500, conFunction4Code.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeId, 2, conFunction4Code.ReturnTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeNameCustom, 50, conFunction4Code.ReturnTypeNameCustom);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.CodeTypeId, 4, conFunction4Code.CodeTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.TabName, 100, conFunction4Code.TabName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.TabId, 8, conFunction4Code.TabId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncPurposeId, 2, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncTypeId, 2, conFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.SourceFunction, 500, conFunction4Code.SourceFunction);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.PrjId, 4, conFunction4Code.PrjId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.UpdDate, 20, conFunction4Code.UpdDate);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.UpdUser, 20, conFunction4Code.UpdUser);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.Memo, 1000, conFunction4Code.Memo);
//检查字段外键固定长度
 objFunction4CodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunction4CodeEN objFunction4CodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncName4Code, 100, conFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncCHName4Code, 200, conFunction4Code.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.PrevFuncId, 8, conFunction4Code.PrevFuncId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.RootFuncId, 8, conFunction4Code.RootFuncId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FunctionSignature, 500, conFunction4Code.FunctionSignature);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FunctionSignatureSim, 500, conFunction4Code.FunctionSignatureSim);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnType, 500, conFunction4Code.ReturnType);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ClsName, 100, conFunction4Code.ClsName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeFullName, 500, conFunction4Code.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeId, 2, conFunction4Code.ReturnTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeNameCustom, 50, conFunction4Code.ReturnTypeNameCustom);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.CodeTypeId, 4, conFunction4Code.CodeTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.TabName, 100, conFunction4Code.TabName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.TabId, 8, conFunction4Code.TabId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncPurposeId, 2, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncTypeId, 2, conFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.SourceFunction, 500, conFunction4Code.SourceFunction);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.PrjId, 4, conFunction4Code.PrjId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.UpdDate, 20, conFunction4Code.UpdDate);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.UpdUser, 20, conFunction4Code.UpdUser);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.Memo, 1000, conFunction4Code.Memo);
//检查外键字段长度
 objFunction4CodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunction4CodeEN objFunction4CodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncId4Code, 8, conFunction4Code.FuncId4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncName4Code, 100, conFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncCHName4Code, 200, conFunction4Code.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.PrevFuncId, 8, conFunction4Code.PrevFuncId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.RootFuncId, 8, conFunction4Code.RootFuncId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncGCTypeId, 2, conFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FunctionSignature, 500, conFunction4Code.FunctionSignature);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FunctionSignatureSim, 500, conFunction4Code.FunctionSignatureSim);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnType, 500, conFunction4Code.ReturnType);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ClsName, 100, conFunction4Code.ClsName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeFullName, 500, conFunction4Code.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeId, 2, conFunction4Code.ReturnTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.ReturnTypeNameCustom, 50, conFunction4Code.ReturnTypeNameCustom);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.CodeTypeId, 4, conFunction4Code.CodeTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncAccessModeId, 2, conFunction4Code.FuncAccessModeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.TabName, 100, conFunction4Code.TabName);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.TabId, 8, conFunction4Code.TabId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncPurposeId, 2, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.FuncTypeId, 2, conFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.SourceFunction, 500, conFunction4Code.SourceFunction);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.PrjId, 4, conFunction4Code.PrjId);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.UpdDate, 20, conFunction4Code.UpdDate);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.UpdUser, 20, conFunction4Code.UpdUser);
clsCheckSql.CheckFieldLen(objFunction4CodeEN.Memo, 1000, conFunction4Code.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncId4Code, conFunction4Code.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncName4Code, conFunction4Code.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncCHName4Code, conFunction4Code.FuncCHName4Code);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.PrevFuncId, conFunction4Code.PrevFuncId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.RootFuncId, conFunction4Code.RootFuncId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncGCTypeId, conFunction4Code.FuncGCTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FunctionSignature, conFunction4Code.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FunctionSignatureSim, conFunction4Code.FunctionSignatureSim);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.ReturnType, conFunction4Code.ReturnType);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.ClsName, conFunction4Code.ClsName);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.ReturnTypeFullName, conFunction4Code.ReturnTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.ReturnTypeId, conFunction4Code.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.ReturnTypeNameCustom, conFunction4Code.ReturnTypeNameCustom);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.CodeTypeId, conFunction4Code.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncAccessModeId, conFunction4Code.FuncAccessModeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.TabName, conFunction4Code.TabName);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.TabId, conFunction4Code.TabId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncPurposeId, conFunction4Code.FuncPurposeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.FuncTypeId, conFunction4Code.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.SourceFunction, conFunction4Code.SourceFunction);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.PrjId, conFunction4Code.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.UpdDate, conFunction4Code.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.UpdUser, conFunction4Code.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFunction4CodeEN.Memo, conFunction4Code.Memo);
//检查外键字段长度
 objFunction4CodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncId4Code()
{
//获取某学院所有专业信息
string strSQL = "select FuncId4Code, FuncName4Code from Function4Code ";
 clsSpecSQLforSql mySql = clsFunction4CodeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Function4Code(函数4Code),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunction4CodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFunction4CodeEN objFunction4CodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName4Code = '{0}'", objFunction4CodeEN.FuncName4Code);
 if (objFunction4CodeEN.ClsName == null)
{
 sbCondition.AppendFormat(" and ClsName is null");
}
else
{
 sbCondition.AppendFormat(" and ClsName = '{0}'", objFunction4CodeEN.ClsName);
}
 sbCondition.AppendFormat(" and FuncPurposeId = '{0}'", objFunction4CodeEN.FuncPurposeId);
 if (objFunction4CodeEN.PrjId == null)
{
 sbCondition.AppendFormat(" and PrjId is null");
}
else
{
 sbCondition.AppendFormat(" and PrjId = '{0}'", objFunction4CodeEN.PrjId);
}
 if (objFunction4CodeEN.CodeTypeId == null)
{
 sbCondition.AppendFormat(" and CodeTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and CodeTypeId = '{0}'", objFunction4CodeEN.CodeTypeId);
}
return sbCondition.ToString();
}

 #endregion 检查唯一性

 #region 表操作常用函数

 /// <summary>
 /// 功能:获取当前表的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCount(string strTabName)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取给定表中满足条件的记录数, 该表与当前类不相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond_S)
 /// </summary>
 /// <param name = "strTabName">所给定的表名</param>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
public static int GetRecCountByCond(string strTabName, string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(strTabName, strCondition);
return intRecCount;
}



 /// <summary>
 /// 功能:获取当前表的记录数.该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCount)
 /// </summary>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCount()
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunction4CodeEN._CurrTabName);
return intRecCount;
}


 /// <summary>
 /// 功能:获取当前表中满足条件的记录数, 该表与当前类相关。
 /// (AutoGCLib.DALCode4CSharp:GenGetRecCountByCond)
 /// </summary>
 /// <param name = "strCondition">所给定的记录条件</param>
 /// <returns>记录数,为整型</returns>
 public static int GetRecCountByCond(string strCondition)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunction4CodeEN._CurrTabName, strCondition);
return intRecCount;
}

 /// <summary>
 /// 功能:获取给定表中的符合条件的某字段的值,以列表返回
 /// (AutoGCLib.DALCode4CSharp:GenGetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>获取的字段值列表</returns>
public static List<string> GetFldValue(string strTabName, string strFldName, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 /// <summary>
 /// 功能:设置给定表中的符合条件的某字段的值
 /// (AutoGCLib.DALCode4CSharp:GenfunSetFldValue_S)
 /// </summary>
 /// <param name = "strTabName">表名</param>
 /// <param name = "strFldName">字段名</param>
 /// <param name = "varValue">值</param>
 /// <param name = "strCondition">条件串</param>
 /// <returns>影响的记录数</returns>
public static int SetFldValue<T>(string strTabName, string strFldName, T varValue, string strCondition) 
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}