
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab4GeneCodeDA
 表名:vPrjTab4GeneCode(00050284)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:48:20
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
 /// vPrjTab4GeneCode(vPrjTab4GeneCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjTab4GeneCodeDA : clsCommBase4DA
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
 return clsvPrjTab4GeneCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjTab4GeneCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab4GeneCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjTab4GeneCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjTab4GeneCodeEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPrjTab4GeneCode中,检查关键字,长度不正确!(clsvPrjTab4GeneCodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjTab4GeneCode中,关键字不能为空 或 null!(clsvPrjTab4GeneCodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjTab4GeneCodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjTab4GeneCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable_vPrjTab4GeneCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab4GeneCode.* " + 
$"from vPrjTab4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab4GeneCode.TabId not in " + 
$"(Select top {intTop_In} vPrjTab4GeneCode.TabId from vPrjTab4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1} and TabId not in (Select top {2} TabId from vPrjTab4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1} and TabId not in (Select top {3} TabId from vPrjTab4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab4GeneCode.* " + 
$"from vPrjTab4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab4GeneCode.TabId not in " + 
$"(Select top {intTop_In} vPrjTab4GeneCode.TabId from vPrjTab4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1} and TabId not in (Select top {2} TabId from vPrjTab4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab4GeneCode where {1} and TabId not in (Select top {3} TabId from vPrjTab4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjTab4GeneCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA:GetObjLst)", objException.Message));
}
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = TransNullToBool(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = TransNullToBool(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = TransNullToBool(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetObjLst)", objException.Message));
}
objvPrjTab4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
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
public List<clsvPrjTab4GeneCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjTab4GeneCodeEN> arrObjLst = new List<clsvPrjTab4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = TransNullToBool(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = TransNullToBool(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = TransNullToBool(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetObjLst)", objException.Message));
}
objvPrjTab4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab4GeneCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjTab4GeneCode(ref clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where TabId = " + "'"+ objvPrjTab4GeneCodeEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjTab4GeneCodeEN.TabId = objDT.Rows[0][convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4GeneCodeEN.FldNum = TransNullToInt(objDT.Rows[0][convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4GeneCodeEN.GeneCodeDate = objDT.Rows[0][convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4GeneCodeEN.IsNeedGene = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.VersionGeneCode = objDT.Rows[0][convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvPrjTab4GeneCodeEN.TabName = objDT.Rows[0][convPrjTab4GeneCode.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab4GeneCodeEN.TabCnName = objDT.Rows[0][convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTab4GeneCodeEN.PrjId = objDT.Rows[0][convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4GeneCodeEN.PrjName = objDT.Rows[0][convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTab4GeneCodeEN.SqlDsTypeId = objDT.Rows[0][convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4GeneCodeEN.SqlDsTypeName = objDT.Rows[0][convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTab4GeneCodeEN.TabStateId = objDT.Rows[0][convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4GeneCodeEN.TabStateName = objDT.Rows[0][convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.TabNameB = objDT.Rows[0][convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4GeneCodeEN.IsParaTab = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsNationStandard = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsArchive = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsChecked = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.FuncModuleAgcId = objDT.Rows[0][convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4GeneCodeEN.FuncModuleName = objDT.Rows[0][convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.FuncModuleEnName = objDT.Rows[0][convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTab4GeneCodeEN.Owner = objDT.Rows[0][convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTab4GeneCodeEN.IsReleToSqlTab = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.Keyword = objDT.Rows[0][convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4GeneCodeEN.TabTypeId = objDT.Rows[0][convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4GeneCodeEN.TabTypeName = objDT.Rows[0][convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.TabMainTypeId = objDT.Rows[0][convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvPrjTab4GeneCodeEN.TabMainTypeName = objDT.Rows[0][convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTab4GeneCodeEN.RelaTabId4View = objDT.Rows[0][convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4GeneCodeEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsUseCache = TransNullToBool(objDT.Rows[0][convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.CacheClassifyField = objDT.Rows[0][convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段(字段类型:char,字段长度:8,是否可空:True)
 objvPrjTab4GeneCodeEN.UpdUserId = objDT.Rows[0][convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4GeneCodeEN.UpdDate = objDT.Rows[0][convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4GeneCodeEN.Memo = objDT.Rows[0][convPrjTab4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTab4GeneCodeEN.ErrMsg2 = objDT.Rows[0][convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPrjTab4GeneCodeEN.DataBaseNameTab = objDT.Rows[0][convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4GeneCodeEN.UserId4GeneCode = objDT.Rows[0][convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetvPrjTab4GeneCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjTab4GeneCodeEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
 objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4GeneCodeEN.IsNeedGene = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4GeneCodeEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTab4GeneCodeEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段(字段类型:char,字段长度:8,是否可空:True)
 objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2(字段类型:varchar,字段长度:8000,是否可空:True)
 objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode(字段类型:varchar,字段长度:18,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetObjByTabId)", objException.Message));
}
return objvPrjTab4GeneCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjTab4GeneCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN()
{
TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(), //表ID
FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()), //字段数
GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(), //生成代码日期
IsNeedGene = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()), //是否需要生成
VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(), //生成代码版本
ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(), //表名
TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(), //表中文名
PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(), //工程名称
IsNeedTransCode = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(), //表状态ID
TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(), //表状态名称
TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(), //表名_后备
IsParaTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()), //是否参数表
IsNationStandard = TransNullToBool(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()), //是否国标
IsArchive = TransNullToBool(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()), //是否存档
IsChecked = TransNullToBool(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()), //是否核实
FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(), //拥有者
IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()), //是否与SQL表相关
Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(), //表类型Id
TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(), //表类型名
TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(), //表主类型Id
TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(), //表主类型名
RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(), //视图的相关表ID
OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()), //引用序号
IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()), //是否需要生成索引器
IsUseCache = TransNullToBool(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()), //是否使用Cache
CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(), //缓存分类字段
UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(), //说明
ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(), //ErrMsg2
DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(), //DataBaseName_Tab
UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim() //UserId4GeneCode
};
objvPrjTab4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab4GeneCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjTab4GeneCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = TransNullToBool(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = TransNullToBool(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = TransNullToBool(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetObjByDataRowvPrjTab4GeneCode)", objException.Message));
}
objvPrjTab4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab4GeneCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjTab4GeneCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN = new clsvPrjTab4GeneCodeEN();
try
{
objvPrjTab4GeneCodeEN.TabId = objRow[convPrjTab4GeneCode.TabId].ToString().Trim(); //表ID
objvPrjTab4GeneCodeEN.FldNum = objRow[convPrjTab4GeneCode.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.FldNum].ToString().Trim()); //字段数
objvPrjTab4GeneCodeEN.GeneCodeDate = objRow[convPrjTab4GeneCode.GeneCodeDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.GeneCodeDate].ToString().Trim(); //生成代码日期
objvPrjTab4GeneCodeEN.IsNeedGene = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGene].ToString().Trim()); //是否需要生成
objvPrjTab4GeneCodeEN.VersionGeneCode = objRow[convPrjTab4GeneCode.VersionGeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.VersionGeneCode].ToString().Trim(); //生成代码版本
objvPrjTab4GeneCodeEN.ApplicationTypeId = objRow[convPrjTab4GeneCode.ApplicationTypeId] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvPrjTab4GeneCodeEN.TabName = objRow[convPrjTab4GeneCode.TabName].ToString().Trim(); //表名
objvPrjTab4GeneCodeEN.TabCnName = objRow[convPrjTab4GeneCode.TabCnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabCnName].ToString().Trim(); //表中文名
objvPrjTab4GeneCodeEN.PrjId = objRow[convPrjTab4GeneCode.PrjId].ToString().Trim(); //工程Id
objvPrjTab4GeneCodeEN.PrjName = objRow[convPrjTab4GeneCode.PrjName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.PrjName].ToString().Trim(); //工程名称
objvPrjTab4GeneCodeEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTab4GeneCodeEN.SqlDsTypeId = objRow[convPrjTab4GeneCode.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab4GeneCodeEN.SqlDsTypeName = objRow[convPrjTab4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTab4GeneCodeEN.TabStateId = objRow[convPrjTab4GeneCode.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab4GeneCodeEN.TabStateName = objRow[convPrjTab4GeneCode.TabStateName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabStateName].ToString().Trim(); //表状态名称
objvPrjTab4GeneCodeEN.TabNameB = objRow[convPrjTab4GeneCode.TabNameB] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabNameB].ToString().Trim(); //表名_后备
objvPrjTab4GeneCodeEN.IsParaTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTab4GeneCodeEN.IsNationStandard = TransNullToBool(objRow[convPrjTab4GeneCode.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTab4GeneCodeEN.IsArchive = TransNullToBool(objRow[convPrjTab4GeneCode.IsArchive].ToString().Trim()); //是否存档
objvPrjTab4GeneCodeEN.IsChecked = TransNullToBool(objRow[convPrjTab4GeneCode.IsChecked].ToString().Trim()); //是否核实
objvPrjTab4GeneCodeEN.FuncModuleAgcId = objRow[convPrjTab4GeneCode.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab4GeneCodeEN.FuncModuleName = objRow[convPrjTab4GeneCode.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTab4GeneCodeEN.FuncModuleEnName = objRow[convPrjTab4GeneCode.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTab4GeneCodeEN.Owner = objRow[convPrjTab4GeneCode.Owner] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Owner].ToString().Trim(); //拥有者
objvPrjTab4GeneCodeEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab4GeneCode.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTab4GeneCodeEN.Keyword = objRow[convPrjTab4GeneCode.Keyword] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Keyword].ToString().Trim(); //关键字
objvPrjTab4GeneCodeEN.TabTypeId = objRow[convPrjTab4GeneCode.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab4GeneCodeEN.TabTypeName = objRow[convPrjTab4GeneCode.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabTypeName].ToString().Trim(); //表类型名
objvPrjTab4GeneCodeEN.TabMainTypeId = objRow[convPrjTab4GeneCode.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTab4GeneCodeEN.TabMainTypeName = objRow[convPrjTab4GeneCode.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTab4GeneCodeEN.RelaTabId4View = objRow[convPrjTab4GeneCode.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTab4GeneCodeEN.OrderNum4Refer = objRow[convPrjTab4GeneCode.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab4GeneCode.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTab4GeneCodeEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab4GeneCode.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTab4GeneCodeEN.IsUseCache = TransNullToBool(objRow[convPrjTab4GeneCode.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTab4GeneCodeEN.CacheClassifyField = objRow[convPrjTab4GeneCode.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTab4GeneCodeEN.UpdUserId = objRow[convPrjTab4GeneCode.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTab4GeneCodeEN.UpdDate = objRow[convPrjTab4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvPrjTab4GeneCodeEN.Memo = objRow[convPrjTab4GeneCode.Memo] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.Memo].ToString().Trim(); //说明
objvPrjTab4GeneCodeEN.ErrMsg2 = objRow[convPrjTab4GeneCode.ErrMsg2] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.ErrMsg2].ToString().Trim(); //ErrMsg2
objvPrjTab4GeneCodeEN.DataBaseNameTab = objRow[convPrjTab4GeneCode.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
objvPrjTab4GeneCodeEN.UserId4GeneCode = objRow[convPrjTab4GeneCode.UserId4GeneCode] == DBNull.Value ? null : objRow[convPrjTab4GeneCode.UserId4GeneCode].ToString().Trim(); //UserId4GeneCode
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjTab4GeneCodeDA: GetObjByDataRow)", objException.Message));
}
objvPrjTab4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab4GeneCodeEN;
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
objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab4GeneCodeEN._CurrTabName, convPrjTab4GeneCode.TabId, 8, "");
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
objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab4GeneCodeEN._CurrTabName, convPrjTab4GeneCode.TabId, 8, strPrefix);
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vPrjTab4GeneCode where " + strCondition;
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vPrjTab4GeneCode where " + strCondition;
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab4GeneCode", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjTab4GeneCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab4GeneCode", strCondition))
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
objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjTab4GeneCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTab4GeneCodeENS">源对象</param>
 /// <param name = "objvPrjTab4GeneCodeENT">目标对象</param>
public void CopyTo(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENS, clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeENT)
{
objvPrjTab4GeneCodeENT.TabId = objvPrjTab4GeneCodeENS.TabId; //表ID
objvPrjTab4GeneCodeENT.FldNum = objvPrjTab4GeneCodeENS.FldNum; //字段数
objvPrjTab4GeneCodeENT.GeneCodeDate = objvPrjTab4GeneCodeENS.GeneCodeDate; //生成代码日期
objvPrjTab4GeneCodeENT.IsNeedGene = objvPrjTab4GeneCodeENS.IsNeedGene; //是否需要生成
objvPrjTab4GeneCodeENT.VersionGeneCode = objvPrjTab4GeneCodeENS.VersionGeneCode; //生成代码版本
objvPrjTab4GeneCodeENT.ApplicationTypeId = objvPrjTab4GeneCodeENS.ApplicationTypeId; //应用程序类型ID
objvPrjTab4GeneCodeENT.TabName = objvPrjTab4GeneCodeENS.TabName; //表名
objvPrjTab4GeneCodeENT.TabCnName = objvPrjTab4GeneCodeENS.TabCnName; //表中文名
objvPrjTab4GeneCodeENT.PrjId = objvPrjTab4GeneCodeENS.PrjId; //工程Id
objvPrjTab4GeneCodeENT.PrjName = objvPrjTab4GeneCodeENS.PrjName; //工程名称
objvPrjTab4GeneCodeENT.IsNeedTransCode = objvPrjTab4GeneCodeENS.IsNeedTransCode; //是否需要转换代码
objvPrjTab4GeneCodeENT.SqlDsTypeId = objvPrjTab4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objvPrjTab4GeneCodeENT.SqlDsTypeName = objvPrjTab4GeneCodeENS.SqlDsTypeName; //Sql数据源名
objvPrjTab4GeneCodeENT.TabStateId = objvPrjTab4GeneCodeENS.TabStateId; //表状态ID
objvPrjTab4GeneCodeENT.TabStateName = objvPrjTab4GeneCodeENS.TabStateName; //表状态名称
objvPrjTab4GeneCodeENT.TabNameB = objvPrjTab4GeneCodeENS.TabNameB; //表名_后备
objvPrjTab4GeneCodeENT.IsParaTab = objvPrjTab4GeneCodeENS.IsParaTab; //是否参数表
objvPrjTab4GeneCodeENT.IsNationStandard = objvPrjTab4GeneCodeENS.IsNationStandard; //是否国标
objvPrjTab4GeneCodeENT.IsArchive = objvPrjTab4GeneCodeENS.IsArchive; //是否存档
objvPrjTab4GeneCodeENT.IsChecked = objvPrjTab4GeneCodeENS.IsChecked; //是否核实
objvPrjTab4GeneCodeENT.FuncModuleAgcId = objvPrjTab4GeneCodeENS.FuncModuleAgcId; //功能模块Id
objvPrjTab4GeneCodeENT.FuncModuleName = objvPrjTab4GeneCodeENS.FuncModuleName; //功能模块名称
objvPrjTab4GeneCodeENT.FuncModuleEnName = objvPrjTab4GeneCodeENS.FuncModuleEnName; //功能模块英文名称
objvPrjTab4GeneCodeENT.Owner = objvPrjTab4GeneCodeENS.Owner; //拥有者
objvPrjTab4GeneCodeENT.IsReleToSqlTab = objvPrjTab4GeneCodeENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTab4GeneCodeENT.Keyword = objvPrjTab4GeneCodeENS.Keyword; //关键字
objvPrjTab4GeneCodeENT.TabTypeId = objvPrjTab4GeneCodeENS.TabTypeId; //表类型Id
objvPrjTab4GeneCodeENT.TabTypeName = objvPrjTab4GeneCodeENS.TabTypeName; //表类型名
objvPrjTab4GeneCodeENT.TabMainTypeId = objvPrjTab4GeneCodeENS.TabMainTypeId; //表主类型Id
objvPrjTab4GeneCodeENT.TabMainTypeName = objvPrjTab4GeneCodeENS.TabMainTypeName; //表主类型名
objvPrjTab4GeneCodeENT.RelaTabId4View = objvPrjTab4GeneCodeENS.RelaTabId4View; //视图的相关表ID
objvPrjTab4GeneCodeENT.OrderNum4Refer = objvPrjTab4GeneCodeENS.OrderNum4Refer; //引用序号
objvPrjTab4GeneCodeENT.IsNeedGeneIndexer = objvPrjTab4GeneCodeENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTab4GeneCodeENT.IsUseCache = objvPrjTab4GeneCodeENS.IsUseCache; //是否使用Cache
objvPrjTab4GeneCodeENT.CacheClassifyField = objvPrjTab4GeneCodeENS.CacheClassifyField; //缓存分类字段
objvPrjTab4GeneCodeENT.UpdUserId = objvPrjTab4GeneCodeENS.UpdUserId; //修改用户Id
objvPrjTab4GeneCodeENT.UpdDate = objvPrjTab4GeneCodeENS.UpdDate; //修改日期
objvPrjTab4GeneCodeENT.Memo = objvPrjTab4GeneCodeENS.Memo; //说明
objvPrjTab4GeneCodeENT.ErrMsg2 = objvPrjTab4GeneCodeENS.ErrMsg2; //ErrMsg2
objvPrjTab4GeneCodeENT.DataBaseNameTab = objvPrjTab4GeneCodeENS.DataBaseNameTab; //DataBaseName_Tab
objvPrjTab4GeneCodeENT.UserId4GeneCode = objvPrjTab4GeneCodeENS.UserId4GeneCode; //UserId4GeneCode
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjTab4GeneCodeEN objvPrjTab4GeneCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabId, 8, convPrjTab4GeneCode.TabId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.GeneCodeDate, 20, convPrjTab4GeneCode.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.VersionGeneCode, 30, convPrjTab4GeneCode.VersionGeneCode);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabName, 100, convPrjTab4GeneCode.TabName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabCnName, 200, convPrjTab4GeneCode.TabCnName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.PrjId, 4, convPrjTab4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.PrjName, 30, convPrjTab4GeneCode.PrjName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.SqlDsTypeId, 2, convPrjTab4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.SqlDsTypeName, 20, convPrjTab4GeneCode.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabStateId, 2, convPrjTab4GeneCode.TabStateId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabStateName, 30, convPrjTab4GeneCode.TabStateName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabNameB, 50, convPrjTab4GeneCode.TabNameB);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.FuncModuleAgcId, 8, convPrjTab4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.FuncModuleName, 30, convPrjTab4GeneCode.FuncModuleName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.FuncModuleEnName, 30, convPrjTab4GeneCode.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.Owner, 50, convPrjTab4GeneCode.Owner);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.Keyword, 50, convPrjTab4GeneCode.Keyword);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabTypeId, 4, convPrjTab4GeneCode.TabTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabTypeName, 30, convPrjTab4GeneCode.TabTypeName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabMainTypeId, 4, convPrjTab4GeneCode.TabMainTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.TabMainTypeName, 30, convPrjTab4GeneCode.TabMainTypeName);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.RelaTabId4View, 8, convPrjTab4GeneCode.RelaTabId4View);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.CacheClassifyField, 8, convPrjTab4GeneCode.CacheClassifyField);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.UpdUserId, 20, convPrjTab4GeneCode.UpdUserId);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.UpdDate, 20, convPrjTab4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.Memo, 1000, convPrjTab4GeneCode.Memo);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.ErrMsg2, 8000, convPrjTab4GeneCode.ErrMsg2);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.DataBaseNameTab, 50, convPrjTab4GeneCode.DataBaseNameTab);
clsCheckSql.CheckFieldLen(objvPrjTab4GeneCodeEN.UserId4GeneCode, 18, convPrjTab4GeneCode.UserId4GeneCode);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabId, convPrjTab4GeneCode.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.GeneCodeDate, convPrjTab4GeneCode.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.VersionGeneCode, convPrjTab4GeneCode.VersionGeneCode);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabName, convPrjTab4GeneCode.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabCnName, convPrjTab4GeneCode.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.PrjId, convPrjTab4GeneCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.PrjName, convPrjTab4GeneCode.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.SqlDsTypeId, convPrjTab4GeneCode.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.SqlDsTypeName, convPrjTab4GeneCode.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabStateId, convPrjTab4GeneCode.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabStateName, convPrjTab4GeneCode.TabStateName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabNameB, convPrjTab4GeneCode.TabNameB);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.FuncModuleAgcId, convPrjTab4GeneCode.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.FuncModuleName, convPrjTab4GeneCode.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.FuncModuleEnName, convPrjTab4GeneCode.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.Owner, convPrjTab4GeneCode.Owner);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.Keyword, convPrjTab4GeneCode.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabTypeId, convPrjTab4GeneCode.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabTypeName, convPrjTab4GeneCode.TabTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabMainTypeId, convPrjTab4GeneCode.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.TabMainTypeName, convPrjTab4GeneCode.TabMainTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.RelaTabId4View, convPrjTab4GeneCode.RelaTabId4View);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.CacheClassifyField, convPrjTab4GeneCode.CacheClassifyField);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.UpdUserId, convPrjTab4GeneCode.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.UpdDate, convPrjTab4GeneCode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.Memo, convPrjTab4GeneCode.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.ErrMsg2, convPrjTab4GeneCode.ErrMsg2);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.DataBaseNameTab, convPrjTab4GeneCode.DataBaseNameTab);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab4GeneCodeEN.UserId4GeneCode, convPrjTab4GeneCode.UserId4GeneCode);
//检查外键字段长度
 objvPrjTab4GeneCodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetTabId()
{
//获取某学院所有专业信息
string strSQL = "select TabId, TabName from vPrjTab4GeneCode ";
 clsSpecSQLforSql mySql = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab4GeneCodeEN._CurrTabName);
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab4GeneCodeEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjTab4GeneCodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}