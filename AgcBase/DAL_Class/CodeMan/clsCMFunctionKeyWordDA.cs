
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCMFunctionKeyWordDA
 表名:CMFunctionKeyWord(00050515)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:54
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:代码管理(CodeMan)
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
 /// CM函数关键字(CMFunctionKeyWord)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCMFunctionKeyWordDA : clsCommBase4DA
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
 return clsCMFunctionKeyWordEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCMFunctionKeyWordEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCMFunctionKeyWordEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCMFunctionKeyWordEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCMFunctionKeyWordEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CMFunctionKeyWord(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable_CMFunctionKeyWord)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFunctionKeyWord.* " + 
$"from CMFunctionKeyWord " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFunctionKeyWord.mId not in " + 
$"(Select top {intTop_In} CMFunctionKeyWord.mId from CMFunctionKeyWord " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1} and mId not in (Select top {2} mId from CMFunctionKeyWord where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1} and mId not in (Select top {3} mId from CMFunctionKeyWord where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CMFunctionKeyWord.* " + 
$"from CMFunctionKeyWord " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CMFunctionKeyWord.mId not in " + 
$"(Select top {intTop_In} CMFunctionKeyWord.mId from CMFunctionKeyWord " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1} and mId not in (Select top {2} mId from CMFunctionKeyWord where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CMFunctionKeyWord where {1} and mId not in (Select top {3} mId from CMFunctionKeyWord where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCMFunctionKeyWordEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA:GetObjLst)", objException.Message));
}
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = TransNullToInt(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetObjLst)", objException.Message));
}
objCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFunctionKeyWordEN);
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
public List<clsCMFunctionKeyWordEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA:GetObjLstByTabName)", objException.Message));
}
List<clsCMFunctionKeyWordEN> arrObjLst = new List<clsCMFunctionKeyWordEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = TransNullToInt(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetObjLst)", objException.Message));
}
objCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCMFunctionKeyWordEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCMFunctionKeyWord(ref clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where mId = " + ""+ objCMFunctionKeyWordEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCMFunctionKeyWordEN.mId = TransNullToInt(objDT.Rows[0][conCMFunctionKeyWord.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objCMFunctionKeyWordEN.CmFunctionId = objDT.Rows[0][conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFunctionKeyWordEN.Keyword = objDT.Rows[0][conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objCMFunctionKeyWordEN.UpdDate = objDT.Rows[0][conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.UpdUser = objDT.Rows[0][conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.Memo = objDT.Rows[0][conCMFunctionKeyWord.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMFunctionKeyWordEN.IsSynchToServer = TransNullToBool(objDT.Rows[0][conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionKeyWordEN.SynchToServerDate = objDT.Rows[0][conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.SynchToServerUser = objDT.Rows[0][conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.IsSynchToClient = TransNullToBool(objDT.Rows[0][conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionKeyWordEN.SynchToClientDate = objDT.Rows[0][conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.SynchToClientUser = objDT.Rows[0][conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.SynSource = objDT.Rows[0][conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetCMFunctionKeyWord)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsCMFunctionKeyWordEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
 objCMFunctionKeyWordEN.mId = Int32.Parse(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objCMFunctionKeyWordEN.IsSynchToServer = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.IsSynchToClient = clsEntityBase2.TransNullToBool_S(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client(字段类型:bit,字段长度:1,是否可空:True)
 objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户(字段类型:varchar,字段长度:20,是否可空:True)
 objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetObjBymId)", objException.Message));
}
return objCMFunctionKeyWordEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCMFunctionKeyWordEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN()
{
mId = TransNullToInt(objRow[conCMFunctionKeyWord.mId].ToString().Trim()), //mId
CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(), //函数Id
Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(), //关键字
UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(), //说明
IsSynchToServer = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()), //是否同步到Server
SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(), //同步到Server日期
SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(), //同步到Server用户
IsSynchToClient = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()), //是否同步到Client
SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(), //同步到Client库日期
SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(), //同步到Client库用户
SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim() //同步来源
};
objCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFunctionKeyWordEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCMFunctionKeyWordEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = TransNullToInt(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetObjByDataRowCMFunctionKeyWord)", objException.Message));
}
objCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFunctionKeyWordEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCMFunctionKeyWordEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCMFunctionKeyWordEN objCMFunctionKeyWordEN = new clsCMFunctionKeyWordEN();
try
{
objCMFunctionKeyWordEN.mId = TransNullToInt(objRow[conCMFunctionKeyWord.mId].ToString().Trim()); //mId
objCMFunctionKeyWordEN.CmFunctionId = objRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objCMFunctionKeyWordEN.Keyword = objRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objCMFunctionKeyWordEN.UpdDate = objRow[conCMFunctionKeyWord.UpdDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objCMFunctionKeyWordEN.UpdUser = objRow[conCMFunctionKeyWord.UpdUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objCMFunctionKeyWordEN.Memo = objRow[conCMFunctionKeyWord.Memo] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objCMFunctionKeyWordEN.IsSynchToServer = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim()); //是否同步到Server
objCMFunctionKeyWordEN.SynchToServerDate = objRow[conCMFunctionKeyWord.SynchToServerDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objCMFunctionKeyWordEN.SynchToServerUser = objRow[conCMFunctionKeyWord.SynchToServerUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objCMFunctionKeyWordEN.IsSynchToClient = TransNullToBool(objRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim()); //是否同步到Client
objCMFunctionKeyWordEN.SynchToClientDate = objRow[conCMFunctionKeyWord.SynchToClientDate] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objCMFunctionKeyWordEN.SynchToClientUser = objRow[conCMFunctionKeyWord.SynchToClientUser] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objCMFunctionKeyWordEN.SynSource = objRow[conCMFunctionKeyWord.SynSource] == DBNull.Value ? null : objRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCMFunctionKeyWordDA: GetObjByDataRow)", objException.Message));
}
objCMFunctionKeyWordEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCMFunctionKeyWordEN;
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
objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFunctionKeyWordEN._CurrTabName, conCMFunctionKeyWord.mId, 8, "");
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
objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCMFunctionKeyWordEN._CurrTabName, conCMFunctionKeyWord.mId, 8, strPrefix);
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from CMFunctionKeyWord where " + strCondition;
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from CMFunctionKeyWord where " + strCondition;
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFunctionKeyWord", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CMFunctionKeyWord", strCondition))
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
objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CMFunctionKeyWord");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
 {
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionKeyWordEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFunctionKeyWord");
objRow = objDS.Tables["CMFunctionKeyWord"].NewRow();
objRow[conCMFunctionKeyWord.CmFunctionId] = objCMFunctionKeyWordEN.CmFunctionId; //函数Id
objRow[conCMFunctionKeyWord.Keyword] = objCMFunctionKeyWordEN.Keyword; //关键字
 if (objCMFunctionKeyWordEN.UpdDate !=  "")
 {
objRow[conCMFunctionKeyWord.UpdDate] = objCMFunctionKeyWordEN.UpdDate; //修改日期
 }
 if (objCMFunctionKeyWordEN.UpdUser !=  "")
 {
objRow[conCMFunctionKeyWord.UpdUser] = objCMFunctionKeyWordEN.UpdUser; //修改者
 }
 if (objCMFunctionKeyWordEN.Memo !=  "")
 {
objRow[conCMFunctionKeyWord.Memo] = objCMFunctionKeyWordEN.Memo; //说明
 }
objRow[conCMFunctionKeyWord.IsSynchToServer] = objCMFunctionKeyWordEN.IsSynchToServer; //是否同步到Server
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  "")
 {
objRow[conCMFunctionKeyWord.SynchToServerDate] = objCMFunctionKeyWordEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  "")
 {
objRow[conCMFunctionKeyWord.SynchToServerUser] = objCMFunctionKeyWordEN.SynchToServerUser; //同步到Server用户
 }
objRow[conCMFunctionKeyWord.IsSynchToClient] = objCMFunctionKeyWordEN.IsSynchToClient; //是否同步到Client
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  "")
 {
objRow[conCMFunctionKeyWord.SynchToClientDate] = objCMFunctionKeyWordEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  "")
 {
objRow[conCMFunctionKeyWord.SynchToClientUser] = objCMFunctionKeyWordEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMFunctionKeyWordEN.SynSource !=  "")
 {
objRow[conCMFunctionKeyWord.SynSource] = objCMFunctionKeyWordEN.SynSource; //同步来源
 }
objDS.Tables[clsCMFunctionKeyWordEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCMFunctionKeyWordEN._CurrTabName);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionKeyWordEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.CmFunctionId);
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Keyword);
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdDate);
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdUser);
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Memo);
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynSource);
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunctionKeyWord");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionKeyWordEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.CmFunctionId);
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Keyword);
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdDate);
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdUser);
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Memo);
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynSource);
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunctionKeyWord");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionKeyWordEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.CmFunctionId);
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Keyword);
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdDate);
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdUser);
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Memo);
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynSource);
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunctionKeyWord");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCMFunctionKeyWordEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.CmFunctionId);
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCmFunctionId + "'");
 }
 
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Keyword);
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdDate);
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.UpdUser);
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.Memo);
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToServer);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToServer  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerDate);
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToServerUser);
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToServerUser + "'");
 }
 
 arrFieldListForInsert.Add(conCMFunctionKeyWord.IsSynchToClient);
 arrValueListForInsert.Add("'" + (objCMFunctionKeyWordEN.IsSynchToClient  ==  false ? "0" : "1") + "'");
 
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientDate);
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientDate + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynchToClientUser);
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynchToClientUser + "'");
 }
 
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 arrFieldListForInsert.Add(conCMFunctionKeyWord.SynSource);
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSynSource + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CMFunctionKeyWord");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCMFunctionKeyWords(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CMFunctionKeyWord");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conCMFunctionKeyWord.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCMFunctionKeyWordEN._CurrTabName ].NewRow();
objRow[conCMFunctionKeyWord.CmFunctionId] = oRow[conCMFunctionKeyWord.CmFunctionId].ToString().Trim(); //函数Id
objRow[conCMFunctionKeyWord.Keyword] = oRow[conCMFunctionKeyWord.Keyword].ToString().Trim(); //关键字
objRow[conCMFunctionKeyWord.UpdDate] = oRow[conCMFunctionKeyWord.UpdDate].ToString().Trim(); //修改日期
objRow[conCMFunctionKeyWord.UpdUser] = oRow[conCMFunctionKeyWord.UpdUser].ToString().Trim(); //修改者
objRow[conCMFunctionKeyWord.Memo] = oRow[conCMFunctionKeyWord.Memo].ToString().Trim(); //说明
objRow[conCMFunctionKeyWord.IsSynchToServer] = oRow[conCMFunctionKeyWord.IsSynchToServer].ToString().Trim(); //是否同步到Server
objRow[conCMFunctionKeyWord.SynchToServerDate] = oRow[conCMFunctionKeyWord.SynchToServerDate].ToString().Trim(); //同步到Server日期
objRow[conCMFunctionKeyWord.SynchToServerUser] = oRow[conCMFunctionKeyWord.SynchToServerUser].ToString().Trim(); //同步到Server用户
objRow[conCMFunctionKeyWord.IsSynchToClient] = oRow[conCMFunctionKeyWord.IsSynchToClient].ToString().Trim(); //是否同步到Client
objRow[conCMFunctionKeyWord.SynchToClientDate] = oRow[conCMFunctionKeyWord.SynchToClientDate].ToString().Trim(); //同步到Client库日期
objRow[conCMFunctionKeyWord.SynchToClientUser] = oRow[conCMFunctionKeyWord.SynchToClientUser].ToString().Trim(); //同步到Client库用户
objRow[conCMFunctionKeyWord.SynSource] = oRow[conCMFunctionKeyWord.SynSource].ToString().Trim(); //同步来源
 objDS.Tables[clsCMFunctionKeyWordEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCMFunctionKeyWordEN._CurrTabName);
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionKeyWordEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
strSQL = "Select * from CMFunctionKeyWord where mId = " + ""+ objCMFunctionKeyWordEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCMFunctionKeyWordEN._CurrTabName);
if (objDS.Tables[clsCMFunctionKeyWordEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objCMFunctionKeyWordEN.mId+"");
return false;
}
objRow = objDS.Tables[clsCMFunctionKeyWordEN._CurrTabName].Rows[0];
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.CmFunctionId))
 {
objRow[conCMFunctionKeyWord.CmFunctionId] = objCMFunctionKeyWordEN.CmFunctionId; //函数Id
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Keyword))
 {
objRow[conCMFunctionKeyWord.Keyword] = objCMFunctionKeyWordEN.Keyword; //关键字
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdDate))
 {
objRow[conCMFunctionKeyWord.UpdDate] = objCMFunctionKeyWordEN.UpdDate; //修改日期
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdUser))
 {
objRow[conCMFunctionKeyWord.UpdUser] = objCMFunctionKeyWordEN.UpdUser; //修改者
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Memo))
 {
objRow[conCMFunctionKeyWord.Memo] = objCMFunctionKeyWordEN.Memo; //说明
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToServer))
 {
objRow[conCMFunctionKeyWord.IsSynchToServer] = objCMFunctionKeyWordEN.IsSynchToServer; //是否同步到Server
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerDate))
 {
objRow[conCMFunctionKeyWord.SynchToServerDate] = objCMFunctionKeyWordEN.SynchToServerDate; //同步到Server日期
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerUser))
 {
objRow[conCMFunctionKeyWord.SynchToServerUser] = objCMFunctionKeyWordEN.SynchToServerUser; //同步到Server用户
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToClient))
 {
objRow[conCMFunctionKeyWord.IsSynchToClient] = objCMFunctionKeyWordEN.IsSynchToClient; //是否同步到Client
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientDate))
 {
objRow[conCMFunctionKeyWord.SynchToClientDate] = objCMFunctionKeyWordEN.SynchToClientDate; //同步到Client库日期
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientUser))
 {
objRow[conCMFunctionKeyWord.SynchToClientUser] = objCMFunctionKeyWordEN.SynchToClientUser; //同步到Client库用户
 }
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynSource))
 {
objRow[conCMFunctionKeyWord.SynSource] = objCMFunctionKeyWordEN.SynSource; //同步来源
 }
try
{
objDA.Update(objDS, clsCMFunctionKeyWordEN._CurrTabName);
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionKeyWordEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CMFunctionKeyWord Set ");
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.CmFunctionId))
 {
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmFunctionId, conCMFunctionKeyWord.CmFunctionId); //函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.CmFunctionId); //函数Id
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Keyword))
 {
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conCMFunctionKeyWord.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.Keyword); //关键字
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdDate))
 {
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFunctionKeyWord.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.UpdDate); //修改日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdUser))
 {
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFunctionKeyWord.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.UpdUser); //修改者
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Memo))
 {
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFunctionKeyWord.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.Memo); //说明
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionKeyWordEN.IsSynchToServer == true?"1":"0", conCMFunctionKeyWord.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerDate))
 {
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMFunctionKeyWord.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerUser))
 {
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMFunctionKeyWord.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionKeyWordEN.IsSynchToClient == true?"1":"0", conCMFunctionKeyWord.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientDate))
 {
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMFunctionKeyWord.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientUser))
 {
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMFunctionKeyWord.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynSource))
 {
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMFunctionKeyWord.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCMFunctionKeyWordEN.mId); 
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strCondition)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionKeyWordEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFunctionKeyWord Set ");
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.CmFunctionId))
 {
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmFunctionId = '{0}',", strCmFunctionId); //函数Id
 }
 else
 {
 sbSQL.Append(" CmFunctionId = null,"); //函数Id
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Keyword))
 {
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdDate))
 {
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdUser))
 {
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Memo))
 {
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMFunctionKeyWordEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerDate))
 {
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerUser))
 {
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMFunctionKeyWordEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientDate))
 {
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientUser))
 {
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynSource))
 {
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynSource = '{0}',", strSynSource); //同步来源
 }
 else
 {
 sbSQL.Append(" SynSource = null,"); //同步来源
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
 /// <param name = "objCMFunctionKeyWordEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionKeyWordEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFunctionKeyWord Set ");
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.CmFunctionId))
 {
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CmFunctionId = '{0}',", strCmFunctionId); //函数Id
 }
 else
 {
 sbSQL.Append(" CmFunctionId = null,"); //函数Id
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Keyword))
 {
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdDate))
 {
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdUser))
 {
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Memo))
 {
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToServer))
 {
 sbSQL.AppendFormat(" IsSynchToServer = '{0}',", objCMFunctionKeyWordEN.IsSynchToServer == true?"1":"0"); //是否同步到Server
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerDate))
 {
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerDate = '{0}',", strSynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.Append(" SynchToServerDate = null,"); //同步到Server日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerUser))
 {
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToServerUser = '{0}',", strSynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.Append(" SynchToServerUser = null,"); //同步到Server用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToClient))
 {
 sbSQL.AppendFormat(" IsSynchToClient = '{0}',", objCMFunctionKeyWordEN.IsSynchToClient == true?"1":"0"); //是否同步到Client
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientDate))
 {
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientDate = '{0}',", strSynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.Append(" SynchToClientDate = null,"); //同步到Client库日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientUser))
 {
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynchToClientUser = '{0}',", strSynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.Append(" SynchToClientUser = null,"); //同步到Client库用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynSource))
 {
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SynSource = '{0}',", strSynSource); //同步来源
 }
 else
 {
 sbSQL.Append(" SynSource = null,"); //同步来源
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
 /// <param name = "objCMFunctionKeyWordEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objCMFunctionKeyWordEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objCMFunctionKeyWordEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCMFunctionKeyWordEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CMFunctionKeyWord Set ");
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.CmFunctionId))
 {
 if (objCMFunctionKeyWordEN.CmFunctionId !=  null)
 {
 var strCmFunctionId = objCMFunctionKeyWordEN.CmFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCmFunctionId, conCMFunctionKeyWord.CmFunctionId); //函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.CmFunctionId); //函数Id
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Keyword))
 {
 if (objCMFunctionKeyWordEN.Keyword !=  null)
 {
 var strKeyword = objCMFunctionKeyWordEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conCMFunctionKeyWord.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.Keyword); //关键字
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdDate))
 {
 if (objCMFunctionKeyWordEN.UpdDate !=  null)
 {
 var strUpdDate = objCMFunctionKeyWordEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conCMFunctionKeyWord.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.UpdDate); //修改日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.UpdUser))
 {
 if (objCMFunctionKeyWordEN.UpdUser !=  null)
 {
 var strUpdUser = objCMFunctionKeyWordEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conCMFunctionKeyWord.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.UpdUser); //修改者
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.Memo))
 {
 if (objCMFunctionKeyWordEN.Memo !=  null)
 {
 var strMemo = objCMFunctionKeyWordEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conCMFunctionKeyWord.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.Memo); //说明
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToServer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionKeyWordEN.IsSynchToServer == true?"1":"0", conCMFunctionKeyWord.IsSynchToServer); //是否同步到Server
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerDate))
 {
 if (objCMFunctionKeyWordEN.SynchToServerDate !=  null)
 {
 var strSynchToServerDate = objCMFunctionKeyWordEN.SynchToServerDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerDate, conCMFunctionKeyWord.SynchToServerDate); //同步到Server日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToServerDate); //同步到Server日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToServerUser))
 {
 if (objCMFunctionKeyWordEN.SynchToServerUser !=  null)
 {
 var strSynchToServerUser = objCMFunctionKeyWordEN.SynchToServerUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToServerUser, conCMFunctionKeyWord.SynchToServerUser); //同步到Server用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToServerUser); //同步到Server用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.IsSynchToClient))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objCMFunctionKeyWordEN.IsSynchToClient == true?"1":"0", conCMFunctionKeyWord.IsSynchToClient); //是否同步到Client
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientDate))
 {
 if (objCMFunctionKeyWordEN.SynchToClientDate !=  null)
 {
 var strSynchToClientDate = objCMFunctionKeyWordEN.SynchToClientDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientDate, conCMFunctionKeyWord.SynchToClientDate); //同步到Client库日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToClientDate); //同步到Client库日期
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynchToClientUser))
 {
 if (objCMFunctionKeyWordEN.SynchToClientUser !=  null)
 {
 var strSynchToClientUser = objCMFunctionKeyWordEN.SynchToClientUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynchToClientUser, conCMFunctionKeyWord.SynchToClientUser); //同步到Client库用户
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynchToClientUser); //同步到Client库用户
 }
 }
 
 if (objCMFunctionKeyWordEN.IsUpdated(conCMFunctionKeyWord.SynSource))
 {
 if (objCMFunctionKeyWordEN.SynSource !=  null)
 {
 var strSynSource = objCMFunctionKeyWordEN.SynSource.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSynSource, conCMFunctionKeyWord.SynSource); //同步来源
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCMFunctionKeyWord.SynSource); //同步来源
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objCMFunctionKeyWordEN.mId); 
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("CMFunctionKeyWord_Delete", values);
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
//删除CMFunctionKeyWord本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFunctionKeyWord where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCMFunctionKeyWord(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
//删除CMFunctionKeyWord本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFunctionKeyWord where mId in (" + strKeyList + ")";
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
//删除CMFunctionKeyWord本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CMFunctionKeyWord where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCMFunctionKeyWord(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: DelCMFunctionKeyWord)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFunctionKeyWord where " + strCondition ;
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
public bool DelCMFunctionKeyWordWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCMFunctionKeyWordDA: DelCMFunctionKeyWordWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CMFunctionKeyWord where " + strCondition ;
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
 /// <param name = "objCMFunctionKeyWordENS">源对象</param>
 /// <param name = "objCMFunctionKeyWordENT">目标对象</param>
public void CopyTo(clsCMFunctionKeyWordEN objCMFunctionKeyWordENS, clsCMFunctionKeyWordEN objCMFunctionKeyWordENT)
{
objCMFunctionKeyWordENT.mId = objCMFunctionKeyWordENS.mId; //mId
objCMFunctionKeyWordENT.CmFunctionId = objCMFunctionKeyWordENS.CmFunctionId; //函数Id
objCMFunctionKeyWordENT.Keyword = objCMFunctionKeyWordENS.Keyword; //关键字
objCMFunctionKeyWordENT.UpdDate = objCMFunctionKeyWordENS.UpdDate; //修改日期
objCMFunctionKeyWordENT.UpdUser = objCMFunctionKeyWordENS.UpdUser; //修改者
objCMFunctionKeyWordENT.Memo = objCMFunctionKeyWordENS.Memo; //说明
objCMFunctionKeyWordENT.IsSynchToServer = objCMFunctionKeyWordENS.IsSynchToServer; //是否同步到Server
objCMFunctionKeyWordENT.SynchToServerDate = objCMFunctionKeyWordENS.SynchToServerDate; //同步到Server日期
objCMFunctionKeyWordENT.SynchToServerUser = objCMFunctionKeyWordENS.SynchToServerUser; //同步到Server用户
objCMFunctionKeyWordENT.IsSynchToClient = objCMFunctionKeyWordENS.IsSynchToClient; //是否同步到Client
objCMFunctionKeyWordENT.SynchToClientDate = objCMFunctionKeyWordENS.SynchToClientDate; //同步到Client库日期
objCMFunctionKeyWordENT.SynchToClientUser = objCMFunctionKeyWordENS.SynchToClientUser; //同步到Client库用户
objCMFunctionKeyWordENT.SynSource = objCMFunctionKeyWordENS.SynSource; //同步来源
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCMFunctionKeyWordEN.CmFunctionId, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldNotNull(objCMFunctionKeyWordEN.Keyword, conCMFunctionKeyWord.Keyword);
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.CmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.Keyword, 50, conCMFunctionKeyWord.Keyword);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.UpdDate, 20, conCMFunctionKeyWord.UpdDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.UpdUser, 20, conCMFunctionKeyWord.UpdUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.Memo, 1000, conCMFunctionKeyWord.Memo);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToServerDate, 20, conCMFunctionKeyWord.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToServerUser, 20, conCMFunctionKeyWord.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToClientDate, 20, conCMFunctionKeyWord.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToClientUser, 20, conCMFunctionKeyWord.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynSource, 50, conCMFunctionKeyWord.SynSource);
//检查字段外键固定长度
 objCMFunctionKeyWordEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.CmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.Keyword, 50, conCMFunctionKeyWord.Keyword);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.UpdDate, 20, conCMFunctionKeyWord.UpdDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.UpdUser, 20, conCMFunctionKeyWord.UpdUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.Memo, 1000, conCMFunctionKeyWord.Memo);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToServerDate, 20, conCMFunctionKeyWord.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToServerUser, 20, conCMFunctionKeyWord.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToClientDate, 20, conCMFunctionKeyWord.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToClientUser, 20, conCMFunctionKeyWord.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynSource, 50, conCMFunctionKeyWord.SynSource);
//检查外键字段长度
 objCMFunctionKeyWordEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.CmFunctionId, 8, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.Keyword, 50, conCMFunctionKeyWord.Keyword);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.UpdDate, 20, conCMFunctionKeyWord.UpdDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.UpdUser, 20, conCMFunctionKeyWord.UpdUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.Memo, 1000, conCMFunctionKeyWord.Memo);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToServerDate, 20, conCMFunctionKeyWord.SynchToServerDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToServerUser, 20, conCMFunctionKeyWord.SynchToServerUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToClientDate, 20, conCMFunctionKeyWord.SynchToClientDate);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynchToClientUser, 20, conCMFunctionKeyWord.SynchToClientUser);
clsCheckSql.CheckFieldLen(objCMFunctionKeyWordEN.SynSource, 50, conCMFunctionKeyWord.SynSource);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.CmFunctionId, conCMFunctionKeyWord.CmFunctionId);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.Keyword, conCMFunctionKeyWord.Keyword);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.UpdDate, conCMFunctionKeyWord.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.UpdUser, conCMFunctionKeyWord.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.Memo, conCMFunctionKeyWord.Memo);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.SynchToServerDate, conCMFunctionKeyWord.SynchToServerDate);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.SynchToServerUser, conCMFunctionKeyWord.SynchToServerUser);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.SynchToClientDate, conCMFunctionKeyWord.SynchToClientDate);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.SynchToClientUser, conCMFunctionKeyWord.SynchToClientUser);
clsCheckSql.CheckSqlInjection4Field(objCMFunctionKeyWordEN.SynSource, conCMFunctionKeyWord.SynSource);
//检查外键字段长度
 objCMFunctionKeyWordEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CMFunctionKeyWord(CM函数关键字),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCMFunctionKeyWordEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCMFunctionKeyWordEN objCMFunctionKeyWordEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and CmFunctionId = '{0}'", objCMFunctionKeyWordEN.CmFunctionId);
 sbCondition.AppendFormat(" and Keyword = '{0}'", objCMFunctionKeyWordEN.Keyword);
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFunctionKeyWordEN._CurrTabName);
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCMFunctionKeyWordEN._CurrTabName, strCondition);
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
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
 objSQL = clsCMFunctionKeyWordDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}