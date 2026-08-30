
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFR_CodeSymbolDA
 表名:FR_CodeSymbol(00050657)
 * 版本:2026.07.24(服务器:WIN-SRV103-116)
 日期:2026/07/24 08:14:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:文件引用(FileReference)
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
 /// FR_CodeSymbol(FR_CodeSymbol)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFR_CodeSymbolDA : clsCommBase4DA
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
 return clsFR_CodeSymbolEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFR_CodeSymbolEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFR_CodeSymbolEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFR_CodeSymbolEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFR_CodeSymbolEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_FR_CodeSymbol(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable_FR_CodeSymbol)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FR_CodeSymbol.* " + 
$"from FR_CodeSymbol " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FR_CodeSymbol.SymbolId not in " + 
$"(Select top {intTop_In} FR_CodeSymbol.SymbolId from FR_CodeSymbol " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1} and SymbolId not in (Select top {2} SymbolId from FR_CodeSymbol where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1} and SymbolId not in (Select top {3} SymbolId from FR_CodeSymbol where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} FR_CodeSymbol.* " + 
$"from FR_CodeSymbol " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and FR_CodeSymbol.SymbolId not in " + 
$"(Select top {intTop_In} FR_CodeSymbol.SymbolId from FR_CodeSymbol " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1} and SymbolId not in (Select top {2} SymbolId from FR_CodeSymbol where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from FR_CodeSymbol where {1} and SymbolId not in (Select top {3} SymbolId from FR_CodeSymbol where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFR_CodeSymbolEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA:GetObjLst)", objException.Message));
}
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = TransNullToInt(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = TransNullToInt(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = TransNullToBool(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = TransNullToDate(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetObjLst)", objException.Message));
}
objFR_CodeSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFR_CodeSymbolEN);
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
public List<clsFR_CodeSymbolEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA:GetObjLstByTabName)", objException.Message));
}
List<clsFR_CodeSymbolEN> arrObjLst = new List<clsFR_CodeSymbolEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = TransNullToInt(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = TransNullToInt(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = TransNullToBool(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = TransNullToDate(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetObjLst)", objException.Message));
}
objFR_CodeSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFR_CodeSymbolEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFR_CodeSymbol(ref clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where SymbolId = " + ""+ objFR_CodeSymbolEN.SymbolId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFR_CodeSymbolEN.SymbolId = TransNullToInt(objDT.Rows[0][conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_CodeSymbolEN.FileResourceId = TransNullToInt(objDT.Rows[0][conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_CodeSymbolEN.SymbolName = objDT.Rows[0][conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称(字段类型:varchar,字段长度:100,是否可空:False)
 objFR_CodeSymbolEN.SymbolType = objDT.Rows[0][conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型(字段类型:varchar,字段长度:100,是否可空:False)
 objFR_CodeSymbolEN.SymbolExportType = objDT.Rows[0][conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型(字段类型:varchar,字段长度:100,是否可空:True)
 objFR_CodeSymbolEN.IsExported = TransNullToBool(objDT.Rows[0][conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出(字段类型:bit,字段长度:1,是否可空:True)
 objFR_CodeSymbolEN.LineStart = TransNullToInt(objDT.Rows[0][conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.LineEnd = TransNullToInt(objDT.Rows[0][conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.ColumnStart = TransNullToInt(objDT.Rows[0][conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.ColumnEnd = TransNullToInt(objDT.Rows[0][conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.Signature = objDT.Rows[0][conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:200,是否可空:True)
 objFR_CodeSymbolEN.DocComment = objDT.Rows[0][conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释(字段类型:varchar,字段长度:500,是否可空:True)
 objFR_CodeSymbolEN.CreatedAt = TransNullToDate(objDT.Rows[0][conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetFR_CodeSymbol)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngSymbolId">表关键字</param>
 /// <returns>表对象</returns>
public clsFR_CodeSymbolEN GetObjBySymbolId(long lngSymbolId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where SymbolId = " + ""+ lngSymbolId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
 objFR_CodeSymbolEN.SymbolId = Int32.Parse(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_CodeSymbolEN.FileResourceId = Int32.Parse(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id(字段类型:bigint,字段长度:8,是否可空:False)
 objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称(字段类型:varchar,字段长度:100,是否可空:False)
 objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型(字段类型:varchar,字段长度:100,是否可空:False)
 objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型(字段类型:varchar,字段长度:100,是否可空:True)
 objFR_CodeSymbolEN.IsExported = clsEntityBase2.TransNullToBool_S(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出(字段类型:bit,字段长度:1,是否可空:True)
 objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列(字段类型:int,字段长度:4,是否可空:True)
 objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:200,是否可空:True)
 objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释(字段类型:varchar,字段长度:500,是否可空:True)
 objFR_CodeSymbolEN.CreatedAt = clsEntityBase2.TransNullToDate_S(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetObjBySymbolId)", objException.Message));
}
return objFR_CodeSymbolEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFR_CodeSymbolEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN()
{
SymbolId = TransNullToInt(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()), //符号Id
FileResourceId = TransNullToInt(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()), //文件资源Id
SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(), //符号名称
SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(), //符号类型
SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(), //符号导出类型
IsExported = TransNullToBool(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()), //是否导出
LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()), //开始行
LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()), //结束行
ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()), //开始列
ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()), //结束列
Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(), //函数签名
DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(), //文档注释
CreatedAt = TransNullToDate(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()) //建立时间
};
objFR_CodeSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFR_CodeSymbolEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFR_CodeSymbolEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = TransNullToInt(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = TransNullToInt(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = TransNullToBool(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = TransNullToDate(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetObjByDataRowFR_CodeSymbol)", objException.Message));
}
objFR_CodeSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFR_CodeSymbolEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFR_CodeSymbolEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFR_CodeSymbolEN objFR_CodeSymbolEN = new clsFR_CodeSymbolEN();
try
{
objFR_CodeSymbolEN.SymbolId = TransNullToInt(objRow[conFR_CodeSymbol.SymbolId].ToString().Trim()); //符号Id
objFR_CodeSymbolEN.FileResourceId = TransNullToInt(objRow[conFR_CodeSymbol.FileResourceId].ToString().Trim()); //文件资源Id
objFR_CodeSymbolEN.SymbolName = objRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objFR_CodeSymbolEN.SymbolType = objRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objFR_CodeSymbolEN.SymbolExportType = objRow[conFR_CodeSymbol.SymbolExportType] == DBNull.Value ? null : objRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objFR_CodeSymbolEN.IsExported = TransNullToBool(objRow[conFR_CodeSymbol.IsExported].ToString().Trim()); //是否导出
objFR_CodeSymbolEN.LineStart = objRow[conFR_CodeSymbol.LineStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineStart].ToString().Trim()); //开始行
objFR_CodeSymbolEN.LineEnd = objRow[conFR_CodeSymbol.LineEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.LineEnd].ToString().Trim()); //结束行
objFR_CodeSymbolEN.ColumnStart = objRow[conFR_CodeSymbol.ColumnStart] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnStart].ToString().Trim()); //开始列
objFR_CodeSymbolEN.ColumnEnd = objRow[conFR_CodeSymbol.ColumnEnd] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim()); //结束列
objFR_CodeSymbolEN.Signature = objRow[conFR_CodeSymbol.Signature] == DBNull.Value ? null : objRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objFR_CodeSymbolEN.DocComment = objRow[conFR_CodeSymbol.DocComment] == DBNull.Value ? null : objRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objFR_CodeSymbolEN.CreatedAt = TransNullToDate(objRow[conFR_CodeSymbol.CreatedAt].ToString().Trim()); //建立时间
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFR_CodeSymbolDA: GetObjByDataRow)", objException.Message));
}
objFR_CodeSymbolEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFR_CodeSymbolEN;
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
objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFR_CodeSymbolEN._CurrTabName, conFR_CodeSymbol.SymbolId, 8, "");
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
objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFR_CodeSymbolEN._CurrTabName, conFR_CodeSymbol.SymbolId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SymbolId from FR_CodeSymbol where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SymbolId from FR_CodeSymbol where " + strCondition;
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
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngSymbolId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FR_CodeSymbol", "SymbolId = " + ""+ lngSymbolId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("FR_CodeSymbol", strCondition))
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
objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("FR_CodeSymbol");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
 {
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_CodeSymbolEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FR_CodeSymbol");
objRow = objDS.Tables["FR_CodeSymbol"].NewRow();
objRow[conFR_CodeSymbol.FileResourceId] = objFR_CodeSymbolEN.FileResourceId; //文件资源Id
objRow[conFR_CodeSymbol.SymbolName] = objFR_CodeSymbolEN.SymbolName; //符号名称
objRow[conFR_CodeSymbol.SymbolType] = objFR_CodeSymbolEN.SymbolType; //符号类型
 if (objFR_CodeSymbolEN.SymbolExportType !=  "")
 {
objRow[conFR_CodeSymbol.SymbolExportType] = objFR_CodeSymbolEN.SymbolExportType; //符号导出类型
 }
objRow[conFR_CodeSymbol.IsExported] = objFR_CodeSymbolEN.IsExported; //是否导出
objRow[conFR_CodeSymbol.LineStart] = objFR_CodeSymbolEN.LineStart; //开始行
objRow[conFR_CodeSymbol.LineEnd] = objFR_CodeSymbolEN.LineEnd; //结束行
objRow[conFR_CodeSymbol.ColumnStart] = objFR_CodeSymbolEN.ColumnStart; //开始列
objRow[conFR_CodeSymbol.ColumnEnd] = objFR_CodeSymbolEN.ColumnEnd; //结束列
 if (objFR_CodeSymbolEN.Signature !=  "")
 {
objRow[conFR_CodeSymbol.Signature] = objFR_CodeSymbolEN.Signature; //函数签名
 }
 if (objFR_CodeSymbolEN.DocComment !=  "")
 {
objRow[conFR_CodeSymbol.DocComment] = objFR_CodeSymbolEN.DocComment; //文档注释
 }
objRow[conFR_CodeSymbol.CreatedAt] = objFR_CodeSymbolEN.CreatedAt; //建立时间
objDS.Tables[clsFR_CodeSymbolEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFR_CodeSymbolEN._CurrTabName);
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_CodeSymbolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.FileResourceId);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.FileResourceId.ToString());
 
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolName);
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolType);
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolType + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolExportType);
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolExportType + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.IsExported);
 arrValueListForInsert.Add("'" + (objFR_CodeSymbolEN.IsExported  ==  false ? "0" : "1") + "'");
 
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.Signature);
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignature + "'");
 }
 
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.DocComment);
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocComment + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.CreatedAt);
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_CodeSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_CodeSymbolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.FileResourceId);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.FileResourceId.ToString());
 
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolName);
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolType);
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolType + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolExportType);
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolExportType + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.IsExported);
 arrValueListForInsert.Add("'" + (objFR_CodeSymbolEN.IsExported  ==  false ? "0" : "1") + "'");
 
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.Signature);
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignature + "'");
 }
 
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.DocComment);
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocComment + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.CreatedAt);
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_CodeSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFR_CodeSymbolEN objFR_CodeSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_CodeSymbolEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.FileResourceId);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.FileResourceId.ToString());
 
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolName);
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolType);
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolType + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolExportType);
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolExportType + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.IsExported);
 arrValueListForInsert.Add("'" + (objFR_CodeSymbolEN.IsExported  ==  false ? "0" : "1") + "'");
 
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.Signature);
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignature + "'");
 }
 
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.DocComment);
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocComment + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.CreatedAt);
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_CodeSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFR_CodeSymbolEN objFR_CodeSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFR_CodeSymbolEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.FileResourceId);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.FileResourceId.ToString());
 
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolName);
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolType);
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolType + "'");
 }
 
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.SymbolExportType);
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolExportType + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.IsExported);
 arrValueListForInsert.Add("'" + (objFR_CodeSymbolEN.IsExported  ==  false ? "0" : "1") + "'");
 
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.LineEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.LineEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnStart);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnStart.ToString());
 }
 
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.ColumnEnd);
 arrValueListForInsert.Add(objFR_CodeSymbolEN.ColumnEnd.ToString());
 }
 
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.Signature);
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSignature + "'");
 }
 
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 arrFieldListForInsert.Add(conFR_CodeSymbol.DocComment);
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDocComment + "'");
 }
 
 arrFieldListForInsert.Add(conFR_CodeSymbol.CreatedAt);
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into FR_CodeSymbol");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFR_CodeSymbols(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where SymbolId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "FR_CodeSymbol");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngSymbolId = TransNullToInt(oRow[conFR_CodeSymbol.SymbolId].ToString().Trim());
if (IsExist(lngSymbolId))
{
 string strResult = "关键字变量值为:" + string.Format("SymbolId = {0}", lngSymbolId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFR_CodeSymbolEN._CurrTabName ].NewRow();
objRow[conFR_CodeSymbol.FileResourceId] = oRow[conFR_CodeSymbol.FileResourceId].ToString().Trim(); //文件资源Id
objRow[conFR_CodeSymbol.SymbolName] = oRow[conFR_CodeSymbol.SymbolName].ToString().Trim(); //符号名称
objRow[conFR_CodeSymbol.SymbolType] = oRow[conFR_CodeSymbol.SymbolType].ToString().Trim(); //符号类型
objRow[conFR_CodeSymbol.SymbolExportType] = oRow[conFR_CodeSymbol.SymbolExportType].ToString().Trim(); //符号导出类型
objRow[conFR_CodeSymbol.IsExported] = oRow[conFR_CodeSymbol.IsExported].ToString().Trim(); //是否导出
objRow[conFR_CodeSymbol.LineStart] = oRow[conFR_CodeSymbol.LineStart].ToString().Trim(); //开始行
objRow[conFR_CodeSymbol.LineEnd] = oRow[conFR_CodeSymbol.LineEnd].ToString().Trim(); //结束行
objRow[conFR_CodeSymbol.ColumnStart] = oRow[conFR_CodeSymbol.ColumnStart].ToString().Trim(); //开始列
objRow[conFR_CodeSymbol.ColumnEnd] = oRow[conFR_CodeSymbol.ColumnEnd].ToString().Trim(); //结束列
objRow[conFR_CodeSymbol.Signature] = oRow[conFR_CodeSymbol.Signature].ToString().Trim(); //函数签名
objRow[conFR_CodeSymbol.DocComment] = oRow[conFR_CodeSymbol.DocComment].ToString().Trim(); //文档注释
objRow[conFR_CodeSymbol.CreatedAt] = oRow[conFR_CodeSymbol.CreatedAt].ToString().Trim(); //建立时间
 objDS.Tables[clsFR_CodeSymbolEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFR_CodeSymbolEN._CurrTabName);
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
 /// <param name = "objFR_CodeSymbolEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_CodeSymbolEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
strSQL = "Select * from FR_CodeSymbol where SymbolId = " + ""+ objFR_CodeSymbolEN.SymbolId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFR_CodeSymbolEN._CurrTabName);
if (objDS.Tables[clsFR_CodeSymbolEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:SymbolId = " + ""+ objFR_CodeSymbolEN.SymbolId+"");
return false;
}
objRow = objDS.Tables[clsFR_CodeSymbolEN._CurrTabName].Rows[0];
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.FileResourceId))
 {
objRow[conFR_CodeSymbol.FileResourceId] = objFR_CodeSymbolEN.FileResourceId; //文件资源Id
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolName))
 {
objRow[conFR_CodeSymbol.SymbolName] = objFR_CodeSymbolEN.SymbolName; //符号名称
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolType))
 {
objRow[conFR_CodeSymbol.SymbolType] = objFR_CodeSymbolEN.SymbolType; //符号类型
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolExportType))
 {
objRow[conFR_CodeSymbol.SymbolExportType] = objFR_CodeSymbolEN.SymbolExportType; //符号导出类型
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.IsExported))
 {
objRow[conFR_CodeSymbol.IsExported] = objFR_CodeSymbolEN.IsExported; //是否导出
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineStart))
 {
objRow[conFR_CodeSymbol.LineStart] = objFR_CodeSymbolEN.LineStart; //开始行
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineEnd))
 {
objRow[conFR_CodeSymbol.LineEnd] = objFR_CodeSymbolEN.LineEnd; //结束行
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnStart))
 {
objRow[conFR_CodeSymbol.ColumnStart] = objFR_CodeSymbolEN.ColumnStart; //开始列
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnEnd))
 {
objRow[conFR_CodeSymbol.ColumnEnd] = objFR_CodeSymbolEN.ColumnEnd; //结束列
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.Signature))
 {
objRow[conFR_CodeSymbol.Signature] = objFR_CodeSymbolEN.Signature; //函数签名
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.DocComment))
 {
objRow[conFR_CodeSymbol.DocComment] = objFR_CodeSymbolEN.DocComment; //文档注释
 }
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.CreatedAt))
 {
objRow[conFR_CodeSymbol.CreatedAt] = objFR_CodeSymbolEN.CreatedAt; //建立时间
 }
try
{
objDA.Update(objDS, clsFR_CodeSymbolEN._CurrTabName);
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_CodeSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update FR_CodeSymbol Set ");
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.FileResourceId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.FileResourceId, conFR_CodeSymbol.FileResourceId); //文件资源Id
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolName))
 {
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolName, conFR_CodeSymbol.SymbolName); //符号名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.SymbolName); //符号名称
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolType))
 {
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolType, conFR_CodeSymbol.SymbolType); //符号类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.SymbolType); //符号类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolExportType))
 {
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolExportType, conFR_CodeSymbol.SymbolExportType); //符号导出类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.SymbolExportType); //符号导出类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.IsExported))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFR_CodeSymbolEN.IsExported == true?"1":"0", conFR_CodeSymbol.IsExported); //是否导出
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineStart))
 {
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineStart, conFR_CodeSymbol.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineStart); //开始行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineEnd))
 {
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineEnd, conFR_CodeSymbol.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineEnd); //结束行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnStart))
 {
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnStart, conFR_CodeSymbol.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnStart); //开始列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnEnd))
 {
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnEnd, conFR_CodeSymbol.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnEnd); //结束列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.Signature))
 {
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignature, conFR_CodeSymbol.Signature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.Signature); //函数签名
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.DocComment))
 {
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocComment, conFR_CodeSymbol.DocComment); //文档注释
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.DocComment); //文档注释
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.CreatedAt))
 {
 if (objFR_CodeSymbolEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conFR_CodeSymbol.CreatedAt); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.CreatedAt); //建立时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SymbolId = {0}", objFR_CodeSymbolEN.SymbolId); 
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
 /// <param name = "objFR_CodeSymbolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strCondition)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_CodeSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FR_CodeSymbol Set ");
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.FileResourceId))
 {
 sbSQL.AppendFormat(" FileResourceId = {0},", objFR_CodeSymbolEN.FileResourceId); //文件资源Id
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolName))
 {
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolName = '{0}',", strSymbolName); //符号名称
 }
 else
 {
 sbSQL.Append(" SymbolName = null,"); //符号名称
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolType))
 {
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolType = '{0}',", strSymbolType); //符号类型
 }
 else
 {
 sbSQL.Append(" SymbolType = null,"); //符号类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolExportType))
 {
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolExportType = '{0}',", strSymbolExportType); //符号导出类型
 }
 else
 {
 sbSQL.Append(" SymbolExportType = null,"); //符号导出类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.IsExported))
 {
 sbSQL.AppendFormat(" IsExported = '{0}',", objFR_CodeSymbolEN.IsExported == true?"1":"0"); //是否导出
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineStart))
 {
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineStart, conFR_CodeSymbol.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineStart); //开始行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineEnd))
 {
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineEnd, conFR_CodeSymbol.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineEnd); //结束行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnStart))
 {
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnStart, conFR_CodeSymbol.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnStart); //开始列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnEnd))
 {
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnEnd, conFR_CodeSymbol.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnEnd); //结束列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.Signature))
 {
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Signature = '{0}',", strSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" Signature = null,"); //函数签名
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.DocComment))
 {
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocComment = '{0}',", strDocComment); //文档注释
 }
 else
 {
 sbSQL.Append(" DocComment = null,"); //文档注释
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.CreatedAt))
 {
 if (objFR_CodeSymbolEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //建立时间
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //建立时间
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
 /// <param name = "objFR_CodeSymbolEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFR_CodeSymbolEN objFR_CodeSymbolEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_CodeSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FR_CodeSymbol Set ");
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.FileResourceId))
 {
 sbSQL.AppendFormat(" FileResourceId = {0},", objFR_CodeSymbolEN.FileResourceId); //文件资源Id
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolName))
 {
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolName = '{0}',", strSymbolName); //符号名称
 }
 else
 {
 sbSQL.Append(" SymbolName = null,"); //符号名称
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolType))
 {
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolType = '{0}',", strSymbolType); //符号类型
 }
 else
 {
 sbSQL.Append(" SymbolType = null,"); //符号类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolExportType))
 {
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolExportType = '{0}',", strSymbolExportType); //符号导出类型
 }
 else
 {
 sbSQL.Append(" SymbolExportType = null,"); //符号导出类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.IsExported))
 {
 sbSQL.AppendFormat(" IsExported = '{0}',", objFR_CodeSymbolEN.IsExported == true?"1":"0"); //是否导出
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineStart))
 {
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineStart, conFR_CodeSymbol.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineStart); //开始行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineEnd))
 {
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineEnd, conFR_CodeSymbol.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineEnd); //结束行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnStart))
 {
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnStart, conFR_CodeSymbol.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnStart); //开始列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnEnd))
 {
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnEnd, conFR_CodeSymbol.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnEnd); //结束列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.Signature))
 {
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Signature = '{0}',", strSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" Signature = null,"); //函数签名
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.DocComment))
 {
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DocComment = '{0}',", strDocComment); //文档注释
 }
 else
 {
 sbSQL.Append(" DocComment = null,"); //文档注释
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.CreatedAt))
 {
 if (objFR_CodeSymbolEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //建立时间
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //建立时间
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
 /// <param name = "objFR_CodeSymbolEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFR_CodeSymbolEN objFR_CodeSymbolEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objFR_CodeSymbolEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFR_CodeSymbolEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update FR_CodeSymbol Set ");
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.FileResourceId))
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.FileResourceId, conFR_CodeSymbol.FileResourceId); //文件资源Id
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolName))
 {
 if (objFR_CodeSymbolEN.SymbolName !=  null)
 {
 var strSymbolName = objFR_CodeSymbolEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolName, conFR_CodeSymbol.SymbolName); //符号名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.SymbolName); //符号名称
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolType))
 {
 if (objFR_CodeSymbolEN.SymbolType !=  null)
 {
 var strSymbolType = objFR_CodeSymbolEN.SymbolType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolType, conFR_CodeSymbol.SymbolType); //符号类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.SymbolType); //符号类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.SymbolExportType))
 {
 if (objFR_CodeSymbolEN.SymbolExportType !=  null)
 {
 var strSymbolExportType = objFR_CodeSymbolEN.SymbolExportType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolExportType, conFR_CodeSymbol.SymbolExportType); //符号导出类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.SymbolExportType); //符号导出类型
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.IsExported))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFR_CodeSymbolEN.IsExported == true?"1":"0", conFR_CodeSymbol.IsExported); //是否导出
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineStart))
 {
 if (objFR_CodeSymbolEN.LineStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineStart, conFR_CodeSymbol.LineStart); //开始行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineStart); //开始行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.LineEnd))
 {
 if (objFR_CodeSymbolEN.LineEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.LineEnd, conFR_CodeSymbol.LineEnd); //结束行
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.LineEnd); //结束行
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnStart))
 {
 if (objFR_CodeSymbolEN.ColumnStart !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnStart, conFR_CodeSymbol.ColumnStart); //开始列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnStart); //开始列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.ColumnEnd))
 {
 if (objFR_CodeSymbolEN.ColumnEnd !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFR_CodeSymbolEN.ColumnEnd, conFR_CodeSymbol.ColumnEnd); //结束列
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.ColumnEnd); //结束列
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.Signature))
 {
 if (objFR_CodeSymbolEN.Signature !=  null)
 {
 var strSignature = objFR_CodeSymbolEN.Signature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSignature, conFR_CodeSymbol.Signature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.Signature); //函数签名
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.DocComment))
 {
 if (objFR_CodeSymbolEN.DocComment !=  null)
 {
 var strDocComment = objFR_CodeSymbolEN.DocComment.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDocComment, conFR_CodeSymbol.DocComment); //文档注释
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.DocComment); //文档注释
 }
 }
 
 if (objFR_CodeSymbolEN.IsUpdated(conFR_CodeSymbol.CreatedAt))
 {
 if (objFR_CodeSymbolEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objFR_CodeSymbolEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conFR_CodeSymbol.CreatedAt); //建立时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFR_CodeSymbol.CreatedAt); //建立时间
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where SymbolId = {0}", objFR_CodeSymbolEN.SymbolId); 
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
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngSymbolId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngSymbolId,
};
 objSQL.ExecSP("FR_CodeSymbol_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngSymbolId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
//删除FR_CodeSymbol本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FR_CodeSymbol where SymbolId = " + ""+ lngSymbolId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFR_CodeSymbol(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除FR_CodeSymbol本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FR_CodeSymbol where SymbolId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngSymbolId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngSymbolId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
//删除FR_CodeSymbol本表中与当前对象有关的记录
strSQL = strSQL + "Delete from FR_CodeSymbol where SymbolId = " + ""+ lngSymbolId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFR_CodeSymbol(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: DelFR_CodeSymbol)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FR_CodeSymbol where " + strCondition ;
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
public bool DelFR_CodeSymbolWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFR_CodeSymbolDA: DelFR_CodeSymbolWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from FR_CodeSymbol where " + strCondition ;
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
 /// <param name = "objFR_CodeSymbolENS">源对象</param>
 /// <param name = "objFR_CodeSymbolENT">目标对象</param>
public void CopyTo(clsFR_CodeSymbolEN objFR_CodeSymbolENS, clsFR_CodeSymbolEN objFR_CodeSymbolENT)
{
objFR_CodeSymbolENT.SymbolId = objFR_CodeSymbolENS.SymbolId; //符号Id
objFR_CodeSymbolENT.FileResourceId = objFR_CodeSymbolENS.FileResourceId; //文件资源Id
objFR_CodeSymbolENT.SymbolName = objFR_CodeSymbolENS.SymbolName; //符号名称
objFR_CodeSymbolENT.SymbolType = objFR_CodeSymbolENS.SymbolType; //符号类型
objFR_CodeSymbolENT.SymbolExportType = objFR_CodeSymbolENS.SymbolExportType; //符号导出类型
objFR_CodeSymbolENT.IsExported = objFR_CodeSymbolENS.IsExported; //是否导出
objFR_CodeSymbolENT.LineStart = objFR_CodeSymbolENS.LineStart; //开始行
objFR_CodeSymbolENT.LineEnd = objFR_CodeSymbolENS.LineEnd; //结束行
objFR_CodeSymbolENT.ColumnStart = objFR_CodeSymbolENS.ColumnStart; //开始列
objFR_CodeSymbolENT.ColumnEnd = objFR_CodeSymbolENS.ColumnEnd; //结束列
objFR_CodeSymbolENT.Signature = objFR_CodeSymbolENS.Signature; //函数签名
objFR_CodeSymbolENT.DocComment = objFR_CodeSymbolENS.DocComment; //文档注释
objFR_CodeSymbolENT.CreatedAt = objFR_CodeSymbolENS.CreatedAt; //建立时间
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFR_CodeSymbolEN.FileResourceId, conFR_CodeSymbol.FileResourceId);
clsCheckSql.CheckFieldNotNull(objFR_CodeSymbolEN.SymbolName, conFR_CodeSymbol.SymbolName);
clsCheckSql.CheckFieldNotNull(objFR_CodeSymbolEN.SymbolType, conFR_CodeSymbol.SymbolType);
//检查字段长度
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolName, 100, conFR_CodeSymbol.SymbolName);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolType, 100, conFR_CodeSymbol.SymbolType);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolExportType, 100, conFR_CodeSymbol.SymbolExportType);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.Signature, 200, conFR_CodeSymbol.Signature);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.DocComment, 500, conFR_CodeSymbol.DocComment);
//检查字段外键固定长度
 objFR_CodeSymbolEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolName, 100, conFR_CodeSymbol.SymbolName);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolType, 100, conFR_CodeSymbol.SymbolType);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolExportType, 100, conFR_CodeSymbol.SymbolExportType);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.Signature, 200, conFR_CodeSymbol.Signature);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.DocComment, 500, conFR_CodeSymbol.DocComment);
//检查外键字段长度
 objFR_CodeSymbolEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolName, 100, conFR_CodeSymbol.SymbolName);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolType, 100, conFR_CodeSymbol.SymbolType);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.SymbolExportType, 100, conFR_CodeSymbol.SymbolExportType);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.Signature, 200, conFR_CodeSymbol.Signature);
clsCheckSql.CheckFieldLen(objFR_CodeSymbolEN.DocComment, 500, conFR_CodeSymbol.DocComment);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFR_CodeSymbolEN.SymbolName, conFR_CodeSymbol.SymbolName);
clsCheckSql.CheckSqlInjection4Field(objFR_CodeSymbolEN.SymbolType, conFR_CodeSymbol.SymbolType);
clsCheckSql.CheckSqlInjection4Field(objFR_CodeSymbolEN.SymbolExportType, conFR_CodeSymbol.SymbolExportType);
clsCheckSql.CheckSqlInjection4Field(objFR_CodeSymbolEN.Signature, conFR_CodeSymbol.Signature);
clsCheckSql.CheckSqlInjection4Field(objFR_CodeSymbolEN.DocComment, conFR_CodeSymbol.DocComment);
//检查外键字段长度
 objFR_CodeSymbolEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--FR_CodeSymbol(FR_CodeSymbol),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFR_CodeSymbolEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFR_CodeSymbolEN objFR_CodeSymbolEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FileResourceId = '{0}'", objFR_CodeSymbolEN.FileResourceId);
 sbCondition.AppendFormat(" and SymbolName = '{0}'", objFR_CodeSymbolEN.SymbolName);
 sbCondition.AppendFormat(" and SymbolType = '{0}'", objFR_CodeSymbolEN.SymbolType);
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFR_CodeSymbolEN._CurrTabName);
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFR_CodeSymbolEN._CurrTabName, strCondition);
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
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
 objSQL = clsFR_CodeSymbolDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}