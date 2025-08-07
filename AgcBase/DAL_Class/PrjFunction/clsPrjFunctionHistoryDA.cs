
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjFunctionHistoryDA
 表名:PrjFunctionHistory(00050109)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:26
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
 /// 工程函数历史(PrjFunctionHistory)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjFunctionHistoryDA : clsCommBase4DA
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
 return clsPrjFunctionHistoryEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjFunctionHistoryEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjFunctionHistoryEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjFunctionHistoryEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjFunctionHistoryEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjFunctionHistory(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable_PrjFunctionHistory)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFunctionHistory.* " + 
$"from PrjFunctionHistory " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFunctionHistory.mId not in " + 
$"(Select top {intTop_In} PrjFunctionHistory.mId from PrjFunctionHistory " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1} and mId not in (Select top {2} mId from PrjFunctionHistory where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1} and mId not in (Select top {3} mId from PrjFunctionHistory where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjFunctionHistory.* " + 
$"from PrjFunctionHistory " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjFunctionHistory.mId not in " + 
$"(Select top {intTop_In} PrjFunctionHistory.mId from PrjFunctionHistory " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1} and mId not in (Select top {2} mId from PrjFunctionHistory where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjFunctionHistory where {1} and mId not in (Select top {3} mId from PrjFunctionHistory where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjFunctionHistoryEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA:GetObjLst)", objException.Message));
}
List<clsPrjFunctionHistoryEN> arrObjLst = new List<clsPrjFunctionHistoryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionHistoryEN objPrjFunctionHistoryEN = new clsPrjFunctionHistoryEN();
try
{
objPrjFunctionHistoryEN.mId = TransNullToInt(objRow[conPrjFunctionHistory.mId].ToString().Trim()); //mId
objPrjFunctionHistoryEN.FuncId = objRow[conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID
objPrjFunctionHistoryEN.PrjId = objRow[conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id
objPrjFunctionHistoryEN.Updator = objRow[conPrjFunctionHistory.Updator] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Updator].ToString().Trim(); //修改者
objPrjFunctionHistoryEN.UpdDate = objRow[conPrjFunctionHistory.UpdDate] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionHistoryEN.UpdTime = objRow[conPrjFunctionHistory.UpdTime] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间
objPrjFunctionHistoryEN.UserId = objRow[conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id
objPrjFunctionHistoryEN.FuncCode = objRow[conPrjFunctionHistory.FuncCode] == DBNull.Value ? null : objRow[conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionHistoryEN.Memo = objRow[conPrjFunctionHistory.Memo] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetObjLst)", objException.Message));
}
objPrjFunctionHistoryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFunctionHistoryEN);
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
public List<clsPrjFunctionHistoryEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjFunctionHistoryEN> arrObjLst = new List<clsPrjFunctionHistoryEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjFunctionHistoryEN objPrjFunctionHistoryEN = new clsPrjFunctionHistoryEN();
try
{
objPrjFunctionHistoryEN.mId = TransNullToInt(objRow[conPrjFunctionHistory.mId].ToString().Trim()); //mId
objPrjFunctionHistoryEN.FuncId = objRow[conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID
objPrjFunctionHistoryEN.PrjId = objRow[conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id
objPrjFunctionHistoryEN.Updator = objRow[conPrjFunctionHistory.Updator] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Updator].ToString().Trim(); //修改者
objPrjFunctionHistoryEN.UpdDate = objRow[conPrjFunctionHistory.UpdDate] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionHistoryEN.UpdTime = objRow[conPrjFunctionHistory.UpdTime] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间
objPrjFunctionHistoryEN.UserId = objRow[conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id
objPrjFunctionHistoryEN.FuncCode = objRow[conPrjFunctionHistory.FuncCode] == DBNull.Value ? null : objRow[conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionHistoryEN.Memo = objRow[conPrjFunctionHistory.Memo] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetObjLst)", objException.Message));
}
objPrjFunctionHistoryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjFunctionHistoryEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjFunctionHistoryEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjFunctionHistory(ref clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where mId = " + ""+ objPrjFunctionHistoryEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjFunctionHistoryEN.mId = TransNullToInt(objDT.Rows[0][conPrjFunctionHistory.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objPrjFunctionHistoryEN.FuncId = objDT.Rows[0][conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objPrjFunctionHistoryEN.PrjId = objDT.Rows[0][conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFunctionHistoryEN.Updator = objDT.Rows[0][conPrjFunctionHistory.Updator].ToString().Trim(); //修改者(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjFunctionHistoryEN.UpdDate = objDT.Rows[0][conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFunctionHistoryEN.UpdTime = objDT.Rows[0][conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:6,是否可空:True)
 objPrjFunctionHistoryEN.UserId = objDT.Rows[0][conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjFunctionHistoryEN.FuncCode = objDT.Rows[0][conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objPrjFunctionHistoryEN.Memo = objDT.Rows[0][conPrjFunctionHistory.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetPrjFunctionHistory)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjFunctionHistoryEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjFunctionHistoryEN objPrjFunctionHistoryEN = new clsPrjFunctionHistoryEN();
try
{
 objPrjFunctionHistoryEN.mId = Int32.Parse(objRow[conPrjFunctionHistory.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objPrjFunctionHistoryEN.FuncId = objRow[conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID(字段类型:varchar,字段长度:10,是否可空:False)
 objPrjFunctionHistoryEN.PrjId = objRow[conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjFunctionHistoryEN.Updator = objRow[conPrjFunctionHistory.Updator] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Updator].ToString().Trim(); //修改者(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjFunctionHistoryEN.UpdDate = objRow[conPrjFunctionHistory.UpdDate] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjFunctionHistoryEN.UpdTime = objRow[conPrjFunctionHistory.UpdTime] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:6,是否可空:True)
 objPrjFunctionHistoryEN.UserId = objRow[conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objPrjFunctionHistoryEN.FuncCode = objRow[conPrjFunctionHistory.FuncCode] == DBNull.Value ? null : objRow[conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objPrjFunctionHistoryEN.Memo = objRow[conPrjFunctionHistory.Memo] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetObjBymId)", objException.Message));
}
return objPrjFunctionHistoryEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjFunctionHistoryEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjFunctionHistoryEN objPrjFunctionHistoryEN = new clsPrjFunctionHistoryEN()
{
mId = TransNullToInt(objRow[conPrjFunctionHistory.mId].ToString().Trim()), //mId
FuncId = objRow[conPrjFunctionHistory.FuncId].ToString().Trim(), //函数ID
PrjId = objRow[conPrjFunctionHistory.PrjId].ToString().Trim(), //工程Id
Updator = objRow[conPrjFunctionHistory.Updator] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Updator].ToString().Trim(), //修改者
UpdDate = objRow[conPrjFunctionHistory.UpdDate] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdDate].ToString().Trim(), //修改日期
UpdTime = objRow[conPrjFunctionHistory.UpdTime] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdTime].ToString().Trim(), //修改时间
UserId = objRow[conPrjFunctionHistory.UserId].ToString().Trim(), //用户Id
FuncCode = objRow[conPrjFunctionHistory.FuncCode] == DBNull.Value ? null : objRow[conPrjFunctionHistory.FuncCode].ToString().Trim(), //函数代码
Memo = objRow[conPrjFunctionHistory.Memo] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Memo].ToString().Trim() //说明
};
objPrjFunctionHistoryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFunctionHistoryEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjFunctionHistoryEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFunctionHistoryEN objPrjFunctionHistoryEN = new clsPrjFunctionHistoryEN();
try
{
objPrjFunctionHistoryEN.mId = TransNullToInt(objRow[conPrjFunctionHistory.mId].ToString().Trim()); //mId
objPrjFunctionHistoryEN.FuncId = objRow[conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID
objPrjFunctionHistoryEN.PrjId = objRow[conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id
objPrjFunctionHistoryEN.Updator = objRow[conPrjFunctionHistory.Updator] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Updator].ToString().Trim(); //修改者
objPrjFunctionHistoryEN.UpdDate = objRow[conPrjFunctionHistory.UpdDate] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionHistoryEN.UpdTime = objRow[conPrjFunctionHistory.UpdTime] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间
objPrjFunctionHistoryEN.UserId = objRow[conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id
objPrjFunctionHistoryEN.FuncCode = objRow[conPrjFunctionHistory.FuncCode] == DBNull.Value ? null : objRow[conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionHistoryEN.Memo = objRow[conPrjFunctionHistory.Memo] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetObjByDataRowPrjFunctionHistory)", objException.Message));
}
objPrjFunctionHistoryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFunctionHistoryEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjFunctionHistoryEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjFunctionHistoryEN objPrjFunctionHistoryEN = new clsPrjFunctionHistoryEN();
try
{
objPrjFunctionHistoryEN.mId = TransNullToInt(objRow[conPrjFunctionHistory.mId].ToString().Trim()); //mId
objPrjFunctionHistoryEN.FuncId = objRow[conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID
objPrjFunctionHistoryEN.PrjId = objRow[conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id
objPrjFunctionHistoryEN.Updator = objRow[conPrjFunctionHistory.Updator] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Updator].ToString().Trim(); //修改者
objPrjFunctionHistoryEN.UpdDate = objRow[conPrjFunctionHistory.UpdDate] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期
objPrjFunctionHistoryEN.UpdTime = objRow[conPrjFunctionHistory.UpdTime] == DBNull.Value ? null : objRow[conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间
objPrjFunctionHistoryEN.UserId = objRow[conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id
objPrjFunctionHistoryEN.FuncCode = objRow[conPrjFunctionHistory.FuncCode] == DBNull.Value ? null : objRow[conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码
objPrjFunctionHistoryEN.Memo = objRow[conPrjFunctionHistory.Memo] == DBNull.Value ? null : objRow[conPrjFunctionHistory.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjFunctionHistoryDA: GetObjByDataRow)", objException.Message));
}
objPrjFunctionHistoryEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjFunctionHistoryEN;
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
objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFunctionHistoryEN._CurrTabName, conPrjFunctionHistory.mId, 8, "");
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
objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjFunctionHistoryEN._CurrTabName, conPrjFunctionHistory.mId, 8, strPrefix);
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from PrjFunctionHistory where " + strCondition;
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from PrjFunctionHistory where " + strCondition;
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFunctionHistory", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjFunctionHistory", strCondition))
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
objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjFunctionHistory");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
 {
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionHistoryEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFunctionHistory");
objRow = objDS.Tables["PrjFunctionHistory"].NewRow();
objRow[conPrjFunctionHistory.FuncId] = objPrjFunctionHistoryEN.FuncId; //函数ID
objRow[conPrjFunctionHistory.PrjId] = objPrjFunctionHistoryEN.PrjId; //工程Id
 if (objPrjFunctionHistoryEN.Updator !=  "")
 {
objRow[conPrjFunctionHistory.Updator] = objPrjFunctionHistoryEN.Updator; //修改者
 }
 if (objPrjFunctionHistoryEN.UpdDate !=  "")
 {
objRow[conPrjFunctionHistory.UpdDate] = objPrjFunctionHistoryEN.UpdDate; //修改日期
 }
 if (objPrjFunctionHistoryEN.UpdTime !=  "")
 {
objRow[conPrjFunctionHistory.UpdTime] = objPrjFunctionHistoryEN.UpdTime; //修改时间
 }
objRow[conPrjFunctionHistory.UserId] = objPrjFunctionHistoryEN.UserId; //用户Id
 if (objPrjFunctionHistoryEN.FuncCode !=  "")
 {
objRow[conPrjFunctionHistory.FuncCode] = objPrjFunctionHistoryEN.FuncCode; //函数代码
 }
 if (objPrjFunctionHistoryEN.Memo !=  "")
 {
objRow[conPrjFunctionHistory.Memo] = objPrjFunctionHistoryEN.Memo; //说明
 }
objDS.Tables[clsPrjFunctionHistoryEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjFunctionHistoryEN._CurrTabName);
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
 /// <param name = "objPrjFunctionHistoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionHistoryEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncId);
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.PrjId);
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Updator);
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdator + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdDate);
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdTime);
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UserId);
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncCode);
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Memo);
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunctionHistory");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjFunctionHistoryEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionHistoryEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncId);
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.PrjId);
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Updator);
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdator + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdDate);
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdTime);
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UserId);
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncCode);
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Memo);
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunctionHistory");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objPrjFunctionHistoryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionHistoryEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncId);
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.PrjId);
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Updator);
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdator + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdDate);
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdTime);
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UserId);
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncCode);
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Memo);
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunctionHistory");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjFunctionHistoryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjFunctionHistoryEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncId);
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId + "'");
 }
 
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.PrjId);
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Updator);
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdator + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdDate);
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UpdTime);
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.UserId);
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.FuncCode);
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjFunctionHistory.Memo);
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjFunctionHistory");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjFunctionHistorys(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjFunctionHistory");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conPrjFunctionHistory.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjFunctionHistoryEN._CurrTabName ].NewRow();
objRow[conPrjFunctionHistory.FuncId] = oRow[conPrjFunctionHistory.FuncId].ToString().Trim(); //函数ID
objRow[conPrjFunctionHistory.PrjId] = oRow[conPrjFunctionHistory.PrjId].ToString().Trim(); //工程Id
objRow[conPrjFunctionHistory.Updator] = oRow[conPrjFunctionHistory.Updator].ToString().Trim(); //修改者
objRow[conPrjFunctionHistory.UpdDate] = oRow[conPrjFunctionHistory.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjFunctionHistory.UpdTime] = oRow[conPrjFunctionHistory.UpdTime].ToString().Trim(); //修改时间
objRow[conPrjFunctionHistory.UserId] = oRow[conPrjFunctionHistory.UserId].ToString().Trim(); //用户Id
objRow[conPrjFunctionHistory.FuncCode] = oRow[conPrjFunctionHistory.FuncCode].ToString().Trim(); //函数代码
objRow[conPrjFunctionHistory.Memo] = oRow[conPrjFunctionHistory.Memo].ToString().Trim(); //说明
 objDS.Tables[clsPrjFunctionHistoryEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjFunctionHistoryEN._CurrTabName);
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
 /// <param name = "objPrjFunctionHistoryEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionHistoryEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
strSQL = "Select * from PrjFunctionHistory where mId = " + ""+ objPrjFunctionHistoryEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjFunctionHistoryEN._CurrTabName);
if (objDS.Tables[clsPrjFunctionHistoryEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objPrjFunctionHistoryEN.mId+"");
return false;
}
objRow = objDS.Tables[clsPrjFunctionHistoryEN._CurrTabName].Rows[0];
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncId))
 {
objRow[conPrjFunctionHistory.FuncId] = objPrjFunctionHistoryEN.FuncId; //函数ID
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.PrjId))
 {
objRow[conPrjFunctionHistory.PrjId] = objPrjFunctionHistoryEN.PrjId; //工程Id
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Updator))
 {
objRow[conPrjFunctionHistory.Updator] = objPrjFunctionHistoryEN.Updator; //修改者
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdDate))
 {
objRow[conPrjFunctionHistory.UpdDate] = objPrjFunctionHistoryEN.UpdDate; //修改日期
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdTime))
 {
objRow[conPrjFunctionHistory.UpdTime] = objPrjFunctionHistoryEN.UpdTime; //修改时间
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UserId))
 {
objRow[conPrjFunctionHistory.UserId] = objPrjFunctionHistoryEN.UserId; //用户Id
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncCode))
 {
objRow[conPrjFunctionHistory.FuncCode] = objPrjFunctionHistoryEN.FuncCode; //函数代码
 }
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Memo))
 {
objRow[conPrjFunctionHistory.Memo] = objPrjFunctionHistoryEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsPrjFunctionHistoryEN._CurrTabName);
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
 /// <param name = "objPrjFunctionHistoryEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionHistoryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjFunctionHistory Set ");
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncId))
 {
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncId, conPrjFunctionHistory.FuncId); //函数ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.FuncId); //函数ID
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.PrjId))
 {
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjFunctionHistory.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.PrjId); //工程Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Updator))
 {
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdator, conPrjFunctionHistory.Updator); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.Updator); //修改者
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdDate))
 {
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFunctionHistory.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.UpdDate); //修改日期
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdTime))
 {
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdTime, conPrjFunctionHistory.UpdTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.UpdTime); //修改时间
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UserId))
 {
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjFunctionHistory.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.UserId); //用户Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncCode))
 {
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCode, conPrjFunctionHistory.FuncCode); //函数代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.FuncCode); //函数代码
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Memo))
 {
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFunctionHistory.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objPrjFunctionHistoryEN.mId); 
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
 /// <param name = "objPrjFunctionHistoryEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN, string strCondition)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionHistoryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFunctionHistory Set ");
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncId))
 {
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId = '{0}',", strFuncId); //函数ID
 }
 else
 {
 sbSQL.Append(" FuncId = null,"); //函数ID
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.PrjId))
 {
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Updator))
 {
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Updator = '{0}',", strUpdator); //修改者
 }
 else
 {
 sbSQL.Append(" Updator = null,"); //修改者
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdDate))
 {
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdTime))
 {
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdTime = '{0}',", strUpdTime); //修改时间
 }
 else
 {
 sbSQL.Append(" UpdTime = null,"); //修改时间
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UserId))
 {
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncCode))
 {
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCode = '{0}',", strFuncCode); //函数代码
 }
 else
 {
 sbSQL.Append(" FuncCode = null,"); //函数代码
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Memo))
 {
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFunctionHistoryEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionHistoryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFunctionHistory Set ");
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncId))
 {
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId = '{0}',", strFuncId); //函数ID
 }
 else
 {
 sbSQL.Append(" FuncId = null,"); //函数ID
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.PrjId))
 {
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Updator))
 {
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Updator = '{0}',", strUpdator); //修改者
 }
 else
 {
 sbSQL.Append(" Updator = null,"); //修改者
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdDate))
 {
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdTime))
 {
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdTime = '{0}',", strUpdTime); //修改时间
 }
 else
 {
 sbSQL.Append(" UpdTime = null,"); //修改时间
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UserId))
 {
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncCode))
 {
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCode = '{0}',", strFuncCode); //函数代码
 }
 else
 {
 sbSQL.Append(" FuncCode = null,"); //函数代码
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Memo))
 {
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objPrjFunctionHistoryEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjFunctionHistoryEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjFunctionHistoryEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjFunctionHistoryEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjFunctionHistory Set ");
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncId))
 {
 if (objPrjFunctionHistoryEN.FuncId !=  null)
 {
 var strFuncId = objPrjFunctionHistoryEN.FuncId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncId, conPrjFunctionHistory.FuncId); //函数ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.FuncId); //函数ID
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.PrjId))
 {
 if (objPrjFunctionHistoryEN.PrjId !=  null)
 {
 var strPrjId = objPrjFunctionHistoryEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjFunctionHistory.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.PrjId); //工程Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Updator))
 {
 if (objPrjFunctionHistoryEN.Updator !=  null)
 {
 var strUpdator = objPrjFunctionHistoryEN.Updator.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdator, conPrjFunctionHistory.Updator); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.Updator); //修改者
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdDate))
 {
 if (objPrjFunctionHistoryEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjFunctionHistoryEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjFunctionHistory.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.UpdDate); //修改日期
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UpdTime))
 {
 if (objPrjFunctionHistoryEN.UpdTime !=  null)
 {
 var strUpdTime = objPrjFunctionHistoryEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdTime, conPrjFunctionHistory.UpdTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.UpdTime); //修改时间
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.UserId))
 {
 if (objPrjFunctionHistoryEN.UserId !=  null)
 {
 var strUserId = objPrjFunctionHistoryEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conPrjFunctionHistory.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.UserId); //用户Id
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.FuncCode))
 {
 if (objPrjFunctionHistoryEN.FuncCode !=  null)
 {
 var strFuncCode = objPrjFunctionHistoryEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCode, conPrjFunctionHistory.FuncCode); //函数代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.FuncCode); //函数代码
 }
 }
 
 if (objPrjFunctionHistoryEN.IsUpdated(conPrjFunctionHistory.Memo))
 {
 if (objPrjFunctionHistoryEN.Memo !=  null)
 {
 var strMemo = objPrjFunctionHistoryEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjFunctionHistory.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjFunctionHistory.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objPrjFunctionHistoryEN.mId); 
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("PrjFunctionHistory_Delete", values);
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
//删除PrjFunctionHistory本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFunctionHistory where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjFunctionHistory(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
//删除PrjFunctionHistory本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFunctionHistory where mId in (" + strKeyList + ")";
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
//删除PrjFunctionHistory本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjFunctionHistory where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjFunctionHistory(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: DelPrjFunctionHistory)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFunctionHistory where " + strCondition ;
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
public bool DelPrjFunctionHistoryWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjFunctionHistoryDA: DelPrjFunctionHistoryWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjFunctionHistory where " + strCondition ;
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
 /// <param name = "objPrjFunctionHistoryENS">源对象</param>
 /// <param name = "objPrjFunctionHistoryENT">目标对象</param>
public void CopyTo(clsPrjFunctionHistoryEN objPrjFunctionHistoryENS, clsPrjFunctionHistoryEN objPrjFunctionHistoryENT)
{
objPrjFunctionHistoryENT.mId = objPrjFunctionHistoryENS.mId; //mId
objPrjFunctionHistoryENT.FuncId = objPrjFunctionHistoryENS.FuncId; //函数ID
objPrjFunctionHistoryENT.PrjId = objPrjFunctionHistoryENS.PrjId; //工程Id
objPrjFunctionHistoryENT.Updator = objPrjFunctionHistoryENS.Updator; //修改者
objPrjFunctionHistoryENT.UpdDate = objPrjFunctionHistoryENS.UpdDate; //修改日期
objPrjFunctionHistoryENT.UpdTime = objPrjFunctionHistoryENS.UpdTime; //修改时间
objPrjFunctionHistoryENT.UserId = objPrjFunctionHistoryENS.UserId; //用户Id
objPrjFunctionHistoryENT.FuncCode = objPrjFunctionHistoryENS.FuncCode; //函数代码
objPrjFunctionHistoryENT.Memo = objPrjFunctionHistoryENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjFunctionHistoryEN.FuncId, conPrjFunctionHistory.FuncId);
clsCheckSql.CheckFieldNotNull(objPrjFunctionHistoryEN.PrjId, conPrjFunctionHistory.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjFunctionHistoryEN.UserId, conPrjFunctionHistory.UserId);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.FuncId, 10, conPrjFunctionHistory.FuncId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.PrjId, 4, conPrjFunctionHistory.PrjId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.Updator, 18, conPrjFunctionHistory.Updator);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UpdDate, 20, conPrjFunctionHistory.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UpdTime, 6, conPrjFunctionHistory.UpdTime);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UserId, 18, conPrjFunctionHistory.UserId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.Memo, 1000, conPrjFunctionHistory.Memo);
//检查字段外键固定长度
 objPrjFunctionHistoryEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.FuncId, 10, conPrjFunctionHistory.FuncId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.PrjId, 4, conPrjFunctionHistory.PrjId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.Updator, 18, conPrjFunctionHistory.Updator);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UpdDate, 20, conPrjFunctionHistory.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UpdTime, 6, conPrjFunctionHistory.UpdTime);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UserId, 18, conPrjFunctionHistory.UserId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.Memo, 1000, conPrjFunctionHistory.Memo);
//检查外键字段长度
 objPrjFunctionHistoryEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.FuncId, 10, conPrjFunctionHistory.FuncId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.PrjId, 4, conPrjFunctionHistory.PrjId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.Updator, 18, conPrjFunctionHistory.Updator);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UpdDate, 20, conPrjFunctionHistory.UpdDate);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UpdTime, 6, conPrjFunctionHistory.UpdTime);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.UserId, 18, conPrjFunctionHistory.UserId);
clsCheckSql.CheckFieldLen(objPrjFunctionHistoryEN.Memo, 1000, conPrjFunctionHistory.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.FuncId, conPrjFunctionHistory.FuncId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.PrjId, conPrjFunctionHistory.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.Updator, conPrjFunctionHistory.Updator);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.UpdDate, conPrjFunctionHistory.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.UpdTime, conPrjFunctionHistory.UpdTime);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.UserId, conPrjFunctionHistory.UserId);
clsCheckSql.CheckSqlInjection4Field(objPrjFunctionHistoryEN.Memo, conPrjFunctionHistory.Memo);
//检查外键字段长度
 objPrjFunctionHistoryEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjFunctionHistory(工程函数历史),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjFunctionHistoryEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjFunctionHistoryEN objPrjFunctionHistoryEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjFunctionHistoryEN.PrjId);
 sbCondition.AppendFormat(" and FuncId = '{0}'", objPrjFunctionHistoryEN.FuncId);
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFunctionHistoryEN._CurrTabName);
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjFunctionHistoryEN._CurrTabName, strCondition);
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
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
 objSQL = clsPrjFunctionHistoryDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}