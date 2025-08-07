
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlDataSynDA
 表名:SqlDataSyn(00050269)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:28
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:数据同步(DataSynch)
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
 /// Sql数据同步(SqlDataSyn)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSqlDataSynDA : clsCommBase4DA
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
 return clsSqlDataSynEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSqlDataSynEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlDataSynEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSqlDataSynEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSqlDataSynEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strTabId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strTabId)
{
strTabId = strTabId.Replace("'", "''");
if (strTabId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:SqlDataSyn中,检查关键字,长度不正确!(clsSqlDataSynDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SqlDataSyn中,关键字不能为空 或 null!(clsSqlDataSynDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSqlDataSynDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SqlDataSyn(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable_SqlDataSyn)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlDataSyn.* " + 
$"from SqlDataSyn " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlDataSyn.TabId not in " + 
$"(Select top {intTop_In} SqlDataSyn.TabId from SqlDataSyn " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1} and TabId not in (Select top {2} TabId from SqlDataSyn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1} and TabId not in (Select top {3} TabId from SqlDataSyn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSqlDataSynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlDataSyn.* " + 
$"from SqlDataSyn " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlDataSyn.TabId not in " + 
$"(Select top {intTop_In} SqlDataSyn.TabId from SqlDataSyn " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1} and TabId not in (Select top {2} TabId from SqlDataSyn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlDataSyn where {1} and TabId not in (Select top {3} TabId from SqlDataSyn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSqlDataSynEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSqlDataSynDA:GetObjLst)", objException.Message));
}
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlDataSynDA: GetObjLst)", objException.Message));
}
objSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlDataSynEN);
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
public List<clsSqlDataSynEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSqlDataSynDA:GetObjLstByTabName)", objException.Message));
}
List<clsSqlDataSynEN> arrObjLst = new List<clsSqlDataSynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlDataSynDA: GetObjLst)", objException.Message));
}
objSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlDataSynEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSqlDataSyn(ref clsSqlDataSynEN objSqlDataSynEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where TabId = " + "'"+ objSqlDataSynEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSqlDataSynEN.TabId = objDT.Rows[0][conSqlDataSyn.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objSqlDataSynEN.TabName = objDT.Rows[0][conSqlDataSyn.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objSqlDataSynEN.TabCnName = objDT.Rows[0][conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objSqlDataSynEN.TabEnName = objDT.Rows[0][conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objSqlDataSynEN.SqlData = objDT.Rows[0][conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据(字段类型:text,字段长度:2147483647,是否可空:True)
 objSqlDataSynEN.SqlCommandTypeId = objDT.Rows[0][conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlDataSynEN.SqlCommandText = objDT.Rows[0][conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容(字段类型:varchar,字段长度:200,是否可空:True)
 objSqlDataSynEN.SqlDataRecNum = TransNullToInt(objDT.Rows[0][conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数(字段类型:int,字段长度:4,是否可空:True)
 objSqlDataSynEN.TargetTabCondition = objDT.Rows[0][conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件(字段类型:varchar,字段长度:300,是否可空:True)
 objSqlDataSynEN.TargetTabRecNum = TransNullToInt(objDT.Rows[0][conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数(字段类型:int,字段长度:4,是否可空:True)
 objSqlDataSynEN.DataSynDate = objDT.Rows[0][conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objSqlDataSynEN.PrimaryTypeId = objDT.Rows[0][conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objSqlDataSynEN.RecExclusiveWayId = objDT.Rows[0][conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlDataSynEN.TextResouce = objDT.Rows[0][conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objSqlDataSynEN.TextResourceTypeId = objDT.Rows[0][conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlDataSynEN.AnalysisDate = objDT.Rows[0][conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlDataSynEN.PrjId = objDT.Rows[0][conSqlDataSyn.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlDataSynEN.ErrMsg = objDT.Rows[0][conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objSqlDataSynEN.UpdDate = objDT.Rows[0][conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlDataSynEN.UpdUserId = objDT.Rows[0][conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlDataSynEN.Memo = objDT.Rows[0][conSqlDataSyn.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSqlDataSynDA: GetSqlDataSyn)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsSqlDataSynEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
 objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据(字段类型:text,字段长度:2147483647,是否可空:True)
 objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容(字段类型:varchar,字段长度:200,是否可空:True)
 objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数(字段类型:int,字段长度:4,是否可空:True)
 objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件(字段类型:varchar,字段长度:300,是否可空:True)
 objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数(字段类型:int,字段长度:4,是否可空:True)
 objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSqlDataSynDA: GetObjByTabId)", objException.Message));
}
return objSqlDataSynEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSqlDataSynEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSqlDataSynDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN()
{
TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(), //表ID
TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(), //表名
TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(), //表中文名
TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(), //表英文详细名
SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(), //Sql表数据
SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(), //Sql命令类型Id
SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(), //Sql命令内容
SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()), //Sql数据记录数
TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(), //目标表有效记录条件
TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()), //目标表记录数
DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(), //数据同步日期
PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(), //主键类型ID
RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(), //记录排他方式Id
TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(), //文本来源
TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(), //文本来源类型Id
AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(), //分析日期
PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(), //工程Id
ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(), //错误信息
UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim() //说明
};
objSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlDataSynEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSqlDataSynDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSqlDataSynEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSqlDataSynDA: GetObjByDataRowSqlDataSyn)", objException.Message));
}
objSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlDataSynEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSqlDataSynEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlDataSynEN objSqlDataSynEN = new clsSqlDataSynEN();
try
{
objSqlDataSynEN.TabId = objRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objSqlDataSynEN.TabName = objRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objSqlDataSynEN.TabCnName = objRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objSqlDataSynEN.TabEnName = objRow[conSqlDataSyn.TabEnName] == DBNull.Value ? null : objRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objSqlDataSynEN.SqlData = objRow[conSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objSqlDataSynEN.SqlCommandTypeId = objRow[conSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objSqlDataSynEN.SqlCommandText = objRow[conSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objSqlDataSynEN.SqlDataRecNum = objRow[conSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objSqlDataSynEN.TargetTabCondition = objRow[conSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objSqlDataSynEN.TargetTabRecNum = objRow[conSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objSqlDataSynEN.DataSynDate = objRow[conSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objSqlDataSynEN.PrimaryTypeId = objRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objSqlDataSynEN.RecExclusiveWayId = objRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objSqlDataSynEN.TextResouce = objRow[conSqlDataSyn.TextResouce] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objSqlDataSynEN.TextResourceTypeId = objRow[conSqlDataSyn.TextResourceTypeId] == DBNull.Value ? null : objRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objSqlDataSynEN.AnalysisDate = objRow[conSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objSqlDataSynEN.PrjId = objRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objSqlDataSynEN.ErrMsg = objRow[conSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objSqlDataSynEN.UpdDate = objRow[conSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objSqlDataSynEN.UpdUserId = objRow[conSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objSqlDataSynEN.Memo = objRow[conSqlDataSyn.Memo] == DBNull.Value ? null : objRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSqlDataSynDA: GetObjByDataRow)", objException.Message));
}
objSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlDataSynEN;
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
objSQL = clsSqlDataSynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlDataSynEN._CurrTabName, conSqlDataSyn.TabId, 8, "");
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
objSQL = clsSqlDataSynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlDataSynEN._CurrTabName, conSqlDataSyn.TabId, 8, strPrefix);
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from SqlDataSyn where " + strCondition;
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from SqlDataSyn where " + strCondition;
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strTabId)
{
CheckPrimaryKey(strTabId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlDataSyn", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSqlDataSynDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlDataSyn", strCondition))
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
objSQL = clsSqlDataSynDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SqlDataSyn");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSqlDataSynEN objSqlDataSynEN)
 {
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlDataSynEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlDataSyn");
objRow = objDS.Tables["SqlDataSyn"].NewRow();
objRow[conSqlDataSyn.TabId] = objSqlDataSynEN.TabId; //表ID
objRow[conSqlDataSyn.TabName] = objSqlDataSynEN.TabName; //表名
objRow[conSqlDataSyn.TabCnName] = objSqlDataSynEN.TabCnName; //表中文名
 if (objSqlDataSynEN.TabEnName !=  "")
 {
objRow[conSqlDataSyn.TabEnName] = objSqlDataSynEN.TabEnName; //表英文详细名
 }
 if (objSqlDataSynEN.SqlData !=  "")
 {
objRow[conSqlDataSyn.SqlData] = objSqlDataSynEN.SqlData; //Sql表数据
 }
 if (objSqlDataSynEN.SqlCommandTypeId !=  "")
 {
objRow[conSqlDataSyn.SqlCommandTypeId] = objSqlDataSynEN.SqlCommandTypeId; //Sql命令类型Id
 }
 if (objSqlDataSynEN.SqlCommandText !=  "")
 {
objRow[conSqlDataSyn.SqlCommandText] = objSqlDataSynEN.SqlCommandText; //Sql命令内容
 }
objRow[conSqlDataSyn.SqlDataRecNum] = objSqlDataSynEN.SqlDataRecNum; //Sql数据记录数
 if (objSqlDataSynEN.TargetTabCondition !=  "")
 {
objRow[conSqlDataSyn.TargetTabCondition] = objSqlDataSynEN.TargetTabCondition; //目标表有效记录条件
 }
objRow[conSqlDataSyn.TargetTabRecNum] = objSqlDataSynEN.TargetTabRecNum; //目标表记录数
 if (objSqlDataSynEN.DataSynDate !=  "")
 {
objRow[conSqlDataSyn.DataSynDate] = objSqlDataSynEN.DataSynDate; //数据同步日期
 }
objRow[conSqlDataSyn.PrimaryTypeId] = objSqlDataSynEN.PrimaryTypeId; //主键类型ID
objRow[conSqlDataSyn.RecExclusiveWayId] = objSqlDataSynEN.RecExclusiveWayId; //记录排他方式Id
 if (objSqlDataSynEN.TextResouce !=  "")
 {
objRow[conSqlDataSyn.TextResouce] = objSqlDataSynEN.TextResouce; //文本来源
 }
 if (objSqlDataSynEN.TextResourceTypeId !=  "")
 {
objRow[conSqlDataSyn.TextResourceTypeId] = objSqlDataSynEN.TextResourceTypeId; //文本来源类型Id
 }
 if (objSqlDataSynEN.AnalysisDate !=  "")
 {
objRow[conSqlDataSyn.AnalysisDate] = objSqlDataSynEN.AnalysisDate; //分析日期
 }
objRow[conSqlDataSyn.PrjId] = objSqlDataSynEN.PrjId; //工程Id
 if (objSqlDataSynEN.ErrMsg !=  "")
 {
objRow[conSqlDataSyn.ErrMsg] = objSqlDataSynEN.ErrMsg; //错误信息
 }
 if (objSqlDataSynEN.UpdDate !=  "")
 {
objRow[conSqlDataSyn.UpdDate] = objSqlDataSynEN.UpdDate; //修改日期
 }
 if (objSqlDataSynEN.UpdUserId !=  "")
 {
objRow[conSqlDataSyn.UpdUserId] = objSqlDataSynEN.UpdUserId; //修改用户Id
 }
 if (objSqlDataSynEN.Memo !=  "")
 {
objRow[conSqlDataSyn.Memo] = objSqlDataSynEN.Memo; //说明
 }
objDS.Tables[clsSqlDataSynEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSqlDataSynEN._CurrTabName);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlDataSynEN objSqlDataSynEN)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlDataSynEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlDataSynEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabId);
 var strTabId = objSqlDataSynEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlDataSynEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabName);
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabCnName);
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabEnName);
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 if (objSqlDataSynEN.SqlData !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlData);
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlData + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandTypeId);
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandTypeId + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandText);
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandText + "'");
 }
 
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlDataRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.SqlDataRecNum.ToString());
 }
 
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabCondition);
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetTabCondition + "'");
 }
 
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.TargetTabRecNum.ToString());
 }
 
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.DataSynDate);
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataSynDate + "'");
 }
 
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrimaryTypeId);
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.RecExclusiveWayId);
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecExclusiveWayId + "'");
 }
 
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResouce);
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResouce + "'");
 }
 
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResourceTypeId);
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResourceTypeId + "'");
 }
 
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.AnalysisDate);
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnalysisDate + "'");
 }
 
 if (objSqlDataSynEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrjId);
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.ErrMsg);
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdDate);
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdUserId);
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlDataSynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.Memo);
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlDataSyn");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlDataSynEN objSqlDataSynEN)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlDataSynEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlDataSynEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabId);
 var strTabId = objSqlDataSynEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlDataSynEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabName);
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabCnName);
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabEnName);
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 if (objSqlDataSynEN.SqlData !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlData);
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlData + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandTypeId);
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandTypeId + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandText);
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandText + "'");
 }
 
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlDataRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.SqlDataRecNum.ToString());
 }
 
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabCondition);
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetTabCondition + "'");
 }
 
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.TargetTabRecNum.ToString());
 }
 
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.DataSynDate);
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataSynDate + "'");
 }
 
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrimaryTypeId);
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.RecExclusiveWayId);
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecExclusiveWayId + "'");
 }
 
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResouce);
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResouce + "'");
 }
 
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResourceTypeId);
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResourceTypeId + "'");
 }
 
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.AnalysisDate);
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnalysisDate + "'");
 }
 
 if (objSqlDataSynEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrjId);
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.ErrMsg);
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdDate);
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdUserId);
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlDataSynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.Memo);
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlDataSyn");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSqlDataSynEN.TabId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlDataSynEN objSqlDataSynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlDataSynEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlDataSynEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabId);
 var strTabId = objSqlDataSynEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlDataSynEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabName);
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabCnName);
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabEnName);
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 if (objSqlDataSynEN.SqlData !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlData);
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlData + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandTypeId);
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandTypeId + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandText);
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandText + "'");
 }
 
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlDataRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.SqlDataRecNum.ToString());
 }
 
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabCondition);
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetTabCondition + "'");
 }
 
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.TargetTabRecNum.ToString());
 }
 
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.DataSynDate);
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataSynDate + "'");
 }
 
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrimaryTypeId);
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.RecExclusiveWayId);
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecExclusiveWayId + "'");
 }
 
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResouce);
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResouce + "'");
 }
 
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResourceTypeId);
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResourceTypeId + "'");
 }
 
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.AnalysisDate);
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnalysisDate + "'");
 }
 
 if (objSqlDataSynEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrjId);
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.ErrMsg);
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdDate);
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdUserId);
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlDataSynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.Memo);
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlDataSyn");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSqlDataSynEN.TabId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlDataSynEN objSqlDataSynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlDataSynEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlDataSynEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabId);
 var strTabId = objSqlDataSynEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlDataSynEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabName);
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabCnName);
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TabEnName);
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 if (objSqlDataSynEN.SqlData !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlData);
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlData + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandTypeId);
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandTypeId + "'");
 }
 
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlCommandText);
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlCommandText + "'");
 }
 
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.SqlDataRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.SqlDataRecNum.ToString());
 }
 
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabCondition);
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetTabCondition + "'");
 }
 
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TargetTabRecNum);
 arrValueListForInsert.Add(objSqlDataSynEN.TargetTabRecNum.ToString());
 }
 
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.DataSynDate);
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataSynDate + "'");
 }
 
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrimaryTypeId);
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeId + "'");
 }
 
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.RecExclusiveWayId);
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecExclusiveWayId + "'");
 }
 
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResouce);
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResouce + "'");
 }
 
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.TextResourceTypeId);
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTextResourceTypeId + "'");
 }
 
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.AnalysisDate);
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAnalysisDate + "'");
 }
 
 if (objSqlDataSynEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.PrjId);
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.ErrMsg);
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdDate);
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.UpdUserId);
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlDataSynEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlDataSyn.Memo);
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlDataSyn");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSqlDataSyns(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where TabId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlDataSyn");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTabId = oRow[conSqlDataSyn.TabId].ToString().Trim();
if (IsExist(strTabId))
{
 string strResult = "关键字变量值为:" + string.Format("TabId = {0}", strTabId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSqlDataSynEN._CurrTabName ].NewRow();
objRow[conSqlDataSyn.TabId] = oRow[conSqlDataSyn.TabId].ToString().Trim(); //表ID
objRow[conSqlDataSyn.TabName] = oRow[conSqlDataSyn.TabName].ToString().Trim(); //表名
objRow[conSqlDataSyn.TabCnName] = oRow[conSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objRow[conSqlDataSyn.TabEnName] = oRow[conSqlDataSyn.TabEnName].ToString().Trim(); //表英文详细名
objRow[conSqlDataSyn.SqlData] = oRow[conSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objRow[conSqlDataSyn.SqlCommandTypeId] = oRow[conSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objRow[conSqlDataSyn.SqlCommandText] = oRow[conSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objRow[conSqlDataSyn.SqlDataRecNum] = oRow[conSqlDataSyn.SqlDataRecNum].ToString().Trim(); //Sql数据记录数
objRow[conSqlDataSyn.TargetTabCondition] = oRow[conSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objRow[conSqlDataSyn.TargetTabRecNum] = oRow[conSqlDataSyn.TargetTabRecNum].ToString().Trim(); //目标表记录数
objRow[conSqlDataSyn.DataSynDate] = oRow[conSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objRow[conSqlDataSyn.PrimaryTypeId] = oRow[conSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objRow[conSqlDataSyn.RecExclusiveWayId] = oRow[conSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objRow[conSqlDataSyn.TextResouce] = oRow[conSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objRow[conSqlDataSyn.TextResourceTypeId] = oRow[conSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objRow[conSqlDataSyn.AnalysisDate] = oRow[conSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objRow[conSqlDataSyn.PrjId] = oRow[conSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objRow[conSqlDataSyn.ErrMsg] = oRow[conSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objRow[conSqlDataSyn.UpdDate] = oRow[conSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objRow[conSqlDataSyn.UpdUserId] = oRow[conSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSqlDataSyn.Memo] = oRow[conSqlDataSyn.Memo].ToString().Trim(); //说明
 objDS.Tables[clsSqlDataSynEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSqlDataSynEN._CurrTabName);
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
 /// <param name = "objSqlDataSynEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSqlDataSynEN objSqlDataSynEN)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlDataSynEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from SqlDataSyn where TabId = " + "'"+ objSqlDataSynEN.TabId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSqlDataSynEN._CurrTabName);
if (objDS.Tables[clsSqlDataSynEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TabId = " + "'"+ objSqlDataSynEN.TabId+"'");
return false;
}
objRow = objDS.Tables[clsSqlDataSynEN._CurrTabName].Rows[0];
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabId))
 {
objRow[conSqlDataSyn.TabId] = objSqlDataSynEN.TabId; //表ID
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabName))
 {
objRow[conSqlDataSyn.TabName] = objSqlDataSynEN.TabName; //表名
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabCnName))
 {
objRow[conSqlDataSyn.TabCnName] = objSqlDataSynEN.TabCnName; //表中文名
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabEnName))
 {
objRow[conSqlDataSyn.TabEnName] = objSqlDataSynEN.TabEnName; //表英文详细名
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlData))
 {
objRow[conSqlDataSyn.SqlData] = objSqlDataSynEN.SqlData; //Sql表数据
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandTypeId))
 {
objRow[conSqlDataSyn.SqlCommandTypeId] = objSqlDataSynEN.SqlCommandTypeId; //Sql命令类型Id
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandText))
 {
objRow[conSqlDataSyn.SqlCommandText] = objSqlDataSynEN.SqlCommandText; //Sql命令内容
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlDataRecNum))
 {
objRow[conSqlDataSyn.SqlDataRecNum] = objSqlDataSynEN.SqlDataRecNum; //Sql数据记录数
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabCondition))
 {
objRow[conSqlDataSyn.TargetTabCondition] = objSqlDataSynEN.TargetTabCondition; //目标表有效记录条件
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabRecNum))
 {
objRow[conSqlDataSyn.TargetTabRecNum] = objSqlDataSynEN.TargetTabRecNum; //目标表记录数
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.DataSynDate))
 {
objRow[conSqlDataSyn.DataSynDate] = objSqlDataSynEN.DataSynDate; //数据同步日期
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrimaryTypeId))
 {
objRow[conSqlDataSyn.PrimaryTypeId] = objSqlDataSynEN.PrimaryTypeId; //主键类型ID
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.RecExclusiveWayId))
 {
objRow[conSqlDataSyn.RecExclusiveWayId] = objSqlDataSynEN.RecExclusiveWayId; //记录排他方式Id
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResouce))
 {
objRow[conSqlDataSyn.TextResouce] = objSqlDataSynEN.TextResouce; //文本来源
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResourceTypeId))
 {
objRow[conSqlDataSyn.TextResourceTypeId] = objSqlDataSynEN.TextResourceTypeId; //文本来源类型Id
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.AnalysisDate))
 {
objRow[conSqlDataSyn.AnalysisDate] = objSqlDataSynEN.AnalysisDate; //分析日期
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrjId))
 {
objRow[conSqlDataSyn.PrjId] = objSqlDataSynEN.PrjId; //工程Id
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.ErrMsg))
 {
objRow[conSqlDataSyn.ErrMsg] = objSqlDataSynEN.ErrMsg; //错误信息
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdDate))
 {
objRow[conSqlDataSyn.UpdDate] = objSqlDataSynEN.UpdDate; //修改日期
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdUserId))
 {
objRow[conSqlDataSyn.UpdUserId] = objSqlDataSynEN.UpdUserId; //修改用户Id
 }
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.Memo))
 {
objRow[conSqlDataSyn.Memo] = objSqlDataSynEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsSqlDataSynEN._CurrTabName);
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlDataSynEN objSqlDataSynEN)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlDataSynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SqlDataSyn Set ");
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabName))
 {
 if (objSqlDataSynEN.TabName !=  null)
 {
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conSqlDataSyn.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TabName); //表名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabCnName))
 {
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCnName, conSqlDataSyn.TabCnName); //表中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TabCnName); //表中文名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabEnName))
 {
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabEnName, conSqlDataSyn.TabEnName); //表英文详细名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TabEnName); //表英文详细名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlData))
 {
 if (objSqlDataSynEN.SqlData !=  null)
 {
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlData, conSqlDataSyn.SqlData); //Sql表数据
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlData); //Sql表数据
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandTypeId))
 {
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlCommandTypeId, conSqlDataSyn.SqlCommandTypeId); //Sql命令类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlCommandTypeId); //Sql命令类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandText))
 {
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlCommandText, conSqlDataSyn.SqlCommandText); //Sql命令内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlCommandText); //Sql命令内容
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlDataRecNum))
 {
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.SqlDataRecNum, conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabCondition))
 {
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetTabCondition, conSqlDataSyn.TargetTabCondition); //目标表有效记录条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TargetTabCondition); //目标表有效记录条件
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabRecNum))
 {
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.TargetTabRecNum, conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.DataSynDate))
 {
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataSynDate, conSqlDataSyn.DataSynDate); //数据同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.DataSynDate); //数据同步日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrimaryTypeId))
 {
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conSqlDataSyn.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.RecExclusiveWayId))
 {
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecExclusiveWayId, conSqlDataSyn.RecExclusiveWayId); //记录排他方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.RecExclusiveWayId); //记录排他方式Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResouce))
 {
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextResouce, conSqlDataSyn.TextResouce); //文本来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TextResouce); //文本来源
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResourceTypeId))
 {
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextResourceTypeId, conSqlDataSyn.TextResourceTypeId); //文本来源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TextResourceTypeId); //文本来源类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.AnalysisDate))
 {
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnalysisDate, conSqlDataSyn.AnalysisDate); //分析日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.AnalysisDate); //分析日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrjId))
 {
 if (objSqlDataSynEN.PrjId !=  null)
 {
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSqlDataSyn.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.PrjId); //工程Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.ErrMsg))
 {
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conSqlDataSyn.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.ErrMsg); //错误信息
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdDate))
 {
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSqlDataSyn.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.UpdDate); //修改日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdUserId))
 {
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSqlDataSyn.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.UpdUserId); //修改用户Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.Memo))
 {
 if (objSqlDataSynEN.Memo !=  null)
 {
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSqlDataSyn.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabId = '{0}'", objSqlDataSynEN.TabId); 
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
 /// <param name = "objSqlDataSynEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSqlDataSynEN objSqlDataSynEN, string strCondition)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlDataSynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlDataSyn Set ");
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabName))
 {
 if (objSqlDataSynEN.TabName !=  null)
 {
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabCnName))
 {
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCnName = '{0}',", strTabCnName); //表中文名
 }
 else
 {
 sbSQL.Append(" TabCnName = null,"); //表中文名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabEnName))
 {
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabEnName = '{0}',", strTabEnName); //表英文详细名
 }
 else
 {
 sbSQL.Append(" TabEnName = null,"); //表英文详细名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlData))
 {
 if (objSqlDataSynEN.SqlData !=  null)
 {
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlData = '{0}',", strSqlData); //Sql表数据
 }
 else
 {
 sbSQL.Append(" SqlData = null,"); //Sql表数据
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandTypeId))
 {
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlCommandTypeId = '{0}',", strSqlCommandTypeId); //Sql命令类型Id
 }
 else
 {
 sbSQL.Append(" SqlCommandTypeId = null,"); //Sql命令类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandText))
 {
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlCommandText = '{0}',", strSqlCommandText); //Sql命令内容
 }
 else
 {
 sbSQL.Append(" SqlCommandText = null,"); //Sql命令内容
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlDataRecNum))
 {
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.SqlDataRecNum, conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabCondition))
 {
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetTabCondition = '{0}',", strTargetTabCondition); //目标表有效记录条件
 }
 else
 {
 sbSQL.Append(" TargetTabCondition = null,"); //目标表有效记录条件
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabRecNum))
 {
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.TargetTabRecNum, conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.DataSynDate))
 {
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataSynDate = '{0}',", strDataSynDate); //数据同步日期
 }
 else
 {
 sbSQL.Append(" DataSynDate = null,"); //数据同步日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrimaryTypeId))
 {
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.RecExclusiveWayId))
 {
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecExclusiveWayId = '{0}',", strRecExclusiveWayId); //记录排他方式Id
 }
 else
 {
 sbSQL.Append(" RecExclusiveWayId = null,"); //记录排他方式Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResouce))
 {
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextResouce = '{0}',", strTextResouce); //文本来源
 }
 else
 {
 sbSQL.Append(" TextResouce = null,"); //文本来源
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResourceTypeId))
 {
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextResourceTypeId = '{0}',", strTextResourceTypeId); //文本来源类型Id
 }
 else
 {
 sbSQL.Append(" TextResourceTypeId = null,"); //文本来源类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.AnalysisDate))
 {
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnalysisDate = '{0}',", strAnalysisDate); //分析日期
 }
 else
 {
 sbSQL.Append(" AnalysisDate = null,"); //分析日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrjId))
 {
 if (objSqlDataSynEN.PrjId !=  null)
 {
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.ErrMsg))
 {
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdDate))
 {
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdUserId))
 {
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.Memo))
 {
 if (objSqlDataSynEN.Memo !=  null)
 {
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSqlDataSynEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSqlDataSynEN objSqlDataSynEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlDataSynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlDataSyn Set ");
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabName))
 {
 if (objSqlDataSynEN.TabName !=  null)
 {
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabCnName))
 {
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCnName = '{0}',", strTabCnName); //表中文名
 }
 else
 {
 sbSQL.Append(" TabCnName = null,"); //表中文名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabEnName))
 {
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabEnName = '{0}',", strTabEnName); //表英文详细名
 }
 else
 {
 sbSQL.Append(" TabEnName = null,"); //表英文详细名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlData))
 {
 if (objSqlDataSynEN.SqlData !=  null)
 {
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlData = '{0}',", strSqlData); //Sql表数据
 }
 else
 {
 sbSQL.Append(" SqlData = null,"); //Sql表数据
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandTypeId))
 {
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlCommandTypeId = '{0}',", strSqlCommandTypeId); //Sql命令类型Id
 }
 else
 {
 sbSQL.Append(" SqlCommandTypeId = null,"); //Sql命令类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandText))
 {
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlCommandText = '{0}',", strSqlCommandText); //Sql命令内容
 }
 else
 {
 sbSQL.Append(" SqlCommandText = null,"); //Sql命令内容
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlDataRecNum))
 {
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.SqlDataRecNum, conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabCondition))
 {
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetTabCondition = '{0}',", strTargetTabCondition); //目标表有效记录条件
 }
 else
 {
 sbSQL.Append(" TargetTabCondition = null,"); //目标表有效记录条件
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabRecNum))
 {
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.TargetTabRecNum, conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.DataSynDate))
 {
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataSynDate = '{0}',", strDataSynDate); //数据同步日期
 }
 else
 {
 sbSQL.Append(" DataSynDate = null,"); //数据同步日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrimaryTypeId))
 {
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeId = '{0}',", strPrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.Append(" PrimaryTypeId = null,"); //主键类型ID
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.RecExclusiveWayId))
 {
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecExclusiveWayId = '{0}',", strRecExclusiveWayId); //记录排他方式Id
 }
 else
 {
 sbSQL.Append(" RecExclusiveWayId = null,"); //记录排他方式Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResouce))
 {
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextResouce = '{0}',", strTextResouce); //文本来源
 }
 else
 {
 sbSQL.Append(" TextResouce = null,"); //文本来源
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResourceTypeId))
 {
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TextResourceTypeId = '{0}',", strTextResourceTypeId); //文本来源类型Id
 }
 else
 {
 sbSQL.Append(" TextResourceTypeId = null,"); //文本来源类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.AnalysisDate))
 {
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AnalysisDate = '{0}',", strAnalysisDate); //分析日期
 }
 else
 {
 sbSQL.Append(" AnalysisDate = null,"); //分析日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrjId))
 {
 if (objSqlDataSynEN.PrjId !=  null)
 {
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.ErrMsg))
 {
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdDate))
 {
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdUserId))
 {
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.Memo))
 {
 if (objSqlDataSynEN.Memo !=  null)
 {
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSqlDataSynEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlDataSynEN objSqlDataSynEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSqlDataSynEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlDataSynEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlDataSynEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlDataSyn Set ");
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabName))
 {
 if (objSqlDataSynEN.TabName !=  null)
 {
 var strTabName = objSqlDataSynEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conSqlDataSyn.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TabName); //表名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabCnName))
 {
 if (objSqlDataSynEN.TabCnName !=  null)
 {
 var strTabCnName = objSqlDataSynEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCnName, conSqlDataSyn.TabCnName); //表中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TabCnName); //表中文名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TabEnName))
 {
 if (objSqlDataSynEN.TabEnName !=  null)
 {
 var strTabEnName = objSqlDataSynEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabEnName, conSqlDataSyn.TabEnName); //表英文详细名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TabEnName); //表英文详细名
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlData))
 {
 if (objSqlDataSynEN.SqlData !=  null)
 {
 var strSqlData = objSqlDataSynEN.SqlData.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlData, conSqlDataSyn.SqlData); //Sql表数据
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlData); //Sql表数据
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandTypeId))
 {
 if (objSqlDataSynEN.SqlCommandTypeId !=  null)
 {
 var strSqlCommandTypeId = objSqlDataSynEN.SqlCommandTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlCommandTypeId, conSqlDataSyn.SqlCommandTypeId); //Sql命令类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlCommandTypeId); //Sql命令类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlCommandText))
 {
 if (objSqlDataSynEN.SqlCommandText !=  null)
 {
 var strSqlCommandText = objSqlDataSynEN.SqlCommandText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlCommandText, conSqlDataSyn.SqlCommandText); //Sql命令内容
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlCommandText); //Sql命令内容
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.SqlDataRecNum))
 {
 if (objSqlDataSynEN.SqlDataRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.SqlDataRecNum, conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.SqlDataRecNum); //Sql数据记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabCondition))
 {
 if (objSqlDataSynEN.TargetTabCondition !=  null)
 {
 var strTargetTabCondition = objSqlDataSynEN.TargetTabCondition.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetTabCondition, conSqlDataSyn.TargetTabCondition); //目标表有效记录条件
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TargetTabCondition); //目标表有效记录条件
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TargetTabRecNum))
 {
 if (objSqlDataSynEN.TargetTabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlDataSynEN.TargetTabRecNum, conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TargetTabRecNum); //目标表记录数
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.DataSynDate))
 {
 if (objSqlDataSynEN.DataSynDate !=  null)
 {
 var strDataSynDate = objSqlDataSynEN.DataSynDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataSynDate, conSqlDataSyn.DataSynDate); //数据同步日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.DataSynDate); //数据同步日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrimaryTypeId))
 {
 if (objSqlDataSynEN.PrimaryTypeId !=  null)
 {
 var strPrimaryTypeId = objSqlDataSynEN.PrimaryTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeId, conSqlDataSyn.PrimaryTypeId); //主键类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.PrimaryTypeId); //主键类型ID
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.RecExclusiveWayId))
 {
 if (objSqlDataSynEN.RecExclusiveWayId !=  null)
 {
 var strRecExclusiveWayId = objSqlDataSynEN.RecExclusiveWayId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecExclusiveWayId, conSqlDataSyn.RecExclusiveWayId); //记录排他方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.RecExclusiveWayId); //记录排他方式Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResouce))
 {
 if (objSqlDataSynEN.TextResouce !=  null)
 {
 var strTextResouce = objSqlDataSynEN.TextResouce.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextResouce, conSqlDataSyn.TextResouce); //文本来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TextResouce); //文本来源
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.TextResourceTypeId))
 {
 if (objSqlDataSynEN.TextResourceTypeId !=  null)
 {
 var strTextResourceTypeId = objSqlDataSynEN.TextResourceTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTextResourceTypeId, conSqlDataSyn.TextResourceTypeId); //文本来源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.TextResourceTypeId); //文本来源类型Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.AnalysisDate))
 {
 if (objSqlDataSynEN.AnalysisDate !=  null)
 {
 var strAnalysisDate = objSqlDataSynEN.AnalysisDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAnalysisDate, conSqlDataSyn.AnalysisDate); //分析日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.AnalysisDate); //分析日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.PrjId))
 {
 if (objSqlDataSynEN.PrjId !=  null)
 {
 var strPrjId = objSqlDataSynEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSqlDataSyn.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.PrjId); //工程Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.ErrMsg))
 {
 if (objSqlDataSynEN.ErrMsg !=  null)
 {
 var strErrMsg = objSqlDataSynEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conSqlDataSyn.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.ErrMsg); //错误信息
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdDate))
 {
 if (objSqlDataSynEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlDataSynEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSqlDataSyn.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.UpdDate); //修改日期
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.UpdUserId))
 {
 if (objSqlDataSynEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlDataSynEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSqlDataSyn.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.UpdUserId); //修改用户Id
 }
 }
 
 if (objSqlDataSynEN.IsUpdated(conSqlDataSyn.Memo))
 {
 if (objSqlDataSynEN.Memo !=  null)
 {
 var strMemo = objSqlDataSynEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSqlDataSyn.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlDataSyn.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabId = '{0}'", objSqlDataSynEN.TabId); 
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTabId) 
{
CheckPrimaryKey(strTabId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTabId,
};
 objSQL.ExecSP("SqlDataSyn_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTabId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTabId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
//删除SqlDataSyn本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlDataSyn where TabId = " + "'"+ strTabId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSqlDataSyn(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
//删除SqlDataSyn本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlDataSyn where TabId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTabId) 
{
CheckPrimaryKey(strTabId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
//删除SqlDataSyn本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlDataSyn where TabId = " + "'"+ strTabId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSqlDataSyn(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSqlDataSynDA: DelSqlDataSyn)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlDataSyn where " + strCondition ;
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
public bool DelSqlDataSynWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSqlDataSynDA: DelSqlDataSynWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlDataSyn where " + strCondition ;
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
 /// <param name = "objSqlDataSynENS">源对象</param>
 /// <param name = "objSqlDataSynENT">目标对象</param>
public void CopyTo(clsSqlDataSynEN objSqlDataSynENS, clsSqlDataSynEN objSqlDataSynENT)
{
objSqlDataSynENT.TabId = objSqlDataSynENS.TabId; //表ID
objSqlDataSynENT.TabName = objSqlDataSynENS.TabName; //表名
objSqlDataSynENT.TabCnName = objSqlDataSynENS.TabCnName; //表中文名
objSqlDataSynENT.TabEnName = objSqlDataSynENS.TabEnName; //表英文详细名
objSqlDataSynENT.SqlData = objSqlDataSynENS.SqlData; //Sql表数据
objSqlDataSynENT.SqlCommandTypeId = objSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objSqlDataSynENT.SqlCommandText = objSqlDataSynENS.SqlCommandText; //Sql命令内容
objSqlDataSynENT.SqlDataRecNum = objSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objSqlDataSynENT.TargetTabCondition = objSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objSqlDataSynENT.TargetTabRecNum = objSqlDataSynENS.TargetTabRecNum; //目标表记录数
objSqlDataSynENT.DataSynDate = objSqlDataSynENS.DataSynDate; //数据同步日期
objSqlDataSynENT.PrimaryTypeId = objSqlDataSynENS.PrimaryTypeId; //主键类型ID
objSqlDataSynENT.RecExclusiveWayId = objSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objSqlDataSynENT.TextResouce = objSqlDataSynENS.TextResouce; //文本来源
objSqlDataSynENT.TextResourceTypeId = objSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objSqlDataSynENT.AnalysisDate = objSqlDataSynENS.AnalysisDate; //分析日期
objSqlDataSynENT.PrjId = objSqlDataSynENS.PrjId; //工程Id
objSqlDataSynENT.ErrMsg = objSqlDataSynENS.ErrMsg; //错误信息
objSqlDataSynENT.UpdDate = objSqlDataSynENS.UpdDate; //修改日期
objSqlDataSynENT.UpdUserId = objSqlDataSynENS.UpdUserId; //修改用户Id
objSqlDataSynENT.Memo = objSqlDataSynENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSqlDataSynEN objSqlDataSynEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSqlDataSynEN.TabName, conSqlDataSyn.TabName);
clsCheckSql.CheckFieldNotNull(objSqlDataSynEN.TabCnName, conSqlDataSyn.TabCnName);
clsCheckSql.CheckFieldNotNull(objSqlDataSynEN.PrimaryTypeId, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldNotNull(objSqlDataSynEN.RecExclusiveWayId, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldNotNull(objSqlDataSynEN.PrjId, conSqlDataSyn.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabId, 8, conSqlDataSyn.TabId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabName, 100, conSqlDataSyn.TabName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabCnName, 200, conSqlDataSyn.TabCnName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabEnName, 200, conSqlDataSyn.TabEnName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.SqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.SqlCommandText, 200, conSqlDataSyn.SqlCommandText);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TargetTabCondition, 300, conSqlDataSyn.TargetTabCondition);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.DataSynDate, 14, conSqlDataSyn.DataSynDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.PrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.RecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TextResouce, 100, conSqlDataSyn.TextResouce);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.AnalysisDate, 20, conSqlDataSyn.AnalysisDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.PrjId, 4, conSqlDataSyn.PrjId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.ErrMsg, 2000, conSqlDataSyn.ErrMsg);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.UpdDate, 20, conSqlDataSyn.UpdDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.UpdUserId, 20, conSqlDataSyn.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.Memo, 1000, conSqlDataSyn.Memo);
//检查字段外键固定长度
 objSqlDataSynEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSqlDataSynEN objSqlDataSynEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabName, 100, conSqlDataSyn.TabName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabCnName, 200, conSqlDataSyn.TabCnName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabEnName, 200, conSqlDataSyn.TabEnName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.SqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.SqlCommandText, 200, conSqlDataSyn.SqlCommandText);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TargetTabCondition, 300, conSqlDataSyn.TargetTabCondition);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.DataSynDate, 14, conSqlDataSyn.DataSynDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.PrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.RecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TextResouce, 100, conSqlDataSyn.TextResouce);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.AnalysisDate, 20, conSqlDataSyn.AnalysisDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.PrjId, 4, conSqlDataSyn.PrjId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.ErrMsg, 2000, conSqlDataSyn.ErrMsg);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.UpdDate, 20, conSqlDataSyn.UpdDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.UpdUserId, 20, conSqlDataSyn.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.Memo, 1000, conSqlDataSyn.Memo);
//检查外键字段长度
 objSqlDataSynEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSqlDataSynEN objSqlDataSynEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabId, 8, conSqlDataSyn.TabId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabName, 100, conSqlDataSyn.TabName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabCnName, 200, conSqlDataSyn.TabCnName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TabEnName, 200, conSqlDataSyn.TabEnName);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.SqlCommandTypeId, 2, conSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.SqlCommandText, 200, conSqlDataSyn.SqlCommandText);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TargetTabCondition, 300, conSqlDataSyn.TargetTabCondition);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.DataSynDate, 14, conSqlDataSyn.DataSynDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.PrimaryTypeId, 2, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.RecExclusiveWayId, 4, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TextResouce, 100, conSqlDataSyn.TextResouce);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.TextResourceTypeId, 2, conSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.AnalysisDate, 20, conSqlDataSyn.AnalysisDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.PrjId, 4, conSqlDataSyn.PrjId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.ErrMsg, 2000, conSqlDataSyn.ErrMsg);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.UpdDate, 20, conSqlDataSyn.UpdDate);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.UpdUserId, 20, conSqlDataSyn.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlDataSynEN.Memo, 1000, conSqlDataSyn.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TabId, conSqlDataSyn.TabId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TabName, conSqlDataSyn.TabName);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TabCnName, conSqlDataSyn.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TabEnName, conSqlDataSyn.TabEnName);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.SqlCommandTypeId, conSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.SqlCommandText, conSqlDataSyn.SqlCommandText);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TargetTabCondition, conSqlDataSyn.TargetTabCondition);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.DataSynDate, conSqlDataSyn.DataSynDate);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.PrimaryTypeId, conSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.RecExclusiveWayId, conSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TextResouce, conSqlDataSyn.TextResouce);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.TextResourceTypeId, conSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.AnalysisDate, conSqlDataSyn.AnalysisDate);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.PrjId, conSqlDataSyn.PrjId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.ErrMsg, conSqlDataSyn.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.UpdDate, conSqlDataSyn.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.UpdUserId, conSqlDataSyn.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSqlDataSynEN.Memo, conSqlDataSyn.Memo);
//检查外键字段长度
 objSqlDataSynEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlDataSynEN._CurrTabName);
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlDataSynEN._CurrTabName, strCondition);
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
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
 objSQL = clsSqlDataSynDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}