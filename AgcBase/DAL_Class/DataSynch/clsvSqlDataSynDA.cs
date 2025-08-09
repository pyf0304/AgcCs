
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlDataSynDA
 表名:vSqlDataSyn(00050271)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:18
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// vSql数据同步(vSqlDataSyn)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSqlDataSynDA : clsCommBase4DA
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
 return clsvSqlDataSynEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSqlDataSynEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlDataSynEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSqlDataSynEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSqlDataSynEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vSqlDataSyn中,检查关键字,长度不正确!(clsvSqlDataSynDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSqlDataSyn中,关键字不能为空 或 null!(clsvSqlDataSynDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSqlDataSynDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSqlDataSyn(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable_vSqlDataSyn)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlDataSyn.* " + 
$"from vSqlDataSyn " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlDataSyn.TabId not in " + 
$"(Select top {intTop_In} vSqlDataSyn.TabId from vSqlDataSyn " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1} and TabId not in (Select top {2} TabId from vSqlDataSyn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1} and TabId not in (Select top {3} TabId from vSqlDataSyn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlDataSyn.* " + 
$"from vSqlDataSyn " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlDataSyn.TabId not in " + 
$"(Select top {intTop_In} vSqlDataSyn.TabId from vSqlDataSyn " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1} and TabId not in (Select top {2} TabId from vSqlDataSyn where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlDataSyn where {1} and TabId not in (Select top {3} TabId from vSqlDataSyn where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSqlDataSynEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSqlDataSynDA:GetObjLst)", objException.Message));
}
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlDataSynDA: GetObjLst)", objException.Message));
}
objvSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlDataSynEN);
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
public List<clsvSqlDataSynEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSqlDataSynDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSqlDataSynEN> arrObjLst = new List<clsvSqlDataSynEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlDataSynDA: GetObjLst)", objException.Message));
}
objvSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlDataSynEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSqlDataSynEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSqlDataSyn(ref clsvSqlDataSynEN objvSqlDataSynEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where TabId = " + "'"+ objvSqlDataSynEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSqlDataSynEN.PrimaryTypeId = objDT.Rows[0][convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvSqlDataSynEN.FieldNum = TransNullToInt(objDT.Rows[0][convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum(字段类型:int,字段长度:4,是否可空:True)
 objvSqlDataSynEN.TabId = objDT.Rows[0][convSqlDataSyn.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvSqlDataSynEN.FuncModuleAgcId = objDT.Rows[0][convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlDataSynEN.Keyword = objDT.Rows[0][convSqlDataSyn.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlDataSynEN.TabTypeId = objDT.Rows[0][convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlDataSynEN.TabTypeName = objDT.Rows[0][convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.FuncModuleName = objDT.Rows[0][convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.TabName = objDT.Rows[0][convSqlDataSyn.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlDataSynEN.TabCnName = objDT.Rows[0][convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlDataSynEN.SqlData = objDT.Rows[0][convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据(字段类型:text,字段长度:2147483647,是否可空:True)
 objvSqlDataSynEN.SqlCommandTypeName = objDT.Rows[0][convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.RecExclusiveWayName = objDT.Rows[0][convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.PrjName = objDT.Rows[0][convSqlDataSyn.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.PrimaryTypeName = objDT.Rows[0][convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.SqlCommandTypeId = objDT.Rows[0][convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlDataSynEN.SqlCommandText = objDT.Rows[0][convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlDataSynEN.SqlDataRecNum = TransNullToInt(objDT.Rows[0][convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数(字段类型:int,字段长度:4,是否可空:True)
 objvSqlDataSynEN.TargetTabCondition = objDT.Rows[0][convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件(字段类型:varchar,字段长度:300,是否可空:True)
 objvSqlDataSynEN.TargetTabRecNum = TransNullToInt(objDT.Rows[0][convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数(字段类型:int,字段长度:4,是否可空:True)
 objvSqlDataSynEN.DataSynDate = objDT.Rows[0][convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvSqlDataSynEN.RecExclusiveWayId = objDT.Rows[0][convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlDataSynEN.TextResouce = objDT.Rows[0][convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlDataSynEN.TextResourceTypeId = objDT.Rows[0][convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlDataSynEN.AnalysisDate = objDT.Rows[0][convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlDataSynEN.PrjId = objDT.Rows[0][convSqlDataSyn.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlDataSynEN.ErrMsg = objDT.Rows[0][convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSqlDataSynEN.UpdDate = objDT.Rows[0][convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlDataSynEN.UpdUserId = objDT.Rows[0][convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlDataSynEN.Memo = objDT.Rows[0][convSqlDataSyn.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSqlDataSynDA: GetvSqlDataSyn)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSqlDataSynEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
 objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID(字段类型:char,字段长度:2,是否可空:False)
 objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum(字段类型:int,字段长度:4,是否可空:True)
 objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据(字段类型:text,字段长度:2147483647,是否可空:True)
 objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数(字段类型:int,字段长度:4,是否可空:True)
 objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件(字段类型:varchar,字段长度:300,是否可空:True)
 objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数(字段类型:int,字段长度:4,是否可空:True)
 objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期(字段类型:varchar,字段长度:14,是否可空:True)
 objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSqlDataSynDA: GetObjByTabId)", objException.Message));
}
return objvSqlDataSynEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSqlDataSynEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSqlDataSynDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
strSQL = "Select * from vSqlDataSyn where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN()
{
PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(), //主键类型ID
FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.FieldNum].ToString().Trim()), //FieldNum
TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(), //表ID
FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(), //功能模块Id
Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(), //表类型Id
TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(), //表类型名
FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(), //功能模块名称
TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(), //表名
TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(), //表中文名
SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(), //Sql表数据
SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(), //Sql命令类型名称
RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(), //记录排他方式名称
PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(), //工程名称
PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(), //主键类型名
SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(), //Sql命令类型Id
SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(), //Sql命令内容
SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()), //Sql数据记录数
TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(), //目标表有效记录条件
TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()), //目标表记录数
DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(), //数据同步日期
RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(), //记录排他方式Id
TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(), //文本来源
TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(), //文本来源类型Id
AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(), //分析日期
PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(), //工程Id
ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(), //错误信息
UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim() //说明
};
objvSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlDataSynEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSqlDataSynDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSqlDataSynEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSqlDataSynDA: GetObjByDataRowvSqlDataSyn)", objException.Message));
}
objvSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlDataSynEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSqlDataSynEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlDataSynEN objvSqlDataSynEN = new clsvSqlDataSynEN();
try
{
objvSqlDataSynEN.PrimaryTypeId = objRow[convSqlDataSyn.PrimaryTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeId].ToString().Trim(); //主键类型ID
objvSqlDataSynEN.FieldNum = objRow[convSqlDataSyn.FieldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.FieldNum].ToString().Trim()); //FieldNum
objvSqlDataSynEN.TabId = objRow[convSqlDataSyn.TabId].ToString().Trim(); //表ID
objvSqlDataSynEN.FuncModuleAgcId = objRow[convSqlDataSyn.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlDataSynEN.Keyword = objRow[convSqlDataSyn.Keyword] == DBNull.Value ? null : objRow[convSqlDataSyn.Keyword].ToString().Trim(); //关键字
objvSqlDataSynEN.TabTypeId = objRow[convSqlDataSyn.TabTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeId].ToString().Trim(); //表类型Id
objvSqlDataSynEN.TabTypeName = objRow[convSqlDataSyn.TabTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabTypeName].ToString().Trim(); //表类型名
objvSqlDataSynEN.FuncModuleName = objRow[convSqlDataSyn.FuncModuleName] == DBNull.Value ? null : objRow[convSqlDataSyn.FuncModuleName].ToString().Trim(); //功能模块名称
objvSqlDataSynEN.TabName = objRow[convSqlDataSyn.TabName].ToString().Trim(); //表名
objvSqlDataSynEN.TabCnName = objRow[convSqlDataSyn.TabCnName] == DBNull.Value ? null : objRow[convSqlDataSyn.TabCnName].ToString().Trim(); //表中文名
objvSqlDataSynEN.SqlData = objRow[convSqlDataSyn.SqlData] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlData].ToString().Trim(); //Sql表数据
objvSqlDataSynEN.SqlCommandTypeName = objRow[convSqlDataSyn.SqlCommandTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeName].ToString().Trim(); //Sql命令类型名称
objvSqlDataSynEN.RecExclusiveWayName = objRow[convSqlDataSyn.RecExclusiveWayName] == DBNull.Value ? null : objRow[convSqlDataSyn.RecExclusiveWayName].ToString().Trim(); //记录排他方式名称
objvSqlDataSynEN.PrjName = objRow[convSqlDataSyn.PrjName].ToString().Trim(); //工程名称
objvSqlDataSynEN.PrimaryTypeName = objRow[convSqlDataSyn.PrimaryTypeName] == DBNull.Value ? null : objRow[convSqlDataSyn.PrimaryTypeName].ToString().Trim(); //主键类型名
objvSqlDataSynEN.SqlCommandTypeId = objRow[convSqlDataSyn.SqlCommandTypeId] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandTypeId].ToString().Trim(); //Sql命令类型Id
objvSqlDataSynEN.SqlCommandText = objRow[convSqlDataSyn.SqlCommandText] == DBNull.Value ? null : objRow[convSqlDataSyn.SqlCommandText].ToString().Trim(); //Sql命令内容
objvSqlDataSynEN.SqlDataRecNum = objRow[convSqlDataSyn.SqlDataRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.SqlDataRecNum].ToString().Trim()); //Sql数据记录数
objvSqlDataSynEN.TargetTabCondition = objRow[convSqlDataSyn.TargetTabCondition] == DBNull.Value ? null : objRow[convSqlDataSyn.TargetTabCondition].ToString().Trim(); //目标表有效记录条件
objvSqlDataSynEN.TargetTabRecNum = objRow[convSqlDataSyn.TargetTabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlDataSyn.TargetTabRecNum].ToString().Trim()); //目标表记录数
objvSqlDataSynEN.DataSynDate = objRow[convSqlDataSyn.DataSynDate] == DBNull.Value ? null : objRow[convSqlDataSyn.DataSynDate].ToString().Trim(); //数据同步日期
objvSqlDataSynEN.RecExclusiveWayId = objRow[convSqlDataSyn.RecExclusiveWayId].ToString().Trim(); //记录排他方式Id
objvSqlDataSynEN.TextResouce = objRow[convSqlDataSyn.TextResouce].ToString().Trim(); //文本来源
objvSqlDataSynEN.TextResourceTypeId = objRow[convSqlDataSyn.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlDataSynEN.AnalysisDate = objRow[convSqlDataSyn.AnalysisDate] == DBNull.Value ? null : objRow[convSqlDataSyn.AnalysisDate].ToString().Trim(); //分析日期
objvSqlDataSynEN.PrjId = objRow[convSqlDataSyn.PrjId].ToString().Trim(); //工程Id
objvSqlDataSynEN.ErrMsg = objRow[convSqlDataSyn.ErrMsg] == DBNull.Value ? null : objRow[convSqlDataSyn.ErrMsg].ToString().Trim(); //错误信息
objvSqlDataSynEN.UpdDate = objRow[convSqlDataSyn.UpdDate] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdDate].ToString().Trim(); //修改日期
objvSqlDataSynEN.UpdUserId = objRow[convSqlDataSyn.UpdUserId] == DBNull.Value ? null : objRow[convSqlDataSyn.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlDataSynEN.Memo = objRow[convSqlDataSyn.Memo] == DBNull.Value ? null : objRow[convSqlDataSyn.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSqlDataSynDA: GetObjByDataRow)", objException.Message));
}
objvSqlDataSynEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlDataSynEN;
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
objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlDataSynEN._CurrTabName, convSqlDataSyn.TabId, 8, "");
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
objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlDataSynEN._CurrTabName, convSqlDataSyn.TabId, 8, strPrefix);
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vSqlDataSyn where " + strCondition;
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vSqlDataSyn where " + strCondition;
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlDataSyn", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSqlDataSynDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlDataSyn", strCondition))
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
objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSqlDataSyn");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSqlDataSynENS">源对象</param>
 /// <param name = "objvSqlDataSynENT">目标对象</param>
public void CopyTo(clsvSqlDataSynEN objvSqlDataSynENS, clsvSqlDataSynEN objvSqlDataSynENT)
{
objvSqlDataSynENT.PrimaryTypeId = objvSqlDataSynENS.PrimaryTypeId; //主键类型ID
objvSqlDataSynENT.FieldNum = objvSqlDataSynENS.FieldNum; //FieldNum
objvSqlDataSynENT.TabId = objvSqlDataSynENS.TabId; //表ID
objvSqlDataSynENT.FuncModuleAgcId = objvSqlDataSynENS.FuncModuleAgcId; //功能模块Id
objvSqlDataSynENT.Keyword = objvSqlDataSynENS.Keyword; //关键字
objvSqlDataSynENT.TabTypeId = objvSqlDataSynENS.TabTypeId; //表类型Id
objvSqlDataSynENT.TabTypeName = objvSqlDataSynENS.TabTypeName; //表类型名
objvSqlDataSynENT.FuncModuleName = objvSqlDataSynENS.FuncModuleName; //功能模块名称
objvSqlDataSynENT.TabName = objvSqlDataSynENS.TabName; //表名
objvSqlDataSynENT.TabCnName = objvSqlDataSynENS.TabCnName; //表中文名
objvSqlDataSynENT.SqlData = objvSqlDataSynENS.SqlData; //Sql表数据
objvSqlDataSynENT.SqlCommandTypeName = objvSqlDataSynENS.SqlCommandTypeName; //Sql命令类型名称
objvSqlDataSynENT.RecExclusiveWayName = objvSqlDataSynENS.RecExclusiveWayName; //记录排他方式名称
objvSqlDataSynENT.PrjName = objvSqlDataSynENS.PrjName; //工程名称
objvSqlDataSynENT.PrimaryTypeName = objvSqlDataSynENS.PrimaryTypeName; //主键类型名
objvSqlDataSynENT.SqlCommandTypeId = objvSqlDataSynENS.SqlCommandTypeId; //Sql命令类型Id
objvSqlDataSynENT.SqlCommandText = objvSqlDataSynENS.SqlCommandText; //Sql命令内容
objvSqlDataSynENT.SqlDataRecNum = objvSqlDataSynENS.SqlDataRecNum; //Sql数据记录数
objvSqlDataSynENT.TargetTabCondition = objvSqlDataSynENS.TargetTabCondition; //目标表有效记录条件
objvSqlDataSynENT.TargetTabRecNum = objvSqlDataSynENS.TargetTabRecNum; //目标表记录数
objvSqlDataSynENT.DataSynDate = objvSqlDataSynENS.DataSynDate; //数据同步日期
objvSqlDataSynENT.RecExclusiveWayId = objvSqlDataSynENS.RecExclusiveWayId; //记录排他方式Id
objvSqlDataSynENT.TextResouce = objvSqlDataSynENS.TextResouce; //文本来源
objvSqlDataSynENT.TextResourceTypeId = objvSqlDataSynENS.TextResourceTypeId; //文本来源类型Id
objvSqlDataSynENT.AnalysisDate = objvSqlDataSynENS.AnalysisDate; //分析日期
objvSqlDataSynENT.PrjId = objvSqlDataSynENS.PrjId; //工程Id
objvSqlDataSynENT.ErrMsg = objvSqlDataSynENS.ErrMsg; //错误信息
objvSqlDataSynENT.UpdDate = objvSqlDataSynENS.UpdDate; //修改日期
objvSqlDataSynENT.UpdUserId = objvSqlDataSynENS.UpdUserId; //修改用户Id
objvSqlDataSynENT.Memo = objvSqlDataSynENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSqlDataSynEN objvSqlDataSynEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.PrimaryTypeId, 2, convSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TabId, 8, convSqlDataSyn.TabId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.FuncModuleAgcId, 8, convSqlDataSyn.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.Keyword, 50, convSqlDataSyn.Keyword);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TabTypeId, 4, convSqlDataSyn.TabTypeId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TabTypeName, 30, convSqlDataSyn.TabTypeName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.FuncModuleName, 30, convSqlDataSyn.FuncModuleName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TabName, 100, convSqlDataSyn.TabName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TabCnName, 200, convSqlDataSyn.TabCnName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.SqlCommandTypeName, 30, convSqlDataSyn.SqlCommandTypeName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.RecExclusiveWayName, 30, convSqlDataSyn.RecExclusiveWayName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.PrjName, 30, convSqlDataSyn.PrjName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.PrimaryTypeName, 30, convSqlDataSyn.PrimaryTypeName);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.SqlCommandTypeId, 2, convSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.SqlCommandText, 200, convSqlDataSyn.SqlCommandText);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TargetTabCondition, 300, convSqlDataSyn.TargetTabCondition);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.DataSynDate, 14, convSqlDataSyn.DataSynDate);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.RecExclusiveWayId, 4, convSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TextResouce, 100, convSqlDataSyn.TextResouce);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.TextResourceTypeId, 2, convSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.AnalysisDate, 20, convSqlDataSyn.AnalysisDate);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.PrjId, 4, convSqlDataSyn.PrjId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.ErrMsg, 2000, convSqlDataSyn.ErrMsg);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.UpdDate, 20, convSqlDataSyn.UpdDate);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.UpdUserId, 20, convSqlDataSyn.UpdUserId);
clsCheckSql.CheckFieldLen(objvSqlDataSynEN.Memo, 1000, convSqlDataSyn.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.PrimaryTypeId, convSqlDataSyn.PrimaryTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TabId, convSqlDataSyn.TabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.FuncModuleAgcId, convSqlDataSyn.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.Keyword, convSqlDataSyn.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TabTypeId, convSqlDataSyn.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TabTypeName, convSqlDataSyn.TabTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.FuncModuleName, convSqlDataSyn.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TabName, convSqlDataSyn.TabName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TabCnName, convSqlDataSyn.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.SqlCommandTypeName, convSqlDataSyn.SqlCommandTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.RecExclusiveWayName, convSqlDataSyn.RecExclusiveWayName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.PrjName, convSqlDataSyn.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.PrimaryTypeName, convSqlDataSyn.PrimaryTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.SqlCommandTypeId, convSqlDataSyn.SqlCommandTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.SqlCommandText, convSqlDataSyn.SqlCommandText);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TargetTabCondition, convSqlDataSyn.TargetTabCondition);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.DataSynDate, convSqlDataSyn.DataSynDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.RecExclusiveWayId, convSqlDataSyn.RecExclusiveWayId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TextResouce, convSqlDataSyn.TextResouce);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.TextResourceTypeId, convSqlDataSyn.TextResourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.AnalysisDate, convSqlDataSyn.AnalysisDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.PrjId, convSqlDataSyn.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.ErrMsg, convSqlDataSyn.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.UpdDate, convSqlDataSyn.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.UpdUserId, convSqlDataSyn.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSqlDataSynEN.Memo, convSqlDataSyn.Memo);
//检查外键字段长度
 objvSqlDataSynEN._IsCheckProperty = true;
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlDataSynEN._CurrTabName);
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlDataSynEN._CurrTabName, strCondition);
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
 objSQL = clsvSqlDataSynDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}