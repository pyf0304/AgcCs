
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsWebSrvFunctionsDA
 表名:WebSrvFunctions(00050342)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// WebSrv函数(WebSrvFunctions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsWebSrvFunctionsDA : clsCommBase4DA
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
 return clsWebSrvFunctionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsWebSrvFunctionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsWebSrvFunctionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsWebSrvFunctionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsWebSrvFunctionsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWebSrvFunctionId)
{
strWebSrvFunctionId = strWebSrvFunctionId.Replace("'", "''");
if (strWebSrvFunctionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:WebSrvFunctions中,检查关键字,长度不正确!(clsWebSrvFunctionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:WebSrvFunctions中,关键字不能为空 或 null!(clsWebSrvFunctionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsWebSrvFunctionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_WebSrvFunctions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable_WebSrvFunctions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebSrvFunctions.* " + 
$"from WebSrvFunctions " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebSrvFunctions.WebSrvFunctionId not in " + 
$"(Select top {intTop_In} WebSrvFunctions.WebSrvFunctionId from WebSrvFunctions " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {2} WebSrvFunctionId from WebSrvFunctions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {3} WebSrvFunctionId from WebSrvFunctions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} WebSrvFunctions.* " + 
$"from WebSrvFunctions " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and WebSrvFunctions.WebSrvFunctionId not in " + 
$"(Select top {intTop_In} WebSrvFunctions.WebSrvFunctionId from WebSrvFunctions " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {2} WebSrvFunctionId from WebSrvFunctions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from WebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {3} WebSrvFunctionId from WebSrvFunctions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsWebSrvFunctionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA:GetObjLst)", objException.Message));
}
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = TransNullToBool(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetObjLst)", objException.Message));
}
objWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebSrvFunctionsEN);
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
public List<clsWebSrvFunctionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA:GetObjLstByTabName)", objException.Message));
}
List<clsWebSrvFunctionsEN> arrObjLst = new List<clsWebSrvFunctionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = TransNullToBool(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetObjLst)", objException.Message));
}
objWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objWebSrvFunctionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetWebSrvFunctions(ref clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where WebSrvFunctionId = " + "'"+ objWebSrvFunctionsEN.WebSrvFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objWebSrvFunctionsEN.WebSrvFunctionId = objDT.Rows[0][conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFunctionsEN.WebSrvClassId = objDT.Rows[0][conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFunctionsEN.FunctionName = objDT.Rows[0][conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objDT.Rows[0][conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objWebSrvFunctionsEN.FunctionSignature = objDT.Rows[0][conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objWebSrvFunctionsEN.FuncTypeId = objDT.Rows[0][conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objWebSrvFunctionsEN.ReturnType = objDT.Rows[0][conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objWebSrvFunctionsEN.ReturnTypeFullName = objDT.Rows[0][conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.IsKnownType = TransNullToBool(objDT.Rows[0][conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.ReturnTypeId = objDT.Rows[0][conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.SourceFunction = objDT.Rows[0][conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objDT.Rows[0][conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.ReturnValueDescription = objDT.Rows[0][conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.FuncParaLst = objDT.Rows[0][conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.IsSysFunction = TransNullToBool(objDT.Rows[0][conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.UpdDate = objDT.Rows[0][conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFunctionsEN.UpdUser = objDT.Rows[0][conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFunctionsEN.Memo = objDT.Rows[0][conWebSrvFunctions.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetWebSrvFunctions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsWebSrvFunctionsEN GetObjByWebSrvFunctionId(string strWebSrvFunctionId)
{
CheckPrimaryKey(strWebSrvFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where WebSrvFunctionId = " + "'"+ strWebSrvFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
 objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objWebSrvFunctionsEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetObjByWebSrvFunctionId)", objException.Message));
}
return objWebSrvFunctionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsWebSrvFunctionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN()
{
WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(), //函数Id
WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(), //类Id
FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(), //功能名称
GetCustomAttributes = TransNullToInt(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()), //GetCustomAttributes
FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(), //函数签名
FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(), //函数类型Id
ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(), //返回类型
ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(), //返回类型全名
IsKnownType = TransNullToBool(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()), //是否已知类型
ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(), //返回类型ID
IsAsyncFunc = TransNullToBool(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()), //是否异步函数
SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(), //来源函数
IsGeneCode = TransNullToBool(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()), //是否生成代码
ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(), //返回值说明
FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(), //函数参数列表
IsSysFunction = TransNullToBool(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()), //是否系统函数
UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim() //说明
};
objWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvFunctionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsWebSrvFunctionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = TransNullToBool(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetObjByDataRowWebSrvFunctions)", objException.Message));
}
objWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvFunctionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsWebSrvFunctionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsWebSrvFunctionsEN objWebSrvFunctionsEN = new clsWebSrvFunctionsEN();
try
{
objWebSrvFunctionsEN.WebSrvFunctionId = objRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objWebSrvFunctionsEN.WebSrvClassId = objRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objWebSrvFunctionsEN.FunctionName = objRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objWebSrvFunctionsEN.FunctionSignature = objRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objWebSrvFunctionsEN.FuncTypeId = objRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objWebSrvFunctionsEN.ReturnType = objRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objWebSrvFunctionsEN.ReturnTypeFullName = objRow[conWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[conWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objWebSrvFunctionsEN.ReturnTypeId = objRow[conWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objWebSrvFunctionsEN.SourceFunction = objRow[conWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[conWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objWebSrvFunctionsEN.ReturnValueDescription = objRow[conWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objWebSrvFunctionsEN.FuncParaLst = objRow[conWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objWebSrvFunctionsEN.IsSysFunction = TransNullToBool(objRow[conWebSrvFunctions.IsSysFunction].ToString().Trim()); //是否系统函数
objWebSrvFunctionsEN.UpdDate = objRow[conWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objWebSrvFunctionsEN.UpdUser = objRow[conWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objWebSrvFunctionsEN.Memo = objRow[conWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsWebSrvFunctionsDA: GetObjByDataRow)", objException.Message));
}
objWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objWebSrvFunctionsEN;
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
objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebSrvFunctionsEN._CurrTabName, conWebSrvFunctions.WebSrvFunctionId, 8, "");
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
objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsWebSrvFunctionsEN._CurrTabName, conWebSrvFunctions.WebSrvFunctionId, 8, strPrefix);
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvFunctionId from WebSrvFunctions where " + strCondition;
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvFunctionId from WebSrvFunctions where " + strCondition;
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
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWebSrvFunctionId)
{
CheckPrimaryKey(strWebSrvFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebSrvFunctions", "WebSrvFunctionId = " + "'"+ strWebSrvFunctionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("WebSrvFunctions", strCondition))
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
objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("WebSrvFunctions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
 {
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFunctionsEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebSrvFunctions");
objRow = objDS.Tables["WebSrvFunctions"].NewRow();
objRow[conWebSrvFunctions.WebSrvFunctionId] = objWebSrvFunctionsEN.WebSrvFunctionId; //函数Id
objRow[conWebSrvFunctions.WebSrvClassId] = objWebSrvFunctionsEN.WebSrvClassId; //类Id
objRow[conWebSrvFunctions.FunctionName] = objWebSrvFunctionsEN.FunctionName; //功能名称
objRow[conWebSrvFunctions.GetCustomAttributes] = objWebSrvFunctionsEN.GetCustomAttributes; //GetCustomAttributes
objRow[conWebSrvFunctions.FunctionSignature] = objWebSrvFunctionsEN.FunctionSignature; //函数签名
objRow[conWebSrvFunctions.FuncTypeId] = objWebSrvFunctionsEN.FuncTypeId; //函数类型Id
objRow[conWebSrvFunctions.ReturnType] = objWebSrvFunctionsEN.ReturnType; //返回类型
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  "")
 {
objRow[conWebSrvFunctions.ReturnTypeFullName] = objWebSrvFunctionsEN.ReturnTypeFullName; //返回类型全名
 }
objRow[conWebSrvFunctions.IsKnownType] = objWebSrvFunctionsEN.IsKnownType; //是否已知类型
 if (objWebSrvFunctionsEN.ReturnTypeId !=  "")
 {
objRow[conWebSrvFunctions.ReturnTypeId] = objWebSrvFunctionsEN.ReturnTypeId; //返回类型ID
 }
objRow[conWebSrvFunctions.IsAsyncFunc] = objWebSrvFunctionsEN.IsAsyncFunc; //是否异步函数
 if (objWebSrvFunctionsEN.SourceFunction !=  "")
 {
objRow[conWebSrvFunctions.SourceFunction] = objWebSrvFunctionsEN.SourceFunction; //来源函数
 }
objRow[conWebSrvFunctions.IsGeneCode] = objWebSrvFunctionsEN.IsGeneCode; //是否生成代码
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  "")
 {
objRow[conWebSrvFunctions.ReturnValueDescription] = objWebSrvFunctionsEN.ReturnValueDescription; //返回值说明
 }
 if (objWebSrvFunctionsEN.FuncParaLst !=  "")
 {
objRow[conWebSrvFunctions.FuncParaLst] = objWebSrvFunctionsEN.FuncParaLst; //函数参数列表
 }
objRow[conWebSrvFunctions.IsSysFunction] = objWebSrvFunctionsEN.IsSysFunction; //是否系统函数
 if (objWebSrvFunctionsEN.UpdDate !=  "")
 {
objRow[conWebSrvFunctions.UpdDate] = objWebSrvFunctionsEN.UpdDate; //修改日期
 }
 if (objWebSrvFunctionsEN.UpdUser !=  "")
 {
objRow[conWebSrvFunctions.UpdUser] = objWebSrvFunctionsEN.UpdUser; //修改者
 }
 if (objWebSrvFunctionsEN.Memo !=  "")
 {
objRow[conWebSrvFunctions.Memo] = objWebSrvFunctionsEN.Memo; //说明
 }
objDS.Tables[clsWebSrvFunctionsEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsWebSrvFunctionsEN._CurrTabName);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFunctionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFunctionsEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFunctionsEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvClassId);
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionName);
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.GetCustomAttributes);
 arrValueListForInsert.Add(objWebSrvFunctionsEN.GetCustomAttributes.ToString());
 
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionSignature);
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncTypeId);
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnType);
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeFullName);
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeId);
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.SourceFunction);
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsGeneCode);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnValueDescription);
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncParaLst);
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsSysFunction);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdDate);
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdUser);
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.Memo);
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFunctions");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFunctionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFunctionsEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFunctionsEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvClassId);
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionName);
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.GetCustomAttributes);
 arrValueListForInsert.Add(objWebSrvFunctionsEN.GetCustomAttributes.ToString());
 
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionSignature);
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncTypeId);
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnType);
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeFullName);
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeId);
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.SourceFunction);
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsGeneCode);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnValueDescription);
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncParaLst);
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsSysFunction);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdDate);
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdUser);
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.Memo);
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFunctions");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objWebSrvFunctionsEN.WebSrvFunctionId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsWebSrvFunctionsEN objWebSrvFunctionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFunctionsEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFunctionsEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFunctionsEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvClassId);
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionName);
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.GetCustomAttributes);
 arrValueListForInsert.Add(objWebSrvFunctionsEN.GetCustomAttributes.ToString());
 
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionSignature);
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncTypeId);
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnType);
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeFullName);
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeId);
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.SourceFunction);
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsGeneCode);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnValueDescription);
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncParaLst);
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsSysFunction);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdDate);
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdUser);
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.Memo);
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFunctions");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objWebSrvFunctionsEN.WebSrvFunctionId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsWebSrvFunctionsEN objWebSrvFunctionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objWebSrvFunctionsEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objWebSrvFunctionsEN.WebSrvFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvFunctionId);
 var strWebSrvFunctionId = objWebSrvFunctionsEN.WebSrvFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvFunctionId + "'");
 }
 
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.WebSrvClassId);
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWebSrvClassId + "'");
 }
 
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionName);
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.GetCustomAttributes);
 arrValueListForInsert.Add(objWebSrvFunctionsEN.GetCustomAttributes.ToString());
 
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FunctionSignature);
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncTypeId);
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnType);
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnType + "'");
 }
 
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeFullName);
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeFullName + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsKnownType);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsKnownType  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnTypeId);
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsAsyncFunc);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsAsyncFunc  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.SourceFunction);
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceFunction + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsGeneCode);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsGeneCode  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.ReturnValueDescription);
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnValueDescription + "'");
 }
 
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.FuncParaLst);
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncParaLst + "'");
 }
 
 arrFieldListForInsert.Add(conWebSrvFunctions.IsSysFunction);
 arrValueListForInsert.Add("'" + (objWebSrvFunctionsEN.IsSysFunction  ==  false ? "0" : "1") + "'");
 
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdDate);
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.UpdUser);
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conWebSrvFunctions.Memo);
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into WebSrvFunctions");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewWebSrvFunctionss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where WebSrvFunctionId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "WebSrvFunctions");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strWebSrvFunctionId = oRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim();
if (IsExist(strWebSrvFunctionId))
{
 string strResult = "关键字变量值为:" + string.Format("WebSrvFunctionId = {0}", strWebSrvFunctionId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsWebSrvFunctionsEN._CurrTabName ].NewRow();
objRow[conWebSrvFunctions.WebSrvFunctionId] = oRow[conWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objRow[conWebSrvFunctions.WebSrvClassId] = oRow[conWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objRow[conWebSrvFunctions.FunctionName] = oRow[conWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objRow[conWebSrvFunctions.GetCustomAttributes] = oRow[conWebSrvFunctions.GetCustomAttributes].ToString().Trim(); //GetCustomAttributes
objRow[conWebSrvFunctions.FunctionSignature] = oRow[conWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objRow[conWebSrvFunctions.FuncTypeId] = oRow[conWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objRow[conWebSrvFunctions.ReturnType] = oRow[conWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objRow[conWebSrvFunctions.ReturnTypeFullName] = oRow[conWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objRow[conWebSrvFunctions.IsKnownType] = oRow[conWebSrvFunctions.IsKnownType].ToString().Trim(); //是否已知类型
objRow[conWebSrvFunctions.ReturnTypeId] = oRow[conWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objRow[conWebSrvFunctions.IsAsyncFunc] = oRow[conWebSrvFunctions.IsAsyncFunc].ToString().Trim(); //是否异步函数
objRow[conWebSrvFunctions.SourceFunction] = oRow[conWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objRow[conWebSrvFunctions.IsGeneCode] = oRow[conWebSrvFunctions.IsGeneCode].ToString().Trim(); //是否生成代码
objRow[conWebSrvFunctions.ReturnValueDescription] = oRow[conWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objRow[conWebSrvFunctions.FuncParaLst] = oRow[conWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objRow[conWebSrvFunctions.IsSysFunction] = oRow[conWebSrvFunctions.IsSysFunction].ToString().Trim(); //是否系统函数
objRow[conWebSrvFunctions.UpdDate] = oRow[conWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objRow[conWebSrvFunctions.UpdUser] = oRow[conWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objRow[conWebSrvFunctions.Memo] = oRow[conWebSrvFunctions.Memo].ToString().Trim(); //说明
 objDS.Tables[clsWebSrvFunctionsEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsWebSrvFunctionsEN._CurrTabName);
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
 /// <param name = "objWebSrvFunctionsEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFunctionsEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from WebSrvFunctions where WebSrvFunctionId = " + "'"+ objWebSrvFunctionsEN.WebSrvFunctionId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsWebSrvFunctionsEN._CurrTabName);
if (objDS.Tables[clsWebSrvFunctionsEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:WebSrvFunctionId = " + "'"+ objWebSrvFunctionsEN.WebSrvFunctionId+"'");
return false;
}
objRow = objDS.Tables[clsWebSrvFunctionsEN._CurrTabName].Rows[0];
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.WebSrvFunctionId))
 {
objRow[conWebSrvFunctions.WebSrvFunctionId] = objWebSrvFunctionsEN.WebSrvFunctionId; //函数Id
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.WebSrvClassId))
 {
objRow[conWebSrvFunctions.WebSrvClassId] = objWebSrvFunctionsEN.WebSrvClassId; //类Id
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionName))
 {
objRow[conWebSrvFunctions.FunctionName] = objWebSrvFunctionsEN.FunctionName; //功能名称
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.GetCustomAttributes))
 {
objRow[conWebSrvFunctions.GetCustomAttributes] = objWebSrvFunctionsEN.GetCustomAttributes; //GetCustomAttributes
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionSignature))
 {
objRow[conWebSrvFunctions.FunctionSignature] = objWebSrvFunctionsEN.FunctionSignature; //函数签名
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncTypeId))
 {
objRow[conWebSrvFunctions.FuncTypeId] = objWebSrvFunctionsEN.FuncTypeId; //函数类型Id
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnType))
 {
objRow[conWebSrvFunctions.ReturnType] = objWebSrvFunctionsEN.ReturnType; //返回类型
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeFullName))
 {
objRow[conWebSrvFunctions.ReturnTypeFullName] = objWebSrvFunctionsEN.ReturnTypeFullName; //返回类型全名
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsKnownType))
 {
objRow[conWebSrvFunctions.IsKnownType] = objWebSrvFunctionsEN.IsKnownType; //是否已知类型
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeId))
 {
objRow[conWebSrvFunctions.ReturnTypeId] = objWebSrvFunctionsEN.ReturnTypeId; //返回类型ID
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsAsyncFunc))
 {
objRow[conWebSrvFunctions.IsAsyncFunc] = objWebSrvFunctionsEN.IsAsyncFunc; //是否异步函数
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.SourceFunction))
 {
objRow[conWebSrvFunctions.SourceFunction] = objWebSrvFunctionsEN.SourceFunction; //来源函数
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsGeneCode))
 {
objRow[conWebSrvFunctions.IsGeneCode] = objWebSrvFunctionsEN.IsGeneCode; //是否生成代码
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnValueDescription))
 {
objRow[conWebSrvFunctions.ReturnValueDescription] = objWebSrvFunctionsEN.ReturnValueDescription; //返回值说明
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncParaLst))
 {
objRow[conWebSrvFunctions.FuncParaLst] = objWebSrvFunctionsEN.FuncParaLst; //函数参数列表
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsSysFunction))
 {
objRow[conWebSrvFunctions.IsSysFunction] = objWebSrvFunctionsEN.IsSysFunction; //是否系统函数
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdDate))
 {
objRow[conWebSrvFunctions.UpdDate] = objWebSrvFunctionsEN.UpdDate; //修改日期
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdUser))
 {
objRow[conWebSrvFunctions.UpdUser] = objWebSrvFunctionsEN.UpdUser; //修改者
 }
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.Memo))
 {
objRow[conWebSrvFunctions.Memo] = objWebSrvFunctionsEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsWebSrvFunctionsEN._CurrTabName);
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFunctionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update WebSrvFunctions Set ");
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.WebSrvClassId))
 {
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSrvClassId, conWebSrvFunctions.WebSrvClassId); //类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.WebSrvClassId); //类Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionName))
 {
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conWebSrvFunctions.FunctionName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FunctionName); //功能名称
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.GetCustomAttributes))
 {
 sbSQL.AppendFormat("{1} = {0},",objWebSrvFunctionsEN.GetCustomAttributes, conWebSrvFunctions.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionSignature))
 {
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conWebSrvFunctions.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FunctionSignature); //函数签名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncTypeId))
 {
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conWebSrvFunctions.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FuncTypeId); //函数类型Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnType))
 {
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnType, conWebSrvFunctions.ReturnType); //返回类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnType); //返回类型
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeFullName))
 {
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeFullName, conWebSrvFunctions.ReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnTypeFullName); //返回类型全名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsKnownType == true?"1":"0", conWebSrvFunctions.IsKnownType); //是否已知类型
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeId))
 {
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conWebSrvFunctions.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsAsyncFunc == true?"1":"0", conWebSrvFunctions.IsAsyncFunc); //是否异步函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.SourceFunction))
 {
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceFunction, conWebSrvFunctions.SourceFunction); //来源函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.SourceFunction); //来源函数
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsGeneCode == true?"1":"0", conWebSrvFunctions.IsGeneCode); //是否生成代码
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnValueDescription))
 {
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnValueDescription, conWebSrvFunctions.ReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnValueDescription); //返回值说明
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncParaLst))
 {
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncParaLst, conWebSrvFunctions.FuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FuncParaLst); //函数参数列表
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsSysFunction))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsSysFunction == true?"1":"0", conWebSrvFunctions.IsSysFunction); //是否系统函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdDate))
 {
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebSrvFunctions.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.UpdDate); //修改日期
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdUser))
 {
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conWebSrvFunctions.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.UpdUser); //修改者
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.Memo))
 {
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebSrvFunctions.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where WebSrvFunctionId = '{0}'", objWebSrvFunctionsEN.WebSrvFunctionId); 
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
 /// <param name = "objWebSrvFunctionsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strCondition)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFunctionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvFunctions Set ");
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.WebSrvClassId))
 {
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSrvClassId = '{0}',", strWebSrvClassId); //类Id
 }
 else
 {
 sbSQL.Append(" WebSrvClassId = null,"); //类Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionName))
 {
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //功能名称
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //功能名称
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.GetCustomAttributes))
 {
 sbSQL.AppendFormat(" GetCustomAttributes = {0},", objWebSrvFunctionsEN.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionSignature))
 {
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncTypeId))
 {
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnType))
 {
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnType = '{0}',", strReturnType); //返回类型
 }
 else
 {
 sbSQL.Append(" ReturnType = null,"); //返回类型
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeFullName))
 {
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeFullName = '{0}',", strReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.Append(" ReturnTypeFullName = null,"); //返回类型全名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objWebSrvFunctionsEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeId))
 {
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" IsAsyncFunc = '{0}',", objWebSrvFunctionsEN.IsAsyncFunc == true?"1":"0"); //是否异步函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.SourceFunction))
 {
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceFunction = '{0}',", strSourceFunction); //来源函数
 }
 else
 {
 sbSQL.Append(" SourceFunction = null,"); //来源函数
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsGeneCode))
 {
 sbSQL.AppendFormat(" IsGeneCode = '{0}',", objWebSrvFunctionsEN.IsGeneCode == true?"1":"0"); //是否生成代码
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnValueDescription))
 {
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnValueDescription = '{0}',", strReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.Append(" ReturnValueDescription = null,"); //返回值说明
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncParaLst))
 {
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncParaLst = '{0}',", strFuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.Append(" FuncParaLst = null,"); //函数参数列表
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsSysFunction))
 {
 sbSQL.AppendFormat(" IsSysFunction = '{0}',", objWebSrvFunctionsEN.IsSysFunction == true?"1":"0"); //是否系统函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdDate))
 {
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdUser))
 {
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.Memo))
 {
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
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
 /// <param name = "objWebSrvFunctionsEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsWebSrvFunctionsEN objWebSrvFunctionsEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFunctionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvFunctions Set ");
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.WebSrvClassId))
 {
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WebSrvClassId = '{0}',", strWebSrvClassId); //类Id
 }
 else
 {
 sbSQL.Append(" WebSrvClassId = null,"); //类Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionName))
 {
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionName = '{0}',", strFunctionName); //功能名称
 }
 else
 {
 sbSQL.Append(" FunctionName = null,"); //功能名称
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.GetCustomAttributes))
 {
 sbSQL.AppendFormat(" GetCustomAttributes = {0},", objWebSrvFunctionsEN.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionSignature))
 {
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncTypeId))
 {
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnType))
 {
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnType = '{0}',", strReturnType); //返回类型
 }
 else
 {
 sbSQL.Append(" ReturnType = null,"); //返回类型
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeFullName))
 {
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeFullName = '{0}',", strReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.Append(" ReturnTypeFullName = null,"); //返回类型全名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsKnownType))
 {
 sbSQL.AppendFormat(" IsKnownType = '{0}',", objWebSrvFunctionsEN.IsKnownType == true?"1":"0"); //是否已知类型
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeId))
 {
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" IsAsyncFunc = '{0}',", objWebSrvFunctionsEN.IsAsyncFunc == true?"1":"0"); //是否异步函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.SourceFunction))
 {
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceFunction = '{0}',", strSourceFunction); //来源函数
 }
 else
 {
 sbSQL.Append(" SourceFunction = null,"); //来源函数
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsGeneCode))
 {
 sbSQL.AppendFormat(" IsGeneCode = '{0}',", objWebSrvFunctionsEN.IsGeneCode == true?"1":"0"); //是否生成代码
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnValueDescription))
 {
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnValueDescription = '{0}',", strReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.Append(" ReturnValueDescription = null,"); //返回值说明
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncParaLst))
 {
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncParaLst = '{0}',", strFuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.Append(" FuncParaLst = null,"); //函数参数列表
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsSysFunction))
 {
 sbSQL.AppendFormat(" IsSysFunction = '{0}',", objWebSrvFunctionsEN.IsSysFunction == true?"1":"0"); //是否系统函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdDate))
 {
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdUser))
 {
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.Memo))
 {
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
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
 /// <param name = "objWebSrvFunctionsEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsWebSrvFunctionsEN objWebSrvFunctionsEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objWebSrvFunctionsEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objWebSrvFunctionsEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objWebSrvFunctionsEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update WebSrvFunctions Set ");
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.WebSrvClassId))
 {
 if (objWebSrvFunctionsEN.WebSrvClassId !=  null)
 {
 var strWebSrvClassId = objWebSrvFunctionsEN.WebSrvClassId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWebSrvClassId, conWebSrvFunctions.WebSrvClassId); //类Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.WebSrvClassId); //类Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionName))
 {
 if (objWebSrvFunctionsEN.FunctionName !=  null)
 {
 var strFunctionName = objWebSrvFunctionsEN.FunctionName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionName, conWebSrvFunctions.FunctionName); //功能名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FunctionName); //功能名称
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.GetCustomAttributes))
 {
 sbSQL.AppendFormat("{1} = {0},",objWebSrvFunctionsEN.GetCustomAttributes, conWebSrvFunctions.GetCustomAttributes); //GetCustomAttributes
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FunctionSignature))
 {
 if (objWebSrvFunctionsEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objWebSrvFunctionsEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conWebSrvFunctions.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FunctionSignature); //函数签名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncTypeId))
 {
 if (objWebSrvFunctionsEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objWebSrvFunctionsEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conWebSrvFunctions.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FuncTypeId); //函数类型Id
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnType))
 {
 if (objWebSrvFunctionsEN.ReturnType !=  null)
 {
 var strReturnType = objWebSrvFunctionsEN.ReturnType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnType, conWebSrvFunctions.ReturnType); //返回类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnType); //返回类型
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeFullName))
 {
 if (objWebSrvFunctionsEN.ReturnTypeFullName !=  null)
 {
 var strReturnTypeFullName = objWebSrvFunctionsEN.ReturnTypeFullName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeFullName, conWebSrvFunctions.ReturnTypeFullName); //返回类型全名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnTypeFullName); //返回类型全名
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsKnownType))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsKnownType == true?"1":"0", conWebSrvFunctions.IsKnownType); //是否已知类型
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnTypeId))
 {
 if (objWebSrvFunctionsEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objWebSrvFunctionsEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conWebSrvFunctions.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsAsyncFunc))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsAsyncFunc == true?"1":"0", conWebSrvFunctions.IsAsyncFunc); //是否异步函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.SourceFunction))
 {
 if (objWebSrvFunctionsEN.SourceFunction !=  null)
 {
 var strSourceFunction = objWebSrvFunctionsEN.SourceFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceFunction, conWebSrvFunctions.SourceFunction); //来源函数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.SourceFunction); //来源函数
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsGeneCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsGeneCode == true?"1":"0", conWebSrvFunctions.IsGeneCode); //是否生成代码
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.ReturnValueDescription))
 {
 if (objWebSrvFunctionsEN.ReturnValueDescription !=  null)
 {
 var strReturnValueDescription = objWebSrvFunctionsEN.ReturnValueDescription.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnValueDescription, conWebSrvFunctions.ReturnValueDescription); //返回值说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.ReturnValueDescription); //返回值说明
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.FuncParaLst))
 {
 if (objWebSrvFunctionsEN.FuncParaLst !=  null)
 {
 var strFuncParaLst = objWebSrvFunctionsEN.FuncParaLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncParaLst, conWebSrvFunctions.FuncParaLst); //函数参数列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.FuncParaLst); //函数参数列表
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.IsSysFunction))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objWebSrvFunctionsEN.IsSysFunction == true?"1":"0", conWebSrvFunctions.IsSysFunction); //是否系统函数
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdDate))
 {
 if (objWebSrvFunctionsEN.UpdDate !=  null)
 {
 var strUpdDate = objWebSrvFunctionsEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conWebSrvFunctions.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.UpdDate); //修改日期
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.UpdUser))
 {
 if (objWebSrvFunctionsEN.UpdUser !=  null)
 {
 var strUpdUser = objWebSrvFunctionsEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conWebSrvFunctions.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.UpdUser); //修改者
 }
 }
 
 if (objWebSrvFunctionsEN.IsUpdated(conWebSrvFunctions.Memo))
 {
 if (objWebSrvFunctionsEN.Memo !=  null)
 {
 var strMemo = objWebSrvFunctionsEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conWebSrvFunctions.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conWebSrvFunctions.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where WebSrvFunctionId = '{0}'", objWebSrvFunctionsEN.WebSrvFunctionId); 
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
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strWebSrvFunctionId) 
{
CheckPrimaryKey(strWebSrvFunctionId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strWebSrvFunctionId,
};
 objSQL.ExecSP("WebSrvFunctions_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strWebSrvFunctionId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strWebSrvFunctionId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
//删除WebSrvFunctions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvFunctions where WebSrvFunctionId = " + "'"+ strWebSrvFunctionId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelWebSrvFunctions(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
//删除WebSrvFunctions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvFunctions where WebSrvFunctionId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strWebSrvFunctionId) 
{
CheckPrimaryKey(strWebSrvFunctionId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
//删除WebSrvFunctions本表中与当前对象有关的记录
strSQL = strSQL + "Delete from WebSrvFunctions where WebSrvFunctionId = " + "'"+ strWebSrvFunctionId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelWebSrvFunctions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: DelWebSrvFunctions)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebSrvFunctions where " + strCondition ;
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
public bool DelWebSrvFunctionsWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsWebSrvFunctionsDA: DelWebSrvFunctionsWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from WebSrvFunctions where " + strCondition ;
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
 /// <param name = "objWebSrvFunctionsENS">源对象</param>
 /// <param name = "objWebSrvFunctionsENT">目标对象</param>
public void CopyTo(clsWebSrvFunctionsEN objWebSrvFunctionsENS, clsWebSrvFunctionsEN objWebSrvFunctionsENT)
{
objWebSrvFunctionsENT.WebSrvFunctionId = objWebSrvFunctionsENS.WebSrvFunctionId; //函数Id
objWebSrvFunctionsENT.WebSrvClassId = objWebSrvFunctionsENS.WebSrvClassId; //类Id
objWebSrvFunctionsENT.FunctionName = objWebSrvFunctionsENS.FunctionName; //功能名称
objWebSrvFunctionsENT.GetCustomAttributes = objWebSrvFunctionsENS.GetCustomAttributes; //GetCustomAttributes
objWebSrvFunctionsENT.FunctionSignature = objWebSrvFunctionsENS.FunctionSignature; //函数签名
objWebSrvFunctionsENT.FuncTypeId = objWebSrvFunctionsENS.FuncTypeId; //函数类型Id
objWebSrvFunctionsENT.ReturnType = objWebSrvFunctionsENS.ReturnType; //返回类型
objWebSrvFunctionsENT.ReturnTypeFullName = objWebSrvFunctionsENS.ReturnTypeFullName; //返回类型全名
objWebSrvFunctionsENT.IsKnownType = objWebSrvFunctionsENS.IsKnownType; //是否已知类型
objWebSrvFunctionsENT.ReturnTypeId = objWebSrvFunctionsENS.ReturnTypeId; //返回类型ID
objWebSrvFunctionsENT.IsAsyncFunc = objWebSrvFunctionsENS.IsAsyncFunc; //是否异步函数
objWebSrvFunctionsENT.SourceFunction = objWebSrvFunctionsENS.SourceFunction; //来源函数
objWebSrvFunctionsENT.IsGeneCode = objWebSrvFunctionsENS.IsGeneCode; //是否生成代码
objWebSrvFunctionsENT.ReturnValueDescription = objWebSrvFunctionsENS.ReturnValueDescription; //返回值说明
objWebSrvFunctionsENT.FuncParaLst = objWebSrvFunctionsENS.FuncParaLst; //函数参数列表
objWebSrvFunctionsENT.IsSysFunction = objWebSrvFunctionsENS.IsSysFunction; //是否系统函数
objWebSrvFunctionsENT.UpdDate = objWebSrvFunctionsENS.UpdDate; //修改日期
objWebSrvFunctionsENT.UpdUser = objWebSrvFunctionsENS.UpdUser; //修改者
objWebSrvFunctionsENT.Memo = objWebSrvFunctionsENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objWebSrvFunctionsEN.WebSrvClassId, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldNotNull(objWebSrvFunctionsEN.FunctionName, conWebSrvFunctions.FunctionName);
clsCheckSql.CheckFieldNotNull(objWebSrvFunctionsEN.GetCustomAttributes, conWebSrvFunctions.GetCustomAttributes);
clsCheckSql.CheckFieldNotNull(objWebSrvFunctionsEN.FunctionSignature, conWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldNotNull(objWebSrvFunctionsEN.FuncTypeId, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldNotNull(objWebSrvFunctionsEN.ReturnType, conWebSrvFunctions.ReturnType);
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.WebSrvFunctionId, 8, conWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.WebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FunctionName, 200, conWebSrvFunctions.FunctionName);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FunctionSignature, 500, conWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnType, 500, conWebSrvFunctions.ReturnType);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnTypeFullName, 500, conWebSrvFunctions.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.SourceFunction, 500, conWebSrvFunctions.SourceFunction);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnValueDescription, 500, conWebSrvFunctions.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FuncParaLst, 500, conWebSrvFunctions.FuncParaLst);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.UpdDate, 20, conWebSrvFunctions.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.UpdUser, 20, conWebSrvFunctions.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.Memo, 1000, conWebSrvFunctions.Memo);
//检查字段外键固定长度
 objWebSrvFunctionsEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.WebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FunctionName, 200, conWebSrvFunctions.FunctionName);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FunctionSignature, 500, conWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnType, 500, conWebSrvFunctions.ReturnType);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnTypeFullName, 500, conWebSrvFunctions.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.SourceFunction, 500, conWebSrvFunctions.SourceFunction);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnValueDescription, 500, conWebSrvFunctions.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FuncParaLst, 500, conWebSrvFunctions.FuncParaLst);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.UpdDate, 20, conWebSrvFunctions.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.UpdUser, 20, conWebSrvFunctions.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.Memo, 1000, conWebSrvFunctions.Memo);
//检查外键字段长度
 objWebSrvFunctionsEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.WebSrvFunctionId, 8, conWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.WebSrvClassId, 8, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FunctionName, 200, conWebSrvFunctions.FunctionName);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FunctionSignature, 500, conWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FuncTypeId, 2, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnType, 500, conWebSrvFunctions.ReturnType);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnTypeFullName, 500, conWebSrvFunctions.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnTypeId, 2, conWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.SourceFunction, 500, conWebSrvFunctions.SourceFunction);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.ReturnValueDescription, 500, conWebSrvFunctions.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.FuncParaLst, 500, conWebSrvFunctions.FuncParaLst);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.UpdDate, 20, conWebSrvFunctions.UpdDate);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.UpdUser, 20, conWebSrvFunctions.UpdUser);
clsCheckSql.CheckFieldLen(objWebSrvFunctionsEN.Memo, 1000, conWebSrvFunctions.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.WebSrvFunctionId, conWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.WebSrvClassId, conWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.FunctionName, conWebSrvFunctions.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.FunctionSignature, conWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.FuncTypeId, conWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.ReturnType, conWebSrvFunctions.ReturnType);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.ReturnTypeFullName, conWebSrvFunctions.ReturnTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.ReturnTypeId, conWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.SourceFunction, conWebSrvFunctions.SourceFunction);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.ReturnValueDescription, conWebSrvFunctions.ReturnValueDescription);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.FuncParaLst, conWebSrvFunctions.FuncParaLst);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.UpdDate, conWebSrvFunctions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.UpdUser, conWebSrvFunctions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objWebSrvFunctionsEN.Memo, conWebSrvFunctions.Memo);
//检查外键字段长度
 objWebSrvFunctionsEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetWebSrvFunctionId()
{
//获取某学院所有专业信息
string strSQL = "select WebSrvFunctionId, FunctionName from WebSrvFunctions ";
 clsSpecSQLforSql mySql = clsWebSrvFunctionsDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--WebSrvFunctions(WebSrv函数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objWebSrvFunctionsEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsWebSrvFunctionsEN objWebSrvFunctionsEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FunctionName = '{0}'", objWebSrvFunctionsEN.FunctionName);
 sbCondition.AppendFormat(" and WebSrvClassId = '{0}'", objWebSrvFunctionsEN.WebSrvClassId);
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebSrvFunctionsEN._CurrTabName);
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsWebSrvFunctionsEN._CurrTabName, strCondition);
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
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
 objSQL = clsWebSrvFunctionsDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}