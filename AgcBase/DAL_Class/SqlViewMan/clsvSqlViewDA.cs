
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewDA
 表名:vSqlView(00050250)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:20
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// vSql视图(vSqlView)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSqlViewDA : clsCommBase4DA
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
 return clsvSqlViewEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSqlViewEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlViewEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSqlViewEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSqlViewEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vSqlView中,检查关键字,长度不正确!(clsvSqlViewDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strSqlViewId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSqlView中,关键字不能为空 或 null!(clsvSqlViewDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strSqlViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSqlViewDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSqlView(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable_vSqlView)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlView where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlView where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSqlView where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlView.* " + 
$"from vSqlView " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlView.SqlViewId not in " + 
$"(Select top {intTop_In} vSqlView.SqlViewId from vSqlView " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlView where {1} and SqlViewId not in (Select top {2} SqlViewId from vSqlView where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlView where {1} and SqlViewId not in (Select top {3} SqlViewId from vSqlView where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSqlViewDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlView.* " + 
$"from vSqlView " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlView.SqlViewId not in " + 
$"(Select top {intTop_In} vSqlView.SqlViewId from vSqlView " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlView where {1} and SqlViewId not in (Select top {2} SqlViewId from vSqlView where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlView where {1} and SqlViewId not in (Select top {3} SqlViewId from vSqlView where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSqlViewEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSqlViewDA:GetObjLst)", objException.Message));
}
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlViewDA: GetObjLst)", objException.Message));
}
objvSqlViewEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlViewEN);
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
public List<clsvSqlViewEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSqlViewDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSqlViewEN> arrObjLst = new List<clsvSqlViewEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlViewDA: GetObjLst)", objException.Message));
}
objvSqlViewEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlViewEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSqlViewEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSqlView(ref clsvSqlViewEN objvSqlViewEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where SqlViewId = " + "'"+ objvSqlViewEN.SqlViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSqlViewEN.SqlViewId = objDT.Rows[0][convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewEN.SqlViewName = objDT.Rows[0][convSqlView.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewEN.SqlViewCNName = objDT.Rows[0][convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewEN.SqlViewText = objDT.Rows[0][convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlViewEN.SqlViewText4Gene = objDT.Rows[0][convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlViewEN.TextResouce = objDT.Rows[0][convSqlView.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewEN.TextResourceTypeId = objDT.Rows[0][convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewEN.TextResourceTypeName = objDT.Rows[0][convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewEN.RelaTabId = objDT.Rows[0][convSqlView.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewEN.TabStateId = objDT.Rows[0][convSqlView.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewEN.FuncModuleAgcId = objDT.Rows[0][convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvSqlViewEN.AnalysisDate = objDT.Rows[0][convSqlView.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.GeneCodeDate = objDT.Rows[0][convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.TopPercent = objDT.Rows[0][convSqlView.TopPercent].ToString().Trim(); //顶百分比(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewEN.DistinctFlag = objDT.Rows[0][convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewEN.WhereCondition = objDT.Rows[0][convSqlView.WhereCondition].ToString().Trim(); //条件串(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewEN.GroupBy = objDT.Rows[0][convSqlView.GroupBy].ToString().Trim(); //分组(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlViewEN.HavingStr = objDT.Rows[0][convSqlView.HavingStr].ToString().Trim(); //分组过滤(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewEN.OrderBy = objDT.Rows[0][convSqlView.OrderBy].ToString().Trim(); //排序(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewEN.ErrMsg = objDT.Rows[0][convSqlView.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSqlViewEN.PrjId = objDT.Rows[0][convSqlView.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlViewEN.PrjName = objDT.Rows[0][convSqlView.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewEN.UpdDate = objDT.Rows[0][convSqlView.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.UpdUserId = objDT.Rows[0][convSqlView.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.Memo = objDT.Rows[0][convSqlView.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSqlViewDA: GetvSqlView)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strSqlViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSqlViewEN GetObjBySqlViewId(string strSqlViewId)
{
CheckPrimaryKey(strSqlViewId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where SqlViewId = " + "'"+ strSqlViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
 objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成(字段类型:varchar,字段长度:8000,是否可空:True)
 objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSqlViewDA: GetObjBySqlViewId)", objException.Message));
}
return objvSqlViewEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSqlViewEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSqlViewDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
strSQL = "Select * from vSqlView where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN()
{
SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(), //Sql视图Id
SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(), //数据视图名称
SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(), //Sql视图中文名
SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(), //Sql视图文本内容
SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(), //Sql视图文本4生成
TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(), //文本来源
TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(), //文本来源类型Id
TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(), //文本来源类型名
RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(), //相关表Id
TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(), //表状态ID
FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(), //功能模块Id
OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView.OrderNum4Refer].ToString().Trim()), //引用序号
AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(), //分析日期
GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(), //生成代码日期
TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(), //顶百分比
DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(), //Distinct标志
WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(), //条件串
GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(), //分组
HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(), //分组过滤
OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(), //排序
ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[convSqlView.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convSqlView.PrjName].ToString().Trim(), //工程名称
UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim() //说明
};
objvSqlViewEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSqlViewDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSqlViewEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSqlViewDA: GetObjByDataRowvSqlView)", objException.Message));
}
objvSqlViewEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSqlViewEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlViewEN objvSqlViewEN = new clsvSqlViewEN();
try
{
objvSqlViewEN.SqlViewId = objRow[convSqlView.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewEN.SqlViewName = objRow[convSqlView.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewEN.SqlViewCNName = objRow[convSqlView.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlView.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewEN.SqlViewText = objRow[convSqlView.SqlViewText] == DBNull.Value ? null : objRow[convSqlView.SqlViewText].ToString().Trim(); //Sql视图文本内容
objvSqlViewEN.SqlViewText4Gene = objRow[convSqlView.SqlViewText4Gene] == DBNull.Value ? null : objRow[convSqlView.SqlViewText4Gene].ToString().Trim(); //Sql视图文本4生成
objvSqlViewEN.TextResouce = objRow[convSqlView.TextResouce].ToString().Trim(); //文本来源
objvSqlViewEN.TextResourceTypeId = objRow[convSqlView.TextResourceTypeId].ToString().Trim(); //文本来源类型Id
objvSqlViewEN.TextResourceTypeName = objRow[convSqlView.TextResourceTypeName].ToString().Trim(); //文本来源类型名
objvSqlViewEN.RelaTabId = objRow[convSqlView.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewEN.TabStateId = objRow[convSqlView.TabStateId] == DBNull.Value ? null : objRow[convSqlView.TabStateId].ToString().Trim(); //表状态ID
objvSqlViewEN.FuncModuleAgcId = objRow[convSqlView.FuncModuleAgcId] == DBNull.Value ? null : objRow[convSqlView.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvSqlViewEN.OrderNum4Refer = objRow[convSqlView.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convSqlView.OrderNum4Refer].ToString().Trim()); //引用序号
objvSqlViewEN.AnalysisDate = objRow[convSqlView.AnalysisDate] == DBNull.Value ? null : objRow[convSqlView.AnalysisDate].ToString().Trim(); //分析日期
objvSqlViewEN.GeneCodeDate = objRow[convSqlView.GeneCodeDate] == DBNull.Value ? null : objRow[convSqlView.GeneCodeDate].ToString().Trim(); //生成代码日期
objvSqlViewEN.TopPercent = objRow[convSqlView.TopPercent] == DBNull.Value ? null : objRow[convSqlView.TopPercent].ToString().Trim(); //顶百分比
objvSqlViewEN.DistinctFlag = objRow[convSqlView.DistinctFlag] == DBNull.Value ? null : objRow[convSqlView.DistinctFlag].ToString().Trim(); //Distinct标志
objvSqlViewEN.WhereCondition = objRow[convSqlView.WhereCondition] == DBNull.Value ? null : objRow[convSqlView.WhereCondition].ToString().Trim(); //条件串
objvSqlViewEN.GroupBy = objRow[convSqlView.GroupBy] == DBNull.Value ? null : objRow[convSqlView.GroupBy].ToString().Trim(); //分组
objvSqlViewEN.HavingStr = objRow[convSqlView.HavingStr] == DBNull.Value ? null : objRow[convSqlView.HavingStr].ToString().Trim(); //分组过滤
objvSqlViewEN.OrderBy = objRow[convSqlView.OrderBy] == DBNull.Value ? null : objRow[convSqlView.OrderBy].ToString().Trim(); //排序
objvSqlViewEN.ErrMsg = objRow[convSqlView.ErrMsg] == DBNull.Value ? null : objRow[convSqlView.ErrMsg].ToString().Trim(); //错误信息
objvSqlViewEN.PrjId = objRow[convSqlView.PrjId].ToString().Trim(); //工程Id
objvSqlViewEN.PrjName = objRow[convSqlView.PrjName].ToString().Trim(); //工程名称
objvSqlViewEN.UpdDate = objRow[convSqlView.UpdDate] == DBNull.Value ? null : objRow[convSqlView.UpdDate].ToString().Trim(); //修改日期
objvSqlViewEN.UpdUserId = objRow[convSqlView.UpdUserId] == DBNull.Value ? null : objRow[convSqlView.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewEN.Memo = objRow[convSqlView.Memo] == DBNull.Value ? null : objRow[convSqlView.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSqlViewDA: GetObjByDataRow)", objException.Message));
}
objvSqlViewEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewEN;
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
objSQL = clsvSqlViewDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlViewEN._CurrTabName, convSqlView.SqlViewId, 8, "");
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
objSQL = clsvSqlViewDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlViewEN._CurrTabName, convSqlView.SqlViewId, 8, strPrefix);
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select SqlViewId from vSqlView where " + strCondition;
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select SqlViewId from vSqlView where " + strCondition;
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlView", "SqlViewId = " + "'"+ strSqlViewId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSqlViewDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlView", strCondition))
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
objSQL = clsvSqlViewDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSqlView");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSqlViewENS">源对象</param>
 /// <param name = "objvSqlViewENT">目标对象</param>
public void CopyTo(clsvSqlViewEN objvSqlViewENS, clsvSqlViewEN objvSqlViewENT)
{
objvSqlViewENT.SqlViewId = objvSqlViewENS.SqlViewId; //Sql视图Id
objvSqlViewENT.SqlViewName = objvSqlViewENS.SqlViewName; //数据视图名称
objvSqlViewENT.SqlViewCNName = objvSqlViewENS.SqlViewCNName; //Sql视图中文名
objvSqlViewENT.SqlViewText = objvSqlViewENS.SqlViewText; //Sql视图文本内容
objvSqlViewENT.SqlViewText4Gene = objvSqlViewENS.SqlViewText4Gene; //Sql视图文本4生成
objvSqlViewENT.TextResouce = objvSqlViewENS.TextResouce; //文本来源
objvSqlViewENT.TextResourceTypeId = objvSqlViewENS.TextResourceTypeId; //文本来源类型Id
objvSqlViewENT.TextResourceTypeName = objvSqlViewENS.TextResourceTypeName; //文本来源类型名
objvSqlViewENT.RelaTabId = objvSqlViewENS.RelaTabId; //相关表Id
objvSqlViewENT.TabStateId = objvSqlViewENS.TabStateId; //表状态ID
objvSqlViewENT.FuncModuleAgcId = objvSqlViewENS.FuncModuleAgcId; //功能模块Id
objvSqlViewENT.OrderNum4Refer = objvSqlViewENS.OrderNum4Refer; //引用序号
objvSqlViewENT.AnalysisDate = objvSqlViewENS.AnalysisDate; //分析日期
objvSqlViewENT.GeneCodeDate = objvSqlViewENS.GeneCodeDate; //生成代码日期
objvSqlViewENT.TopPercent = objvSqlViewENS.TopPercent; //顶百分比
objvSqlViewENT.DistinctFlag = objvSqlViewENS.DistinctFlag; //Distinct标志
objvSqlViewENT.WhereCondition = objvSqlViewENS.WhereCondition; //条件串
objvSqlViewENT.GroupBy = objvSqlViewENS.GroupBy; //分组
objvSqlViewENT.HavingStr = objvSqlViewENS.HavingStr; //分组过滤
objvSqlViewENT.OrderBy = objvSqlViewENS.OrderBy; //排序
objvSqlViewENT.ErrMsg = objvSqlViewENS.ErrMsg; //错误信息
objvSqlViewENT.PrjId = objvSqlViewENS.PrjId; //工程Id
objvSqlViewENT.PrjName = objvSqlViewENS.PrjName; //工程名称
objvSqlViewENT.UpdDate = objvSqlViewENS.UpdDate; //修改日期
objvSqlViewENT.UpdUserId = objvSqlViewENS.UpdUserId; //修改用户Id
objvSqlViewENT.Memo = objvSqlViewENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSqlViewEN objvSqlViewEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSqlViewEN.SqlViewId, 8, convSqlView.SqlViewId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.SqlViewName, 100, convSqlView.SqlViewName);
clsCheckSql.CheckFieldLen(objvSqlViewEN.SqlViewCNName, 200, convSqlView.SqlViewCNName);
clsCheckSql.CheckFieldLen(objvSqlViewEN.SqlViewText, 8000, convSqlView.SqlViewText);
clsCheckSql.CheckFieldLen(objvSqlViewEN.SqlViewText4Gene, 8000, convSqlView.SqlViewText4Gene);
clsCheckSql.CheckFieldLen(objvSqlViewEN.TextResouce, 100, convSqlView.TextResouce);
clsCheckSql.CheckFieldLen(objvSqlViewEN.TextResourceTypeId, 2, convSqlView.TextResourceTypeId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.TextResourceTypeName, 30, convSqlView.TextResourceTypeName);
clsCheckSql.CheckFieldLen(objvSqlViewEN.RelaTabId, 8, convSqlView.RelaTabId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.TabStateId, 2, convSqlView.TabStateId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.FuncModuleAgcId, 8, convSqlView.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.AnalysisDate, 20, convSqlView.AnalysisDate);
clsCheckSql.CheckFieldLen(objvSqlViewEN.GeneCodeDate, 20, convSqlView.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvSqlViewEN.TopPercent, 200, convSqlView.TopPercent);
clsCheckSql.CheckFieldLen(objvSqlViewEN.DistinctFlag, 100, convSqlView.DistinctFlag);
clsCheckSql.CheckFieldLen(objvSqlViewEN.WhereCondition, 500, convSqlView.WhereCondition);
clsCheckSql.CheckFieldLen(objvSqlViewEN.GroupBy, 1000, convSqlView.GroupBy);
clsCheckSql.CheckFieldLen(objvSqlViewEN.HavingStr, 200, convSqlView.HavingStr);
clsCheckSql.CheckFieldLen(objvSqlViewEN.OrderBy, 100, convSqlView.OrderBy);
clsCheckSql.CheckFieldLen(objvSqlViewEN.ErrMsg, 2000, convSqlView.ErrMsg);
clsCheckSql.CheckFieldLen(objvSqlViewEN.PrjId, 4, convSqlView.PrjId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.PrjName, 30, convSqlView.PrjName);
clsCheckSql.CheckFieldLen(objvSqlViewEN.UpdDate, 20, convSqlView.UpdDate);
clsCheckSql.CheckFieldLen(objvSqlViewEN.UpdUserId, 20, convSqlView.UpdUserId);
clsCheckSql.CheckFieldLen(objvSqlViewEN.Memo, 1000, convSqlView.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.SqlViewId, convSqlView.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.SqlViewName, convSqlView.SqlViewName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.SqlViewCNName, convSqlView.SqlViewCNName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.SqlViewText, convSqlView.SqlViewText);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.SqlViewText4Gene, convSqlView.SqlViewText4Gene);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.TextResouce, convSqlView.TextResouce);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.TextResourceTypeId, convSqlView.TextResourceTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.TextResourceTypeName, convSqlView.TextResourceTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.RelaTabId, convSqlView.RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.TabStateId, convSqlView.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.FuncModuleAgcId, convSqlView.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.AnalysisDate, convSqlView.AnalysisDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.GeneCodeDate, convSqlView.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.TopPercent, convSqlView.TopPercent);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.DistinctFlag, convSqlView.DistinctFlag);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.WhereCondition, convSqlView.WhereCondition);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.GroupBy, convSqlView.GroupBy);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.HavingStr, convSqlView.HavingStr);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.OrderBy, convSqlView.OrderBy);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.ErrMsg, convSqlView.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.PrjId, convSqlView.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.PrjName, convSqlView.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.UpdDate, convSqlView.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.UpdUserId, convSqlView.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewEN.Memo, convSqlView.Memo);
//检查外键字段长度
 objvSqlViewEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetSqlViewId()
{
//获取某学院所有专业信息
string strSQL = "select SqlViewId, SqlViewName from vSqlView ";
 clsSpecSQLforSql mySql = clsvSqlViewDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlViewEN._CurrTabName);
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlViewEN._CurrTabName, strCondition);
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
 objSQL = clsvSqlViewDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}