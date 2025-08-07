
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsLog4GeneTabCodeDA
 表名:Log4GeneTabCode(00050279)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:34:09
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 生成表代码日志(Log4GeneTabCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsLog4GeneTabCodeDA : clsCommBase4DA
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
 return clsLog4GeneTabCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsLog4GeneTabCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsLog4GeneTabCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsLog4GeneTabCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsLog4GeneTabCodeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Log4GeneTabCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable_Log4GeneTabCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Log4GeneTabCode.* " + 
$"from Log4GeneTabCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Log4GeneTabCode.mId not in " + 
$"(Select top {intTop_In} Log4GeneTabCode.mId from Log4GeneTabCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1} and mId not in (Select top {2} mId from Log4GeneTabCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1} and mId not in (Select top {3} mId from Log4GeneTabCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Log4GeneTabCode.* " + 
$"from Log4GeneTabCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Log4GeneTabCode.mId not in " + 
$"(Select top {intTop_In} Log4GeneTabCode.mId from Log4GeneTabCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1} and mId not in (Select top {2} mId from Log4GeneTabCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Log4GeneTabCode where {1} and mId not in (Select top {3} mId from Log4GeneTabCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsLog4GeneTabCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA:GetObjLst)", objException.Message));
}
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = TransNullToInt(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = TransNullToBool(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetObjLst)", objException.Message));
}
objLog4GeneTabCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLog4GeneTabCodeEN);
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
public List<clsLog4GeneTabCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsLog4GeneTabCodeEN> arrObjLst = new List<clsLog4GeneTabCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = TransNullToInt(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = TransNullToBool(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetObjLst)", objException.Message));
}
objLog4GeneTabCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objLog4GeneTabCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetLog4GeneTabCode(ref clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where mId = " + ""+ objLog4GeneTabCodeEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objLog4GeneTabCodeEN.mId = TransNullToInt(objDT.Rows[0][conLog4GeneTabCode.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objLog4GeneTabCodeEN.UserId = objDT.Rows[0][conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objLog4GeneTabCodeEN.TabId = objDT.Rows[0][conLog4GeneTabCode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objLog4GeneTabCodeEN.PrjId = objDT.Rows[0][conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objLog4GeneTabCodeEN.GcPathId = objDT.Rows[0][conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id(字段类型:char,字段长度:8,是否可空:True)
 objLog4GeneTabCodeEN.GeneCodeDate = objDT.Rows[0][conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objLog4GeneTabCodeEN.IsNeedGene = TransNullToBool(objDT.Rows[0][conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objLog4GeneTabCodeEN.VersionGeneCode = objDT.Rows[0][conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objLog4GeneTabCodeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objLog4GeneTabCodeEN.Memo = objDT.Rows[0][conLog4GeneTabCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetLog4GeneTabCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsLog4GeneTabCodeEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
 objLog4GeneTabCodeEN.mId = Int32.Parse(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id(字段类型:char,字段长度:8,是否可空:True)
 objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objLog4GeneTabCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetObjBymId)", objException.Message));
}
return objLog4GeneTabCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsLog4GeneTabCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN()
{
mId = TransNullToInt(objRow[conLog4GeneTabCode.mId].ToString().Trim()), //mId
UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(), //用户Id
TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(), //表ID
PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(), //工程Id
GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(), //GC路径Id
GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(), //生成代码日期
IsNeedGene = TransNullToBool(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()), //是否需要生成
VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(), //生成代码版本
ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim() //说明
};
objLog4GeneTabCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLog4GeneTabCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsLog4GeneTabCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = TransNullToInt(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = TransNullToBool(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetObjByDataRowLog4GeneTabCode)", objException.Message));
}
objLog4GeneTabCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLog4GeneTabCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsLog4GeneTabCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsLog4GeneTabCodeEN objLog4GeneTabCodeEN = new clsLog4GeneTabCodeEN();
try
{
objLog4GeneTabCodeEN.mId = TransNullToInt(objRow[conLog4GeneTabCode.mId].ToString().Trim()); //mId
objLog4GeneTabCodeEN.UserId = objRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objLog4GeneTabCodeEN.TabId = objRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objLog4GeneTabCodeEN.PrjId = objRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objLog4GeneTabCodeEN.GcPathId = objRow[conLog4GeneTabCode.GcPathId] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objLog4GeneTabCodeEN.GeneCodeDate = objRow[conLog4GeneTabCode.GeneCodeDate] == DBNull.Value ? null : objRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objLog4GeneTabCodeEN.IsNeedGene = TransNullToBool(objRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim()); //是否需要生成
objLog4GeneTabCodeEN.VersionGeneCode = objRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objLog4GeneTabCodeEN.ApplicationTypeId = objRow[conLog4GeneTabCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objLog4GeneTabCodeEN.Memo = objRow[conLog4GeneTabCode.Memo] == DBNull.Value ? null : objRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsLog4GeneTabCodeDA: GetObjByDataRow)", objException.Message));
}
objLog4GeneTabCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objLog4GeneTabCodeEN;
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
objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLog4GeneTabCodeEN._CurrTabName, conLog4GeneTabCode.mId, 8, "");
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
objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsLog4GeneTabCodeEN._CurrTabName, conLog4GeneTabCode.mId, 8, strPrefix);
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from Log4GeneTabCode where " + strCondition;
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from Log4GeneTabCode where " + strCondition;
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Log4GeneTabCode", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Log4GeneTabCode", strCondition))
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
objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Log4GeneTabCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
 {
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneTabCodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Log4GeneTabCode");
objRow = objDS.Tables["Log4GeneTabCode"].NewRow();
objRow[conLog4GeneTabCode.UserId] = objLog4GeneTabCodeEN.UserId; //用户Id
objRow[conLog4GeneTabCode.TabId] = objLog4GeneTabCodeEN.TabId; //表ID
objRow[conLog4GeneTabCode.PrjId] = objLog4GeneTabCodeEN.PrjId; //工程Id
 if (objLog4GeneTabCodeEN.GcPathId !=  "")
 {
objRow[conLog4GeneTabCode.GcPathId] = objLog4GeneTabCodeEN.GcPathId; //GC路径Id
 }
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  "")
 {
objRow[conLog4GeneTabCode.GeneCodeDate] = objLog4GeneTabCodeEN.GeneCodeDate; //生成代码日期
 }
objRow[conLog4GeneTabCode.IsNeedGene] = objLog4GeneTabCodeEN.IsNeedGene; //是否需要生成
objRow[conLog4GeneTabCode.VersionGeneCode] = objLog4GeneTabCodeEN.VersionGeneCode; //生成代码版本
objRow[conLog4GeneTabCode.ApplicationTypeId] = objLog4GeneTabCodeEN.ApplicationTypeId; //应用程序类型ID
 if (objLog4GeneTabCodeEN.Memo !=  "")
 {
objRow[conLog4GeneTabCode.Memo] = objLog4GeneTabCodeEN.Memo; //说明
 }
objDS.Tables[clsLog4GeneTabCodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsLog4GeneTabCodeEN._CurrTabName);
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneTabCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.UserId);
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.TabId);
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.PrjId);
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GcPathId);
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 arrFieldListForInsert.Add(conLog4GeneTabCode.IsNeedGene);
 arrValueListForInsert.Add("'" + (objLog4GeneTabCodeEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.ApplicationTypeId);
 arrValueListForInsert.Add(objLog4GeneTabCodeEN.ApplicationTypeId.ToString());
 }
 
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.Memo);
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneTabCode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneTabCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.UserId);
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.TabId);
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.PrjId);
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GcPathId);
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 arrFieldListForInsert.Add(conLog4GeneTabCode.IsNeedGene);
 arrValueListForInsert.Add("'" + (objLog4GeneTabCodeEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.ApplicationTypeId);
 arrValueListForInsert.Add(objLog4GeneTabCodeEN.ApplicationTypeId.ToString());
 }
 
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.Memo);
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneTabCode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneTabCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.UserId);
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.TabId);
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.PrjId);
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GcPathId);
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 arrFieldListForInsert.Add(conLog4GeneTabCode.IsNeedGene);
 arrValueListForInsert.Add("'" + (objLog4GeneTabCodeEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.ApplicationTypeId);
 arrValueListForInsert.Add(objLog4GeneTabCodeEN.ApplicationTypeId.ToString());
 }
 
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.Memo);
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneTabCode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objLog4GeneTabCodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.UserId);
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.TabId);
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.PrjId);
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GcPathId);
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGcPathId + "'");
 }
 
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.GeneCodeDate);
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 arrFieldListForInsert.Add(conLog4GeneTabCode.IsNeedGene);
 arrValueListForInsert.Add("'" + (objLog4GeneTabCodeEN.IsNeedGene  ==  false ? "0" : "1") + "'");
 
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.VersionGeneCode);
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strVersionGeneCode + "'");
 }
 
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.ApplicationTypeId);
 arrValueListForInsert.Add(objLog4GeneTabCodeEN.ApplicationTypeId.ToString());
 }
 
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conLog4GeneTabCode.Memo);
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Log4GeneTabCode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewLog4GeneTabCodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Log4GeneTabCode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conLog4GeneTabCode.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsLog4GeneTabCodeEN._CurrTabName ].NewRow();
objRow[conLog4GeneTabCode.UserId] = oRow[conLog4GeneTabCode.UserId].ToString().Trim(); //用户Id
objRow[conLog4GeneTabCode.TabId] = oRow[conLog4GeneTabCode.TabId].ToString().Trim(); //表ID
objRow[conLog4GeneTabCode.PrjId] = oRow[conLog4GeneTabCode.PrjId].ToString().Trim(); //工程Id
objRow[conLog4GeneTabCode.GcPathId] = oRow[conLog4GeneTabCode.GcPathId].ToString().Trim(); //GC路径Id
objRow[conLog4GeneTabCode.GeneCodeDate] = oRow[conLog4GeneTabCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objRow[conLog4GeneTabCode.IsNeedGene] = oRow[conLog4GeneTabCode.IsNeedGene].ToString().Trim(); //是否需要生成
objRow[conLog4GeneTabCode.VersionGeneCode] = oRow[conLog4GeneTabCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objRow[conLog4GeneTabCode.ApplicationTypeId] = oRow[conLog4GeneTabCode.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conLog4GeneTabCode.Memo] = oRow[conLog4GeneTabCode.Memo].ToString().Trim(); //说明
 objDS.Tables[clsLog4GeneTabCodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsLog4GeneTabCodeEN._CurrTabName);
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneTabCodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
strSQL = "Select * from Log4GeneTabCode where mId = " + ""+ objLog4GeneTabCodeEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsLog4GeneTabCodeEN._CurrTabName);
if (objDS.Tables[clsLog4GeneTabCodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objLog4GeneTabCodeEN.mId+"");
return false;
}
objRow = objDS.Tables[clsLog4GeneTabCodeEN._CurrTabName].Rows[0];
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.UserId))
 {
objRow[conLog4GeneTabCode.UserId] = objLog4GeneTabCodeEN.UserId; //用户Id
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.TabId))
 {
objRow[conLog4GeneTabCode.TabId] = objLog4GeneTabCodeEN.TabId; //表ID
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.PrjId))
 {
objRow[conLog4GeneTabCode.PrjId] = objLog4GeneTabCodeEN.PrjId; //工程Id
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GcPathId))
 {
objRow[conLog4GeneTabCode.GcPathId] = objLog4GeneTabCodeEN.GcPathId; //GC路径Id
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GeneCodeDate))
 {
objRow[conLog4GeneTabCode.GeneCodeDate] = objLog4GeneTabCodeEN.GeneCodeDate; //生成代码日期
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.IsNeedGene))
 {
objRow[conLog4GeneTabCode.IsNeedGene] = objLog4GeneTabCodeEN.IsNeedGene; //是否需要生成
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.VersionGeneCode))
 {
objRow[conLog4GeneTabCode.VersionGeneCode] = objLog4GeneTabCodeEN.VersionGeneCode; //生成代码版本
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.ApplicationTypeId))
 {
objRow[conLog4GeneTabCode.ApplicationTypeId] = objLog4GeneTabCodeEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.Memo))
 {
objRow[conLog4GeneTabCode.Memo] = objLog4GeneTabCodeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsLog4GeneTabCodeEN._CurrTabName);
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneTabCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Log4GeneTabCode Set ");
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.UserId))
 {
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conLog4GeneTabCode.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.UserId); //用户Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.TabId))
 {
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conLog4GeneTabCode.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.TabId); //表ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.PrjId))
 {
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conLog4GeneTabCode.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.PrjId); //工程Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GcPathId))
 {
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcPathId, conLog4GeneTabCode.GcPathId); //GC路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.GcPathId); //GC路径Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GeneCodeDate))
 {
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneCodeDate, conLog4GeneTabCode.GeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.GeneCodeDate); //生成代码日期
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.IsNeedGene))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objLog4GeneTabCodeEN.IsNeedGene == true?"1":"0", conLog4GeneTabCode.IsNeedGene); //是否需要生成
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.VersionGeneCode))
 {
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionGeneCode, conLog4GeneTabCode.VersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.VersionGeneCode); //生成代码版本
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.ApplicationTypeId))
 {
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLog4GeneTabCodeEN.ApplicationTypeId, conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.Memo))
 {
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLog4GeneTabCode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objLog4GeneTabCodeEN.mId); 
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strCondition)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneTabCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Log4GeneTabCode Set ");
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.UserId))
 {
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.TabId))
 {
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.PrjId))
 {
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GcPathId))
 {
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcPathId = '{0}',", strGcPathId); //GC路径Id
 }
 else
 {
 sbSQL.Append(" GcPathId = null,"); //GC路径Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GeneCodeDate))
 {
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneCodeDate = '{0}',", strGeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.Append(" GeneCodeDate = null,"); //生成代码日期
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.IsNeedGene))
 {
 sbSQL.AppendFormat(" IsNeedGene = '{0}',", objLog4GeneTabCodeEN.IsNeedGene == true?"1":"0"); //是否需要生成
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.VersionGeneCode))
 {
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionGeneCode = '{0}',", strVersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.Append(" VersionGeneCode = null,"); //生成代码版本
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.ApplicationTypeId))
 {
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLog4GeneTabCodeEN.ApplicationTypeId, conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.Memo))
 {
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objLog4GeneTabCodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneTabCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Log4GeneTabCode Set ");
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.UserId))
 {
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.TabId))
 {
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.PrjId))
 {
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GcPathId))
 {
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GcPathId = '{0}',", strGcPathId); //GC路径Id
 }
 else
 {
 sbSQL.Append(" GcPathId = null,"); //GC路径Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GeneCodeDate))
 {
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneCodeDate = '{0}',", strGeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.Append(" GeneCodeDate = null,"); //生成代码日期
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.IsNeedGene))
 {
 sbSQL.AppendFormat(" IsNeedGene = '{0}',", objLog4GeneTabCodeEN.IsNeedGene == true?"1":"0"); //是否需要生成
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.VersionGeneCode))
 {
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" VersionGeneCode = '{0}',", strVersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.Append(" VersionGeneCode = null,"); //生成代码版本
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.ApplicationTypeId))
 {
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLog4GeneTabCodeEN.ApplicationTypeId, conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.Memo))
 {
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objLog4GeneTabCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objLog4GeneTabCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objLog4GeneTabCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Log4GeneTabCode Set ");
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.UserId))
 {
 if (objLog4GeneTabCodeEN.UserId !=  null)
 {
 var strUserId = objLog4GeneTabCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conLog4GeneTabCode.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.UserId); //用户Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.TabId))
 {
 if (objLog4GeneTabCodeEN.TabId !=  null)
 {
 var strTabId = objLog4GeneTabCodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conLog4GeneTabCode.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.TabId); //表ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.PrjId))
 {
 if (objLog4GeneTabCodeEN.PrjId !=  null)
 {
 var strPrjId = objLog4GeneTabCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conLog4GeneTabCode.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.PrjId); //工程Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GcPathId))
 {
 if (objLog4GeneTabCodeEN.GcPathId !=  null)
 {
 var strGcPathId = objLog4GeneTabCodeEN.GcPathId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGcPathId, conLog4GeneTabCode.GcPathId); //GC路径Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.GcPathId); //GC路径Id
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.GeneCodeDate))
 {
 if (objLog4GeneTabCodeEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objLog4GeneTabCodeEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneCodeDate, conLog4GeneTabCode.GeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.GeneCodeDate); //生成代码日期
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.IsNeedGene))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objLog4GeneTabCodeEN.IsNeedGene == true?"1":"0", conLog4GeneTabCode.IsNeedGene); //是否需要生成
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.VersionGeneCode))
 {
 if (objLog4GeneTabCodeEN.VersionGeneCode !=  null)
 {
 var strVersionGeneCode = objLog4GeneTabCodeEN.VersionGeneCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strVersionGeneCode, conLog4GeneTabCode.VersionGeneCode); //生成代码版本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.VersionGeneCode); //生成代码版本
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.ApplicationTypeId))
 {
 if (objLog4GeneTabCodeEN.ApplicationTypeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objLog4GeneTabCodeEN.ApplicationTypeId, conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.ApplicationTypeId); //应用程序类型ID
 }
 }
 
 if (objLog4GeneTabCodeEN.IsUpdated(conLog4GeneTabCode.Memo))
 {
 if (objLog4GeneTabCodeEN.Memo !=  null)
 {
 var strMemo = objLog4GeneTabCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conLog4GeneTabCode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conLog4GeneTabCode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objLog4GeneTabCodeEN.mId); 
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("Log4GeneTabCode_Delete", values);
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
//删除Log4GeneTabCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Log4GeneTabCode where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelLog4GeneTabCode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
//删除Log4GeneTabCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Log4GeneTabCode where mId in (" + strKeyList + ")";
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
//删除Log4GeneTabCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Log4GeneTabCode where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelLog4GeneTabCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: DelLog4GeneTabCode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Log4GeneTabCode where " + strCondition ;
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
public bool DelLog4GeneTabCodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsLog4GeneTabCodeDA: DelLog4GeneTabCodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Log4GeneTabCode where " + strCondition ;
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
 /// <param name = "objLog4GeneTabCodeENS">源对象</param>
 /// <param name = "objLog4GeneTabCodeENT">目标对象</param>
public void CopyTo(clsLog4GeneTabCodeEN objLog4GeneTabCodeENS, clsLog4GeneTabCodeEN objLog4GeneTabCodeENT)
{
objLog4GeneTabCodeENT.mId = objLog4GeneTabCodeENS.mId; //mId
objLog4GeneTabCodeENT.UserId = objLog4GeneTabCodeENS.UserId; //用户Id
objLog4GeneTabCodeENT.TabId = objLog4GeneTabCodeENS.TabId; //表ID
objLog4GeneTabCodeENT.PrjId = objLog4GeneTabCodeENS.PrjId; //工程Id
objLog4GeneTabCodeENT.GcPathId = objLog4GeneTabCodeENS.GcPathId; //GC路径Id
objLog4GeneTabCodeENT.GeneCodeDate = objLog4GeneTabCodeENS.GeneCodeDate; //生成代码日期
objLog4GeneTabCodeENT.IsNeedGene = objLog4GeneTabCodeENS.IsNeedGene; //是否需要生成
objLog4GeneTabCodeENT.VersionGeneCode = objLog4GeneTabCodeENS.VersionGeneCode; //生成代码版本
objLog4GeneTabCodeENT.ApplicationTypeId = objLog4GeneTabCodeENS.ApplicationTypeId; //应用程序类型ID
objLog4GeneTabCodeENT.Memo = objLog4GeneTabCodeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objLog4GeneTabCodeEN.UserId, conLog4GeneTabCode.UserId);
clsCheckSql.CheckFieldNotNull(objLog4GeneTabCodeEN.TabId, conLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldNotNull(objLog4GeneTabCodeEN.PrjId, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckFieldNotNull(objLog4GeneTabCodeEN.VersionGeneCode, conLog4GeneTabCode.VersionGeneCode);
//检查字段长度
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.UserId, 18, conLog4GeneTabCode.UserId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.TabId, 8, conLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.PrjId, 4, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.GcPathId, 8, conLog4GeneTabCode.GcPathId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.GeneCodeDate, 20, conLog4GeneTabCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.VersionGeneCode, 30, conLog4GeneTabCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.Memo, 1000, conLog4GeneTabCode.Memo);
//检查字段外键固定长度
 objLog4GeneTabCodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.UserId, 18, conLog4GeneTabCode.UserId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.TabId, 8, conLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.PrjId, 4, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.GcPathId, 8, conLog4GeneTabCode.GcPathId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.GeneCodeDate, 20, conLog4GeneTabCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.VersionGeneCode, 30, conLog4GeneTabCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.Memo, 1000, conLog4GeneTabCode.Memo);
//检查外键字段长度
 objLog4GeneTabCodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.UserId, 18, conLog4GeneTabCode.UserId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.TabId, 8, conLog4GeneTabCode.TabId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.PrjId, 4, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.GcPathId, 8, conLog4GeneTabCode.GcPathId);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.GeneCodeDate, 20, conLog4GeneTabCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.VersionGeneCode, 30, conLog4GeneTabCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objLog4GeneTabCodeEN.Memo, 1000, conLog4GeneTabCode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.UserId, conLog4GeneTabCode.UserId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.TabId, conLog4GeneTabCode.TabId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.PrjId, conLog4GeneTabCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.GcPathId, conLog4GeneTabCode.GcPathId);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.GeneCodeDate, conLog4GeneTabCode.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.VersionGeneCode, conLog4GeneTabCode.VersionGeneCode);
clsCheckSql.CheckSqlInjection4Field(objLog4GeneTabCodeEN.Memo, conLog4GeneTabCode.Memo);
//检查外键字段长度
 objLog4GeneTabCodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Log4GeneTabCode(生成表代码日志),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objLog4GeneTabCodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsLog4GeneTabCodeEN objLog4GeneTabCodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objLog4GeneTabCodeEN.TabId);
 if (objLog4GeneTabCodeEN.GcPathId == null)
{
 sbCondition.AppendFormat(" and GcPathId is null");
}
else
{
 sbCondition.AppendFormat(" and GcPathId = '{0}'", objLog4GeneTabCodeEN.GcPathId);
}
 if (objLog4GeneTabCodeEN.ApplicationTypeId == null)
{
 sbCondition.AppendFormat(" and ApplicationTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objLog4GeneTabCodeEN.ApplicationTypeId);
}
 sbCondition.AppendFormat(" and UserId = '{0}'", objLog4GeneTabCodeEN.UserId);
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLog4GeneTabCodeEN._CurrTabName);
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsLog4GeneTabCodeEN._CurrTabName, strCondition);
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
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
 objSQL = clsLog4GeneTabCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}