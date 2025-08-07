
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlView_SimDA
 表名:vSqlView_Sim(00050298)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:36:58
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
 /// vSql视图_Sim(vSqlView_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSqlView_SimDA : clsCommBase4DA
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
 return clsvSqlView_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSqlView_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlView_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSqlView_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSqlView_SimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strSqlViewId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strSqlViewId)
{
strSqlViewId = strSqlViewId.Replace("'", "''");
if (strSqlViewId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vSqlView_Sim中,检查关键字,长度不正确!(clsvSqlView_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSqlViewId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSqlView_Sim中,关键字不能为空 或 null!(clsvSqlView_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSqlView_SimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSqlView_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable_vSqlView_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlView_Sim.* " + 
$"from vSqlView_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlView_Sim.SqlViewId not in " + 
$"(Select top {intTop_In} vSqlView_Sim.SqlViewId from vSqlView_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1} and SqlViewId not in (Select top {2} SqlViewId from vSqlView_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1} and SqlViewId not in (Select top {3} SqlViewId from vSqlView_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlView_Sim.* " + 
$"from vSqlView_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlView_Sim.SqlViewId not in " + 
$"(Select top {intTop_In} vSqlView_Sim.SqlViewId from vSqlView_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1} and SqlViewId not in (Select top {2} SqlViewId from vSqlView_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlView_Sim where {1} and SqlViewId not in (Select top {3} SqlViewId from vSqlView_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSqlView_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSqlView_SimDA:GetObjLst)", objException.Message));
}
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlView_SimDA: GetObjLst)", objException.Message));
}
objvSqlView_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlView_SimEN);
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
public List<clsvSqlView_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSqlView_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSqlView_SimEN> arrObjLst = new List<clsvSqlView_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlView_SimDA: GetObjLst)", objException.Message));
}
objvSqlView_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlView_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSqlView_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSqlView_Sim(ref clsvSqlView_SimEN objvSqlView_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where SqlViewId = " + "'"+ objvSqlView_SimEN.SqlViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSqlView_SimEN.SqlViewId = objDT.Rows[0][convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlView_SimEN.SqlViewName = objDT.Rows[0][convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlView_SimEN.SqlViewCNName = objDT.Rows[0][convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlView_SimEN.SqlViewText = objDT.Rows[0][convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlView_SimEN.SqlViewText4Gene = objDT.Rows[0][convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlView_SimEN.TextResouce = objDT.Rows[0][convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlView_SimEN.TextResourceTypeId = objDT.Rows[0][convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlView_SimEN.TextResourceTypeName = objDT.Rows[0][convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlView_SimEN.RelaTabId = objDT.Rows[0][convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlView_SimEN.TabStateId = objDT.Rows[0][convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvSqlView_SimEN.FuncModuleAgcId = objDT.Rows[0][convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlView_SimEN.AnalysisDate = objDT.Rows[0][convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.GeneCodeDate = objDT.Rows[0][convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.TopPercent = objDT.Rows[0][convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlView_SimEN.DistinctFlag = objDT.Rows[0][convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlView_SimEN.WhereCondition = objDT.Rows[0][convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlView_SimEN.GroupBy = objDT.Rows[0][convSqlView_Sim.GroupBy].ToString().Trim(); //分组(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlView_SimEN.HavingStr = objDT.Rows[0][convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlView_SimEN.OrderBy = objDT.Rows[0][convSqlView_Sim.OrderBy].ToString().Trim(); //排序(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlView_SimEN.ErrMsg = objDT.Rows[0][convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSqlView_SimEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvSqlView_SimEN.PrjId = objDT.Rows[0][convSqlView_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlView_SimEN.PrjName = objDT.Rows[0][convSqlView_Sim.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlView_SimEN.UpdDate = objDT.Rows[0][convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.UpdUserId = objDT.Rows[0][convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.Memo = objDT.Rows[0][convSqlView_Sim.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSqlView_SimDA: GetvSqlView_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSqlView_SimEN GetObjBySqlViewId(string strSqlViewId)
{
CheckPrimaryKey(strSqlViewId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where SqlViewId = " + "'"+ strSqlViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
 objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSqlView_SimDA: GetObjBySqlViewId)", objException.Message));
}
return objvSqlView_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSqlView_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSqlView_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN()
{
SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(), //Sql视图Id
SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(), //数据视图名称
SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(), //Sql视图中文名
SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(), //Sql视图文本内容
SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(), //Sql视图文本4生成
TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(), //文本来源
TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(), //文本来源类型Id
TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(), //文本来源类型名
RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(), //相关表Id
TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(), //表状态ID
FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(), //功能模块Id
AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(), //分析日期
GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(), //生成代码日期
TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(), //顶百分比
DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(), //Distinct标志
WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(), //条件串
GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(), //分组
HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(), //分组过滤
OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(), //排序
ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(), //错误信息
OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()), //引用序号
PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim() //说明
};
objvSqlView_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlView_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSqlView_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSqlView_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSqlView_SimDA: GetObjByDataRowvSqlView_Sim)", objException.Message));
}
objvSqlView_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlView_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSqlView_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlView_SimEN objvSqlView_SimEN = new clsvSqlView_SimEN();
try
{
objvSqlView_SimEN.SqlViewId = objRow[convSqlView_Sim.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlView_SimEN.SqlViewName = objRow[convSqlView_Sim.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlView_SimEN.SqlViewCNName = objRow[convSqlView_Sim.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlView_SimEN.SqlViewText = objRow[convSqlView_Sim.SqlViewText] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlView_SimEN.SqlViewText4Gene = objRow[convSqlView_Sim.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView_Sim.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlView_SimEN.TextResouce = objRow[convSqlView_Sim.TextResouce].ToString().Trim(); //文本来源
objvSqlView_SimEN.TextResourceTypeId = objRow[convSqlView_Sim.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlView_SimEN.TextResourceTypeName = objRow[convSqlView_Sim.TextResourceTypeName] == DBNull.Value ? null : objRow[convSqlView_Sim.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlView_SimEN.RelaTabId = objRow[convSqlView_Sim.RelaTabId].ToString().Trim(); //相关表Id
objvSqlView_SimEN.TabStateId = objRow[convSqlView_Sim.TabStateId] == DBNull.Value ? null : objRow[convSqlView_Sim.TabStateId].ToString().Trim(); //表状态ID
objvSqlView_SimEN.FuncModuleAgcId = objRow[convSqlView_Sim.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView_Sim.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlView_SimEN.AnalysisDate = objRow[convSqlView_Sim.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView_Sim.AnalysisDate].ToString().Trim(); //分析日期
objvSqlView_SimEN.GeneCodeDate = objRow[convSqlView_Sim.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView_Sim.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlView_SimEN.TopPercent = objRow[convSqlView_Sim.TopPercent] == DBNull.Value ? null : objRow[convSqlView_Sim.TopPercent].ToString().Trim(); //顶百分比
objvSqlView_SimEN.DistinctFlag = objRow[convSqlView_Sim.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView_Sim.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlView_SimEN.WhereCondition = objRow[convSqlView_Sim.WhereCondition] == DBNull.Value ? null : objRow[convSqlView_Sim.WhereCondition].ToString().Trim(); //条件串
objvSqlView_SimEN.GroupBy = objRow[convSqlView_Sim.GroupBy] == DBNull.Value ? null : objRow[convSqlView_Sim.GroupBy].ToString().Trim(); //分组
objvSqlView_SimEN.HavingStr = objRow[convSqlView_Sim.HavingStr] == DBNull.Value ? null : objRow[convSqlView_Sim.HavingStr].ToString().Trim(); //分组过滤
objvSqlView_SimEN.OrderBy = objRow[convSqlView_Sim.OrderBy] == DBNull.Value ? null : objRow[convSqlView_Sim.OrderBy].ToString().Trim(); //排序
objvSqlView_SimEN.ErrMsg = objRow[convSqlView_Sim.ErrMsg] == DBNull.Value ? null : objRow[convSqlView_Sim.ErrMsg].ToString().Trim(); //错误信息
objvSqlView_SimEN.OrderNum4Refer = objRow[convSqlView_Sim.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView_Sim.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlView_SimEN.PrjId = objRow[convSqlView_Sim.PrjId].ToString().Trim(); //工程Id
objvSqlView_SimEN.PrjName = objRow[convSqlView_Sim.PrjName] == DBNull.Value ? null : objRow[convSqlView_Sim.PrjName].ToString().Trim(); //工程名称
objvSqlView_SimEN.UpdDate = objRow[convSqlView_Sim.UpdDate] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdDate].ToString().Trim(); //修改日期
objvSqlView_SimEN.UpdUserId = objRow[convSqlView_Sim.UpdUserId] == DBNull.Value ? null : objRow[convSqlView_Sim.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlView_SimEN.Memo = objRow[convSqlView_Sim.Memo] == DBNull.Value ? null : objRow[convSqlView_Sim.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSqlView_SimDA: GetObjByDataRow)", objException.Message));
}
objvSqlView_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlView_SimEN;
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
objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlView_SimEN._CurrTabName, convSqlView_Sim.SqlViewId, 8, "");
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
objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlView_SimEN._CurrTabName, convSqlView_Sim.SqlViewId, 8, strPrefix);
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SqlViewId from vSqlView_Sim where " + strCondition;
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SqlViewId from vSqlView_Sim where " + strCondition;
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
 /// <param name = "strSqlViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strSqlViewId)
{
CheckPrimaryKey(strSqlViewId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlView_Sim", "SqlViewId = " + "'"+ strSqlViewId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSqlView_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlView_Sim", strCondition))
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
objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSqlView_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSqlView_SimENS">源对象</param>
 /// <param name = "objvSqlView_SimENT">目标对象</param>
public void CopyTo(clsvSqlView_SimEN objvSqlView_SimENS, clsvSqlView_SimEN objvSqlView_SimENT)
{
objvSqlView_SimENT.SqlViewId = objvSqlView_SimENS.SqlViewId; //Sql视图Id
objvSqlView_SimENT.SqlViewName = objvSqlView_SimENS.SqlViewName; //数据视图名称
objvSqlView_SimENT.SqlViewCNName = objvSqlView_SimENS.SqlViewCNName; //Sql视图中文名
objvSqlView_SimENT.SqlViewText = objvSqlView_SimENS.SqlViewText; //Sql视图文本内容
objvSqlView_SimENT.SqlViewText4Gene = objvSqlView_SimENS.SqlViewText4Gene; //Sql视图文本4生成
objvSqlView_SimENT.TextResouce = objvSqlView_SimENS.TextResouce; //文本来源
objvSqlView_SimENT.TextResourceTypeId = objvSqlView_SimENS.TextResourceTypeId; //文本来源类型Id
objvSqlView_SimENT.TextResourceTypeName = objvSqlView_SimENS.TextResourceTypeName; //文本来源类型名
objvSqlView_SimENT.RelaTabId = objvSqlView_SimENS.RelaTabId; //相关表Id
objvSqlView_SimENT.TabStateId = objvSqlView_SimENS.TabStateId; //表状态ID
objvSqlView_SimENT.FuncModuleAgcId = objvSqlView_SimENS.FuncModuleAgcId; //功能模块Id
objvSqlView_SimENT.AnalysisDate = objvSqlView_SimENS.AnalysisDate; //分析日期
objvSqlView_SimENT.GeneCodeDate = objvSqlView_SimENS.GeneCodeDate; //生成代码日期
objvSqlView_SimENT.TopPercent = objvSqlView_SimENS.TopPercent; //顶百分比
objvSqlView_SimENT.DistinctFlag = objvSqlView_SimENS.DistinctFlag; //Distinct标志
objvSqlView_SimENT.WhereCondition = objvSqlView_SimENS.WhereCondition; //条件串
objvSqlView_SimENT.GroupBy = objvSqlView_SimENS.GroupBy; //分组
objvSqlView_SimENT.HavingStr = objvSqlView_SimENS.HavingStr; //分组过滤
objvSqlView_SimENT.OrderBy = objvSqlView_SimENS.OrderBy; //排序
objvSqlView_SimENT.ErrMsg = objvSqlView_SimENS.ErrMsg; //错误信息
objvSqlView_SimENT.OrderNum4Refer = objvSqlView_SimENS.OrderNum4Refer; //引用序号
objvSqlView_SimENT.PrjId = objvSqlView_SimENS.PrjId; //工程Id
objvSqlView_SimENT.PrjName = objvSqlView_SimENS.PrjName; //工程名称
objvSqlView_SimENT.UpdDate = objvSqlView_SimENS.UpdDate; //修改日期
objvSqlView_SimENT.UpdUserId = objvSqlView_SimENS.UpdUserId; //修改用户Id
objvSqlView_SimENT.Memo = objvSqlView_SimENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSqlView_SimEN objvSqlView_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.SqlViewId, 8, convSqlView_Sim.SqlViewId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.SqlViewName, 100, convSqlView_Sim.SqlViewName);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.SqlViewCNName, 200, convSqlView_Sim.SqlViewCNName);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.SqlViewText, 8000, convSqlView_Sim.SqlViewText);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.SqlViewText4Gene, 8000, convSqlView_Sim.SqlViewText4Gene);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.TextResouce, 100, convSqlView_Sim.TextResouce);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.TextResourceTypeId, 2, convSqlView_Sim.TextResourceTypeId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.TextResourceTypeName, 30, convSqlView_Sim.TextResourceTypeName);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.RelaTabId, 8, convSqlView_Sim.RelaTabId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.TabStateId, 2, convSqlView_Sim.TabStateId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.FuncModuleAgcId, 8, convSqlView_Sim.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.AnalysisDate, 20, convSqlView_Sim.AnalysisDate);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.GeneCodeDate, 20, convSqlView_Sim.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.TopPercent, 200, convSqlView_Sim.TopPercent);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.DistinctFlag, 100, convSqlView_Sim.DistinctFlag);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.WhereCondition, 500, convSqlView_Sim.WhereCondition);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.GroupBy, 1000, convSqlView_Sim.GroupBy);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.HavingStr, 200, convSqlView_Sim.HavingStr);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.OrderBy, 100, convSqlView_Sim.OrderBy);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.ErrMsg, 2000, convSqlView_Sim.ErrMsg);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.PrjId, 4, convSqlView_Sim.PrjId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.PrjName, 30, convSqlView_Sim.PrjName);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.UpdDate, 20, convSqlView_Sim.UpdDate);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.UpdUserId, 20, convSqlView_Sim.UpdUserId);
clsCheckSql.CheckFieldLen(objvSqlView_SimEN.Memo, 1000, convSqlView_Sim.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.SqlViewId, convSqlView_Sim.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.SqlViewName, convSqlView_Sim.SqlViewName);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.SqlViewCNName, convSqlView_Sim.SqlViewCNName);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.SqlViewText, convSqlView_Sim.SqlViewText);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.SqlViewText4Gene, convSqlView_Sim.SqlViewText4Gene);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.TextResouce, convSqlView_Sim.TextResouce);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.TextResourceTypeId, convSqlView_Sim.TextResourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.TextResourceTypeName, convSqlView_Sim.TextResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.RelaTabId, convSqlView_Sim.RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.TabStateId, convSqlView_Sim.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.FuncModuleAgcId, convSqlView_Sim.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.AnalysisDate, convSqlView_Sim.AnalysisDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.GeneCodeDate, convSqlView_Sim.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.TopPercent, convSqlView_Sim.TopPercent);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.DistinctFlag, convSqlView_Sim.DistinctFlag);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.WhereCondition, convSqlView_Sim.WhereCondition);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.GroupBy, convSqlView_Sim.GroupBy);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.HavingStr, convSqlView_Sim.HavingStr);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.OrderBy, convSqlView_Sim.OrderBy);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.ErrMsg, convSqlView_Sim.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.PrjId, convSqlView_Sim.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.PrjName, convSqlView_Sim.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.UpdDate, convSqlView_Sim.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.UpdUserId, convSqlView_Sim.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSqlView_SimEN.Memo, convSqlView_Sim.Memo);
//检查外键字段长度
 objvSqlView_SimEN._IsCheckProperty = true;
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlView_SimEN._CurrTabName);
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlView_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvSqlView_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}