
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewFldDA
 表名:SqlViewFld(00050249)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:33:33
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:Sql视图管理(SqlViewMan)
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
 /// Sql视图字段(SqlViewFld)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSqlViewFldDA : clsCommBase4DA
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
 return clsSqlViewFldEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSqlViewFldEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlViewFldEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSqlViewFldEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSqlViewFldEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SqlViewFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable_SqlViewFld)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlViewFld.* " + 
$"from SqlViewFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlViewFld.mId not in " + 
$"(Select top {intTop_In} SqlViewFld.mId from SqlViewFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1} and mId not in (Select top {2} mId from SqlViewFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1} and mId not in (Select top {3} mId from SqlViewFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSqlViewFldDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlViewFld.* " + 
$"from SqlViewFld " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlViewFld.mId not in " + 
$"(Select top {intTop_In} SqlViewFld.mId from SqlViewFld " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1} and mId not in (Select top {2} mId from SqlViewFld where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlViewFld where {1} and mId not in (Select top {3} mId from SqlViewFld where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSqlViewFldEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSqlViewFldDA:GetObjLst)", objException.Message));
}
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = TransNullToInt(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = TransNullToInt(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlViewFldDA: GetObjLst)", objException.Message));
}
objSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlViewFldEN);
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
public List<clsSqlViewFldEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSqlViewFldDA:GetObjLstByTabName)", objException.Message));
}
List<clsSqlViewFldEN> arrObjLst = new List<clsSqlViewFldEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = TransNullToInt(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = TransNullToInt(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlViewFldDA: GetObjLst)", objException.Message));
}
objSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlViewFldEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSqlViewFld(ref clsSqlViewFldEN objSqlViewFldEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where mId = " + ""+ objSqlViewFldEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSqlViewFldEN.mId = TransNullToInt(objDT.Rows[0][conSqlViewFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSqlViewFldEN.SqlViewId = objDT.Rows[0][conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewFldEN.RelaTabId = objDT.Rows[0][conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewFldEN.FldId = objDT.Rows[0][conSqlViewFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewFldEN.FldExpression = objDT.Rows[0][conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式(字段类型:varchar,字段长度:500,是否可空:True)
 objSqlViewFldEN.FldExpressionType = objDT.Rows[0][conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType(字段类型:varchar,字段长度:50,是否可空:True)
 objSqlViewFldEN.FieldAliases = objDT.Rows[0][conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名(字段类型:varchar,字段长度:50,是否可空:True)
 objSqlViewFldEN.Filters = objDT.Rows[0][conSqlViewFld.Filters].ToString().Trim(); //筛选器(字段类型:varchar,字段长度:50,是否可空:True)
 objSqlViewFldEN.OrderNum = TransNullToInt(objDT.Rows[0][conSqlViewFld.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objSqlViewFldEN.PrjId = objDT.Rows[0][conSqlViewFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlViewFldEN.UpdDate = objDT.Rows[0][conSqlViewFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewFldEN.UpdUserId = objDT.Rows[0][conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewFldEN.Memo = objDT.Rows[0][conSqlViewFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSqlViewFldDA: GetSqlViewFld)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsSqlViewFldEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
 objSqlViewFldEN.mId = Int32.Parse(objRow[conSqlViewFld.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式(字段类型:varchar,字段长度:500,是否可空:True)
 objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType(字段类型:varchar,字段长度:50,是否可空:True)
 objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名(字段类型:varchar,字段长度:50,是否可空:True)
 objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器(字段类型:varchar,字段长度:50,是否可空:True)
 objSqlViewFldEN.OrderNum = Int32.Parse(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSqlViewFldDA: GetObjBymId)", objException.Message));
}
return objSqlViewFldEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSqlViewFldEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSqlViewFldDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN()
{
mId = TransNullToInt(objRow[conSqlViewFld.mId].ToString().Trim()), //mId
SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(), //Sql视图Id
RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(), //相关表Id
FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(), //字段Id
FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(), //字段表达式
FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(), //FldExpressionType
FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(), //字段别名
Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(), //筛选器
OrderNum = TransNullToInt(objRow[conSqlViewFld.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim() //说明
};
objSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlViewFldEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSqlViewFldDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSqlViewFldEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = TransNullToInt(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = TransNullToInt(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSqlViewFldDA: GetObjByDataRowSqlViewFld)", objException.Message));
}
objSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlViewFldEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSqlViewFldEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlViewFldEN objSqlViewFldEN = new clsSqlViewFldEN();
try
{
objSqlViewFldEN.mId = TransNullToInt(objRow[conSqlViewFld.mId].ToString().Trim()); //mId
objSqlViewFldEN.SqlViewId = objRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewFldEN.RelaTabId = objRow[conSqlViewFld.RelaTabId] == DBNull.Value ? null : objRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewFldEN.FldId = objRow[conSqlViewFld.FldId] == DBNull.Value ? null : objRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objSqlViewFldEN.FldExpression = objRow[conSqlViewFld.FldExpression] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objSqlViewFldEN.FldExpressionType = objRow[conSqlViewFld.FldExpressionType] == DBNull.Value ? null : objRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objSqlViewFldEN.FieldAliases = objRow[conSqlViewFld.FieldAliases] == DBNull.Value ? null : objRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objSqlViewFldEN.Filters = objRow[conSqlViewFld.Filters] == DBNull.Value ? null : objRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objSqlViewFldEN.OrderNum = TransNullToInt(objRow[conSqlViewFld.OrderNum].ToString().Trim()); //序号
objSqlViewFldEN.PrjId = objRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objSqlViewFldEN.UpdDate = objRow[conSqlViewFld.UpdDate] == DBNull.Value ? null : objRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objSqlViewFldEN.UpdUserId = objRow[conSqlViewFld.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewFldEN.Memo = objRow[conSqlViewFld.Memo] == DBNull.Value ? null : objRow[conSqlViewFld.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSqlViewFldDA: GetObjByDataRow)", objException.Message));
}
objSqlViewFldEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlViewFldEN;
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
objSQL = clsSqlViewFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlViewFldEN._CurrTabName, conSqlViewFld.mId, 8, "");
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
objSQL = clsSqlViewFldDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlViewFldEN._CurrTabName, conSqlViewFld.mId, 8, strPrefix);
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from SqlViewFld where " + strCondition;
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from SqlViewFld where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlViewFld", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSqlViewFldDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlViewFld", strCondition))
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
objSQL = clsSqlViewFldDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SqlViewFld");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSqlViewFldEN objSqlViewFldEN)
 {
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewFldEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlViewFld");
objRow = objDS.Tables["SqlViewFld"].NewRow();
objRow[conSqlViewFld.SqlViewId] = objSqlViewFldEN.SqlViewId; //Sql视图Id
 if (objSqlViewFldEN.RelaTabId !=  "")
 {
objRow[conSqlViewFld.RelaTabId] = objSqlViewFldEN.RelaTabId; //相关表Id
 }
 if (objSqlViewFldEN.FldId !=  "")
 {
objRow[conSqlViewFld.FldId] = objSqlViewFldEN.FldId; //字段Id
 }
 if (objSqlViewFldEN.FldExpression !=  "")
 {
objRow[conSqlViewFld.FldExpression] = objSqlViewFldEN.FldExpression; //字段表达式
 }
 if (objSqlViewFldEN.FldExpressionType !=  "")
 {
objRow[conSqlViewFld.FldExpressionType] = objSqlViewFldEN.FldExpressionType; //FldExpressionType
 }
 if (objSqlViewFldEN.FieldAliases !=  "")
 {
objRow[conSqlViewFld.FieldAliases] = objSqlViewFldEN.FieldAliases; //字段别名
 }
 if (objSqlViewFldEN.Filters !=  "")
 {
objRow[conSqlViewFld.Filters] = objSqlViewFldEN.Filters; //筛选器
 }
objRow[conSqlViewFld.OrderNum] = objSqlViewFldEN.OrderNum; //序号
objRow[conSqlViewFld.PrjId] = objSqlViewFldEN.PrjId; //工程Id
 if (objSqlViewFldEN.UpdDate !=  "")
 {
objRow[conSqlViewFld.UpdDate] = objSqlViewFldEN.UpdDate; //修改日期
 }
 if (objSqlViewFldEN.UpdUserId !=  "")
 {
objRow[conSqlViewFld.UpdUserId] = objSqlViewFldEN.UpdUserId; //修改用户Id
 }
 if (objSqlViewFldEN.Memo !=  "")
 {
objRow[conSqlViewFld.Memo] = objSqlViewFldEN.Memo; //说明
 }
objDS.Tables[clsSqlViewFldEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSqlViewFldEN._CurrTabName);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlViewFldEN objSqlViewFldEN)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.SqlViewId);
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.RelaTabId);
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldId);
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpression);
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpression + "'");
 }
 
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpressionType);
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpressionType + "'");
 }
 
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FieldAliases);
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldAliases + "'");
 }
 
 if (objSqlViewFldEN.Filters !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Filters);
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilters + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewFld.OrderNum);
 arrValueListForInsert.Add(objSqlViewFldEN.OrderNum.ToString());
 
 if (objSqlViewFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.PrjId);
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdDate);
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdUserId);
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Memo);
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewFld");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlViewFldEN objSqlViewFldEN)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.SqlViewId);
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.RelaTabId);
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldId);
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpression);
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpression + "'");
 }
 
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpressionType);
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpressionType + "'");
 }
 
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FieldAliases);
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldAliases + "'");
 }
 
 if (objSqlViewFldEN.Filters !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Filters);
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilters + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewFld.OrderNum);
 arrValueListForInsert.Add(objSqlViewFldEN.OrderNum.ToString());
 
 if (objSqlViewFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.PrjId);
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdDate);
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdUserId);
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Memo);
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewFld");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlViewFldEN objSqlViewFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewFldEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.SqlViewId);
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.RelaTabId);
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldId);
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpression);
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpression + "'");
 }
 
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpressionType);
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpressionType + "'");
 }
 
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FieldAliases);
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldAliases + "'");
 }
 
 if (objSqlViewFldEN.Filters !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Filters);
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilters + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewFld.OrderNum);
 arrValueListForInsert.Add(objSqlViewFldEN.OrderNum.ToString());
 
 if (objSqlViewFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.PrjId);
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdDate);
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdUserId);
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Memo);
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewFld");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlViewFldEN objSqlViewFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewFldEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.SqlViewId);
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.RelaTabId);
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewFldEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldId);
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpression);
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpression + "'");
 }
 
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FldExpressionType);
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldExpressionType + "'");
 }
 
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.FieldAliases);
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFieldAliases + "'");
 }
 
 if (objSqlViewFldEN.Filters !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Filters);
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilters + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewFld.OrderNum);
 arrValueListForInsert.Add(objSqlViewFldEN.OrderNum.ToString());
 
 if (objSqlViewFldEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.PrjId);
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdDate);
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.UpdUserId);
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewFldEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewFld.Memo);
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewFld");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSqlViewFlds(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlViewFld");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conSqlViewFld.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSqlViewFldEN._CurrTabName ].NewRow();
objRow[conSqlViewFld.SqlViewId] = oRow[conSqlViewFld.SqlViewId].ToString().Trim(); //Sql视图Id
objRow[conSqlViewFld.RelaTabId] = oRow[conSqlViewFld.RelaTabId].ToString().Trim(); //相关表Id
objRow[conSqlViewFld.FldId] = oRow[conSqlViewFld.FldId].ToString().Trim(); //字段Id
objRow[conSqlViewFld.FldExpression] = oRow[conSqlViewFld.FldExpression].ToString().Trim(); //字段表达式
objRow[conSqlViewFld.FldExpressionType] = oRow[conSqlViewFld.FldExpressionType].ToString().Trim(); //FldExpressionType
objRow[conSqlViewFld.FieldAliases] = oRow[conSqlViewFld.FieldAliases].ToString().Trim(); //字段别名
objRow[conSqlViewFld.Filters] = oRow[conSqlViewFld.Filters].ToString().Trim(); //筛选器
objRow[conSqlViewFld.OrderNum] = oRow[conSqlViewFld.OrderNum].ToString().Trim(); //序号
objRow[conSqlViewFld.PrjId] = oRow[conSqlViewFld.PrjId].ToString().Trim(); //工程Id
objRow[conSqlViewFld.UpdDate] = oRow[conSqlViewFld.UpdDate].ToString().Trim(); //修改日期
objRow[conSqlViewFld.UpdUserId] = oRow[conSqlViewFld.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSqlViewFld.Memo] = oRow[conSqlViewFld.Memo].ToString().Trim(); //说明
 objDS.Tables[clsSqlViewFldEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSqlViewFldEN._CurrTabName);
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
 /// <param name = "objSqlViewFldEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSqlViewFldEN objSqlViewFldEN)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewFldEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewFld where mId = " + ""+ objSqlViewFldEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSqlViewFldEN._CurrTabName);
if (objDS.Tables[clsSqlViewFldEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objSqlViewFldEN.mId+"");
return false;
}
objRow = objDS.Tables[clsSqlViewFldEN._CurrTabName].Rows[0];
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.SqlViewId))
 {
objRow[conSqlViewFld.SqlViewId] = objSqlViewFldEN.SqlViewId; //Sql视图Id
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.RelaTabId))
 {
objRow[conSqlViewFld.RelaTabId] = objSqlViewFldEN.RelaTabId; //相关表Id
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldId))
 {
objRow[conSqlViewFld.FldId] = objSqlViewFldEN.FldId; //字段Id
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpression))
 {
objRow[conSqlViewFld.FldExpression] = objSqlViewFldEN.FldExpression; //字段表达式
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpressionType))
 {
objRow[conSqlViewFld.FldExpressionType] = objSqlViewFldEN.FldExpressionType; //FldExpressionType
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FieldAliases))
 {
objRow[conSqlViewFld.FieldAliases] = objSqlViewFldEN.FieldAliases; //字段别名
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Filters))
 {
objRow[conSqlViewFld.Filters] = objSqlViewFldEN.Filters; //筛选器
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.OrderNum))
 {
objRow[conSqlViewFld.OrderNum] = objSqlViewFldEN.OrderNum; //序号
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.PrjId))
 {
objRow[conSqlViewFld.PrjId] = objSqlViewFldEN.PrjId; //工程Id
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdDate))
 {
objRow[conSqlViewFld.UpdDate] = objSqlViewFldEN.UpdDate; //修改日期
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdUserId))
 {
objRow[conSqlViewFld.UpdUserId] = objSqlViewFldEN.UpdUserId; //修改用户Id
 }
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Memo))
 {
objRow[conSqlViewFld.Memo] = objSqlViewFldEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsSqlViewFldEN._CurrTabName);
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlViewFldEN objSqlViewFldEN)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SqlViewFld Set ");
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.SqlViewId))
 {
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlViewId, conSqlViewFld.SqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.SqlViewId); //Sql视图Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.RelaTabId))
 {
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaTabId, conSqlViewFld.RelaTabId); //相关表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.RelaTabId); //相关表Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldId))
 {
 if (objSqlViewFldEN.FldId !=  null)
 {
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conSqlViewFld.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FldId); //字段Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpression))
 {
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldExpression, conSqlViewFld.FldExpression); //字段表达式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FldExpression); //字段表达式
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpressionType))
 {
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldExpressionType, conSqlViewFld.FldExpressionType); //FldExpressionType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FldExpressionType); //FldExpressionType
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FieldAliases))
 {
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldAliases, conSqlViewFld.FieldAliases); //字段别名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FieldAliases); //字段别名
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Filters))
 {
 if (objSqlViewFldEN.Filters !=  null)
 {
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilters, conSqlViewFld.Filters); //筛选器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.Filters); //筛选器
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlViewFldEN.OrderNum, conSqlViewFld.OrderNum); //序号
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.PrjId))
 {
 if (objSqlViewFldEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSqlViewFld.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.PrjId); //工程Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdDate))
 {
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSqlViewFld.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.UpdDate); //修改日期
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdUserId))
 {
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSqlViewFld.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.UpdUserId); //修改用户Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Memo))
 {
 if (objSqlViewFldEN.Memo !=  null)
 {
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSqlViewFld.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSqlViewFldEN.mId); 
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
 /// <param name = "objSqlViewFldEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSqlViewFldEN objSqlViewFldEN, string strCondition)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlViewFld Set ");
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.SqlViewId))
 {
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlViewId = '{0}',", strSqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.Append(" SqlViewId = null,"); //Sql视图Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.RelaTabId))
 {
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaTabId = '{0}',", strRelaTabId); //相关表Id
 }
 else
 {
 sbSQL.Append(" RelaTabId = null,"); //相关表Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldId))
 {
 if (objSqlViewFldEN.FldId !=  null)
 {
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpression))
 {
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldExpression = '{0}',", strFldExpression); //字段表达式
 }
 else
 {
 sbSQL.Append(" FldExpression = null,"); //字段表达式
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpressionType))
 {
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldExpressionType = '{0}',", strFldExpressionType); //FldExpressionType
 }
 else
 {
 sbSQL.Append(" FldExpressionType = null,"); //FldExpressionType
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FieldAliases))
 {
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldAliases = '{0}',", strFieldAliases); //字段别名
 }
 else
 {
 sbSQL.Append(" FieldAliases = null,"); //字段别名
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Filters))
 {
 if (objSqlViewFldEN.Filters !=  null)
 {
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Filters = '{0}',", strFilters); //筛选器
 }
 else
 {
 sbSQL.Append(" Filters = null,"); //筛选器
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objSqlViewFldEN.OrderNum); //序号
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.PrjId))
 {
 if (objSqlViewFldEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdDate))
 {
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdUserId))
 {
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Memo))
 {
 if (objSqlViewFldEN.Memo !=  null)
 {
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSqlViewFldEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSqlViewFldEN objSqlViewFldEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlViewFld Set ");
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.SqlViewId))
 {
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlViewId = '{0}',", strSqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.Append(" SqlViewId = null,"); //Sql视图Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.RelaTabId))
 {
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaTabId = '{0}',", strRelaTabId); //相关表Id
 }
 else
 {
 sbSQL.Append(" RelaTabId = null,"); //相关表Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldId))
 {
 if (objSqlViewFldEN.FldId !=  null)
 {
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpression))
 {
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldExpression = '{0}',", strFldExpression); //字段表达式
 }
 else
 {
 sbSQL.Append(" FldExpression = null,"); //字段表达式
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpressionType))
 {
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldExpressionType = '{0}',", strFldExpressionType); //FldExpressionType
 }
 else
 {
 sbSQL.Append(" FldExpressionType = null,"); //FldExpressionType
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FieldAliases))
 {
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FieldAliases = '{0}',", strFieldAliases); //字段别名
 }
 else
 {
 sbSQL.Append(" FieldAliases = null,"); //字段别名
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Filters))
 {
 if (objSqlViewFldEN.Filters !=  null)
 {
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Filters = '{0}',", strFilters); //筛选器
 }
 else
 {
 sbSQL.Append(" Filters = null,"); //筛选器
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objSqlViewFldEN.OrderNum); //序号
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.PrjId))
 {
 if (objSqlViewFldEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdDate))
 {
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdUserId))
 {
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Memo))
 {
 if (objSqlViewFldEN.Memo !=  null)
 {
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSqlViewFldEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlViewFldEN objSqlViewFldEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSqlViewFldEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewFldEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewFldEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlViewFld Set ");
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.SqlViewId))
 {
 if (objSqlViewFldEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewFldEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlViewId, conSqlViewFld.SqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.SqlViewId); //Sql视图Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.RelaTabId))
 {
 if (objSqlViewFldEN.RelaTabId !=  null)
 {
 var strRelaTabId = objSqlViewFldEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaTabId, conSqlViewFld.RelaTabId); //相关表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.RelaTabId); //相关表Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldId))
 {
 if (objSqlViewFldEN.FldId !=  null)
 {
 var strFldId = objSqlViewFldEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conSqlViewFld.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FldId); //字段Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpression))
 {
 if (objSqlViewFldEN.FldExpression !=  null)
 {
 var strFldExpression = objSqlViewFldEN.FldExpression.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldExpression, conSqlViewFld.FldExpression); //字段表达式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FldExpression); //字段表达式
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FldExpressionType))
 {
 if (objSqlViewFldEN.FldExpressionType !=  null)
 {
 var strFldExpressionType = objSqlViewFldEN.FldExpressionType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldExpressionType, conSqlViewFld.FldExpressionType); //FldExpressionType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FldExpressionType); //FldExpressionType
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.FieldAliases))
 {
 if (objSqlViewFldEN.FieldAliases !=  null)
 {
 var strFieldAliases = objSqlViewFldEN.FieldAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFieldAliases, conSqlViewFld.FieldAliases); //字段别名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.FieldAliases); //字段别名
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Filters))
 {
 if (objSqlViewFldEN.Filters !=  null)
 {
 var strFilters = objSqlViewFldEN.Filters.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilters, conSqlViewFld.Filters); //筛选器
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.Filters); //筛选器
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlViewFldEN.OrderNum, conSqlViewFld.OrderNum); //序号
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.PrjId))
 {
 if (objSqlViewFldEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewFldEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSqlViewFld.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.PrjId); //工程Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdDate))
 {
 if (objSqlViewFldEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewFldEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSqlViewFld.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.UpdDate); //修改日期
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.UpdUserId))
 {
 if (objSqlViewFldEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewFldEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSqlViewFld.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.UpdUserId); //修改用户Id
 }
 }
 
 if (objSqlViewFldEN.IsUpdated(conSqlViewFld.Memo))
 {
 if (objSqlViewFldEN.Memo !=  null)
 {
 var strMemo = objSqlViewFldEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSqlViewFld.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewFld.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSqlViewFldEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("SqlViewFld_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
//删除SqlViewFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlViewFld where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSqlViewFld(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
//删除SqlViewFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlViewFld where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
//删除SqlViewFld本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlViewFld where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSqlViewFld(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSqlViewFldDA: DelSqlViewFld)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlViewFld where " + strCondition ;
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
public bool DelSqlViewFldWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSqlViewFldDA: DelSqlViewFldWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlViewFld where " + strCondition ;
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
 /// <param name = "objSqlViewFldENS">源对象</param>
 /// <param name = "objSqlViewFldENT">目标对象</param>
public void CopyTo(clsSqlViewFldEN objSqlViewFldENS, clsSqlViewFldEN objSqlViewFldENT)
{
objSqlViewFldENT.mId = objSqlViewFldENS.mId; //mId
objSqlViewFldENT.SqlViewId = objSqlViewFldENS.SqlViewId; //Sql视图Id
objSqlViewFldENT.RelaTabId = objSqlViewFldENS.RelaTabId; //相关表Id
objSqlViewFldENT.FldId = objSqlViewFldENS.FldId; //字段Id
objSqlViewFldENT.FldExpression = objSqlViewFldENS.FldExpression; //字段表达式
objSqlViewFldENT.FldExpressionType = objSqlViewFldENS.FldExpressionType; //FldExpressionType
objSqlViewFldENT.FieldAliases = objSqlViewFldENS.FieldAliases; //字段别名
objSqlViewFldENT.Filters = objSqlViewFldENS.Filters; //筛选器
objSqlViewFldENT.OrderNum = objSqlViewFldENS.OrderNum; //序号
objSqlViewFldENT.PrjId = objSqlViewFldENS.PrjId; //工程Id
objSqlViewFldENT.UpdDate = objSqlViewFldENS.UpdDate; //修改日期
objSqlViewFldENT.UpdUserId = objSqlViewFldENS.UpdUserId; //修改用户Id
objSqlViewFldENT.Memo = objSqlViewFldENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSqlViewFldEN objSqlViewFldEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSqlViewFldEN.SqlViewId, conSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldNotNull(objSqlViewFldEN.OrderNum, conSqlViewFld.OrderNum);
clsCheckSql.CheckFieldNotNull(objSqlViewFldEN.PrjId, conSqlViewFld.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlViewFldEN.SqlViewId, 8, conSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.RelaTabId, 8, conSqlViewFld.RelaTabId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldId, 8, conSqlViewFld.FldId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldExpression, 500, conSqlViewFld.FldExpression);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldExpressionType, 50, conSqlViewFld.FldExpressionType);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FieldAliases, 50, conSqlViewFld.FieldAliases);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.Filters, 50, conSqlViewFld.Filters);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.PrjId, 4, conSqlViewFld.PrjId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.UpdDate, 20, conSqlViewFld.UpdDate);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.UpdUserId, 20, conSqlViewFld.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.Memo, 1000, conSqlViewFld.Memo);
//检查字段外键固定长度
 objSqlViewFldEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSqlViewFldEN objSqlViewFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlViewFldEN.SqlViewId, 8, conSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.RelaTabId, 8, conSqlViewFld.RelaTabId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldId, 8, conSqlViewFld.FldId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldExpression, 500, conSqlViewFld.FldExpression);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldExpressionType, 50, conSqlViewFld.FldExpressionType);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FieldAliases, 50, conSqlViewFld.FieldAliases);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.Filters, 50, conSqlViewFld.Filters);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.PrjId, 4, conSqlViewFld.PrjId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.UpdDate, 20, conSqlViewFld.UpdDate);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.UpdUserId, 20, conSqlViewFld.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.Memo, 1000, conSqlViewFld.Memo);
//检查外键字段长度
 objSqlViewFldEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSqlViewFldEN objSqlViewFldEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlViewFldEN.SqlViewId, 8, conSqlViewFld.SqlViewId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.RelaTabId, 8, conSqlViewFld.RelaTabId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldId, 8, conSqlViewFld.FldId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldExpression, 500, conSqlViewFld.FldExpression);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FldExpressionType, 50, conSqlViewFld.FldExpressionType);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.FieldAliases, 50, conSqlViewFld.FieldAliases);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.Filters, 50, conSqlViewFld.Filters);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.PrjId, 4, conSqlViewFld.PrjId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.UpdDate, 20, conSqlViewFld.UpdDate);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.UpdUserId, 20, conSqlViewFld.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlViewFldEN.Memo, 1000, conSqlViewFld.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.SqlViewId, conSqlViewFld.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.RelaTabId, conSqlViewFld.RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.FldId, conSqlViewFld.FldId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.FldExpression, conSqlViewFld.FldExpression);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.FldExpressionType, conSqlViewFld.FldExpressionType);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.FieldAliases, conSqlViewFld.FieldAliases);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.Filters, conSqlViewFld.Filters);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.PrjId, conSqlViewFld.PrjId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.UpdDate, conSqlViewFld.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.UpdUserId, conSqlViewFld.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewFldEN.Memo, conSqlViewFld.Memo);
//检查外键字段长度
 objSqlViewFldEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SqlViewFld(Sql视图字段),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlViewFldEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSqlViewFldEN objSqlViewFldEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objSqlViewFldEN.PrjId);
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewFldEN.SqlViewId);
 if (objSqlViewFldEN.RelaTabId == null)
{
 sbCondition.AppendFormat(" and RelaTabId is null");
}
else
{
 sbCondition.AppendFormat(" and RelaTabId = '{0}'", objSqlViewFldEN.RelaTabId);
}
 if (objSqlViewFldEN.FldId == null)
{
 sbCondition.AppendFormat(" and FldId is null");
}
else
{
 sbCondition.AppendFormat(" and FldId = '{0}'", objSqlViewFldEN.FldId);
}
 if (objSqlViewFldEN.FldExpression == null)
{
 sbCondition.AppendFormat(" and FldExpression is null");
}
else
{
 sbCondition.AppendFormat(" and FldExpression = '{0}'", objSqlViewFldEN.FldExpression);
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlViewFldEN._CurrTabName);
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlViewFldEN._CurrTabName, strCondition);
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
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
 objSQL = clsSqlViewFldDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}