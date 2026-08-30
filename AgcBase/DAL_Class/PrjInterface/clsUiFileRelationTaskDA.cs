
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationTaskDA
 表名:UiFileRelationTask(00050655)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:49:53
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// UiFileRelationTask(UiFileRelationTask)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUiFileRelationTaskDA : clsCommBase4DA
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
 return clsUiFileRelationTaskEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUiFileRelationTaskEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUiFileRelationTaskEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUiFileRelationTaskEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUiFileRelationTaskEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UiFileRelationTask(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable_UiFileRelationTask)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UiFileRelationTask.* " + 
$"from UiFileRelationTask " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UiFileRelationTask.TaskId not in " + 
$"(Select top {intTop_In} UiFileRelationTask.TaskId from UiFileRelationTask " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1} and TaskId not in (Select top {2} TaskId from UiFileRelationTask where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1} and TaskId not in (Select top {3} TaskId from UiFileRelationTask where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UiFileRelationTask.* " + 
$"from UiFileRelationTask " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UiFileRelationTask.TaskId not in " + 
$"(Select top {intTop_In} UiFileRelationTask.TaskId from UiFileRelationTask " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1} and TaskId not in (Select top {2} TaskId from UiFileRelationTask where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationTask where {1} and TaskId not in (Select top {3} TaskId from UiFileRelationTask where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUiFileRelationTaskEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA:GetObjLst)", objException.Message));
}
List<clsUiFileRelationTaskEN> arrObjLst = new List<clsUiFileRelationTaskEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationTaskEN objUiFileRelationTaskEN = new clsUiFileRelationTaskEN();
try
{
objUiFileRelationTaskEN.TaskId = TransNullToInt(objRow[conUiFileRelationTask.TaskId].ToString().Trim()); //TaskId
objUiFileRelationTaskEN.PrjId = objRow[conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id
objUiFileRelationTaskEN.EntryFilePath = objRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath
objUiFileRelationTaskEN.EntryFileName = objRow[conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName
objUiFileRelationTaskEN.RootPath = objRow[conUiFileRelationTask.RootPath] == DBNull.Value ? null : objRow[conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath
objUiFileRelationTaskEN.MaxDepth = TransNullToInt(objRow[conUiFileRelationTask.MaxDepth].ToString().Trim()); //MaxDepth
objUiFileRelationTaskEN.StatusId = objRow[conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId
objUiFileRelationTaskEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationTask.CreatedAt].ToString().Trim()); //CreatedAt
objUiFileRelationTaskEN.FinishedAt = TransNullToDate(objRow[conUiFileRelationTask.FinishedAt].ToString().Trim()); //FinishedAt
objUiFileRelationTaskEN.ErrorMsg = objRow[conUiFileRelationTask.ErrorMsg] == DBNull.Value ? null : objRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg
objUiFileRelationTaskEN.RequestJson = objRow[conUiFileRelationTask.RequestJson] == DBNull.Value ? null : objRow[conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetObjLst)", objException.Message));
}
objUiFileRelationTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUiFileRelationTaskEN);
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
public List<clsUiFileRelationTaskEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA:GetObjLstByTabName)", objException.Message));
}
List<clsUiFileRelationTaskEN> arrObjLst = new List<clsUiFileRelationTaskEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationTaskEN objUiFileRelationTaskEN = new clsUiFileRelationTaskEN();
try
{
objUiFileRelationTaskEN.TaskId = TransNullToInt(objRow[conUiFileRelationTask.TaskId].ToString().Trim()); //TaskId
objUiFileRelationTaskEN.PrjId = objRow[conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id
objUiFileRelationTaskEN.EntryFilePath = objRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath
objUiFileRelationTaskEN.EntryFileName = objRow[conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName
objUiFileRelationTaskEN.RootPath = objRow[conUiFileRelationTask.RootPath] == DBNull.Value ? null : objRow[conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath
objUiFileRelationTaskEN.MaxDepth = TransNullToInt(objRow[conUiFileRelationTask.MaxDepth].ToString().Trim()); //MaxDepth
objUiFileRelationTaskEN.StatusId = objRow[conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId
objUiFileRelationTaskEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationTask.CreatedAt].ToString().Trim()); //CreatedAt
objUiFileRelationTaskEN.FinishedAt = TransNullToDate(objRow[conUiFileRelationTask.FinishedAt].ToString().Trim()); //FinishedAt
objUiFileRelationTaskEN.ErrorMsg = objRow[conUiFileRelationTask.ErrorMsg] == DBNull.Value ? null : objRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg
objUiFileRelationTaskEN.RequestJson = objRow[conUiFileRelationTask.RequestJson] == DBNull.Value ? null : objRow[conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetObjLst)", objException.Message));
}
objUiFileRelationTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUiFileRelationTaskEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUiFileRelationTaskEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUiFileRelationTask(ref clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where TaskId = " + ""+ objUiFileRelationTaskEN.TaskId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUiFileRelationTaskEN.TaskId = TransNullToInt(objDT.Rows[0][conUiFileRelationTask.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationTaskEN.PrjId = objDT.Rows[0][conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUiFileRelationTaskEN.EntryFilePath = objDT.Rows[0][conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath(字段类型:nvarchar,字段长度:1000,是否可空:False)
 objUiFileRelationTaskEN.EntryFileName = objDT.Rows[0][conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName(字段类型:nvarchar,字段长度:400,是否可空:False)
 objUiFileRelationTaskEN.RootPath = objDT.Rows[0][conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath(字段类型:nvarchar,字段长度:1000,是否可空:True)
 objUiFileRelationTaskEN.MaxDepth = TransNullToInt(objDT.Rows[0][conUiFileRelationTask.MaxDepth].ToString().Trim()); //MaxDepth(字段类型:int,字段长度:4,是否可空:False)
 objUiFileRelationTaskEN.StatusId = objDT.Rows[0][conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationTaskEN.CreatedAt = TransNullToDate(objDT.Rows[0][conUiFileRelationTask.CreatedAt].ToString().Trim()); //CreatedAt(字段类型:datetime,字段长度:16,是否可空:False)
 objUiFileRelationTaskEN.FinishedAt = TransNullToDate(objDT.Rows[0][conUiFileRelationTask.FinishedAt].ToString().Trim()); //FinishedAt(字段类型:datetime,字段长度:16,是否可空:True)
 objUiFileRelationTaskEN.ErrorMsg = objDT.Rows[0][conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg(字段类型:ntext,字段长度:2147483646,是否可空:True)
 objUiFileRelationTaskEN.RequestJson = objDT.Rows[0][conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson(字段类型:ntext,字段长度:2147483646,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetUiFileRelationTask)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngTaskId">表关键字</param>
 /// <returns>表对象</returns>
public clsUiFileRelationTaskEN GetObjByTaskId(long lngTaskId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where TaskId = " + ""+ lngTaskId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUiFileRelationTaskEN objUiFileRelationTaskEN = new clsUiFileRelationTaskEN();
try
{
 objUiFileRelationTaskEN.TaskId = Int32.Parse(objRow[conUiFileRelationTask.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationTaskEN.PrjId = objRow[conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objUiFileRelationTaskEN.EntryFilePath = objRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath(字段类型:nvarchar,字段长度:1000,是否可空:False)
 objUiFileRelationTaskEN.EntryFileName = objRow[conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName(字段类型:nvarchar,字段长度:400,是否可空:False)
 objUiFileRelationTaskEN.RootPath = objRow[conUiFileRelationTask.RootPath] == DBNull.Value ? null : objRow[conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath(字段类型:nvarchar,字段长度:1000,是否可空:True)
 objUiFileRelationTaskEN.MaxDepth = Int32.Parse(objRow[conUiFileRelationTask.MaxDepth].ToString().Trim()); //MaxDepth(字段类型:int,字段长度:4,是否可空:False)
 objUiFileRelationTaskEN.StatusId = objRow[conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationTaskEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationTask.CreatedAt].ToString().Trim()); //CreatedAt(字段类型:datetime,字段长度:16,是否可空:False)
 objUiFileRelationTaskEN.FinishedAt = clsEntityBase2.TransNullToDate_S(objRow[conUiFileRelationTask.FinishedAt].ToString().Trim()); //FinishedAt(字段类型:datetime,字段长度:16,是否可空:True)
 objUiFileRelationTaskEN.ErrorMsg = objRow[conUiFileRelationTask.ErrorMsg] == DBNull.Value ? null : objRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg(字段类型:ntext,字段长度:2147483646,是否可空:True)
 objUiFileRelationTaskEN.RequestJson = objRow[conUiFileRelationTask.RequestJson] == DBNull.Value ? null : objRow[conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson(字段类型:ntext,字段长度:2147483646,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetObjByTaskId)", objException.Message));
}
return objUiFileRelationTaskEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUiFileRelationTaskEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUiFileRelationTaskEN objUiFileRelationTaskEN = new clsUiFileRelationTaskEN()
{
TaskId = TransNullToInt(objRow[conUiFileRelationTask.TaskId].ToString().Trim()), //TaskId
PrjId = objRow[conUiFileRelationTask.PrjId].ToString().Trim(), //工程Id
EntryFilePath = objRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(), //EntryFilePath
EntryFileName = objRow[conUiFileRelationTask.EntryFileName].ToString().Trim(), //EntryFileName
RootPath = objRow[conUiFileRelationTask.RootPath] == DBNull.Value ? null : objRow[conUiFileRelationTask.RootPath].ToString().Trim(), //RootPath
MaxDepth = TransNullToInt(objRow[conUiFileRelationTask.MaxDepth].ToString().Trim()), //MaxDepth
StatusId = objRow[conUiFileRelationTask.StatusId].ToString().Trim(), //StatusId
CreatedAt = TransNullToDate(objRow[conUiFileRelationTask.CreatedAt].ToString().Trim()), //CreatedAt
FinishedAt = TransNullToDate(objRow[conUiFileRelationTask.FinishedAt].ToString().Trim()), //FinishedAt
ErrorMsg = objRow[conUiFileRelationTask.ErrorMsg] == DBNull.Value ? null : objRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(), //ErrorMsg
RequestJson = objRow[conUiFileRelationTask.RequestJson] == DBNull.Value ? null : objRow[conUiFileRelationTask.RequestJson].ToString().Trim() //RequestJson
};
objUiFileRelationTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationTaskEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUiFileRelationTaskEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUiFileRelationTaskEN objUiFileRelationTaskEN = new clsUiFileRelationTaskEN();
try
{
objUiFileRelationTaskEN.TaskId = TransNullToInt(objRow[conUiFileRelationTask.TaskId].ToString().Trim()); //TaskId
objUiFileRelationTaskEN.PrjId = objRow[conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id
objUiFileRelationTaskEN.EntryFilePath = objRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath
objUiFileRelationTaskEN.EntryFileName = objRow[conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName
objUiFileRelationTaskEN.RootPath = objRow[conUiFileRelationTask.RootPath] == DBNull.Value ? null : objRow[conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath
objUiFileRelationTaskEN.MaxDepth = TransNullToInt(objRow[conUiFileRelationTask.MaxDepth].ToString().Trim()); //MaxDepth
objUiFileRelationTaskEN.StatusId = objRow[conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId
objUiFileRelationTaskEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationTask.CreatedAt].ToString().Trim()); //CreatedAt
objUiFileRelationTaskEN.FinishedAt = TransNullToDate(objRow[conUiFileRelationTask.FinishedAt].ToString().Trim()); //FinishedAt
objUiFileRelationTaskEN.ErrorMsg = objRow[conUiFileRelationTask.ErrorMsg] == DBNull.Value ? null : objRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg
objUiFileRelationTaskEN.RequestJson = objRow[conUiFileRelationTask.RequestJson] == DBNull.Value ? null : objRow[conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetObjByDataRowUiFileRelationTask)", objException.Message));
}
objUiFileRelationTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationTaskEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUiFileRelationTaskEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUiFileRelationTaskEN objUiFileRelationTaskEN = new clsUiFileRelationTaskEN();
try
{
objUiFileRelationTaskEN.TaskId = TransNullToInt(objRow[conUiFileRelationTask.TaskId].ToString().Trim()); //TaskId
objUiFileRelationTaskEN.PrjId = objRow[conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id
objUiFileRelationTaskEN.EntryFilePath = objRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath
objUiFileRelationTaskEN.EntryFileName = objRow[conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName
objUiFileRelationTaskEN.RootPath = objRow[conUiFileRelationTask.RootPath] == DBNull.Value ? null : objRow[conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath
objUiFileRelationTaskEN.MaxDepth = TransNullToInt(objRow[conUiFileRelationTask.MaxDepth].ToString().Trim()); //MaxDepth
objUiFileRelationTaskEN.StatusId = objRow[conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId
objUiFileRelationTaskEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationTask.CreatedAt].ToString().Trim()); //CreatedAt
objUiFileRelationTaskEN.FinishedAt = TransNullToDate(objRow[conUiFileRelationTask.FinishedAt].ToString().Trim()); //FinishedAt
objUiFileRelationTaskEN.ErrorMsg = objRow[conUiFileRelationTask.ErrorMsg] == DBNull.Value ? null : objRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg
objUiFileRelationTaskEN.RequestJson = objRow[conUiFileRelationTask.RequestJson] == DBNull.Value ? null : objRow[conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUiFileRelationTaskDA: GetObjByDataRow)", objException.Message));
}
objUiFileRelationTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationTaskEN;
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
objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUiFileRelationTaskEN._CurrTabName, conUiFileRelationTask.TaskId, 8, "");
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
objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUiFileRelationTaskEN._CurrTabName, conUiFileRelationTask.TaskId, 8, strPrefix);
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TaskId from UiFileRelationTask where " + strCondition;
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TaskId from UiFileRelationTask where " + strCondition;
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngTaskId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UiFileRelationTask", "TaskId = " + ""+ lngTaskId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UiFileRelationTask", strCondition))
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
objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UiFileRelationTask");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
 {
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationTaskEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UiFileRelationTask");
objRow = objDS.Tables["UiFileRelationTask"].NewRow();
objRow[conUiFileRelationTask.PrjId] = objUiFileRelationTaskEN.PrjId; //工程Id
objRow[conUiFileRelationTask.EntryFilePath] = objUiFileRelationTaskEN.EntryFilePath; //EntryFilePath
objRow[conUiFileRelationTask.EntryFileName] = objUiFileRelationTaskEN.EntryFileName; //EntryFileName
 if (objUiFileRelationTaskEN.RootPath !=  "")
 {
objRow[conUiFileRelationTask.RootPath] = objUiFileRelationTaskEN.RootPath; //RootPath
 }
objRow[conUiFileRelationTask.MaxDepth] = objUiFileRelationTaskEN.MaxDepth; //MaxDepth
objRow[conUiFileRelationTask.StatusId] = objUiFileRelationTaskEN.StatusId; //StatusId
objRow[conUiFileRelationTask.CreatedAt] = objUiFileRelationTaskEN.CreatedAt; //CreatedAt
objRow[conUiFileRelationTask.FinishedAt] = objUiFileRelationTaskEN.FinishedAt; //FinishedAt
 if (objUiFileRelationTaskEN.ErrorMsg !=  "")
 {
objRow[conUiFileRelationTask.ErrorMsg] = objUiFileRelationTaskEN.ErrorMsg; //ErrorMsg
 }
 if (objUiFileRelationTaskEN.RequestJson !=  "")
 {
objRow[conUiFileRelationTask.RequestJson] = objUiFileRelationTaskEN.RequestJson; //RequestJson
 }
objDS.Tables[clsUiFileRelationTaskEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUiFileRelationTaskEN._CurrTabName);
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
 /// <param name = "objUiFileRelationTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationTaskEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.PrjId);
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFilePath);
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFilePath + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFileName);
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFileName + "'");
 }
 
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RootPath);
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootPath + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.MaxDepth);
 arrValueListForInsert.Add(objUiFileRelationTaskEN.MaxDepth.ToString());
 
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.StatusId);
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.CreatedAt);
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 
 arrFieldListForInsert.Add(conUiFileRelationTask.FinishedAt);
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 arrValueListForInsert.Add("'" + dteFinishedAt + "'");
 
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.ErrorMsg);
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RequestJson);
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestJson + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationTask");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUiFileRelationTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationTaskEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.PrjId);
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFilePath);
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFilePath + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFileName);
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFileName + "'");
 }
 
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RootPath);
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootPath + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.MaxDepth);
 arrValueListForInsert.Add(objUiFileRelationTaskEN.MaxDepth.ToString());
 
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.StatusId);
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.CreatedAt);
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 
 arrFieldListForInsert.Add(conUiFileRelationTask.FinishedAt);
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 arrValueListForInsert.Add("'" + dteFinishedAt + "'");
 
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.ErrorMsg);
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RequestJson);
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestJson + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationTask");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUiFileRelationTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUiFileRelationTaskEN objUiFileRelationTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationTaskEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.PrjId);
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFilePath);
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFilePath + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFileName);
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFileName + "'");
 }
 
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RootPath);
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootPath + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.MaxDepth);
 arrValueListForInsert.Add(objUiFileRelationTaskEN.MaxDepth.ToString());
 
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.StatusId);
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.CreatedAt);
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 
 arrFieldListForInsert.Add(conUiFileRelationTask.FinishedAt);
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 arrValueListForInsert.Add("'" + dteFinishedAt + "'");
 
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.ErrorMsg);
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RequestJson);
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestJson + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationTask");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUiFileRelationTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUiFileRelationTaskEN objUiFileRelationTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationTaskEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.PrjId);
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFilePath);
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFilePath + "'");
 }
 
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.EntryFileName);
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strEntryFileName + "'");
 }
 
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RootPath);
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRootPath + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.MaxDepth);
 arrValueListForInsert.Add(objUiFileRelationTaskEN.MaxDepth.ToString());
 
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.StatusId);
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatusId + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationTask.CreatedAt);
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 
 arrFieldListForInsert.Add(conUiFileRelationTask.FinishedAt);
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 arrValueListForInsert.Add("'" + dteFinishedAt + "'");
 
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.ErrorMsg);
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationTask.RequestJson);
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRequestJson + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationTask");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUiFileRelationTasks(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where TaskId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UiFileRelationTask");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngTaskId = TransNullToInt(oRow[conUiFileRelationTask.TaskId].ToString().Trim());
if (IsExist(lngTaskId))
{
 string strResult = "关键字变量值为:" + string.Format("TaskId = {0}", lngTaskId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUiFileRelationTaskEN._CurrTabName ].NewRow();
objRow[conUiFileRelationTask.PrjId] = oRow[conUiFileRelationTask.PrjId].ToString().Trim(); //工程Id
objRow[conUiFileRelationTask.EntryFilePath] = oRow[conUiFileRelationTask.EntryFilePath].ToString().Trim(); //EntryFilePath
objRow[conUiFileRelationTask.EntryFileName] = oRow[conUiFileRelationTask.EntryFileName].ToString().Trim(); //EntryFileName
objRow[conUiFileRelationTask.RootPath] = oRow[conUiFileRelationTask.RootPath].ToString().Trim(); //RootPath
objRow[conUiFileRelationTask.MaxDepth] = oRow[conUiFileRelationTask.MaxDepth].ToString().Trim(); //MaxDepth
objRow[conUiFileRelationTask.StatusId] = oRow[conUiFileRelationTask.StatusId].ToString().Trim(); //StatusId
objRow[conUiFileRelationTask.CreatedAt] = oRow[conUiFileRelationTask.CreatedAt].ToString().Trim(); //CreatedAt
objRow[conUiFileRelationTask.FinishedAt] = oRow[conUiFileRelationTask.FinishedAt].ToString().Trim(); //FinishedAt
objRow[conUiFileRelationTask.ErrorMsg] = oRow[conUiFileRelationTask.ErrorMsg].ToString().Trim(); //ErrorMsg
objRow[conUiFileRelationTask.RequestJson] = oRow[conUiFileRelationTask.RequestJson].ToString().Trim(); //RequestJson
 objDS.Tables[clsUiFileRelationTaskEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUiFileRelationTaskEN._CurrTabName);
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
 /// <param name = "objUiFileRelationTaskEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationTaskEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationTask where TaskId = " + ""+ objUiFileRelationTaskEN.TaskId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUiFileRelationTaskEN._CurrTabName);
if (objDS.Tables[clsUiFileRelationTaskEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TaskId = " + ""+ objUiFileRelationTaskEN.TaskId+"");
return false;
}
objRow = objDS.Tables[clsUiFileRelationTaskEN._CurrTabName].Rows[0];
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.PrjId))
 {
objRow[conUiFileRelationTask.PrjId] = objUiFileRelationTaskEN.PrjId; //工程Id
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFilePath))
 {
objRow[conUiFileRelationTask.EntryFilePath] = objUiFileRelationTaskEN.EntryFilePath; //EntryFilePath
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFileName))
 {
objRow[conUiFileRelationTask.EntryFileName] = objUiFileRelationTaskEN.EntryFileName; //EntryFileName
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RootPath))
 {
objRow[conUiFileRelationTask.RootPath] = objUiFileRelationTaskEN.RootPath; //RootPath
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.MaxDepth))
 {
objRow[conUiFileRelationTask.MaxDepth] = objUiFileRelationTaskEN.MaxDepth; //MaxDepth
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.StatusId))
 {
objRow[conUiFileRelationTask.StatusId] = objUiFileRelationTaskEN.StatusId; //StatusId
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.CreatedAt))
 {
objRow[conUiFileRelationTask.CreatedAt] = objUiFileRelationTaskEN.CreatedAt; //CreatedAt
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.FinishedAt))
 {
objRow[conUiFileRelationTask.FinishedAt] = objUiFileRelationTaskEN.FinishedAt; //FinishedAt
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.ErrorMsg))
 {
objRow[conUiFileRelationTask.ErrorMsg] = objUiFileRelationTaskEN.ErrorMsg; //ErrorMsg
 }
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RequestJson))
 {
objRow[conUiFileRelationTask.RequestJson] = objUiFileRelationTaskEN.RequestJson; //RequestJson
 }
try
{
objDA.Update(objDS, clsUiFileRelationTaskEN._CurrTabName);
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
 /// <param name = "objUiFileRelationTaskEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UiFileRelationTask Set ");
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.PrjId))
 {
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUiFileRelationTask.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.PrjId); //工程Id
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFilePath))
 {
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryFilePath, conUiFileRelationTask.EntryFilePath); //EntryFilePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.EntryFilePath); //EntryFilePath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFileName))
 {
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryFileName, conUiFileRelationTask.EntryFileName); //EntryFileName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.EntryFileName); //EntryFileName
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RootPath))
 {
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootPath, conUiFileRelationTask.RootPath); //RootPath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.RootPath); //RootPath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.MaxDepth))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationTaskEN.MaxDepth, conUiFileRelationTask.MaxDepth); //MaxDepth
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.StatusId))
 {
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatusId, conUiFileRelationTask.StatusId); //StatusId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.StatusId); //StatusId
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.CreatedAt))
 {
 if (objUiFileRelationTaskEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conUiFileRelationTask.CreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.CreatedAt); //CreatedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.FinishedAt))
 {
 if (objUiFileRelationTaskEN.FinishedAt !=  null)
 {
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteFinishedAt, conUiFileRelationTask.FinishedAt); //FinishedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.FinishedAt); //FinishedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.ErrorMsg))
 {
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMsg, conUiFileRelationTask.ErrorMsg); //ErrorMsg
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.ErrorMsg); //ErrorMsg
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RequestJson))
 {
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestJson, conUiFileRelationTask.RequestJson); //RequestJson
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.RequestJson); //RequestJson
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TaskId = {0}", objUiFileRelationTaskEN.TaskId); 
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
 /// <param name = "objUiFileRelationTaskEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUiFileRelationTaskEN objUiFileRelationTaskEN, string strCondition)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationTask Set ");
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.PrjId))
 {
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFilePath))
 {
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryFilePath = '{0}',", strEntryFilePath); //EntryFilePath
 }
 else
 {
 sbSQL.Append(" EntryFilePath = null,"); //EntryFilePath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFileName))
 {
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryFileName = '{0}',", strEntryFileName); //EntryFileName
 }
 else
 {
 sbSQL.Append(" EntryFileName = null,"); //EntryFileName
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RootPath))
 {
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootPath = '{0}',", strRootPath); //RootPath
 }
 else
 {
 sbSQL.Append(" RootPath = null,"); //RootPath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.MaxDepth))
 {
 sbSQL.AppendFormat(" MaxDepth = {0},", objUiFileRelationTaskEN.MaxDepth); //MaxDepth
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.StatusId))
 {
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StatusId = '{0}',", strStatusId); //StatusId
 }
 else
 {
 sbSQL.Append(" StatusId = null,"); //StatusId
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.CreatedAt))
 {
 if (objUiFileRelationTaskEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //CreatedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.FinishedAt))
 {
 if (objUiFileRelationTaskEN.FinishedAt !=  null)
 {
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 sbSQL.AppendFormat(" FinishedAt = '{0}',", dteFinishedAt); //FinishedAt
 }
 else
 {
 sbSQL.Append(" FinishedAt = null,"); //FinishedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.ErrorMsg))
 {
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMsg = '{0}',", strErrorMsg); //ErrorMsg
 }
 else
 {
 sbSQL.Append(" ErrorMsg = null,"); //ErrorMsg
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RequestJson))
 {
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestJson = '{0}',", strRequestJson); //RequestJson
 }
 else
 {
 sbSQL.Append(" RequestJson = null,"); //RequestJson
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
 /// <param name = "objUiFileRelationTaskEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUiFileRelationTaskEN objUiFileRelationTaskEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationTask Set ");
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.PrjId))
 {
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFilePath))
 {
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryFilePath = '{0}',", strEntryFilePath); //EntryFilePath
 }
 else
 {
 sbSQL.Append(" EntryFilePath = null,"); //EntryFilePath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFileName))
 {
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" EntryFileName = '{0}',", strEntryFileName); //EntryFileName
 }
 else
 {
 sbSQL.Append(" EntryFileName = null,"); //EntryFileName
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RootPath))
 {
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RootPath = '{0}',", strRootPath); //RootPath
 }
 else
 {
 sbSQL.Append(" RootPath = null,"); //RootPath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.MaxDepth))
 {
 sbSQL.AppendFormat(" MaxDepth = {0},", objUiFileRelationTaskEN.MaxDepth); //MaxDepth
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.StatusId))
 {
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" StatusId = '{0}',", strStatusId); //StatusId
 }
 else
 {
 sbSQL.Append(" StatusId = null,"); //StatusId
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.CreatedAt))
 {
 if (objUiFileRelationTaskEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //CreatedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.FinishedAt))
 {
 if (objUiFileRelationTaskEN.FinishedAt !=  null)
 {
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 sbSQL.AppendFormat(" FinishedAt = '{0}',", dteFinishedAt); //FinishedAt
 }
 else
 {
 sbSQL.Append(" FinishedAt = null,"); //FinishedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.ErrorMsg))
 {
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMsg = '{0}',", strErrorMsg); //ErrorMsg
 }
 else
 {
 sbSQL.Append(" ErrorMsg = null,"); //ErrorMsg
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RequestJson))
 {
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RequestJson = '{0}',", strRequestJson); //RequestJson
 }
 else
 {
 sbSQL.Append(" RequestJson = null,"); //RequestJson
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
 /// <param name = "objUiFileRelationTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUiFileRelationTaskEN objUiFileRelationTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUiFileRelationTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationTask Set ");
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.PrjId))
 {
 if (objUiFileRelationTaskEN.PrjId !=  null)
 {
 var strPrjId = objUiFileRelationTaskEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conUiFileRelationTask.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.PrjId); //工程Id
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFilePath))
 {
 if (objUiFileRelationTaskEN.EntryFilePath !=  null)
 {
 var strEntryFilePath = objUiFileRelationTaskEN.EntryFilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryFilePath, conUiFileRelationTask.EntryFilePath); //EntryFilePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.EntryFilePath); //EntryFilePath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.EntryFileName))
 {
 if (objUiFileRelationTaskEN.EntryFileName !=  null)
 {
 var strEntryFileName = objUiFileRelationTaskEN.EntryFileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strEntryFileName, conUiFileRelationTask.EntryFileName); //EntryFileName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.EntryFileName); //EntryFileName
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RootPath))
 {
 if (objUiFileRelationTaskEN.RootPath !=  null)
 {
 var strRootPath = objUiFileRelationTaskEN.RootPath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRootPath, conUiFileRelationTask.RootPath); //RootPath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.RootPath); //RootPath
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.MaxDepth))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationTaskEN.MaxDepth, conUiFileRelationTask.MaxDepth); //MaxDepth
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.StatusId))
 {
 if (objUiFileRelationTaskEN.StatusId !=  null)
 {
 var strStatusId = objUiFileRelationTaskEN.StatusId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatusId, conUiFileRelationTask.StatusId); //StatusId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.StatusId); //StatusId
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.CreatedAt))
 {
 if (objUiFileRelationTaskEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationTaskEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conUiFileRelationTask.CreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.CreatedAt); //CreatedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.FinishedAt))
 {
 if (objUiFileRelationTaskEN.FinishedAt !=  null)
 {
 var dteFinishedAt = objUiFileRelationTaskEN.FinishedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteFinishedAt, conUiFileRelationTask.FinishedAt); //FinishedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.FinishedAt); //FinishedAt
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.ErrorMsg))
 {
 if (objUiFileRelationTaskEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objUiFileRelationTaskEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMsg, conUiFileRelationTask.ErrorMsg); //ErrorMsg
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.ErrorMsg); //ErrorMsg
 }
 }
 
 if (objUiFileRelationTaskEN.IsUpdated(conUiFileRelationTask.RequestJson))
 {
 if (objUiFileRelationTaskEN.RequestJson !=  null)
 {
 var strRequestJson = objUiFileRelationTaskEN.RequestJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRequestJson, conUiFileRelationTask.RequestJson); //RequestJson
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationTask.RequestJson); //RequestJson
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TaskId = {0}", objUiFileRelationTaskEN.TaskId); 
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngTaskId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngTaskId,
};
 objSQL.ExecSP("UiFileRelationTask_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngTaskId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
//删除UiFileRelationTask本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationTask where TaskId = " + ""+ lngTaskId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUiFileRelationTask(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
//删除UiFileRelationTask本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationTask where TaskId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngTaskId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
//删除UiFileRelationTask本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationTask where TaskId = " + ""+ lngTaskId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUiFileRelationTask(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: DelUiFileRelationTask)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UiFileRelationTask where " + strCondition ;
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
public bool DelUiFileRelationTaskWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUiFileRelationTaskDA: DelUiFileRelationTaskWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UiFileRelationTask where " + strCondition ;
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
 /// <param name = "objUiFileRelationTaskENS">源对象</param>
 /// <param name = "objUiFileRelationTaskENT">目标对象</param>
public void CopyTo(clsUiFileRelationTaskEN objUiFileRelationTaskENS, clsUiFileRelationTaskEN objUiFileRelationTaskENT)
{
objUiFileRelationTaskENT.TaskId = objUiFileRelationTaskENS.TaskId; //TaskId
objUiFileRelationTaskENT.PrjId = objUiFileRelationTaskENS.PrjId; //工程Id
objUiFileRelationTaskENT.EntryFilePath = objUiFileRelationTaskENS.EntryFilePath; //EntryFilePath
objUiFileRelationTaskENT.EntryFileName = objUiFileRelationTaskENS.EntryFileName; //EntryFileName
objUiFileRelationTaskENT.RootPath = objUiFileRelationTaskENS.RootPath; //RootPath
objUiFileRelationTaskENT.MaxDepth = objUiFileRelationTaskENS.MaxDepth; //MaxDepth
objUiFileRelationTaskENT.StatusId = objUiFileRelationTaskENS.StatusId; //StatusId
objUiFileRelationTaskENT.CreatedAt = objUiFileRelationTaskENS.CreatedAt; //CreatedAt
objUiFileRelationTaskENT.FinishedAt = objUiFileRelationTaskENS.FinishedAt; //FinishedAt
objUiFileRelationTaskENT.ErrorMsg = objUiFileRelationTaskENS.ErrorMsg; //ErrorMsg
objUiFileRelationTaskENT.RequestJson = objUiFileRelationTaskENS.RequestJson; //RequestJson
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUiFileRelationTaskEN.PrjId, conUiFileRelationTask.PrjId);
clsCheckSql.CheckFieldNotNull(objUiFileRelationTaskEN.EntryFilePath, conUiFileRelationTask.EntryFilePath);
clsCheckSql.CheckFieldNotNull(objUiFileRelationTaskEN.EntryFileName, conUiFileRelationTask.EntryFileName);
clsCheckSql.CheckFieldNotNull(objUiFileRelationTaskEN.MaxDepth, conUiFileRelationTask.MaxDepth);
clsCheckSql.CheckFieldNotNull(objUiFileRelationTaskEN.StatusId, conUiFileRelationTask.StatusId);
clsCheckSql.CheckFieldNotNull(objUiFileRelationTaskEN.CreatedAt, conUiFileRelationTask.CreatedAt);
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.PrjId, 4, conUiFileRelationTask.PrjId);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.EntryFilePath, 1000, conUiFileRelationTask.EntryFilePath);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.EntryFileName, 400, conUiFileRelationTask.EntryFileName);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.RootPath, 1000, conUiFileRelationTask.RootPath);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.StatusId, 20, conUiFileRelationTask.StatusId);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.ErrorMsg, 2147483646, conUiFileRelationTask.ErrorMsg);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.RequestJson, 2147483646, conUiFileRelationTask.RequestJson);
//检查字段外键固定长度
 objUiFileRelationTaskEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.PrjId, 4, conUiFileRelationTask.PrjId);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.EntryFilePath, 1000, conUiFileRelationTask.EntryFilePath);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.EntryFileName, 400, conUiFileRelationTask.EntryFileName);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.RootPath, 1000, conUiFileRelationTask.RootPath);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.StatusId, 20, conUiFileRelationTask.StatusId);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.ErrorMsg, 2147483646, conUiFileRelationTask.ErrorMsg);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.RequestJson, 2147483646, conUiFileRelationTask.RequestJson);
//检查外键字段长度
 objUiFileRelationTaskEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.PrjId, 4, conUiFileRelationTask.PrjId);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.EntryFilePath, 1000, conUiFileRelationTask.EntryFilePath);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.EntryFileName, 400, conUiFileRelationTask.EntryFileName);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.RootPath, 1000, conUiFileRelationTask.RootPath);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.StatusId, 20, conUiFileRelationTask.StatusId);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.ErrorMsg, 2147483646, conUiFileRelationTask.ErrorMsg);
clsCheckSql.CheckFieldLen(objUiFileRelationTaskEN.RequestJson, 2147483646, conUiFileRelationTask.RequestJson);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.PrjId, conUiFileRelationTask.PrjId);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.EntryFilePath, conUiFileRelationTask.EntryFilePath);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.EntryFileName, conUiFileRelationTask.EntryFileName);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.RootPath, conUiFileRelationTask.RootPath);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.StatusId, conUiFileRelationTask.StatusId);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.ErrorMsg, conUiFileRelationTask.ErrorMsg);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationTaskEN.RequestJson, conUiFileRelationTask.RequestJson);
//检查外键字段长度
 objUiFileRelationTaskEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UiFileRelationTask(UiFileRelationTask),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUiFileRelationTaskEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUiFileRelationTaskEN objUiFileRelationTaskEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objUiFileRelationTaskEN.PrjId);
 sbCondition.AppendFormat(" and EntryFilePath = '{0}'", objUiFileRelationTaskEN.EntryFilePath);
 sbCondition.AppendFormat(" and EntryFileName = '{0}'", objUiFileRelationTaskEN.EntryFileName);
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUiFileRelationTaskEN._CurrTabName);
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUiFileRelationTaskEN._CurrTabName, strCondition);
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationTaskDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}