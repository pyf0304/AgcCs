
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTab_SimDA
 表名:vPrjTab_Sim(00050597)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:15
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:字段、表维护(Table_Field)
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
 /// v工程表_Sim(vPrjTab_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjTab_SimDA : clsCommBase4DA
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
 return clsvPrjTab_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjTab_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTab_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjTab_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjTab_SimEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPrjTab_Sim中,检查关键字,长度不正确!(clsvPrjTab_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjTab_Sim中,关键字不能为空 或 null!(clsvPrjTab_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjTab_SimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjTab_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable_vPrjTab_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab_Sim.* " + 
$"from vPrjTab_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab_Sim.TabId not in " + 
$"(Select top {intTop_In} vPrjTab_Sim.TabId from vPrjTab_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1} and TabId not in (Select top {2} TabId from vPrjTab_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1} and TabId not in (Select top {3} TabId from vPrjTab_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab_Sim.* " + 
$"from vPrjTab_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab_Sim.TabId not in " + 
$"(Select top {intTop_In} vPrjTab_Sim.TabId from vPrjTab_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1} and TabId not in (Select top {2} TabId from vPrjTab_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab_Sim where {1} and TabId not in (Select top {3} TabId from vPrjTab_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjTab_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA:GetObjLst)", objException.Message));
}
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = TransNullToBool(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab_SimDA: GetObjLst)", objException.Message));
}
objvPrjTab_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab_SimEN);
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
public List<clsvPrjTab_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjTab_SimEN> arrObjLst = new List<clsvPrjTab_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = TransNullToBool(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTab_SimDA: GetObjLst)", objException.Message));
}
objvPrjTab_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTab_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjTab_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjTab_Sim(ref clsvPrjTab_SimEN objvPrjTab_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where TabId = " + "'"+ objvPrjTab_SimEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjTab_SimEN.TabId = objDT.Rows[0][convPrjTab_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimEN.TabName = objDT.Rows[0][convPrjTab_Sim.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab_SimEN.SqlDsTypeId = objDT.Rows[0][convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimEN.FuncModuleAgcId = objDT.Rows[0][convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimEN.TabTypeId = objDT.Rows[0][convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab_SimEN.CacheModeId = objDT.Rows[0][convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTab_SimEN.TabStateId = objDT.Rows[0][convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimEN.PrjId = objDT.Rows[0][convPrjTab_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab_SimEN.DataBaseName = objDT.Rows[0][convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTab_SimEN.UpdDate = objDT.Rows[0][convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab_SimEN.FldNum = TransNullToInt(objDT.Rows[0][convPrjTab_Sim.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab_SimEN.IsShare = TransNullToBool(objDT.Rows[0][convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjTab_SimDA: GetvPrjTab_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjTab_SimEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
 objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTab_SimEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjTab_SimDA: GetObjByTabId)", objException.Message));
}
return objvPrjTab_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjTab_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN()
{
TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(), //表ID
TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(), //表名
SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(), //数据源类型Id
FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(), //功能模块Id
TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(), //表类型Id
CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(), //缓存方式Id
TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(), //表状态ID
PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(), //工程Id
DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(), //数据库名
UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(), //修改日期
FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab_Sim.FldNum].ToString().Trim()), //字段数
IsShare = TransNullToBool(objRow[convPrjTab_Sim.IsShare].ToString().Trim()) //是否共享
};
objvPrjTab_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjTab_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjTab_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = TransNullToBool(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjTab_SimDA: GetObjByDataRowvPrjTab_Sim)", objException.Message));
}
objvPrjTab_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjTab_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTab_SimEN objvPrjTab_SimEN = new clsvPrjTab_SimEN();
try
{
objvPrjTab_SimEN.TabId = objRow[convPrjTab_Sim.TabId].ToString().Trim(); //表ID
objvPrjTab_SimEN.TabName = objRow[convPrjTab_Sim.TabName].ToString().Trim(); //表名
objvPrjTab_SimEN.SqlDsTypeId = objRow[convPrjTab_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTab_SimEN.FuncModuleAgcId = objRow[convPrjTab_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTab_SimEN.TabTypeId = objRow[convPrjTab_Sim.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTab_SimEN.CacheModeId = objRow[convPrjTab_Sim.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab_Sim.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTab_SimEN.TabStateId = objRow[convPrjTab_Sim.TabStateId].ToString().Trim(); //表状态ID
objvPrjTab_SimEN.PrjId = objRow[convPrjTab_Sim.PrjId].ToString().Trim(); //工程Id
objvPrjTab_SimEN.DataBaseName = objRow[convPrjTab_Sim.DataBaseName] == DBNull.Value ? null : objRow[convPrjTab_Sim.DataBaseName].ToString().Trim(); //数据库名
objvPrjTab_SimEN.UpdDate = objRow[convPrjTab_Sim.UpdDate] == DBNull.Value ? null : objRow[convPrjTab_Sim.UpdDate].ToString().Trim(); //修改日期
objvPrjTab_SimEN.FldNum = objRow[convPrjTab_Sim.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab_Sim.FldNum].ToString().Trim()); //字段数
objvPrjTab_SimEN.IsShare = TransNullToBool(objRow[convPrjTab_Sim.IsShare].ToString().Trim()); //是否共享
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjTab_SimDA: GetObjByDataRow)", objException.Message));
}
objvPrjTab_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTab_SimEN;
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
objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab_SimEN._CurrTabName, convPrjTab_Sim.TabId, 8, "");
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
objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTab_SimEN._CurrTabName, convPrjTab_Sim.TabId, 8, strPrefix);
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vPrjTab_Sim where " + strCondition;
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vPrjTab_Sim where " + strCondition;
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab_Sim", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjTab_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab_Sim", strCondition))
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
objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjTab_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTab_SimENS">源对象</param>
 /// <param name = "objvPrjTab_SimENT">目标对象</param>
public void CopyTo(clsvPrjTab_SimEN objvPrjTab_SimENS, clsvPrjTab_SimEN objvPrjTab_SimENT)
{
objvPrjTab_SimENT.TabId = objvPrjTab_SimENS.TabId; //表ID
objvPrjTab_SimENT.TabName = objvPrjTab_SimENS.TabName; //表名
objvPrjTab_SimENT.SqlDsTypeId = objvPrjTab_SimENS.SqlDsTypeId; //数据源类型Id
objvPrjTab_SimENT.FuncModuleAgcId = objvPrjTab_SimENS.FuncModuleAgcId; //功能模块Id
objvPrjTab_SimENT.TabTypeId = objvPrjTab_SimENS.TabTypeId; //表类型Id
objvPrjTab_SimENT.CacheModeId = objvPrjTab_SimENS.CacheModeId; //缓存方式Id
objvPrjTab_SimENT.TabStateId = objvPrjTab_SimENS.TabStateId; //表状态ID
objvPrjTab_SimENT.PrjId = objvPrjTab_SimENS.PrjId; //工程Id
objvPrjTab_SimENT.DataBaseName = objvPrjTab_SimENS.DataBaseName; //数据库名
objvPrjTab_SimENT.UpdDate = objvPrjTab_SimENS.UpdDate; //修改日期
objvPrjTab_SimENT.FldNum = objvPrjTab_SimENS.FldNum; //字段数
objvPrjTab_SimENT.IsShare = objvPrjTab_SimENS.IsShare; //是否共享
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjTab_SimEN objvPrjTab_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.TabId, 8, convPrjTab_Sim.TabId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.TabName, 100, convPrjTab_Sim.TabName);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.SqlDsTypeId, 2, convPrjTab_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.FuncModuleAgcId, 8, convPrjTab_Sim.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.TabTypeId, 4, convPrjTab_Sim.TabTypeId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.CacheModeId, 2, convPrjTab_Sim.CacheModeId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.TabStateId, 2, convPrjTab_Sim.TabStateId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.PrjId, 4, convPrjTab_Sim.PrjId);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.DataBaseName, 50, convPrjTab_Sim.DataBaseName);
clsCheckSql.CheckFieldLen(objvPrjTab_SimEN.UpdDate, 20, convPrjTab_Sim.UpdDate);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.TabId, convPrjTab_Sim.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.TabName, convPrjTab_Sim.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.SqlDsTypeId, convPrjTab_Sim.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.FuncModuleAgcId, convPrjTab_Sim.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.TabTypeId, convPrjTab_Sim.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.CacheModeId, convPrjTab_Sim.CacheModeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.TabStateId, convPrjTab_Sim.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.PrjId, convPrjTab_Sim.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.DataBaseName, convPrjTab_Sim.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTab_SimEN.UpdDate, convPrjTab_Sim.UpdDate);
//检查外键字段长度
 objvPrjTab_SimEN._IsCheckProperty = true;
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
string strSQL = "select TabId, TabName from vPrjTab_Sim ";
 clsSpecSQLforSql mySql = clsvPrjTab_SimDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab_SimEN._CurrTabName);
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTab_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjTab_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}