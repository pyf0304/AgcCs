
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlSP_ParaDA
 表名:SqlSP_Para(00050183)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:49
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:SQL表字段管理(SQLTabField)
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
 /// SQL存储过程参数(SqlSP_Para)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSqlSP_ParaDA : clsCommBase4DA
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
 return clsSqlSP_ParaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSqlSP_ParaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlSP_ParaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSqlSP_ParaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSqlSP_ParaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SqlSP_Para(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable_SqlSP_Para)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlSP_Para.* " + 
$"from SqlSP_Para " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlSP_Para.mId not in " + 
$"(Select top {intTop_In} SqlSP_Para.mId from SqlSP_Para " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1} and mId not in (Select top {2} mId from SqlSP_Para where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1} and mId not in (Select top {3} mId from SqlSP_Para where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlSP_Para.* " + 
$"from SqlSP_Para " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlSP_Para.mId not in " + 
$"(Select top {intTop_In} SqlSP_Para.mId from SqlSP_Para " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1} and mId not in (Select top {2} mId from SqlSP_Para where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlSP_Para where {1} and mId not in (Select top {3} mId from SqlSP_Para where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSqlSP_ParaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA:GetObjLst)", objException.Message));
}
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = TransNullToInt(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = TransNullToInt(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = TransNullToShort(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = TransNullToBool(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = TransNullToInt(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlSP_ParaDA: GetObjLst)", objException.Message));
}
objSqlSP_ParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlSP_ParaEN);
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
public List<clsSqlSP_ParaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA:GetObjLstByTabName)", objException.Message));
}
List<clsSqlSP_ParaEN> arrObjLst = new List<clsSqlSP_ParaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = TransNullToInt(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = TransNullToInt(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = TransNullToShort(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = TransNullToBool(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = TransNullToInt(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlSP_ParaDA: GetObjLst)", objException.Message));
}
objSqlSP_ParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlSP_ParaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSqlSP_Para(ref clsSqlSP_ParaEN objSqlSP_ParaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where mId = " + ""+ objSqlSP_ParaEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSqlSP_ParaEN.mId = TransNullToInt(objDT.Rows[0][conSqlSP_Para.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSqlSP_ParaEN.IdStoreProcedure = TransNullToInt(objDT.Rows[0][conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objSqlSP_ParaEN.ParaName = objDT.Rows[0][conSqlSP_Para.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objSqlSP_ParaEN.ParaSize = TransNullToShort(objDT.Rows[0][conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度(字段类型:tinyint,字段长度:1,是否可空:False)
 objSqlSP_ParaEN.ParaDataType = objDT.Rows[0][conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型(字段类型:varchar,字段长度:20,是否可空:False)
 objSqlSP_ParaEN.ParaDirection = objDT.Rows[0][conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型(字段类型:varchar,字段长度:20,是否可空:False)
 objSqlSP_ParaEN.IsNullable = TransNullToBool(objDT.Rows[0][conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objSqlSP_ParaEN.SpId = TransNullToInt(objDT.Rows[0][conSqlSP_Para.SpId].ToString().Trim()); //SP_ID(字段类型:bigint,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSqlSP_ParaDA: GetSqlSP_Para)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsSqlSP_ParaEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
 objSqlSP_ParaEN.mId = Int32.Parse(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objSqlSP_ParaEN.IdStoreProcedure = Int32.Parse(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号(字段类型:bigint,字段长度:8,是否可空:False)
 objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名(字段类型:varchar,字段长度:50,是否可空:False)
 objSqlSP_ParaEN.ParaSize = short.Parse(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度(字段类型:tinyint,字段长度:1,是否可空:False)
 objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型(字段类型:varchar,字段长度:20,是否可空:False)
 objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型(字段类型:varchar,字段长度:20,是否可空:False)
 objSqlSP_ParaEN.IsNullable = clsEntityBase2.TransNullToBool_S(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空(字段类型:bit,字段长度:1,是否可空:False)
 objSqlSP_ParaEN.SpId = Int32.Parse(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID(字段类型:bigint,字段长度:8,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSqlSP_ParaDA: GetObjBymId)", objException.Message));
}
return objSqlSP_ParaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSqlSP_ParaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN()
{
mId = TransNullToInt(objRow[conSqlSP_Para.mId].ToString().Trim()), //mId
IdStoreProcedure = TransNullToInt(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()), //存储过程流水号
ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(), //参数名
ParaSize = TransNullToShort(objRow[conSqlSP_Para.ParaSize].ToString().Trim()), //参数长度
ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(), //参数数据类型
ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(), //参数数据类型
IsNullable = TransNullToBool(objRow[conSqlSP_Para.IsNullable].ToString().Trim()), //是否可空
SpId = TransNullToInt(objRow[conSqlSP_Para.SpId].ToString().Trim()) //SP_ID
};
objSqlSP_ParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlSP_ParaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSqlSP_ParaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSqlSP_ParaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = TransNullToInt(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = TransNullToInt(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = TransNullToShort(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = TransNullToBool(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = TransNullToInt(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSqlSP_ParaDA: GetObjByDataRowSqlSP_Para)", objException.Message));
}
objSqlSP_ParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlSP_ParaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSqlSP_ParaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlSP_ParaEN objSqlSP_ParaEN = new clsSqlSP_ParaEN();
try
{
objSqlSP_ParaEN.mId = TransNullToInt(objRow[conSqlSP_Para.mId].ToString().Trim()); //mId
objSqlSP_ParaEN.IdStoreProcedure = TransNullToInt(objRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim()); //存储过程流水号
objSqlSP_ParaEN.ParaName = objRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objSqlSP_ParaEN.ParaSize = TransNullToShort(objRow[conSqlSP_Para.ParaSize].ToString().Trim()); //参数长度
objSqlSP_ParaEN.ParaDataType = objRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.ParaDirection = objRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objSqlSP_ParaEN.IsNullable = TransNullToBool(objRow[conSqlSP_Para.IsNullable].ToString().Trim()); //是否可空
objSqlSP_ParaEN.SpId = TransNullToInt(objRow[conSqlSP_Para.SpId].ToString().Trim()); //SP_ID
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSqlSP_ParaDA: GetObjByDataRow)", objException.Message));
}
objSqlSP_ParaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlSP_ParaEN;
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
objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlSP_ParaEN._CurrTabName, conSqlSP_Para.mId, 8, "");
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
objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlSP_ParaEN._CurrTabName, conSqlSP_Para.mId, 8, strPrefix);
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from SqlSP_Para where " + strCondition;
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from SqlSP_Para where " + strCondition;
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlSP_Para", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlSP_Para", strCondition))
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
objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SqlSP_Para");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSqlSP_ParaEN objSqlSP_ParaEN)
 {
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlSP_ParaEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlSP_Para");
objRow = objDS.Tables["SqlSP_Para"].NewRow();
objRow[conSqlSP_Para.IdStoreProcedure] = objSqlSP_ParaEN.IdStoreProcedure; //存储过程流水号
objRow[conSqlSP_Para.ParaName] = objSqlSP_ParaEN.ParaName; //参数名
objRow[conSqlSP_Para.ParaSize] = objSqlSP_ParaEN.ParaSize; //参数长度
objRow[conSqlSP_Para.ParaDataType] = objSqlSP_ParaEN.ParaDataType; //参数数据类型
objRow[conSqlSP_Para.ParaDirection] = objSqlSP_ParaEN.ParaDirection; //参数数据类型
objRow[conSqlSP_Para.IsNullable] = objSqlSP_ParaEN.IsNullable; //是否可空
objRow[conSqlSP_Para.SpId] = objSqlSP_ParaEN.SpId; //SP_ID
objDS.Tables[clsSqlSP_ParaEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSqlSP_ParaEN._CurrTabName);
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlSP_ParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conSqlSP_Para.IdStoreProcedure);
 arrValueListForInsert.Add(objSqlSP_ParaEN.IdStoreProcedure.ToString());
 
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaName);
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.ParaSize);
 arrValueListForInsert.Add(objSqlSP_ParaEN.ParaSize.ToString());
 
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDataType);
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDataType + "'");
 }
 
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDirection);
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDirection + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.IsNullable);
 arrValueListForInsert.Add("'" + (objSqlSP_ParaEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conSqlSP_Para.SpId);
 arrValueListForInsert.Add(objSqlSP_ParaEN.SpId.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlSP_Para");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlSP_ParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conSqlSP_Para.IdStoreProcedure);
 arrValueListForInsert.Add(objSqlSP_ParaEN.IdStoreProcedure.ToString());
 
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaName);
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.ParaSize);
 arrValueListForInsert.Add(objSqlSP_ParaEN.ParaSize.ToString());
 
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDataType);
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDataType + "'");
 }
 
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDirection);
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDirection + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.IsNullable);
 arrValueListForInsert.Add("'" + (objSqlSP_ParaEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conSqlSP_Para.SpId);
 arrValueListForInsert.Add(objSqlSP_ParaEN.SpId.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlSP_Para");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlSP_ParaEN objSqlSP_ParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlSP_ParaEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conSqlSP_Para.IdStoreProcedure);
 arrValueListForInsert.Add(objSqlSP_ParaEN.IdStoreProcedure.ToString());
 
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaName);
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.ParaSize);
 arrValueListForInsert.Add(objSqlSP_ParaEN.ParaSize.ToString());
 
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDataType);
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDataType + "'");
 }
 
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDirection);
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDirection + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.IsNullable);
 arrValueListForInsert.Add("'" + (objSqlSP_ParaEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conSqlSP_Para.SpId);
 arrValueListForInsert.Add(objSqlSP_ParaEN.SpId.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlSP_Para");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlSP_ParaEN objSqlSP_ParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlSP_ParaEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conSqlSP_Para.IdStoreProcedure);
 arrValueListForInsert.Add(objSqlSP_ParaEN.IdStoreProcedure.ToString());
 
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaName);
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaName + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.ParaSize);
 arrValueListForInsert.Add(objSqlSP_ParaEN.ParaSize.ToString());
 
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDataType);
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDataType + "'");
 }
 
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 arrFieldListForInsert.Add(conSqlSP_Para.ParaDirection);
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaDirection + "'");
 }
 
 arrFieldListForInsert.Add(conSqlSP_Para.IsNullable);
 arrValueListForInsert.Add("'" + (objSqlSP_ParaEN.IsNullable  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conSqlSP_Para.SpId);
 arrValueListForInsert.Add(objSqlSP_ParaEN.SpId.ToString());
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlSP_Para");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSqlSP_Paras(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlSP_Para");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conSqlSP_Para.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSqlSP_ParaEN._CurrTabName ].NewRow();
objRow[conSqlSP_Para.IdStoreProcedure] = oRow[conSqlSP_Para.IdStoreProcedure].ToString().Trim(); //存储过程流水号
objRow[conSqlSP_Para.ParaName] = oRow[conSqlSP_Para.ParaName].ToString().Trim(); //参数名
objRow[conSqlSP_Para.ParaSize] = oRow[conSqlSP_Para.ParaSize].ToString().Trim(); //参数长度
objRow[conSqlSP_Para.ParaDataType] = oRow[conSqlSP_Para.ParaDataType].ToString().Trim(); //参数数据类型
objRow[conSqlSP_Para.ParaDirection] = oRow[conSqlSP_Para.ParaDirection].ToString().Trim(); //参数数据类型
objRow[conSqlSP_Para.IsNullable] = oRow[conSqlSP_Para.IsNullable].ToString().Trim(); //是否可空
objRow[conSqlSP_Para.SpId] = oRow[conSqlSP_Para.SpId].ToString().Trim(); //SP_ID
 objDS.Tables[clsSqlSP_ParaEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSqlSP_ParaEN._CurrTabName);
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
 /// <param name = "objSqlSP_ParaEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlSP_ParaEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
strSQL = "Select * from SqlSP_Para where mId = " + ""+ objSqlSP_ParaEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSqlSP_ParaEN._CurrTabName);
if (objDS.Tables[clsSqlSP_ParaEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objSqlSP_ParaEN.mId+"");
return false;
}
objRow = objDS.Tables[clsSqlSP_ParaEN._CurrTabName].Rows[0];
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IdStoreProcedure))
 {
objRow[conSqlSP_Para.IdStoreProcedure] = objSqlSP_ParaEN.IdStoreProcedure; //存储过程流水号
 }
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaName))
 {
objRow[conSqlSP_Para.ParaName] = objSqlSP_ParaEN.ParaName; //参数名
 }
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaSize))
 {
objRow[conSqlSP_Para.ParaSize] = objSqlSP_ParaEN.ParaSize; //参数长度
 }
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDataType))
 {
objRow[conSqlSP_Para.ParaDataType] = objSqlSP_ParaEN.ParaDataType; //参数数据类型
 }
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDirection))
 {
objRow[conSqlSP_Para.ParaDirection] = objSqlSP_ParaEN.ParaDirection; //参数数据类型
 }
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IsNullable))
 {
objRow[conSqlSP_Para.IsNullable] = objSqlSP_ParaEN.IsNullable; //是否可空
 }
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.SpId))
 {
objRow[conSqlSP_Para.SpId] = objSqlSP_ParaEN.SpId; //SP_ID
 }
try
{
objDA.Update(objDS, clsSqlSP_ParaEN._CurrTabName);
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlSP_ParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SqlSP_Para Set ");
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IdStoreProcedure))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlSP_ParaEN.IdStoreProcedure, conSqlSP_Para.IdStoreProcedure); //存储过程流水号
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaName))
 {
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conSqlSP_Para.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlSP_Para.ParaName); //参数名
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlSP_ParaEN.ParaSize, conSqlSP_Para.ParaSize); //参数长度
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDataType))
 {
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaDataType, conSqlSP_Para.ParaDataType); //参数数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlSP_Para.ParaDataType); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDirection))
 {
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaDirection, conSqlSP_Para.ParaDirection); //参数数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlSP_Para.ParaDirection); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IsNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSqlSP_ParaEN.IsNullable == true?"1":"0", conSqlSP_Para.IsNullable); //是否可空
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.SpId))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlSP_ParaEN.SpId, conSqlSP_Para.SpId); //SP_ID
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSqlSP_ParaEN.mId); 
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
 /// <param name = "objSqlSP_ParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSqlSP_ParaEN objSqlSP_ParaEN, string strCondition)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlSP_ParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlSP_Para Set ");
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IdStoreProcedure))
 {
 sbSQL.AppendFormat(" IdStoreProcedure = {0},", objSqlSP_ParaEN.IdStoreProcedure); //存储过程流水号
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaName))
 {
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaSize))
 {
 sbSQL.AppendFormat(" ParaSize = {0},", objSqlSP_ParaEN.ParaSize); //参数长度
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDataType))
 {
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaDataType = '{0}',", strParaDataType); //参数数据类型
 }
 else
 {
 sbSQL.Append(" ParaDataType = null,"); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDirection))
 {
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaDirection = '{0}',", strParaDirection); //参数数据类型
 }
 else
 {
 sbSQL.Append(" ParaDirection = null,"); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IsNullable))
 {
 sbSQL.AppendFormat(" IsNullable = '{0}',", objSqlSP_ParaEN.IsNullable == true?"1":"0"); //是否可空
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.SpId))
 {
 sbSQL.AppendFormat(" SpId = {0},", objSqlSP_ParaEN.SpId); //SP_ID
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
 /// <param name = "objSqlSP_ParaEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSqlSP_ParaEN objSqlSP_ParaEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlSP_ParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlSP_Para Set ");
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IdStoreProcedure))
 {
 sbSQL.AppendFormat(" IdStoreProcedure = {0},", objSqlSP_ParaEN.IdStoreProcedure); //存储过程流水号
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaName))
 {
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaName = '{0}',", strParaName); //参数名
 }
 else
 {
 sbSQL.Append(" ParaName = null,"); //参数名
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaSize))
 {
 sbSQL.AppendFormat(" ParaSize = {0},", objSqlSP_ParaEN.ParaSize); //参数长度
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDataType))
 {
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaDataType = '{0}',", strParaDataType); //参数数据类型
 }
 else
 {
 sbSQL.Append(" ParaDataType = null,"); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDirection))
 {
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaDirection = '{0}',", strParaDirection); //参数数据类型
 }
 else
 {
 sbSQL.Append(" ParaDirection = null,"); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IsNullable))
 {
 sbSQL.AppendFormat(" IsNullable = '{0}',", objSqlSP_ParaEN.IsNullable == true?"1":"0"); //是否可空
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.SpId))
 {
 sbSQL.AppendFormat(" SpId = {0},", objSqlSP_ParaEN.SpId); //SP_ID
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
 /// <param name = "objSqlSP_ParaEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlSP_ParaEN objSqlSP_ParaEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objSqlSP_ParaEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlSP_ParaEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlSP_Para Set ");
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IdStoreProcedure))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlSP_ParaEN.IdStoreProcedure, conSqlSP_Para.IdStoreProcedure); //存储过程流水号
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaName))
 {
 if (objSqlSP_ParaEN.ParaName !=  null)
 {
 var strParaName = objSqlSP_ParaEN.ParaName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaName, conSqlSP_Para.ParaName); //参数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlSP_Para.ParaName); //参数名
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaSize))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlSP_ParaEN.ParaSize, conSqlSP_Para.ParaSize); //参数长度
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDataType))
 {
 if (objSqlSP_ParaEN.ParaDataType !=  null)
 {
 var strParaDataType = objSqlSP_ParaEN.ParaDataType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaDataType, conSqlSP_Para.ParaDataType); //参数数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlSP_Para.ParaDataType); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.ParaDirection))
 {
 if (objSqlSP_ParaEN.ParaDirection !=  null)
 {
 var strParaDirection = objSqlSP_ParaEN.ParaDirection.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaDirection, conSqlSP_Para.ParaDirection); //参数数据类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlSP_Para.ParaDirection); //参数数据类型
 }
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.IsNullable))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objSqlSP_ParaEN.IsNullable == true?"1":"0", conSqlSP_Para.IsNullable); //是否可空
 }
 
 if (objSqlSP_ParaEN.IsUpdated(conSqlSP_Para.SpId))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlSP_ParaEN.SpId, conSqlSP_Para.SpId); //SP_ID
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objSqlSP_ParaEN.mId); 
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("SqlSP_Para_Delete", values);
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
//删除SqlSP_Para本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlSP_Para where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSqlSP_Para(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
//删除SqlSP_Para本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlSP_Para where mId in (" + strKeyList + ")";
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
//删除SqlSP_Para本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlSP_Para where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSqlSP_Para(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: DelSqlSP_Para)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlSP_Para where " + strCondition ;
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
public bool DelSqlSP_ParaWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSqlSP_ParaDA: DelSqlSP_ParaWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlSP_Para where " + strCondition ;
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
 /// <param name = "objSqlSP_ParaENS">源对象</param>
 /// <param name = "objSqlSP_ParaENT">目标对象</param>
public void CopyTo(clsSqlSP_ParaEN objSqlSP_ParaENS, clsSqlSP_ParaEN objSqlSP_ParaENT)
{
objSqlSP_ParaENT.mId = objSqlSP_ParaENS.mId; //mId
objSqlSP_ParaENT.IdStoreProcedure = objSqlSP_ParaENS.IdStoreProcedure; //存储过程流水号
objSqlSP_ParaENT.ParaName = objSqlSP_ParaENS.ParaName; //参数名
objSqlSP_ParaENT.ParaSize = objSqlSP_ParaENS.ParaSize; //参数长度
objSqlSP_ParaENT.ParaDataType = objSqlSP_ParaENS.ParaDataType; //参数数据类型
objSqlSP_ParaENT.ParaDirection = objSqlSP_ParaENS.ParaDirection; //参数数据类型
objSqlSP_ParaENT.IsNullable = objSqlSP_ParaENS.IsNullable; //是否可空
objSqlSP_ParaENT.SpId = objSqlSP_ParaENS.SpId; //SP_ID
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.IdStoreProcedure, conSqlSP_Para.IdStoreProcedure);
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.ParaName, conSqlSP_Para.ParaName);
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.ParaSize, conSqlSP_Para.ParaSize);
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.ParaDataType, conSqlSP_Para.ParaDataType);
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.ParaDirection, conSqlSP_Para.ParaDirection);
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.IsNullable, conSqlSP_Para.IsNullable);
clsCheckSql.CheckFieldNotNull(objSqlSP_ParaEN.SpId, conSqlSP_Para.SpId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaName, 50, conSqlSP_Para.ParaName);
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaDataType, 20, conSqlSP_Para.ParaDataType);
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaDirection, 20, conSqlSP_Para.ParaDirection);
//检查字段外键固定长度
 objSqlSP_ParaEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaName, 50, conSqlSP_Para.ParaName);
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaDataType, 20, conSqlSP_Para.ParaDataType);
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaDirection, 20, conSqlSP_Para.ParaDirection);
//检查外键字段长度
 objSqlSP_ParaEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaName, 50, conSqlSP_Para.ParaName);
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaDataType, 20, conSqlSP_Para.ParaDataType);
clsCheckSql.CheckFieldLen(objSqlSP_ParaEN.ParaDirection, 20, conSqlSP_Para.ParaDirection);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSqlSP_ParaEN.ParaName, conSqlSP_Para.ParaName);
clsCheckSql.CheckSqlInjection4Field(objSqlSP_ParaEN.ParaDataType, conSqlSP_Para.ParaDataType);
clsCheckSql.CheckSqlInjection4Field(objSqlSP_ParaEN.ParaDirection, conSqlSP_Para.ParaDirection);
//检查外键字段长度
 objSqlSP_ParaEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SqlSP_Para(SQL存储过程参数),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlSP_ParaEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSqlSP_ParaEN objSqlSP_ParaEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and IdStoreProcedure = '{0}'", objSqlSP_ParaEN.IdStoreProcedure);
 sbCondition.AppendFormat(" and ParaName = '{0}'", objSqlSP_ParaEN.ParaName);
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlSP_ParaEN._CurrTabName);
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlSP_ParaEN._CurrTabName, strCondition);
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
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
 objSQL = clsSqlSP_ParaDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}