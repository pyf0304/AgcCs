
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvPrjTabDA
 表名:vPrjTab(00050124)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:49:17
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// v工程表(vPrjTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvPrjTabDA : clsCommBase4DA
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
 return clsvPrjTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvPrjTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvPrjTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvPrjTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvPrjTabEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vPrjTab中,检查关键字,长度不正确!(clsvPrjTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vPrjTab中,关键字不能为空 或 null!(clsvPrjTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvPrjTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable_vPrjTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab.* " + 
$"from vPrjTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab.TabId not in " + 
$"(Select top {intTop_In} vPrjTab.TabId from vPrjTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1} and TabId not in (Select top {2} TabId from vPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1} and TabId not in (Select top {3} TabId from vPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vPrjTab.* " + 
$"from vPrjTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vPrjTab.TabId not in " + 
$"(Select top {intTop_In} vPrjTab.TabId from vPrjTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1} and TabId not in (Select top {2} TabId from vPrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vPrjTab where {1} and TabId not in (Select top {3} TabId from vPrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvPrjTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvPrjTabDA:GetObjLst)", objException.Message));
}
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = TransNullToBool(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = TransNullToBool(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = TransNullToBool(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = TransNullToBool(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = TransNullToBool(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = TransNullToBool(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTabDA: GetObjLst)", objException.Message));
}
objvPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTabEN);
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
public List<clsvPrjTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvPrjTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvPrjTabEN> arrObjLst = new List<clsvPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = TransNullToBool(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = TransNullToBool(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = TransNullToBool(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = TransNullToBool(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = TransNullToBool(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = TransNullToBool(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvPrjTabDA: GetObjLst)", objException.Message));
}
objvPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvPrjTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvPrjTab(ref clsvPrjTabEN objvPrjTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where TabId = " + "'"+ objvPrjTabEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvPrjTabEN.TabId = objDT.Rows[0][convPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabEN.TabName = objDT.Rows[0][convPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabEN.TabCnName = objDT.Rows[0][convPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabEN.PrjId = objDT.Rows[0][convPrjTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabEN.SqlDsTypeId = objDT.Rows[0][convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabEN.TabStateId = objDT.Rows[0][convPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabEN.FuncModuleAgcId = objDT.Rows[0][convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabEN.FuncModuleEnName = objDT.Rows[0][convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabEN.IsReleToSqlTab = TransNullToBool(objDT.Rows[0][convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.Keyword = objDT.Rows[0][convPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabEN.TabTypeId = objDT.Rows[0][convPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabEN.TabMainTypeId = objDT.Rows[0][convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvPrjTabEN.RelaTabId4View = objDT.Rows[0][convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objDT.Rows[0][convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.ParentClass = objDT.Rows[0][convPrjTab.ParentClass].ToString().Trim(); //父类(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabEN.IsUseCache = TransNullToBool(objDT.Rows[0][convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.IsShare = TransNullToBool(objDT.Rows[0][convPrjTab.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.CacheClassifyField = objDT.Rows[0][convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段(字段类型:char,字段长度:8,是否可空:True)
 objvPrjTabEN.CacheModeId = objDT.Rows[0][convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTabEN.IsRefresh4RelaView = TransNullToBool(objDT.Rows[0][convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.TabRecNum = TransNullToInt(objDT.Rows[0][convPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabEN.ErrMsg = objDT.Rows[0][convPrjTab.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPrjTabEN.UpdUserId = objDT.Rows[0][convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTabEN.UpdDate = objDT.Rows[0][convPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTabEN.Memo = objDT.Rows[0][convPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTabEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabEN.FuncModuleName = objDT.Rows[0][convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.FldNum = TransNullToInt(objDT.Rows[0][convPrjTab.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabEN.SqlDsTypeName = objDT.Rows[0][convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTabEN.TabStateName = objDT.Rows[0][convPrjTab.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.TabMainTypeName = objDT.Rows[0][convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabEN.TabTypeName = objDT.Rows[0][convPrjTab.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.RelaTabName4View = objDT.Rows[0][convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjTabEN.PrjName = objDT.Rows[0][convPrjTab.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.IsChecked = TransNullToBool(objDT.Rows[0][convPrjTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.Owner = objDT.Rows[0][convPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTabEN.TabEnName = objDT.Rows[0][convPrjTab.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTabEN.TabNameB = objDT.Rows[0][convPrjTab.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabEN.IsNationStandard = TransNullToBool(objDT.Rows[0][convPrjTab.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0][convPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.IsArchive = TransNullToBool(objDT.Rows[0][convPrjTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.UpdDate2 = objDT.Rows[0][convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTabEN.DataBaseNameTab = objDT.Rows[0][convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvPrjTabDA: GetvPrjTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvPrjTabEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
 objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objvPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段(字段类型:char,字段长度:8,是否可空:True)
 objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objvPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名(字段类型:varchar,字段长度:30,是否可空:True)
 objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View(字段类型:varchar,字段长度:100,是否可空:True)
 objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objvPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objvPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
 objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2(字段类型:varchar,字段长度:20,是否可空:True)
 objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvPrjTabDA: GetObjByTabId)", objException.Message));
}
return objvPrjTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvPrjTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvPrjTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from vPrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN()
{
TabId = objRow[convPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[convPrjTab.TabName].ToString().Trim(), //表名
TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(), //表中文名
PrjId = objRow[convPrjTab.PrjId].ToString().Trim(), //工程Id
SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(), //数据源类型Id
TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(), //表状态ID
FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
IsReleToSqlTab = TransNullToBool(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()), //是否与SQL表相关
Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(), //表类型Id
TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(), //表主类型Id
RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(), //视图的相关表ID
IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()), //是否需要生成索引器
ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(), //父类
IsUseCache = TransNullToBool(objRow[convPrjTab.IsUseCache].ToString().Trim()), //是否使用Cache
IsShare = TransNullToBool(objRow[convPrjTab.IsShare].ToString().Trim()), //是否共享
CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(), //缓存分类字段
CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(), //缓存方式Id
IsRefresh4RelaView = TransNullToBool(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()), //是否刷新相关视图
TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.TabRecNum].ToString().Trim()), //记录数
ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(), //错误信息
UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(), //说明
OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()), //引用序号
FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(), //功能模块名称
FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.FldNum].ToString().Trim()), //字段数
SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(), //Sql数据源名
TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(), //表状态名称
TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(), //表主类型名
TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(), //表类型名
RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(), //RelaTabName4View
PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(), //工程名称
IsChecked = TransNullToBool(objRow[convPrjTab.IsChecked].ToString().Trim()), //是否核实
Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(), //拥有者
TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(), //表英文详细名
IsNeedTransCode = TransNullToBool(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(), //表名_后备
IsNationStandard = TransNullToBool(objRow[convPrjTab.IsNationStandard].ToString().Trim()), //是否国标
IsParaTab = TransNullToBool(objRow[convPrjTab.IsParaTab].ToString().Trim()), //是否参数表
IsArchive = TransNullToBool(objRow[convPrjTab.IsArchive].ToString().Trim()), //是否存档
UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(), //UpdDate2
DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim() //DataBaseName_Tab
};
objvPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvPrjTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvPrjTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = TransNullToBool(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = TransNullToBool(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = TransNullToBool(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = TransNullToBool(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = TransNullToBool(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = TransNullToBool(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvPrjTabDA: GetObjByDataRowvPrjTab)", objException.Message));
}
objvPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvPrjTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvPrjTabEN objvPrjTabEN = new clsvPrjTabEN();
try
{
objvPrjTabEN.TabId = objRow[convPrjTab.TabId].ToString().Trim(); //表ID
objvPrjTabEN.TabName = objRow[convPrjTab.TabName].ToString().Trim(); //表名
objvPrjTabEN.TabCnName = objRow[convPrjTab.TabCnName].ToString().Trim(); //表中文名
objvPrjTabEN.PrjId = objRow[convPrjTab.PrjId].ToString().Trim(); //工程Id
objvPrjTabEN.SqlDsTypeId = objRow[convPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvPrjTabEN.TabStateId = objRow[convPrjTab.TabStateId].ToString().Trim(); //表状态ID
objvPrjTabEN.FuncModuleAgcId = objRow[convPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvPrjTabEN.FuncModuleEnName = objRow[convPrjTab.FuncModuleEnName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[convPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objvPrjTabEN.Keyword = objRow[convPrjTab.Keyword] == DBNull.Value ? null : objRow[convPrjTab.Keyword].ToString().Trim(); //关键字
objvPrjTabEN.TabTypeId = objRow[convPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objvPrjTabEN.TabMainTypeId = objRow[convPrjTab.TabMainTypeId] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objvPrjTabEN.RelaTabId4View = objRow[convPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objvPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[convPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objvPrjTabEN.ParentClass = objRow[convPrjTab.ParentClass] == DBNull.Value ? null : objRow[convPrjTab.ParentClass].ToString().Trim(); //父类
objvPrjTabEN.IsUseCache = TransNullToBool(objRow[convPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objvPrjTabEN.IsShare = TransNullToBool(objRow[convPrjTab.IsShare].ToString().Trim()); //是否共享
objvPrjTabEN.CacheClassifyField = objRow[convPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[convPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objvPrjTabEN.CacheModeId = objRow[convPrjTab.CacheModeId] == DBNull.Value ? null : objRow[convPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objvPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[convPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objvPrjTabEN.TabRecNum = objRow[convPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.TabRecNum].ToString().Trim()); //记录数
objvPrjTabEN.ErrMsg = objRow[convPrjTab.ErrMsg].ToString().Trim(); //错误信息
objvPrjTabEN.UpdUserId = objRow[convPrjTab.UpdUserId] == DBNull.Value ? null : objRow[convPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objvPrjTabEN.UpdDate = objRow[convPrjTab.UpdDate] == DBNull.Value ? null : objRow[convPrjTab.UpdDate].ToString().Trim(); //修改日期
objvPrjTabEN.Memo = objRow[convPrjTab.Memo] == DBNull.Value ? null : objRow[convPrjTab.Memo].ToString().Trim(); //说明
objvPrjTabEN.OrderNum4Refer = objRow[convPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objvPrjTabEN.FuncModuleName = objRow[convPrjTab.FuncModuleName] == DBNull.Value ? null : objRow[convPrjTab.FuncModuleName].ToString().Trim(); //功能模块名称
objvPrjTabEN.FldNum = objRow[convPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convPrjTab.FldNum].ToString().Trim()); //字段数
objvPrjTabEN.SqlDsTypeName = objRow[convPrjTab.SqlDsTypeName] == DBNull.Value ? null : objRow[convPrjTab.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvPrjTabEN.TabStateName = objRow[convPrjTab.TabStateName] == DBNull.Value ? null : objRow[convPrjTab.TabStateName].ToString().Trim(); //表状态名称
objvPrjTabEN.TabMainTypeName = objRow[convPrjTab.TabMainTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabMainTypeName].ToString().Trim(); //表主类型名
objvPrjTabEN.TabTypeName = objRow[convPrjTab.TabTypeName] == DBNull.Value ? null : objRow[convPrjTab.TabTypeName].ToString().Trim(); //表类型名
objvPrjTabEN.RelaTabName4View = objRow[convPrjTab.RelaTabName4View] == DBNull.Value ? null : objRow[convPrjTab.RelaTabName4View].ToString().Trim(); //RelaTabName4View
objvPrjTabEN.PrjName = objRow[convPrjTab.PrjName] == DBNull.Value ? null : objRow[convPrjTab.PrjName].ToString().Trim(); //工程名称
objvPrjTabEN.IsChecked = TransNullToBool(objRow[convPrjTab.IsChecked].ToString().Trim()); //是否核实
objvPrjTabEN.Owner = objRow[convPrjTab.Owner] == DBNull.Value ? null : objRow[convPrjTab.Owner].ToString().Trim(); //拥有者
objvPrjTabEN.TabEnName = objRow[convPrjTab.TabEnName] == DBNull.Value ? null : objRow[convPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objvPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[convPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvPrjTabEN.TabNameB = objRow[convPrjTab.TabNameB].ToString().Trim(); //表名_后备
objvPrjTabEN.IsNationStandard = TransNullToBool(objRow[convPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objvPrjTabEN.IsParaTab = TransNullToBool(objRow[convPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objvPrjTabEN.IsArchive = TransNullToBool(objRow[convPrjTab.IsArchive].ToString().Trim()); //是否存档
objvPrjTabEN.UpdDate2 = objRow[convPrjTab.UpdDate2] == DBNull.Value ? null : objRow[convPrjTab.UpdDate2].ToString().Trim(); //UpdDate2
objvPrjTabEN.DataBaseNameTab = objRow[convPrjTab.DataBaseNameTab] == DBNull.Value ? null : objRow[convPrjTab.DataBaseNameTab].ToString().Trim(); //DataBaseName_Tab
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvPrjTabDA: GetObjByDataRow)", objException.Message));
}
objvPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvPrjTabEN;
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
objSQL = clsvPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTabEN._CurrTabName, convPrjTab.TabId, 8, "");
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
objSQL = clsvPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvPrjTabEN._CurrTabName, convPrjTab.TabId, 8, strPrefix);
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from vPrjTab where " + strCondition;
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from vPrjTab where " + strCondition;
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvPrjTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vPrjTab", strCondition))
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
objSQL = clsvPrjTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vPrjTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvPrjTabENS">源对象</param>
 /// <param name = "objvPrjTabENT">目标对象</param>
public void CopyTo(clsvPrjTabEN objvPrjTabENS, clsvPrjTabEN objvPrjTabENT)
{
objvPrjTabENT.TabId = objvPrjTabENS.TabId; //表ID
objvPrjTabENT.TabName = objvPrjTabENS.TabName; //表名
objvPrjTabENT.TabCnName = objvPrjTabENS.TabCnName; //表中文名
objvPrjTabENT.PrjId = objvPrjTabENS.PrjId; //工程Id
objvPrjTabENT.SqlDsTypeId = objvPrjTabENS.SqlDsTypeId; //数据源类型Id
objvPrjTabENT.TabStateId = objvPrjTabENS.TabStateId; //表状态ID
objvPrjTabENT.FuncModuleAgcId = objvPrjTabENS.FuncModuleAgcId; //功能模块Id
objvPrjTabENT.FuncModuleEnName = objvPrjTabENS.FuncModuleEnName; //功能模块英文名称
objvPrjTabENT.IsReleToSqlTab = objvPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objvPrjTabENT.Keyword = objvPrjTabENS.Keyword; //关键字
objvPrjTabENT.TabTypeId = objvPrjTabENS.TabTypeId; //表类型Id
objvPrjTabENT.TabMainTypeId = objvPrjTabENS.TabMainTypeId; //表主类型Id
objvPrjTabENT.RelaTabId4View = objvPrjTabENS.RelaTabId4View; //视图的相关表ID
objvPrjTabENT.IsNeedGeneIndexer = objvPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objvPrjTabENT.ParentClass = objvPrjTabENS.ParentClass; //父类
objvPrjTabENT.IsUseCache = objvPrjTabENS.IsUseCache; //是否使用Cache
objvPrjTabENT.IsShare = objvPrjTabENS.IsShare; //是否共享
objvPrjTabENT.CacheClassifyField = objvPrjTabENS.CacheClassifyField; //缓存分类字段
objvPrjTabENT.CacheModeId = objvPrjTabENS.CacheModeId; //缓存方式Id
objvPrjTabENT.IsRefresh4RelaView = objvPrjTabENS.IsRefresh4RelaView; //是否刷新相关视图
objvPrjTabENT.TabRecNum = objvPrjTabENS.TabRecNum; //记录数
objvPrjTabENT.ErrMsg = objvPrjTabENS.ErrMsg; //错误信息
objvPrjTabENT.UpdUserId = objvPrjTabENS.UpdUserId; //修改用户Id
objvPrjTabENT.UpdDate = objvPrjTabENS.UpdDate; //修改日期
objvPrjTabENT.Memo = objvPrjTabENS.Memo; //说明
objvPrjTabENT.OrderNum4Refer = objvPrjTabENS.OrderNum4Refer; //引用序号
objvPrjTabENT.FuncModuleName = objvPrjTabENS.FuncModuleName; //功能模块名称
objvPrjTabENT.FldNum = objvPrjTabENS.FldNum; //字段数
objvPrjTabENT.SqlDsTypeName = objvPrjTabENS.SqlDsTypeName; //Sql数据源名
objvPrjTabENT.TabStateName = objvPrjTabENS.TabStateName; //表状态名称
objvPrjTabENT.TabMainTypeName = objvPrjTabENS.TabMainTypeName; //表主类型名
objvPrjTabENT.TabTypeName = objvPrjTabENS.TabTypeName; //表类型名
objvPrjTabENT.RelaTabName4View = objvPrjTabENS.RelaTabName4View; //RelaTabName4View
objvPrjTabENT.PrjName = objvPrjTabENS.PrjName; //工程名称
objvPrjTabENT.IsChecked = objvPrjTabENS.IsChecked; //是否核实
objvPrjTabENT.Owner = objvPrjTabENS.Owner; //拥有者
objvPrjTabENT.TabEnName = objvPrjTabENS.TabEnName; //表英文详细名
objvPrjTabENT.IsNeedTransCode = objvPrjTabENS.IsNeedTransCode; //是否需要转换代码
objvPrjTabENT.TabNameB = objvPrjTabENS.TabNameB; //表名_后备
objvPrjTabENT.IsNationStandard = objvPrjTabENS.IsNationStandard; //是否国标
objvPrjTabENT.IsParaTab = objvPrjTabENS.IsParaTab; //是否参数表
objvPrjTabENT.IsArchive = objvPrjTabENS.IsArchive; //是否存档
objvPrjTabENT.UpdDate2 = objvPrjTabENS.UpdDate2; //UpdDate2
objvPrjTabENT.DataBaseNameTab = objvPrjTabENS.DataBaseNameTab; //DataBaseName_Tab
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvPrjTabEN objvPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabId, 8, convPrjTab.TabId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabName, 100, convPrjTab.TabName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabCnName, 200, convPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.PrjId, 4, convPrjTab.PrjId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.SqlDsTypeId, 2, convPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabStateId, 2, convPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.FuncModuleAgcId, 8, convPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.FuncModuleEnName, 30, convPrjTab.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.Keyword, 50, convPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabTypeId, 4, convPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabMainTypeId, 4, convPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.RelaTabId4View, 8, convPrjTab.RelaTabId4View);
clsCheckSql.CheckFieldLen(objvPrjTabEN.ParentClass, 50, convPrjTab.ParentClass);
clsCheckSql.CheckFieldLen(objvPrjTabEN.CacheClassifyField, 8, convPrjTab.CacheClassifyField);
clsCheckSql.CheckFieldLen(objvPrjTabEN.CacheModeId, 2, convPrjTab.CacheModeId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.ErrMsg, 2000, convPrjTab.ErrMsg);
clsCheckSql.CheckFieldLen(objvPrjTabEN.UpdUserId, 20, convPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objvPrjTabEN.UpdDate, 20, convPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objvPrjTabEN.Memo, 1000, convPrjTab.Memo);
clsCheckSql.CheckFieldLen(objvPrjTabEN.FuncModuleName, 30, convPrjTab.FuncModuleName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.SqlDsTypeName, 20, convPrjTab.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabStateName, 30, convPrjTab.TabStateName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabMainTypeName, 30, convPrjTab.TabMainTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabTypeName, 30, convPrjTab.TabTypeName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.RelaTabName4View, 100, convPrjTab.RelaTabName4View);
clsCheckSql.CheckFieldLen(objvPrjTabEN.PrjName, 30, convPrjTab.PrjName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.Owner, 50, convPrjTab.Owner);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabEnName, 200, convPrjTab.TabEnName);
clsCheckSql.CheckFieldLen(objvPrjTabEN.TabNameB, 50, convPrjTab.TabNameB);
clsCheckSql.CheckFieldLen(objvPrjTabEN.UpdDate2, 20, convPrjTab.UpdDate2);
clsCheckSql.CheckFieldLen(objvPrjTabEN.DataBaseNameTab, 50, convPrjTab.DataBaseNameTab);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabId, convPrjTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabName, convPrjTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabCnName, convPrjTab.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.PrjId, convPrjTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.SqlDsTypeId, convPrjTab.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabStateId, convPrjTab.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.FuncModuleAgcId, convPrjTab.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.FuncModuleEnName, convPrjTab.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.Keyword, convPrjTab.Keyword);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabTypeId, convPrjTab.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabMainTypeId, convPrjTab.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.RelaTabId4View, convPrjTab.RelaTabId4View);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.ParentClass, convPrjTab.ParentClass);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.CacheClassifyField, convPrjTab.CacheClassifyField);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.CacheModeId, convPrjTab.CacheModeId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.ErrMsg, convPrjTab.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.UpdUserId, convPrjTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.UpdDate, convPrjTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.Memo, convPrjTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.FuncModuleName, convPrjTab.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.SqlDsTypeName, convPrjTab.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabStateName, convPrjTab.TabStateName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabMainTypeName, convPrjTab.TabMainTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabTypeName, convPrjTab.TabTypeName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.RelaTabName4View, convPrjTab.RelaTabName4View);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.PrjName, convPrjTab.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.Owner, convPrjTab.Owner);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabEnName, convPrjTab.TabEnName);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.TabNameB, convPrjTab.TabNameB);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.UpdDate2, convPrjTab.UpdDate2);
clsCheckSql.CheckSqlInjection4Field(objvPrjTabEN.DataBaseNameTab, convPrjTab.DataBaseNameTab);
//检查外键字段长度
 objvPrjTabEN._IsCheckProperty = true;
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTabEN._CurrTabName);
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvPrjTabEN._CurrTabName, strCondition);
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
 objSQL = clsvPrjTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}