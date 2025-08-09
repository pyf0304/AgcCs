
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsPrjTabDA
 表名:PrjTab(00050009)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:00:31
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
 /// 工程表(PrjTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsPrjTabDA : clsCommBase4DA
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
 return clsPrjTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsPrjTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsPrjTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsPrjTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsPrjTabEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:PrjTab中,检查关键字,长度不正确!(clsPrjTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:PrjTab中,关键字不能为空 或 null!(clsPrjTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsPrjTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_PrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable_PrjTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from PrjTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjTab.* " + 
$"from PrjTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjTab.TabId not in " + 
$"(Select top {intTop_In} PrjTab.TabId from PrjTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTab where {1} and TabId not in (Select top {2} TabId from PrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTab where {1} and TabId not in (Select top {3} TabId from PrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsPrjTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} PrjTab.* " + 
$"from PrjTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and PrjTab.TabId not in " + 
$"(Select top {intTop_In} PrjTab.TabId from PrjTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from PrjTab where {1} and TabId not in (Select top {2} TabId from PrjTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from PrjTab where {1} and TabId not in (Select top {3} TabId from PrjTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsPrjTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsPrjTabDA:GetObjLst)", objException.Message));
}
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = TransNullToBool(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = TransNullToBool(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = TransNullToBool(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = TransNullToBool(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = TransNullToBool(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = TransNullToBool(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = TransNullToBool(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = TransNullToBool(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjTabDA: GetObjLst)", objException.Message));
}
objPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjTabEN);
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
public List<clsPrjTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsPrjTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsPrjTabEN> arrObjLst = new List<clsPrjTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = TransNullToBool(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = TransNullToBool(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = TransNullToBool(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = TransNullToBool(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = TransNullToBool(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = TransNullToBool(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = TransNullToBool(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = TransNullToBool(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsPrjTabDA: GetObjLst)", objException.Message));
}
objPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objPrjTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetPrjTab(ref clsPrjTabEN objPrjTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where TabId = " + "'"+ objPrjTabEN.TabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objPrjTabEN.TabId = objDT.Rows[0][conPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabEN.TabName = objDT.Rows[0][conPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objPrjTabEN.TabCnName = objDT.Rows[0][conPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objPrjTabEN.PrjId = objDT.Rows[0][conPrjTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabEN.SqlDsTypeId = objDT.Rows[0][conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabEN.TabStateId = objDT.Rows[0][conPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabEN.FuncModuleAgcId = objDT.Rows[0][conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabEN.IsReleToSqlTab = TransNullToBool(objDT.Rows[0][conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.Keyword = objDT.Rows[0][conPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.TabTypeId = objDT.Rows[0][conPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabEN.TabMainTypeId = objDT.Rows[0][conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objPrjTabEN.RelaTabId4View = objDT.Rows[0][conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objDT.Rows[0][conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.ParentClass = objDT.Rows[0][conPrjTab.ParentClass].ToString().Trim(); //父类(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.IsShare = TransNullToBool(objDT.Rows[0][conPrjTab.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsUseDelSign = TransNullToBool(objDT.Rows[0][conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsUseCache = TransNullToBool(objDT.Rows[0][conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsMultiKeyClassify = TransNullToBool(objDT.Rows[0][conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabEN.CacheClassifyField = objDT.Rows[0][conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.CacheClassifyField2 = objDT.Rows[0][conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.CacheModeId = objDT.Rows[0][conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objPrjTabEN.CacheClassifyFieldTS = objDT.Rows[0][conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.CacheClassifyField2TS = objDT.Rows[0][conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.ParaVar2TS = objDT.Rows[0][conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.ParaVar1TS = objDT.Rows[0][conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.WhereFormat = objDT.Rows[0][conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjTabEN.WhereFormatBack = objDT.Rows[0][conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjTabEN.IsRefresh4RelaView = TransNullToBool(objDT.Rows[0][conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.TabRecNum = TransNullToInt(objDT.Rows[0][conPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabEN.KeyId4Test = objDT.Rows[0][conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.ErrMsg = objDT.Rows[0][conPrjTab.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objPrjTabEN.FldNum = TransNullToInt(objDT.Rows[0][conPrjTab.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabEN.UpdUserId = objDT.Rows[0][conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabEN.UpdDate = objDT.Rows[0][conPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabEN.Memo = objDT.Rows[0][conPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objPrjTabEN.OrderNum4Refer = TransNullToInt(objDT.Rows[0][conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabEN.IsChecked = TransNullToBool(objDT.Rows[0][conPrjTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.Owner = objDT.Rows[0][conPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjTabEN.TabEnName = objDT.Rows[0][conPrjTab.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objPrjTabEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabEN.TabNameB = objDT.Rows[0][conPrjTab.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.RelaViewId = objDT.Rows[0][conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.DataBaseName = objDT.Rows[0][conPrjTab.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjTabEN.IsNationStandard = TransNullToBool(objDT.Rows[0][conPrjTab.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsParaTab = TransNullToBool(objDT.Rows[0][conPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsArchive = TransNullToBool(objDT.Rows[0][conPrjTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsPrjTabDA: GetPrjTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsPrjTabEN GetObjByTabId(string strTabId)
{
CheckPrimaryKey(strTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where TabId = " + "'"+ strTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
 objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID(字段类型:char,字段长度:2,是否可空:False)
 objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabEN.IsReleToSqlTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id(字段类型:char,字段长度:4,是否可空:False)
 objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id(字段类型:char,字段长度:4,是否可空:True)
 objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID(字段类型:char,字段长度:8,是否可空:False)
 objPrjTabEN.IsNeedGeneIndexer = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsUseDelSign = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsUseCache = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsMultiKeyClassify = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id(字段类型:char,字段长度:2,是否可空:True)
 objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式(字段类型:varchar,字段长度:500,是否可空:True)
 objPrjTabEN.IsRefresh4RelaView = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号(字段类型:int,字段长度:4,是否可空:True)
 objPrjTabEN.IsChecked = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名(字段类型:varchar,字段长度:200,是否可空:True)
 objPrjTabEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备(字段类型:varchar,字段长度:50,是否可空:True)
 objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId(字段类型:char,字段长度:8,是否可空:True)
 objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objPrjTabEN.IsNationStandard = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsParaTab = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表(字段类型:bit,字段长度:1,是否可空:True)
 objPrjTabEN.IsArchive = clsEntityBase2.TransNullToBool_S(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsPrjTabDA: GetObjByTabId)", objException.Message));
}
return objPrjTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsPrjTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsPrjTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN()
{
TabId = objRow[conPrjTab.TabId].ToString().Trim(), //表ID
TabName = objRow[conPrjTab.TabName].ToString().Trim(), //表名
TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(), //表中文名
PrjId = objRow[conPrjTab.PrjId].ToString().Trim(), //工程Id
SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(), //数据源类型Id
TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(), //表状态ID
FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(), //功能模块Id
IsReleToSqlTab = TransNullToBool(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()), //是否与SQL表相关
Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(), //关键字
TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(), //表类型Id
TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(), //表主类型Id
RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(), //视图的相关表ID
IsNeedGeneIndexer = TransNullToBool(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()), //是否需要生成索引器
ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(), //父类
IsShare = TransNullToBool(objRow[conPrjTab.IsShare].ToString().Trim()), //是否共享
IsUseDelSign = TransNullToBool(objRow[conPrjTab.IsUseDelSign].ToString().Trim()), //是否使用删除标记
IsUseCache = TransNullToBool(objRow[conPrjTab.IsUseCache].ToString().Trim()), //是否使用Cache
IsMultiKeyClassify = TransNullToBool(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()), //是否可以多个关键字分类共存
CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(), //缓存分类字段
CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(), //缓存分类字段2
CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(), //缓存方式Id
CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(), //缓存分类字段_TS
CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(), //缓存分类字段2_TS
ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(), //参数变量2_TS
ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(), //参数变量_TS
WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(), //缓存条件格式
WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(), //后台缓存条件格式
IsRefresh4RelaView = TransNullToBool(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()), //是否刷新相关视图
TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.TabRecNum].ToString().Trim()), //记录数
KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(), //测试关键字Id
ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(), //错误信息
FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.FldNum].ToString().Trim()), //字段数
UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(), //修改用户Id
UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(), //修改日期
Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(), //说明
OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()), //引用序号
IsChecked = TransNullToBool(objRow[conPrjTab.IsChecked].ToString().Trim()), //是否核实
Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(), //拥有者
TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(), //表英文详细名
IsNeedTransCode = TransNullToBool(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(), //表名_后备
RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(), //RelaViewId
DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(), //数据库名
IsNationStandard = TransNullToBool(objRow[conPrjTab.IsNationStandard].ToString().Trim()), //是否国标
IsParaTab = TransNullToBool(objRow[conPrjTab.IsParaTab].ToString().Trim()), //是否参数表
IsArchive = TransNullToBool(objRow[conPrjTab.IsArchive].ToString().Trim()) //是否存档
};
objPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsPrjTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsPrjTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = TransNullToBool(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = TransNullToBool(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = TransNullToBool(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = TransNullToBool(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = TransNullToBool(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = TransNullToBool(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = TransNullToBool(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = TransNullToBool(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsPrjTabDA: GetObjByDataRowPrjTab)", objException.Message));
}
objPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsPrjTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsPrjTabEN objPrjTabEN = new clsPrjTabEN();
try
{
objPrjTabEN.TabId = objRow[conPrjTab.TabId].ToString().Trim(); //表ID
objPrjTabEN.TabName = objRow[conPrjTab.TabName].ToString().Trim(); //表名
objPrjTabEN.TabCnName = objRow[conPrjTab.TabCnName] == DBNull.Value ? null : objRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objPrjTabEN.PrjId = objRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objPrjTabEN.SqlDsTypeId = objRow[conPrjTab.SqlDsTypeId] == DBNull.Value ? null : objRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objPrjTabEN.TabStateId = objRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objPrjTabEN.FuncModuleAgcId = objRow[conPrjTab.FuncModuleAgcId] == DBNull.Value ? null : objRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objPrjTabEN.IsReleToSqlTab = TransNullToBool(objRow[conPrjTab.IsReleToSqlTab].ToString().Trim()); //是否与SQL表相关
objPrjTabEN.Keyword = objRow[conPrjTab.Keyword] == DBNull.Value ? null : objRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objPrjTabEN.TabTypeId = objRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objPrjTabEN.TabMainTypeId = objRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objPrjTabEN.RelaTabId4View = objRow[conPrjTab.RelaTabId4View] == DBNull.Value ? null : objRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objPrjTabEN.IsNeedGeneIndexer = TransNullToBool(objRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim()); //是否需要生成索引器
objPrjTabEN.ParentClass = objRow[conPrjTab.ParentClass] == DBNull.Value ? null : objRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objPrjTabEN.IsShare = TransNullToBool(objRow[conPrjTab.IsShare].ToString().Trim()); //是否共享
objPrjTabEN.IsUseDelSign = TransNullToBool(objRow[conPrjTab.IsUseDelSign].ToString().Trim()); //是否使用删除标记
objPrjTabEN.IsUseCache = TransNullToBool(objRow[conPrjTab.IsUseCache].ToString().Trim()); //是否使用Cache
objPrjTabEN.IsMultiKeyClassify = TransNullToBool(objRow[conPrjTab.IsMultiKeyClassify].ToString().Trim()); //是否可以多个关键字分类共存
objPrjTabEN.CacheClassifyField = objRow[conPrjTab.CacheClassifyField] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objPrjTabEN.CacheClassifyField2 = objRow[conPrjTab.CacheClassifyField2] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objPrjTabEN.CacheModeId = objRow[conPrjTab.CacheModeId] == DBNull.Value ? null : objRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objPrjTabEN.CacheClassifyFieldTS = objRow[conPrjTab.CacheClassifyFieldTS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objPrjTabEN.CacheClassifyField2TS = objRow[conPrjTab.CacheClassifyField2TS] == DBNull.Value ? null : objRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objPrjTabEN.ParaVar2TS = objRow[conPrjTab.ParaVar2TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objPrjTabEN.ParaVar1TS = objRow[conPrjTab.ParaVar1TS] == DBNull.Value ? null : objRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objPrjTabEN.WhereFormat = objRow[conPrjTab.WhereFormat] == DBNull.Value ? null : objRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objPrjTabEN.WhereFormatBack = objRow[conPrjTab.WhereFormatBack] == DBNull.Value ? null : objRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objPrjTabEN.IsRefresh4RelaView = TransNullToBool(objRow[conPrjTab.IsRefresh4RelaView].ToString().Trim()); //是否刷新相关视图
objPrjTabEN.TabRecNum = objRow[conPrjTab.TabRecNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.TabRecNum].ToString().Trim()); //记录数
objPrjTabEN.KeyId4Test = objRow[conPrjTab.KeyId4Test] == DBNull.Value ? null : objRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objPrjTabEN.ErrMsg = objRow[conPrjTab.ErrMsg] == DBNull.Value ? null : objRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objPrjTabEN.FldNum = objRow[conPrjTab.FldNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.FldNum].ToString().Trim()); //字段数
objPrjTabEN.UpdUserId = objRow[conPrjTab.UpdUserId] == DBNull.Value ? null : objRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objPrjTabEN.UpdDate = objRow[conPrjTab.UpdDate] == DBNull.Value ? null : objRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objPrjTabEN.Memo = objRow[conPrjTab.Memo] == DBNull.Value ? null : objRow[conPrjTab.Memo].ToString().Trim(); //说明
objPrjTabEN.OrderNum4Refer = objRow[conPrjTab.OrderNum4Refer] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conPrjTab.OrderNum4Refer].ToString().Trim()); //引用序号
objPrjTabEN.IsChecked = TransNullToBool(objRow[conPrjTab.IsChecked].ToString().Trim()); //是否核实
objPrjTabEN.Owner = objRow[conPrjTab.Owner] == DBNull.Value ? null : objRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objPrjTabEN.TabEnName = objRow[conPrjTab.TabEnName] == DBNull.Value ? null : objRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objPrjTabEN.IsNeedTransCode = TransNullToBool(objRow[conPrjTab.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objPrjTabEN.TabNameB = objRow[conPrjTab.TabNameB] == DBNull.Value ? null : objRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objPrjTabEN.RelaViewId = objRow[conPrjTab.RelaViewId] == DBNull.Value ? null : objRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objPrjTabEN.DataBaseName = objRow[conPrjTab.DataBaseName] == DBNull.Value ? null : objRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objPrjTabEN.IsNationStandard = TransNullToBool(objRow[conPrjTab.IsNationStandard].ToString().Trim()); //是否国标
objPrjTabEN.IsParaTab = TransNullToBool(objRow[conPrjTab.IsParaTab].ToString().Trim()); //是否参数表
objPrjTabEN.IsArchive = TransNullToBool(objRow[conPrjTab.IsArchive].ToString().Trim()); //是否存档
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsPrjTabDA: GetObjByDataRow)", objException.Message));
}
objPrjTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objPrjTabEN;
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
objSQL = clsPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjTabEN._CurrTabName, conPrjTab.TabId, 8, "");
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
objSQL = clsPrjTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsPrjTabEN._CurrTabName, conPrjTab.TabId, 8, strPrefix);
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TabId from PrjTab where " + strCondition;
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TabId from PrjTab where " + strCondition;
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjTab", "TabId = " + "'"+ strTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsPrjTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("PrjTab", strCondition))
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
objSQL = clsPrjTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("PrjTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsPrjTabEN objPrjTabEN)
 {
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjTab");
objRow = objDS.Tables["PrjTab"].NewRow();
objRow[conPrjTab.TabId] = objPrjTabEN.TabId; //表ID
objRow[conPrjTab.TabName] = objPrjTabEN.TabName; //表名
 if (objPrjTabEN.TabCnName !=  "")
 {
objRow[conPrjTab.TabCnName] = objPrjTabEN.TabCnName; //表中文名
 }
objRow[conPrjTab.PrjId] = objPrjTabEN.PrjId; //工程Id
 if (objPrjTabEN.SqlDsTypeId !=  "")
 {
objRow[conPrjTab.SqlDsTypeId] = objPrjTabEN.SqlDsTypeId; //数据源类型Id
 }
objRow[conPrjTab.TabStateId] = objPrjTabEN.TabStateId; //表状态ID
 if (objPrjTabEN.FuncModuleAgcId !=  "")
 {
objRow[conPrjTab.FuncModuleAgcId] = objPrjTabEN.FuncModuleAgcId; //功能模块Id
 }
objRow[conPrjTab.IsReleToSqlTab] = objPrjTabEN.IsReleToSqlTab; //是否与SQL表相关
 if (objPrjTabEN.Keyword !=  "")
 {
objRow[conPrjTab.Keyword] = objPrjTabEN.Keyword; //关键字
 }
objRow[conPrjTab.TabTypeId] = objPrjTabEN.TabTypeId; //表类型Id
objRow[conPrjTab.TabMainTypeId] = objPrjTabEN.TabMainTypeId; //表主类型Id
 if (objPrjTabEN.RelaTabId4View !=  "")
 {
objRow[conPrjTab.RelaTabId4View] = objPrjTabEN.RelaTabId4View; //视图的相关表ID
 }
objRow[conPrjTab.IsNeedGeneIndexer] = objPrjTabEN.IsNeedGeneIndexer; //是否需要生成索引器
 if (objPrjTabEN.ParentClass !=  "")
 {
objRow[conPrjTab.ParentClass] = objPrjTabEN.ParentClass; //父类
 }
objRow[conPrjTab.IsShare] = objPrjTabEN.IsShare; //是否共享
objRow[conPrjTab.IsUseDelSign] = objPrjTabEN.IsUseDelSign; //是否使用删除标记
objRow[conPrjTab.IsUseCache] = objPrjTabEN.IsUseCache; //是否使用Cache
objRow[conPrjTab.IsMultiKeyClassify] = objPrjTabEN.IsMultiKeyClassify; //是否可以多个关键字分类共存
 if (objPrjTabEN.CacheClassifyField !=  "")
 {
objRow[conPrjTab.CacheClassifyField] = objPrjTabEN.CacheClassifyField; //缓存分类字段
 }
 if (objPrjTabEN.CacheClassifyField2 !=  "")
 {
objRow[conPrjTab.CacheClassifyField2] = objPrjTabEN.CacheClassifyField2; //缓存分类字段2
 }
 if (objPrjTabEN.CacheModeId !=  "")
 {
objRow[conPrjTab.CacheModeId] = objPrjTabEN.CacheModeId; //缓存方式Id
 }
 if (objPrjTabEN.CacheClassifyFieldTS !=  "")
 {
objRow[conPrjTab.CacheClassifyFieldTS] = objPrjTabEN.CacheClassifyFieldTS; //缓存分类字段_TS
 }
 if (objPrjTabEN.CacheClassifyField2TS !=  "")
 {
objRow[conPrjTab.CacheClassifyField2TS] = objPrjTabEN.CacheClassifyField2TS; //缓存分类字段2_TS
 }
 if (objPrjTabEN.ParaVar2TS !=  "")
 {
objRow[conPrjTab.ParaVar2TS] = objPrjTabEN.ParaVar2TS; //参数变量2_TS
 }
 if (objPrjTabEN.ParaVar1TS !=  "")
 {
objRow[conPrjTab.ParaVar1TS] = objPrjTabEN.ParaVar1TS; //参数变量_TS
 }
 if (objPrjTabEN.WhereFormat !=  "")
 {
objRow[conPrjTab.WhereFormat] = objPrjTabEN.WhereFormat; //缓存条件格式
 }
 if (objPrjTabEN.WhereFormatBack !=  "")
 {
objRow[conPrjTab.WhereFormatBack] = objPrjTabEN.WhereFormatBack; //后台缓存条件格式
 }
objRow[conPrjTab.IsRefresh4RelaView] = objPrjTabEN.IsRefresh4RelaView; //是否刷新相关视图
objRow[conPrjTab.TabRecNum] = objPrjTabEN.TabRecNum; //记录数
 if (objPrjTabEN.KeyId4Test !=  "")
 {
objRow[conPrjTab.KeyId4Test] = objPrjTabEN.KeyId4Test; //测试关键字Id
 }
 if (objPrjTabEN.ErrMsg !=  "")
 {
objRow[conPrjTab.ErrMsg] = objPrjTabEN.ErrMsg; //错误信息
 }
objRow[conPrjTab.FldNum] = objPrjTabEN.FldNum; //字段数
 if (objPrjTabEN.UpdUserId !=  "")
 {
objRow[conPrjTab.UpdUserId] = objPrjTabEN.UpdUserId; //修改用户Id
 }
 if (objPrjTabEN.UpdDate !=  "")
 {
objRow[conPrjTab.UpdDate] = objPrjTabEN.UpdDate; //修改日期
 }
 if (objPrjTabEN.Memo !=  "")
 {
objRow[conPrjTab.Memo] = objPrjTabEN.Memo; //说明
 }
objRow[conPrjTab.OrderNum4Refer] = objPrjTabEN.OrderNum4Refer; //引用序号
objRow[conPrjTab.IsChecked] = objPrjTabEN.IsChecked; //是否核实
 if (objPrjTabEN.Owner !=  "")
 {
objRow[conPrjTab.Owner] = objPrjTabEN.Owner; //拥有者
 }
 if (objPrjTabEN.TabEnName !=  "")
 {
objRow[conPrjTab.TabEnName] = objPrjTabEN.TabEnName; //表英文详细名
 }
objRow[conPrjTab.IsNeedTransCode] = objPrjTabEN.IsNeedTransCode; //是否需要转换代码
 if (objPrjTabEN.TabNameB !=  "")
 {
objRow[conPrjTab.TabNameB] = objPrjTabEN.TabNameB; //表名_后备
 }
 if (objPrjTabEN.RelaViewId !=  "")
 {
objRow[conPrjTab.RelaViewId] = objPrjTabEN.RelaViewId; //RelaViewId
 }
 if (objPrjTabEN.DataBaseName !=  "")
 {
objRow[conPrjTab.DataBaseName] = objPrjTabEN.DataBaseName; //数据库名
 }
objRow[conPrjTab.IsNationStandard] = objPrjTabEN.IsNationStandard; //是否国标
objRow[conPrjTab.IsParaTab] = objPrjTabEN.IsParaTab; //是否参数表
objRow[conPrjTab.IsArchive] = objPrjTabEN.IsArchive; //是否存档
objDS.Tables[clsPrjTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsPrjTabEN._CurrTabName);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjTabEN objPrjTabEN)
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabId);
 var strTabId = objPrjTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabName);
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objPrjTabEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabCnName);
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.PrjId);
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.SqlDsTypeId);
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objPrjTabEN.TabStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabStateId);
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabStateId + "'");
 }
 
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.FuncModuleAgcId);
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsReleToSqlTab);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsReleToSqlTab  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Keyword);
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPrjTabEN.TabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabTypeId);
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabTypeId + "'");
 }
 
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabMainTypeId);
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.RelaTabId4View);
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId4View + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNeedGeneIndexer);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNeedGeneIndexer  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.ParentClass !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParentClass);
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentClass + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsShare);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsShare  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsUseDelSign);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsUseDelSign  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsUseCache);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsUseCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsMultiKeyClassify);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsMultiKeyClassify  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField);
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField + "'");
 }
 
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField2);
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField2 + "'");
 }
 
 if (objPrjTabEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheModeId);
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyFieldTS);
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyFieldTS + "'");
 }
 
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField2TS);
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField2TS + "'");
 }
 
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParaVar2TS);
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaVar2TS + "'");
 }
 
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParaVar1TS);
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaVar1TS + "'");
 }
 
 if (objPrjTabEN.WhereFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.WhereFormat);
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWhereFormat + "'");
 }
 
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.WhereFormatBack);
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWhereFormatBack + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.TabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabRecNum);
 arrValueListForInsert.Add(objPrjTabEN.TabRecNum.ToString());
 }
 
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.KeyId4Test);
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ErrMsg);
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabEN.FldNum !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.FldNum);
 arrValueListForInsert.Add(objPrjTabEN.FldNum.ToString());
 }
 
 if (objPrjTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.UpdUserId);
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.UpdDate);
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Memo);
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.OrderNum4Refer);
 arrValueListForInsert.Add(objPrjTabEN.OrderNum4Refer.ToString());
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsChecked);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.Owner !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Owner);
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwner + "'");
 }
 
 if (objPrjTabEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabEnName);
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.TabNameB !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabNameB);
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabNameB + "'");
 }
 
 if (objPrjTabEN.RelaViewId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.RelaViewId);
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaViewId + "'");
 }
 
 if (objPrjTabEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.DataBaseName);
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNationStandard);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNationStandard  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsParaTab);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsParaTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsArchive);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsArchive  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsPrjTabEN objPrjTabEN)
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabId);
 var strTabId = objPrjTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabName);
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objPrjTabEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabCnName);
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.PrjId);
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.SqlDsTypeId);
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objPrjTabEN.TabStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabStateId);
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabStateId + "'");
 }
 
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.FuncModuleAgcId);
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsReleToSqlTab);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsReleToSqlTab  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Keyword);
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPrjTabEN.TabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabTypeId);
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabTypeId + "'");
 }
 
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabMainTypeId);
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.RelaTabId4View);
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId4View + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNeedGeneIndexer);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNeedGeneIndexer  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.ParentClass !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParentClass);
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentClass + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsShare);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsShare  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsUseDelSign);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsUseDelSign  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsUseCache);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsUseCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsMultiKeyClassify);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsMultiKeyClassify  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField);
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField + "'");
 }
 
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField2);
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField2 + "'");
 }
 
 if (objPrjTabEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheModeId);
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyFieldTS);
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyFieldTS + "'");
 }
 
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField2TS);
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField2TS + "'");
 }
 
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParaVar2TS);
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaVar2TS + "'");
 }
 
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParaVar1TS);
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaVar1TS + "'");
 }
 
 if (objPrjTabEN.WhereFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.WhereFormat);
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWhereFormat + "'");
 }
 
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.WhereFormatBack);
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWhereFormatBack + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.TabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabRecNum);
 arrValueListForInsert.Add(objPrjTabEN.TabRecNum.ToString());
 }
 
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.KeyId4Test);
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ErrMsg);
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabEN.FldNum !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.FldNum);
 arrValueListForInsert.Add(objPrjTabEN.FldNum.ToString());
 }
 
 if (objPrjTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.UpdUserId);
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.UpdDate);
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Memo);
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.OrderNum4Refer);
 arrValueListForInsert.Add(objPrjTabEN.OrderNum4Refer.ToString());
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsChecked);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.Owner !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Owner);
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwner + "'");
 }
 
 if (objPrjTabEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabEnName);
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.TabNameB !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabNameB);
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabNameB + "'");
 }
 
 if (objPrjTabEN.RelaViewId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.RelaViewId);
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaViewId + "'");
 }
 
 if (objPrjTabEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.DataBaseName);
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNationStandard);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNationStandard  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsParaTab);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsParaTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsArchive);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsArchive  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objPrjTabEN.TabId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsPrjTabEN objPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objPrjTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objPrjTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabId);
 var strTabId = objPrjTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objPrjTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabName);
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objPrjTabEN.TabCnName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabCnName);
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCnName + "'");
 }
 
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.PrjId);
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.SqlDsTypeId);
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objPrjTabEN.TabStateId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabStateId);
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabStateId + "'");
 }
 
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.FuncModuleAgcId);
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsReleToSqlTab);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsReleToSqlTab  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.Keyword !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Keyword);
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyword + "'");
 }
 
 if (objPrjTabEN.TabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabTypeId);
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabTypeId + "'");
 }
 
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabMainTypeId);
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabMainTypeId + "'");
 }
 
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.RelaTabId4View);
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId4View + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNeedGeneIndexer);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNeedGeneIndexer  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.ParentClass !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParentClass);
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParentClass + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsShare);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsShare  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsUseDelSign);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsUseDelSign  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsUseCache);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsUseCache  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsMultiKeyClassify);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsMultiKeyClassify  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField);
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField + "'");
 }
 
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField2);
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField2 + "'");
 }
 
 if (objPrjTabEN.CacheModeId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheModeId);
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheModeId + "'");
 }
 
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyFieldTS);
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyFieldTS + "'");
 }
 
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.CacheClassifyField2TS);
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCacheClassifyField2TS + "'");
 }
 
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParaVar2TS);
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaVar2TS + "'");
 }
 
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ParaVar1TS);
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParaVar1TS + "'");
 }
 
 if (objPrjTabEN.WhereFormat !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.WhereFormat);
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWhereFormat + "'");
 }
 
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.WhereFormatBack);
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWhereFormatBack + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsRefresh4RelaView);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsRefresh4RelaView  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.TabRecNum !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabRecNum);
 arrValueListForInsert.Add(objPrjTabEN.TabRecNum.ToString());
 }
 
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.KeyId4Test);
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objPrjTabEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.ErrMsg);
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objPrjTabEN.FldNum !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.FldNum);
 arrValueListForInsert.Add(objPrjTabEN.FldNum.ToString());
 }
 
 if (objPrjTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.UpdUserId);
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objPrjTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.UpdDate);
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objPrjTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Memo);
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.OrderNum4Refer);
 arrValueListForInsert.Add(objPrjTabEN.OrderNum4Refer.ToString());
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsChecked);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsChecked  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.Owner !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.Owner);
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOwner + "'");
 }
 
 if (objPrjTabEN.TabEnName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabEnName);
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabEnName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 
 if (objPrjTabEN.TabNameB !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.TabNameB);
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabNameB + "'");
 }
 
 if (objPrjTabEN.RelaViewId !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.RelaViewId);
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaViewId + "'");
 }
 
 if (objPrjTabEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conPrjTab.DataBaseName);
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 arrFieldListForInsert.Add(conPrjTab.IsNationStandard);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsNationStandard  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsParaTab);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsParaTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conPrjTab.IsArchive);
 arrValueListForInsert.Add("'" + (objPrjTabEN.IsArchive  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into PrjTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewPrjTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where TabId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "PrjTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strTabId = oRow[conPrjTab.TabId].ToString().Trim();
if (IsExist(strTabId))
{
 string strResult = "关键字变量值为:" + string.Format("TabId = {0}", strTabId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsPrjTabEN._CurrTabName ].NewRow();
objRow[conPrjTab.TabId] = oRow[conPrjTab.TabId].ToString().Trim(); //表ID
objRow[conPrjTab.TabName] = oRow[conPrjTab.TabName].ToString().Trim(); //表名
objRow[conPrjTab.TabCnName] = oRow[conPrjTab.TabCnName].ToString().Trim(); //表中文名
objRow[conPrjTab.PrjId] = oRow[conPrjTab.PrjId].ToString().Trim(); //工程Id
objRow[conPrjTab.SqlDsTypeId] = oRow[conPrjTab.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objRow[conPrjTab.TabStateId] = oRow[conPrjTab.TabStateId].ToString().Trim(); //表状态ID
objRow[conPrjTab.FuncModuleAgcId] = oRow[conPrjTab.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conPrjTab.IsReleToSqlTab] = oRow[conPrjTab.IsReleToSqlTab].ToString().Trim(); //是否与SQL表相关
objRow[conPrjTab.Keyword] = oRow[conPrjTab.Keyword].ToString().Trim(); //关键字
objRow[conPrjTab.TabTypeId] = oRow[conPrjTab.TabTypeId].ToString().Trim(); //表类型Id
objRow[conPrjTab.TabMainTypeId] = oRow[conPrjTab.TabMainTypeId].ToString().Trim(); //表主类型Id
objRow[conPrjTab.RelaTabId4View] = oRow[conPrjTab.RelaTabId4View].ToString().Trim(); //视图的相关表ID
objRow[conPrjTab.IsNeedGeneIndexer] = oRow[conPrjTab.IsNeedGeneIndexer].ToString().Trim(); //是否需要生成索引器
objRow[conPrjTab.ParentClass] = oRow[conPrjTab.ParentClass].ToString().Trim(); //父类
objRow[conPrjTab.IsShare] = oRow[conPrjTab.IsShare].ToString().Trim(); //是否共享
objRow[conPrjTab.IsUseDelSign] = oRow[conPrjTab.IsUseDelSign].ToString().Trim(); //是否使用删除标记
objRow[conPrjTab.IsUseCache] = oRow[conPrjTab.IsUseCache].ToString().Trim(); //是否使用Cache
objRow[conPrjTab.IsMultiKeyClassify] = oRow[conPrjTab.IsMultiKeyClassify].ToString().Trim(); //是否可以多个关键字分类共存
objRow[conPrjTab.CacheClassifyField] = oRow[conPrjTab.CacheClassifyField].ToString().Trim(); //缓存分类字段
objRow[conPrjTab.CacheClassifyField2] = oRow[conPrjTab.CacheClassifyField2].ToString().Trim(); //缓存分类字段2
objRow[conPrjTab.CacheModeId] = oRow[conPrjTab.CacheModeId].ToString().Trim(); //缓存方式Id
objRow[conPrjTab.CacheClassifyFieldTS] = oRow[conPrjTab.CacheClassifyFieldTS].ToString().Trim(); //缓存分类字段_TS
objRow[conPrjTab.CacheClassifyField2TS] = oRow[conPrjTab.CacheClassifyField2TS].ToString().Trim(); //缓存分类字段2_TS
objRow[conPrjTab.ParaVar2TS] = oRow[conPrjTab.ParaVar2TS].ToString().Trim(); //参数变量2_TS
objRow[conPrjTab.ParaVar1TS] = oRow[conPrjTab.ParaVar1TS].ToString().Trim(); //参数变量_TS
objRow[conPrjTab.WhereFormat] = oRow[conPrjTab.WhereFormat].ToString().Trim(); //缓存条件格式
objRow[conPrjTab.WhereFormatBack] = oRow[conPrjTab.WhereFormatBack].ToString().Trim(); //后台缓存条件格式
objRow[conPrjTab.IsRefresh4RelaView] = oRow[conPrjTab.IsRefresh4RelaView].ToString().Trim(); //是否刷新相关视图
objRow[conPrjTab.TabRecNum] = oRow[conPrjTab.TabRecNum].ToString().Trim(); //记录数
objRow[conPrjTab.KeyId4Test] = oRow[conPrjTab.KeyId4Test].ToString().Trim(); //测试关键字Id
objRow[conPrjTab.ErrMsg] = oRow[conPrjTab.ErrMsg].ToString().Trim(); //错误信息
objRow[conPrjTab.FldNum] = oRow[conPrjTab.FldNum].ToString().Trim(); //字段数
objRow[conPrjTab.UpdUserId] = oRow[conPrjTab.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conPrjTab.UpdDate] = oRow[conPrjTab.UpdDate].ToString().Trim(); //修改日期
objRow[conPrjTab.Memo] = oRow[conPrjTab.Memo].ToString().Trim(); //说明
objRow[conPrjTab.OrderNum4Refer] = oRow[conPrjTab.OrderNum4Refer].ToString().Trim(); //引用序号
objRow[conPrjTab.IsChecked] = oRow[conPrjTab.IsChecked].ToString().Trim(); //是否核实
objRow[conPrjTab.Owner] = oRow[conPrjTab.Owner].ToString().Trim(); //拥有者
objRow[conPrjTab.TabEnName] = oRow[conPrjTab.TabEnName].ToString().Trim(); //表英文详细名
objRow[conPrjTab.IsNeedTransCode] = oRow[conPrjTab.IsNeedTransCode].ToString().Trim(); //是否需要转换代码
objRow[conPrjTab.TabNameB] = oRow[conPrjTab.TabNameB].ToString().Trim(); //表名_后备
objRow[conPrjTab.RelaViewId] = oRow[conPrjTab.RelaViewId].ToString().Trim(); //RelaViewId
objRow[conPrjTab.DataBaseName] = oRow[conPrjTab.DataBaseName].ToString().Trim(); //数据库名
objRow[conPrjTab.IsNationStandard] = oRow[conPrjTab.IsNationStandard].ToString().Trim(); //是否国标
objRow[conPrjTab.IsParaTab] = oRow[conPrjTab.IsParaTab].ToString().Trim(); //是否参数表
objRow[conPrjTab.IsArchive] = oRow[conPrjTab.IsArchive].ToString().Trim(); //是否存档
 objDS.Tables[clsPrjTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsPrjTabEN._CurrTabName);
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
 /// <param name = "objPrjTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsPrjTabEN objPrjTabEN)
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
strSQL = "Select * from PrjTab where TabId = " + "'"+ objPrjTabEN.TabId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsPrjTabEN._CurrTabName);
if (objDS.Tables[clsPrjTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TabId = " + "'"+ objPrjTabEN.TabId+"'");
return false;
}
objRow = objDS.Tables[clsPrjTabEN._CurrTabName].Rows[0];
 if (objPrjTabEN.IsUpdated(conPrjTab.TabId))
 {
objRow[conPrjTab.TabId] = objPrjTabEN.TabId; //表ID
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabName))
 {
objRow[conPrjTab.TabName] = objPrjTabEN.TabName; //表名
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabCnName))
 {
objRow[conPrjTab.TabCnName] = objPrjTabEN.TabCnName; //表中文名
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.PrjId))
 {
objRow[conPrjTab.PrjId] = objPrjTabEN.PrjId; //工程Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.SqlDsTypeId))
 {
objRow[conPrjTab.SqlDsTypeId] = objPrjTabEN.SqlDsTypeId; //数据源类型Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabStateId))
 {
objRow[conPrjTab.TabStateId] = objPrjTabEN.TabStateId; //表状态ID
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.FuncModuleAgcId))
 {
objRow[conPrjTab.FuncModuleAgcId] = objPrjTabEN.FuncModuleAgcId; //功能模块Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsReleToSqlTab))
 {
objRow[conPrjTab.IsReleToSqlTab] = objPrjTabEN.IsReleToSqlTab; //是否与SQL表相关
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.Keyword))
 {
objRow[conPrjTab.Keyword] = objPrjTabEN.Keyword; //关键字
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabTypeId))
 {
objRow[conPrjTab.TabTypeId] = objPrjTabEN.TabTypeId; //表类型Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabMainTypeId))
 {
objRow[conPrjTab.TabMainTypeId] = objPrjTabEN.TabMainTypeId; //表主类型Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaTabId4View))
 {
objRow[conPrjTab.RelaTabId4View] = objPrjTabEN.RelaTabId4View; //视图的相关表ID
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedGeneIndexer))
 {
objRow[conPrjTab.IsNeedGeneIndexer] = objPrjTabEN.IsNeedGeneIndexer; //是否需要生成索引器
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.ParentClass))
 {
objRow[conPrjTab.ParentClass] = objPrjTabEN.ParentClass; //父类
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsShare))
 {
objRow[conPrjTab.IsShare] = objPrjTabEN.IsShare; //是否共享
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseDelSign))
 {
objRow[conPrjTab.IsUseDelSign] = objPrjTabEN.IsUseDelSign; //是否使用删除标记
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseCache))
 {
objRow[conPrjTab.IsUseCache] = objPrjTabEN.IsUseCache; //是否使用Cache
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsMultiKeyClassify))
 {
objRow[conPrjTab.IsMultiKeyClassify] = objPrjTabEN.IsMultiKeyClassify; //是否可以多个关键字分类共存
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField))
 {
objRow[conPrjTab.CacheClassifyField] = objPrjTabEN.CacheClassifyField; //缓存分类字段
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2))
 {
objRow[conPrjTab.CacheClassifyField2] = objPrjTabEN.CacheClassifyField2; //缓存分类字段2
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheModeId))
 {
objRow[conPrjTab.CacheModeId] = objPrjTabEN.CacheModeId; //缓存方式Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyFieldTS))
 {
objRow[conPrjTab.CacheClassifyFieldTS] = objPrjTabEN.CacheClassifyFieldTS; //缓存分类字段_TS
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2TS))
 {
objRow[conPrjTab.CacheClassifyField2TS] = objPrjTabEN.CacheClassifyField2TS; //缓存分类字段2_TS
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar2TS))
 {
objRow[conPrjTab.ParaVar2TS] = objPrjTabEN.ParaVar2TS; //参数变量2_TS
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar1TS))
 {
objRow[conPrjTab.ParaVar1TS] = objPrjTabEN.ParaVar1TS; //参数变量_TS
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormat))
 {
objRow[conPrjTab.WhereFormat] = objPrjTabEN.WhereFormat; //缓存条件格式
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormatBack))
 {
objRow[conPrjTab.WhereFormatBack] = objPrjTabEN.WhereFormatBack; //后台缓存条件格式
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsRefresh4RelaView))
 {
objRow[conPrjTab.IsRefresh4RelaView] = objPrjTabEN.IsRefresh4RelaView; //是否刷新相关视图
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabRecNum))
 {
objRow[conPrjTab.TabRecNum] = objPrjTabEN.TabRecNum; //记录数
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.KeyId4Test))
 {
objRow[conPrjTab.KeyId4Test] = objPrjTabEN.KeyId4Test; //测试关键字Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.ErrMsg))
 {
objRow[conPrjTab.ErrMsg] = objPrjTabEN.ErrMsg; //错误信息
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.FldNum))
 {
objRow[conPrjTab.FldNum] = objPrjTabEN.FldNum; //字段数
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdUserId))
 {
objRow[conPrjTab.UpdUserId] = objPrjTabEN.UpdUserId; //修改用户Id
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdDate))
 {
objRow[conPrjTab.UpdDate] = objPrjTabEN.UpdDate; //修改日期
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.Memo))
 {
objRow[conPrjTab.Memo] = objPrjTabEN.Memo; //说明
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.OrderNum4Refer))
 {
objRow[conPrjTab.OrderNum4Refer] = objPrjTabEN.OrderNum4Refer; //引用序号
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsChecked))
 {
objRow[conPrjTab.IsChecked] = objPrjTabEN.IsChecked; //是否核实
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.Owner))
 {
objRow[conPrjTab.Owner] = objPrjTabEN.Owner; //拥有者
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabEnName))
 {
objRow[conPrjTab.TabEnName] = objPrjTabEN.TabEnName; //表英文详细名
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedTransCode))
 {
objRow[conPrjTab.IsNeedTransCode] = objPrjTabEN.IsNeedTransCode; //是否需要转换代码
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.TabNameB))
 {
objRow[conPrjTab.TabNameB] = objPrjTabEN.TabNameB; //表名_后备
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaViewId))
 {
objRow[conPrjTab.RelaViewId] = objPrjTabEN.RelaViewId; //RelaViewId
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.DataBaseName))
 {
objRow[conPrjTab.DataBaseName] = objPrjTabEN.DataBaseName; //数据库名
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNationStandard))
 {
objRow[conPrjTab.IsNationStandard] = objPrjTabEN.IsNationStandard; //是否国标
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsParaTab))
 {
objRow[conPrjTab.IsParaTab] = objPrjTabEN.IsParaTab; //是否参数表
 }
 if (objPrjTabEN.IsUpdated(conPrjTab.IsArchive))
 {
objRow[conPrjTab.IsArchive] = objPrjTabEN.IsArchive; //是否存档
 }
try
{
objDA.Update(objDS, clsPrjTabEN._CurrTabName);
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjTabEN objPrjTabEN)
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update PrjTab Set ");
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabName))
 {
 if (objPrjTabEN.TabName !=  null)
 {
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conPrjTab.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabName); //表名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabCnName))
 {
 if (objPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCnName, conPrjTab.TabCnName); //表中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabCnName); //表中文名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.PrjId))
 {
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.PrjId); //工程Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.SqlDsTypeId))
 {
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsTypeId, conPrjTab.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.SqlDsTypeId); //数据源类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabStateId))
 {
 if (objPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabStateId, conPrjTab.TabStateId); //表状态ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabStateId); //表状态ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FuncModuleAgcId))
 {
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conPrjTab.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsReleToSqlTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsReleToSqlTab == true?"1":"0", conPrjTab.IsReleToSqlTab); //是否与SQL表相关
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Keyword))
 {
 if (objPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conPrjTab.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.Keyword); //关键字
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabTypeId))
 {
 if (objPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabTypeId, conPrjTab.TabTypeId); //表类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabTypeId); //表类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabMainTypeId))
 {
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabMainTypeId, conPrjTab.TabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabMainTypeId); //表主类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaTabId4View))
 {
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaTabId4View, conPrjTab.RelaTabId4View); //视图的相关表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.RelaTabId4View); //视图的相关表ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedGeneIndexer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsNeedGeneIndexer == true?"1":"0", conPrjTab.IsNeedGeneIndexer); //是否需要生成索引器
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParentClass))
 {
 if (objPrjTabEN.ParentClass !=  null)
 {
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentClass, conPrjTab.ParentClass); //父类
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ParentClass); //父类
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsShare))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsShare == true?"1":"0", conPrjTab.IsShare); //是否共享
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseDelSign))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsUseDelSign == true?"1":"0", conPrjTab.IsUseDelSign); //是否使用删除标记
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseCache))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsUseCache == true?"1":"0", conPrjTab.IsUseCache); //是否使用Cache
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsMultiKeyClassify))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsMultiKeyClassify == true?"1":"0", conPrjTab.IsMultiKeyClassify); //是否可以多个关键字分类共存
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField))
 {
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyField, conPrjTab.CacheClassifyField); //缓存分类字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyField); //缓存分类字段
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2))
 {
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyField2, conPrjTab.CacheClassifyField2); //缓存分类字段2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyField2); //缓存分类字段2
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheModeId))
 {
 if (objPrjTabEN.CacheModeId !=  null)
 {
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheModeId, conPrjTab.CacheModeId); //缓存方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheModeId); //缓存方式Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyFieldTS))
 {
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyFieldTS, conPrjTab.CacheClassifyFieldTS); //缓存分类字段_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyFieldTS); //缓存分类字段_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2TS))
 {
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyField2TS, conPrjTab.CacheClassifyField2TS); //缓存分类字段2_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyField2TS); //缓存分类字段2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar2TS))
 {
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaVar2TS, conPrjTab.ParaVar2TS); //参数变量2_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ParaVar2TS); //参数变量2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar1TS))
 {
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaVar1TS, conPrjTab.ParaVar1TS); //参数变量_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ParaVar1TS); //参数变量_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormat))
 {
 if (objPrjTabEN.WhereFormat !=  null)
 {
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWhereFormat, conPrjTab.WhereFormat); //缓存条件格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.WhereFormat); //缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormatBack))
 {
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWhereFormatBack, conPrjTab.WhereFormatBack); //后台缓存条件格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.WhereFormatBack); //后台缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsRefresh4RelaView == true?"1":"0", conPrjTab.IsRefresh4RelaView); //是否刷新相关视图
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabRecNum))
 {
 if (objPrjTabEN.TabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.TabRecNum, conPrjTab.TabRecNum); //记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabRecNum); //记录数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.KeyId4Test))
 {
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conPrjTab.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ErrMsg))
 {
 if (objPrjTabEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conPrjTab.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ErrMsg); //错误信息
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FldNum))
 {
 if (objPrjTabEN.FldNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.FldNum, conPrjTab.FldNum); //字段数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.FldNum); //字段数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdUserId))
 {
 if (objPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPrjTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdDate))
 {
 if (objPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.UpdDate); //修改日期
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Memo))
 {
 if (objPrjTabEN.Memo !=  null)
 {
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.Memo); //说明
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.OrderNum4Refer))
 {
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.OrderNum4Refer, conPrjTab.OrderNum4Refer); //引用序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.OrderNum4Refer); //引用序号
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsChecked == true?"1":"0", conPrjTab.IsChecked); //是否核实
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Owner))
 {
 if (objPrjTabEN.Owner !=  null)
 {
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwner, conPrjTab.Owner); //拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.Owner); //拥有者
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabEnName))
 {
 if (objPrjTabEN.TabEnName !=  null)
 {
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabEnName, conPrjTab.TabEnName); //表英文详细名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabEnName); //表英文详细名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsNeedTransCode == true?"1":"0", conPrjTab.IsNeedTransCode); //是否需要转换代码
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabNameB))
 {
 if (objPrjTabEN.TabNameB !=  null)
 {
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabNameB, conPrjTab.TabNameB); //表名_后备
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabNameB); //表名_后备
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaViewId))
 {
 if (objPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaViewId, conPrjTab.RelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.RelaViewId); //RelaViewId
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.DataBaseName))
 {
 if (objPrjTabEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conPrjTab.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.DataBaseName); //数据库名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNationStandard))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsNationStandard == true?"1":"0", conPrjTab.IsNationStandard); //是否国标
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsParaTab == true?"1":"0", conPrjTab.IsParaTab); //是否参数表
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsArchive == true?"1":"0", conPrjTab.IsArchive); //是否存档
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabId = '{0}'", objPrjTabEN.TabId); 
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
 /// <param name = "objPrjTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsPrjTabEN objPrjTabEN, string strCondition)
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTab Set ");
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabName))
 {
 if (objPrjTabEN.TabName !=  null)
 {
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabCnName))
 {
 if (objPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCnName = '{0}',", strTabCnName); //表中文名
 }
 else
 {
 sbSQL.Append(" TabCnName = null,"); //表中文名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.PrjId))
 {
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.SqlDsTypeId))
 {
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", strSqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabStateId))
 {
 if (objPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabStateId = '{0}',", strTabStateId); //表状态ID
 }
 else
 {
 sbSQL.Append(" TabStateId = null,"); //表状态ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FuncModuleAgcId))
 {
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsReleToSqlTab))
 {
 sbSQL.AppendFormat(" IsReleToSqlTab = '{0}',", objPrjTabEN.IsReleToSqlTab == true?"1":"0"); //是否与SQL表相关
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Keyword))
 {
 if (objPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabTypeId))
 {
 if (objPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabTypeId = '{0}',", strTabTypeId); //表类型Id
 }
 else
 {
 sbSQL.Append(" TabTypeId = null,"); //表类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabMainTypeId))
 {
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabMainTypeId = '{0}',", strTabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.Append(" TabMainTypeId = null,"); //表主类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaTabId4View))
 {
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaTabId4View = '{0}',", strRelaTabId4View); //视图的相关表ID
 }
 else
 {
 sbSQL.Append(" RelaTabId4View = null,"); //视图的相关表ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedGeneIndexer))
 {
 sbSQL.AppendFormat(" IsNeedGeneIndexer = '{0}',", objPrjTabEN.IsNeedGeneIndexer == true?"1":"0"); //是否需要生成索引器
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParentClass))
 {
 if (objPrjTabEN.ParentClass !=  null)
 {
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentClass = '{0}',", strParentClass); //父类
 }
 else
 {
 sbSQL.Append(" ParentClass = null,"); //父类
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsShare))
 {
 sbSQL.AppendFormat(" IsShare = '{0}',", objPrjTabEN.IsShare == true?"1":"0"); //是否共享
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseDelSign))
 {
 sbSQL.AppendFormat(" IsUseDelSign = '{0}',", objPrjTabEN.IsUseDelSign == true?"1":"0"); //是否使用删除标记
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseCache))
 {
 sbSQL.AppendFormat(" IsUseCache = '{0}',", objPrjTabEN.IsUseCache == true?"1":"0"); //是否使用Cache
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsMultiKeyClassify))
 {
 sbSQL.AppendFormat(" IsMultiKeyClassify = '{0}',", objPrjTabEN.IsMultiKeyClassify == true?"1":"0"); //是否可以多个关键字分类共存
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField))
 {
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyField = '{0}',", strCacheClassifyField); //缓存分类字段
 }
 else
 {
 sbSQL.Append(" CacheClassifyField = null,"); //缓存分类字段
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2))
 {
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyField2 = '{0}',", strCacheClassifyField2); //缓存分类字段2
 }
 else
 {
 sbSQL.Append(" CacheClassifyField2 = null,"); //缓存分类字段2
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheModeId))
 {
 if (objPrjTabEN.CacheModeId !=  null)
 {
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheModeId = '{0}',", strCacheModeId); //缓存方式Id
 }
 else
 {
 sbSQL.Append(" CacheModeId = null,"); //缓存方式Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyFieldTS))
 {
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyFieldTS = '{0}',", strCacheClassifyFieldTS); //缓存分类字段_TS
 }
 else
 {
 sbSQL.Append(" CacheClassifyFieldTS = null,"); //缓存分类字段_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2TS))
 {
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyField2TS = '{0}',", strCacheClassifyField2TS); //缓存分类字段2_TS
 }
 else
 {
 sbSQL.Append(" CacheClassifyField2TS = null,"); //缓存分类字段2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar2TS))
 {
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaVar2TS = '{0}',", strParaVar2TS); //参数变量2_TS
 }
 else
 {
 sbSQL.Append(" ParaVar2TS = null,"); //参数变量2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar1TS))
 {
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaVar1TS = '{0}',", strParaVar1TS); //参数变量_TS
 }
 else
 {
 sbSQL.Append(" ParaVar1TS = null,"); //参数变量_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormat))
 {
 if (objPrjTabEN.WhereFormat !=  null)
 {
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WhereFormat = '{0}',", strWhereFormat); //缓存条件格式
 }
 else
 {
 sbSQL.Append(" WhereFormat = null,"); //缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormatBack))
 {
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WhereFormatBack = '{0}',", strWhereFormatBack); //后台缓存条件格式
 }
 else
 {
 sbSQL.Append(" WhereFormatBack = null,"); //后台缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" IsRefresh4RelaView = '{0}',", objPrjTabEN.IsRefresh4RelaView == true?"1":"0"); //是否刷新相关视图
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabRecNum))
 {
 if (objPrjTabEN.TabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.TabRecNum, conPrjTab.TabRecNum); //记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabRecNum); //记录数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.KeyId4Test))
 {
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ErrMsg))
 {
 if (objPrjTabEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FldNum))
 {
 if (objPrjTabEN.FldNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.FldNum, conPrjTab.FldNum); //字段数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.FldNum); //字段数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdUserId))
 {
 if (objPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdDate))
 {
 if (objPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Memo))
 {
 if (objPrjTabEN.Memo !=  null)
 {
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.OrderNum4Refer))
 {
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.OrderNum4Refer, conPrjTab.OrderNum4Refer); //引用序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.OrderNum4Refer); //引用序号
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objPrjTabEN.IsChecked == true?"1":"0"); //是否核实
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Owner))
 {
 if (objPrjTabEN.Owner !=  null)
 {
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Owner = '{0}',", strOwner); //拥有者
 }
 else
 {
 sbSQL.Append(" Owner = null,"); //拥有者
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabEnName))
 {
 if (objPrjTabEN.TabEnName !=  null)
 {
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabEnName = '{0}',", strTabEnName); //表英文详细名
 }
 else
 {
 sbSQL.Append(" TabEnName = null,"); //表英文详细名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" IsNeedTransCode = '{0}',", objPrjTabEN.IsNeedTransCode == true?"1":"0"); //是否需要转换代码
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabNameB))
 {
 if (objPrjTabEN.TabNameB !=  null)
 {
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabNameB = '{0}',", strTabNameB); //表名_后备
 }
 else
 {
 sbSQL.Append(" TabNameB = null,"); //表名_后备
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaViewId))
 {
 if (objPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaViewId = '{0}',", strRelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.Append(" RelaViewId = null,"); //RelaViewId
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.DataBaseName))
 {
 if (objPrjTabEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNationStandard))
 {
 sbSQL.AppendFormat(" IsNationStandard = '{0}',", objPrjTabEN.IsNationStandard == true?"1":"0"); //是否国标
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" IsParaTab = '{0}',", objPrjTabEN.IsParaTab == true?"1":"0"); //是否参数表
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objPrjTabEN.IsArchive == true?"1":"0"); //是否存档
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
 /// <param name = "objPrjTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsPrjTabEN objPrjTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTab Set ");
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabName))
 {
 if (objPrjTabEN.TabName !=  null)
 {
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabCnName))
 {
 if (objPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCnName = '{0}',", strTabCnName); //表中文名
 }
 else
 {
 sbSQL.Append(" TabCnName = null,"); //表中文名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.PrjId))
 {
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.SqlDsTypeId))
 {
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", strSqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabStateId))
 {
 if (objPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabStateId = '{0}',", strTabStateId); //表状态ID
 }
 else
 {
 sbSQL.Append(" TabStateId = null,"); //表状态ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FuncModuleAgcId))
 {
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsReleToSqlTab))
 {
 sbSQL.AppendFormat(" IsReleToSqlTab = '{0}',", objPrjTabEN.IsReleToSqlTab == true?"1":"0"); //是否与SQL表相关
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Keyword))
 {
 if (objPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Keyword = '{0}',", strKeyword); //关键字
 }
 else
 {
 sbSQL.Append(" Keyword = null,"); //关键字
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabTypeId))
 {
 if (objPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabTypeId = '{0}',", strTabTypeId); //表类型Id
 }
 else
 {
 sbSQL.Append(" TabTypeId = null,"); //表类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabMainTypeId))
 {
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabMainTypeId = '{0}',", strTabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.Append(" TabMainTypeId = null,"); //表主类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaTabId4View))
 {
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaTabId4View = '{0}',", strRelaTabId4View); //视图的相关表ID
 }
 else
 {
 sbSQL.Append(" RelaTabId4View = null,"); //视图的相关表ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedGeneIndexer))
 {
 sbSQL.AppendFormat(" IsNeedGeneIndexer = '{0}',", objPrjTabEN.IsNeedGeneIndexer == true?"1":"0"); //是否需要生成索引器
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParentClass))
 {
 if (objPrjTabEN.ParentClass !=  null)
 {
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParentClass = '{0}',", strParentClass); //父类
 }
 else
 {
 sbSQL.Append(" ParentClass = null,"); //父类
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsShare))
 {
 sbSQL.AppendFormat(" IsShare = '{0}',", objPrjTabEN.IsShare == true?"1":"0"); //是否共享
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseDelSign))
 {
 sbSQL.AppendFormat(" IsUseDelSign = '{0}',", objPrjTabEN.IsUseDelSign == true?"1":"0"); //是否使用删除标记
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseCache))
 {
 sbSQL.AppendFormat(" IsUseCache = '{0}',", objPrjTabEN.IsUseCache == true?"1":"0"); //是否使用Cache
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsMultiKeyClassify))
 {
 sbSQL.AppendFormat(" IsMultiKeyClassify = '{0}',", objPrjTabEN.IsMultiKeyClassify == true?"1":"0"); //是否可以多个关键字分类共存
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField))
 {
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyField = '{0}',", strCacheClassifyField); //缓存分类字段
 }
 else
 {
 sbSQL.Append(" CacheClassifyField = null,"); //缓存分类字段
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2))
 {
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyField2 = '{0}',", strCacheClassifyField2); //缓存分类字段2
 }
 else
 {
 sbSQL.Append(" CacheClassifyField2 = null,"); //缓存分类字段2
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheModeId))
 {
 if (objPrjTabEN.CacheModeId !=  null)
 {
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheModeId = '{0}',", strCacheModeId); //缓存方式Id
 }
 else
 {
 sbSQL.Append(" CacheModeId = null,"); //缓存方式Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyFieldTS))
 {
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyFieldTS = '{0}',", strCacheClassifyFieldTS); //缓存分类字段_TS
 }
 else
 {
 sbSQL.Append(" CacheClassifyFieldTS = null,"); //缓存分类字段_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2TS))
 {
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CacheClassifyField2TS = '{0}',", strCacheClassifyField2TS); //缓存分类字段2_TS
 }
 else
 {
 sbSQL.Append(" CacheClassifyField2TS = null,"); //缓存分类字段2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar2TS))
 {
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaVar2TS = '{0}',", strParaVar2TS); //参数变量2_TS
 }
 else
 {
 sbSQL.Append(" ParaVar2TS = null,"); //参数变量2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar1TS))
 {
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParaVar1TS = '{0}',", strParaVar1TS); //参数变量_TS
 }
 else
 {
 sbSQL.Append(" ParaVar1TS = null,"); //参数变量_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormat))
 {
 if (objPrjTabEN.WhereFormat !=  null)
 {
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WhereFormat = '{0}',", strWhereFormat); //缓存条件格式
 }
 else
 {
 sbSQL.Append(" WhereFormat = null,"); //缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormatBack))
 {
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WhereFormatBack = '{0}',", strWhereFormatBack); //后台缓存条件格式
 }
 else
 {
 sbSQL.Append(" WhereFormatBack = null,"); //后台缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" IsRefresh4RelaView = '{0}',", objPrjTabEN.IsRefresh4RelaView == true?"1":"0"); //是否刷新相关视图
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabRecNum))
 {
 if (objPrjTabEN.TabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.TabRecNum, conPrjTab.TabRecNum); //记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabRecNum); //记录数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.KeyId4Test))
 {
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ErrMsg))
 {
 if (objPrjTabEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FldNum))
 {
 if (objPrjTabEN.FldNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.FldNum, conPrjTab.FldNum); //字段数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.FldNum); //字段数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdUserId))
 {
 if (objPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdDate))
 {
 if (objPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Memo))
 {
 if (objPrjTabEN.Memo !=  null)
 {
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.OrderNum4Refer))
 {
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.OrderNum4Refer, conPrjTab.OrderNum4Refer); //引用序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.OrderNum4Refer); //引用序号
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsChecked))
 {
 sbSQL.AppendFormat(" IsChecked = '{0}',", objPrjTabEN.IsChecked == true?"1":"0"); //是否核实
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Owner))
 {
 if (objPrjTabEN.Owner !=  null)
 {
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Owner = '{0}',", strOwner); //拥有者
 }
 else
 {
 sbSQL.Append(" Owner = null,"); //拥有者
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabEnName))
 {
 if (objPrjTabEN.TabEnName !=  null)
 {
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabEnName = '{0}',", strTabEnName); //表英文详细名
 }
 else
 {
 sbSQL.Append(" TabEnName = null,"); //表英文详细名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" IsNeedTransCode = '{0}',", objPrjTabEN.IsNeedTransCode == true?"1":"0"); //是否需要转换代码
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabNameB))
 {
 if (objPrjTabEN.TabNameB !=  null)
 {
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabNameB = '{0}',", strTabNameB); //表名_后备
 }
 else
 {
 sbSQL.Append(" TabNameB = null,"); //表名_后备
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaViewId))
 {
 if (objPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaViewId = '{0}',", strRelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.Append(" RelaViewId = null,"); //RelaViewId
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.DataBaseName))
 {
 if (objPrjTabEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNationStandard))
 {
 sbSQL.AppendFormat(" IsNationStandard = '{0}',", objPrjTabEN.IsNationStandard == true?"1":"0"); //是否国标
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" IsParaTab = '{0}',", objPrjTabEN.IsParaTab == true?"1":"0"); //是否参数表
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsArchive))
 {
 sbSQL.AppendFormat(" IsArchive = '{0}',", objPrjTabEN.IsArchive == true?"1":"0"); //是否存档
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
 /// <param name = "objPrjTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsPrjTabEN objPrjTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objPrjTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objPrjTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objPrjTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update PrjTab Set ");
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabName))
 {
 if (objPrjTabEN.TabName !=  null)
 {
 var strTabName = objPrjTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conPrjTab.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabName); //表名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabCnName))
 {
 if (objPrjTabEN.TabCnName !=  null)
 {
 var strTabCnName = objPrjTabEN.TabCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCnName, conPrjTab.TabCnName); //表中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabCnName); //表中文名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.PrjId))
 {
 if (objPrjTabEN.PrjId  ==  "")
 {
 objPrjTabEN.PrjId = null;
 }
 if (objPrjTabEN.PrjId !=  null)
 {
 var strPrjId = objPrjTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conPrjTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.PrjId); //工程Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.SqlDsTypeId))
 {
 if (objPrjTabEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objPrjTabEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsTypeId, conPrjTab.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.SqlDsTypeId); //数据源类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabStateId))
 {
 if (objPrjTabEN.TabStateId !=  null)
 {
 var strTabStateId = objPrjTabEN.TabStateId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabStateId, conPrjTab.TabStateId); //表状态ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabStateId); //表状态ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FuncModuleAgcId))
 {
 if (objPrjTabEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objPrjTabEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conPrjTab.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsReleToSqlTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsReleToSqlTab == true?"1":"0", conPrjTab.IsReleToSqlTab); //是否与SQL表相关
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Keyword))
 {
 if (objPrjTabEN.Keyword !=  null)
 {
 var strKeyword = objPrjTabEN.Keyword.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyword, conPrjTab.Keyword); //关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.Keyword); //关键字
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabTypeId))
 {
 if (objPrjTabEN.TabTypeId !=  null)
 {
 var strTabTypeId = objPrjTabEN.TabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabTypeId, conPrjTab.TabTypeId); //表类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabTypeId); //表类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabMainTypeId))
 {
 if (objPrjTabEN.TabMainTypeId !=  null)
 {
 var strTabMainTypeId = objPrjTabEN.TabMainTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabMainTypeId, conPrjTab.TabMainTypeId); //表主类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabMainTypeId); //表主类型Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaTabId4View))
 {
 if (objPrjTabEN.RelaTabId4View  ==  "")
 {
 objPrjTabEN.RelaTabId4View = null;
 }
 if (objPrjTabEN.RelaTabId4View !=  null)
 {
 var strRelaTabId4View = objPrjTabEN.RelaTabId4View.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaTabId4View, conPrjTab.RelaTabId4View); //视图的相关表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.RelaTabId4View); //视图的相关表ID
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedGeneIndexer))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsNeedGeneIndexer == true?"1":"0", conPrjTab.IsNeedGeneIndexer); //是否需要生成索引器
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParentClass))
 {
 if (objPrjTabEN.ParentClass !=  null)
 {
 var strParentClass = objPrjTabEN.ParentClass.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParentClass, conPrjTab.ParentClass); //父类
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ParentClass); //父类
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsShare))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsShare == true?"1":"0", conPrjTab.IsShare); //是否共享
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseDelSign))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsUseDelSign == true?"1":"0", conPrjTab.IsUseDelSign); //是否使用删除标记
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsUseCache))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsUseCache == true?"1":"0", conPrjTab.IsUseCache); //是否使用Cache
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsMultiKeyClassify))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsMultiKeyClassify == true?"1":"0", conPrjTab.IsMultiKeyClassify); //是否可以多个关键字分类共存
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField))
 {
 if (objPrjTabEN.CacheClassifyField !=  null)
 {
 var strCacheClassifyField = objPrjTabEN.CacheClassifyField.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyField, conPrjTab.CacheClassifyField); //缓存分类字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyField); //缓存分类字段
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2))
 {
 if (objPrjTabEN.CacheClassifyField2 !=  null)
 {
 var strCacheClassifyField2 = objPrjTabEN.CacheClassifyField2.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyField2, conPrjTab.CacheClassifyField2); //缓存分类字段2
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyField2); //缓存分类字段2
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheModeId))
 {
 if (objPrjTabEN.CacheModeId !=  null)
 {
 var strCacheModeId = objPrjTabEN.CacheModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheModeId, conPrjTab.CacheModeId); //缓存方式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheModeId); //缓存方式Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyFieldTS))
 {
 if (objPrjTabEN.CacheClassifyFieldTS !=  null)
 {
 var strCacheClassifyFieldTS = objPrjTabEN.CacheClassifyFieldTS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyFieldTS, conPrjTab.CacheClassifyFieldTS); //缓存分类字段_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyFieldTS); //缓存分类字段_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.CacheClassifyField2TS))
 {
 if (objPrjTabEN.CacheClassifyField2TS !=  null)
 {
 var strCacheClassifyField2TS = objPrjTabEN.CacheClassifyField2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCacheClassifyField2TS, conPrjTab.CacheClassifyField2TS); //缓存分类字段2_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.CacheClassifyField2TS); //缓存分类字段2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar2TS))
 {
 if (objPrjTabEN.ParaVar2TS !=  null)
 {
 var strParaVar2TS = objPrjTabEN.ParaVar2TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaVar2TS, conPrjTab.ParaVar2TS); //参数变量2_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ParaVar2TS); //参数变量2_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ParaVar1TS))
 {
 if (objPrjTabEN.ParaVar1TS !=  null)
 {
 var strParaVar1TS = objPrjTabEN.ParaVar1TS.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParaVar1TS, conPrjTab.ParaVar1TS); //参数变量_TS
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ParaVar1TS); //参数变量_TS
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormat))
 {
 if (objPrjTabEN.WhereFormat !=  null)
 {
 var strWhereFormat = objPrjTabEN.WhereFormat.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWhereFormat, conPrjTab.WhereFormat); //缓存条件格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.WhereFormat); //缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.WhereFormatBack))
 {
 if (objPrjTabEN.WhereFormatBack !=  null)
 {
 var strWhereFormatBack = objPrjTabEN.WhereFormatBack.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWhereFormatBack, conPrjTab.WhereFormatBack); //后台缓存条件格式
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.WhereFormatBack); //后台缓存条件格式
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsRefresh4RelaView))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsRefresh4RelaView == true?"1":"0", conPrjTab.IsRefresh4RelaView); //是否刷新相关视图
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabRecNum))
 {
 if (objPrjTabEN.TabRecNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.TabRecNum, conPrjTab.TabRecNum); //记录数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabRecNum); //记录数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.KeyId4Test))
 {
 if (objPrjTabEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objPrjTabEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conPrjTab.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.ErrMsg))
 {
 if (objPrjTabEN.ErrMsg !=  null)
 {
 var strErrMsg = objPrjTabEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conPrjTab.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.ErrMsg); //错误信息
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.FldNum))
 {
 if (objPrjTabEN.FldNum !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.FldNum, conPrjTab.FldNum); //字段数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.FldNum); //字段数
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdUserId))
 {
 if (objPrjTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objPrjTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conPrjTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.UpdDate))
 {
 if (objPrjTabEN.UpdDate !=  null)
 {
 var strUpdDate = objPrjTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conPrjTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.UpdDate); //修改日期
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Memo))
 {
 if (objPrjTabEN.Memo !=  null)
 {
 var strMemo = objPrjTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conPrjTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.Memo); //说明
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.OrderNum4Refer))
 {
 if (objPrjTabEN.OrderNum4Refer !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objPrjTabEN.OrderNum4Refer, conPrjTab.OrderNum4Refer); //引用序号
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.OrderNum4Refer); //引用序号
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsChecked))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsChecked == true?"1":"0", conPrjTab.IsChecked); //是否核实
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.Owner))
 {
 if (objPrjTabEN.Owner !=  null)
 {
 var strOwner = objPrjTabEN.Owner.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOwner, conPrjTab.Owner); //拥有者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.Owner); //拥有者
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabEnName))
 {
 if (objPrjTabEN.TabEnName !=  null)
 {
 var strTabEnName = objPrjTabEN.TabEnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabEnName, conPrjTab.TabEnName); //表英文详细名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabEnName); //表英文详细名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsNeedTransCode == true?"1":"0", conPrjTab.IsNeedTransCode); //是否需要转换代码
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.TabNameB))
 {
 if (objPrjTabEN.TabNameB !=  null)
 {
 var strTabNameB = objPrjTabEN.TabNameB.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabNameB, conPrjTab.TabNameB); //表名_后备
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.TabNameB); //表名_后备
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.RelaViewId))
 {
 if (objPrjTabEN.RelaViewId !=  null)
 {
 var strRelaViewId = objPrjTabEN.RelaViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaViewId, conPrjTab.RelaViewId); //RelaViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.RelaViewId); //RelaViewId
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.DataBaseName))
 {
 if (objPrjTabEN.DataBaseName !=  null)
 {
 var strDataBaseName = objPrjTabEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conPrjTab.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conPrjTab.DataBaseName); //数据库名
 }
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsNationStandard))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsNationStandard == true?"1":"0", conPrjTab.IsNationStandard); //是否国标
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsParaTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsParaTab == true?"1":"0", conPrjTab.IsParaTab); //是否参数表
 }
 
 if (objPrjTabEN.IsUpdated(conPrjTab.IsArchive))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objPrjTabEN.IsArchive == true?"1":"0", conPrjTab.IsArchive); //是否存档
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TabId = '{0}'", objPrjTabEN.TabId); 
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
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strTabId) 
{
CheckPrimaryKey(strTabId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strTabId,
};
 objSQL.ExecSP("PrjTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strTabId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strTabId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
//删除PrjTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTab where TabId = " + "'"+ strTabId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelPrjTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除PrjTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTab where TabId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strTabId) 
{
CheckPrimaryKey(strTabId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
//删除PrjTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from PrjTab where TabId = " + "'"+ strTabId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelPrjTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsPrjTabDA: DelPrjTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjTab where " + strCondition ;
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
public bool DelPrjTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsPrjTabDA: DelPrjTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsPrjTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from PrjTab where " + strCondition ;
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
 /// <param name = "objPrjTabENS">源对象</param>
 /// <param name = "objPrjTabENT">目标对象</param>
public void CopyTo(clsPrjTabEN objPrjTabENS, clsPrjTabEN objPrjTabENT)
{
objPrjTabENT.TabId = objPrjTabENS.TabId; //表ID
objPrjTabENT.TabName = objPrjTabENS.TabName; //表名
objPrjTabENT.TabCnName = objPrjTabENS.TabCnName; //表中文名
objPrjTabENT.PrjId = objPrjTabENS.PrjId; //工程Id
objPrjTabENT.SqlDsTypeId = objPrjTabENS.SqlDsTypeId; //数据源类型Id
objPrjTabENT.TabStateId = objPrjTabENS.TabStateId; //表状态ID
objPrjTabENT.FuncModuleAgcId = objPrjTabENS.FuncModuleAgcId; //功能模块Id
objPrjTabENT.IsReleToSqlTab = objPrjTabENS.IsReleToSqlTab; //是否与SQL表相关
objPrjTabENT.Keyword = objPrjTabENS.Keyword; //关键字
objPrjTabENT.TabTypeId = objPrjTabENS.TabTypeId; //表类型Id
objPrjTabENT.TabMainTypeId = objPrjTabENS.TabMainTypeId; //表主类型Id
objPrjTabENT.RelaTabId4View = objPrjTabENS.RelaTabId4View; //视图的相关表ID
objPrjTabENT.IsNeedGeneIndexer = objPrjTabENS.IsNeedGeneIndexer; //是否需要生成索引器
objPrjTabENT.ParentClass = objPrjTabENS.ParentClass; //父类
objPrjTabENT.IsShare = objPrjTabENS.IsShare; //是否共享
objPrjTabENT.IsUseDelSign = objPrjTabENS.IsUseDelSign; //是否使用删除标记
objPrjTabENT.IsUseCache = objPrjTabENS.IsUseCache; //是否使用Cache
objPrjTabENT.IsMultiKeyClassify = objPrjTabENS.IsMultiKeyClassify; //是否可以多个关键字分类共存
objPrjTabENT.CacheClassifyField = objPrjTabENS.CacheClassifyField; //缓存分类字段
objPrjTabENT.CacheClassifyField2 = objPrjTabENS.CacheClassifyField2; //缓存分类字段2
objPrjTabENT.CacheModeId = objPrjTabENS.CacheModeId; //缓存方式Id
objPrjTabENT.CacheClassifyFieldTS = objPrjTabENS.CacheClassifyFieldTS; //缓存分类字段_TS
objPrjTabENT.CacheClassifyField2TS = objPrjTabENS.CacheClassifyField2TS; //缓存分类字段2_TS
objPrjTabENT.ParaVar2TS = objPrjTabENS.ParaVar2TS; //参数变量2_TS
objPrjTabENT.ParaVar1TS = objPrjTabENS.ParaVar1TS; //参数变量_TS
objPrjTabENT.WhereFormat = objPrjTabENS.WhereFormat; //缓存条件格式
objPrjTabENT.WhereFormatBack = objPrjTabENS.WhereFormatBack; //后台缓存条件格式
objPrjTabENT.IsRefresh4RelaView = objPrjTabENS.IsRefresh4RelaView; //是否刷新相关视图
objPrjTabENT.TabRecNum = objPrjTabENS.TabRecNum; //记录数
objPrjTabENT.KeyId4Test = objPrjTabENS.KeyId4Test; //测试关键字Id
objPrjTabENT.ErrMsg = objPrjTabENS.ErrMsg; //错误信息
objPrjTabENT.FldNum = objPrjTabENS.FldNum; //字段数
objPrjTabENT.UpdUserId = objPrjTabENS.UpdUserId; //修改用户Id
objPrjTabENT.UpdDate = objPrjTabENS.UpdDate; //修改日期
objPrjTabENT.Memo = objPrjTabENS.Memo; //说明
objPrjTabENT.OrderNum4Refer = objPrjTabENS.OrderNum4Refer; //引用序号
objPrjTabENT.IsChecked = objPrjTabENS.IsChecked; //是否核实
objPrjTabENT.Owner = objPrjTabENS.Owner; //拥有者
objPrjTabENT.TabEnName = objPrjTabENS.TabEnName; //表英文详细名
objPrjTabENT.IsNeedTransCode = objPrjTabENS.IsNeedTransCode; //是否需要转换代码
objPrjTabENT.TabNameB = objPrjTabENS.TabNameB; //表名_后备
objPrjTabENT.RelaViewId = objPrjTabENS.RelaViewId; //RelaViewId
objPrjTabENT.DataBaseName = objPrjTabENS.DataBaseName; //数据库名
objPrjTabENT.IsNationStandard = objPrjTabENS.IsNationStandard; //是否国标
objPrjTabENT.IsParaTab = objPrjTabENS.IsParaTab; //是否参数表
objPrjTabENT.IsArchive = objPrjTabENS.IsArchive; //是否存档
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsPrjTabEN objPrjTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objPrjTabEN.TabName, conPrjTab.TabName);
clsCheckSql.CheckFieldNotNull(objPrjTabEN.PrjId, conPrjTab.PrjId);
clsCheckSql.CheckFieldNotNull(objPrjTabEN.TabStateId, conPrjTab.TabStateId);
clsCheckSql.CheckFieldNotNull(objPrjTabEN.IsReleToSqlTab, conPrjTab.IsReleToSqlTab);
clsCheckSql.CheckFieldNotNull(objPrjTabEN.TabTypeId, conPrjTab.TabTypeId);
clsCheckSql.CheckFieldNotNull(objPrjTabEN.TabMainTypeId, conPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldNotNull(objPrjTabEN.IsNeedTransCode, conPrjTab.IsNeedTransCode);
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabEN.TabId, 8, conPrjTab.TabId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabName, 100, conPrjTab.TabName);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabCnName, 200, conPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objPrjTabEN.PrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabEN.SqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabStateId, 2, conPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objPrjTabEN.FuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objPrjTabEN.Keyword, 50, conPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabTypeId, 4, conPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabMainTypeId, 4, conPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.RelaTabId4View, 8, conPrjTab.RelaTabId4View);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParentClass, 50, conPrjTab.ParentClass);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField, 8, conPrjTab.CacheClassifyField);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheModeId, 2, conPrjTab.CacheModeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParaVar2TS, 8, conPrjTab.ParaVar2TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParaVar1TS, 8, conPrjTab.ParaVar1TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.WhereFormat, 500, conPrjTab.WhereFormat);
clsCheckSql.CheckFieldLen(objPrjTabEN.WhereFormatBack, 500, conPrjTab.WhereFormatBack);
clsCheckSql.CheckFieldLen(objPrjTabEN.KeyId4Test, 50, conPrjTab.KeyId4Test);
clsCheckSql.CheckFieldLen(objPrjTabEN.ErrMsg, 2000, conPrjTab.ErrMsg);
clsCheckSql.CheckFieldLen(objPrjTabEN.UpdUserId, 20, conPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjTabEN.UpdDate, 20, conPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objPrjTabEN.Memo, 1000, conPrjTab.Memo);
clsCheckSql.CheckFieldLen(objPrjTabEN.Owner, 50, conPrjTab.Owner);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabEnName, 200, conPrjTab.TabEnName);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabNameB, 50, conPrjTab.TabNameB);
clsCheckSql.CheckFieldLen(objPrjTabEN.RelaViewId, 8, conPrjTab.RelaViewId);
clsCheckSql.CheckFieldLen(objPrjTabEN.DataBaseName, 50, conPrjTab.DataBaseName);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objPrjTabEN.PrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjTabEN.RelaTabId4View, 8, conPrjTab.RelaTabId4View);
 objPrjTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsPrjTabEN objPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabEN.TabName, 100, conPrjTab.TabName);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabCnName, 200, conPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objPrjTabEN.PrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabEN.SqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabStateId, 2, conPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objPrjTabEN.FuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objPrjTabEN.Keyword, 50, conPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabTypeId, 4, conPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabMainTypeId, 4, conPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.RelaTabId4View, 8, conPrjTab.RelaTabId4View);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParentClass, 50, conPrjTab.ParentClass);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField, 8, conPrjTab.CacheClassifyField);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheModeId, 2, conPrjTab.CacheModeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParaVar2TS, 8, conPrjTab.ParaVar2TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParaVar1TS, 8, conPrjTab.ParaVar1TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.WhereFormat, 500, conPrjTab.WhereFormat);
clsCheckSql.CheckFieldLen(objPrjTabEN.WhereFormatBack, 500, conPrjTab.WhereFormatBack);
clsCheckSql.CheckFieldLen(objPrjTabEN.KeyId4Test, 50, conPrjTab.KeyId4Test);
clsCheckSql.CheckFieldLen(objPrjTabEN.ErrMsg, 2000, conPrjTab.ErrMsg);
clsCheckSql.CheckFieldLen(objPrjTabEN.UpdUserId, 20, conPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjTabEN.UpdDate, 20, conPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objPrjTabEN.Memo, 1000, conPrjTab.Memo);
clsCheckSql.CheckFieldLen(objPrjTabEN.Owner, 50, conPrjTab.Owner);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabEnName, 200, conPrjTab.TabEnName);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabNameB, 50, conPrjTab.TabNameB);
clsCheckSql.CheckFieldLen(objPrjTabEN.RelaViewId, 8, conPrjTab.RelaViewId);
clsCheckSql.CheckFieldLen(objPrjTabEN.DataBaseName, 50, conPrjTab.DataBaseName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjTabEN.PrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjTabEN.RelaTabId4View, 8, conPrjTab.RelaTabId4View);
 objPrjTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsPrjTabEN objPrjTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objPrjTabEN.TabId, 8, conPrjTab.TabId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabName, 100, conPrjTab.TabName);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabCnName, 200, conPrjTab.TabCnName);
clsCheckSql.CheckFieldLen(objPrjTabEN.PrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldLen(objPrjTabEN.SqlDsTypeId, 2, conPrjTab.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabStateId, 2, conPrjTab.TabStateId);
clsCheckSql.CheckFieldLen(objPrjTabEN.FuncModuleAgcId, 8, conPrjTab.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objPrjTabEN.Keyword, 50, conPrjTab.Keyword);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabTypeId, 4, conPrjTab.TabTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabMainTypeId, 4, conPrjTab.TabMainTypeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.RelaTabId4View, 8, conPrjTab.RelaTabId4View);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParentClass, 50, conPrjTab.ParentClass);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField, 8, conPrjTab.CacheClassifyField);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField2, 8, conPrjTab.CacheClassifyField2);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheModeId, 2, conPrjTab.CacheModeId);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyFieldTS, 8, conPrjTab.CacheClassifyFieldTS);
clsCheckSql.CheckFieldLen(objPrjTabEN.CacheClassifyField2TS, 8, conPrjTab.CacheClassifyField2TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParaVar2TS, 8, conPrjTab.ParaVar2TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.ParaVar1TS, 8, conPrjTab.ParaVar1TS);
clsCheckSql.CheckFieldLen(objPrjTabEN.WhereFormat, 500, conPrjTab.WhereFormat);
clsCheckSql.CheckFieldLen(objPrjTabEN.WhereFormatBack, 500, conPrjTab.WhereFormatBack);
clsCheckSql.CheckFieldLen(objPrjTabEN.KeyId4Test, 50, conPrjTab.KeyId4Test);
clsCheckSql.CheckFieldLen(objPrjTabEN.ErrMsg, 2000, conPrjTab.ErrMsg);
clsCheckSql.CheckFieldLen(objPrjTabEN.UpdUserId, 20, conPrjTab.UpdUserId);
clsCheckSql.CheckFieldLen(objPrjTabEN.UpdDate, 20, conPrjTab.UpdDate);
clsCheckSql.CheckFieldLen(objPrjTabEN.Memo, 1000, conPrjTab.Memo);
clsCheckSql.CheckFieldLen(objPrjTabEN.Owner, 50, conPrjTab.Owner);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabEnName, 200, conPrjTab.TabEnName);
clsCheckSql.CheckFieldLen(objPrjTabEN.TabNameB, 50, conPrjTab.TabNameB);
clsCheckSql.CheckFieldLen(objPrjTabEN.RelaViewId, 8, conPrjTab.RelaViewId);
clsCheckSql.CheckFieldLen(objPrjTabEN.DataBaseName, 50, conPrjTab.DataBaseName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabId, conPrjTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabName, conPrjTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabCnName, conPrjTab.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.PrjId, conPrjTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.SqlDsTypeId, conPrjTab.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabStateId, conPrjTab.TabStateId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.FuncModuleAgcId, conPrjTab.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.Keyword, conPrjTab.Keyword);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabTypeId, conPrjTab.TabTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabMainTypeId, conPrjTab.TabMainTypeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.RelaTabId4View, conPrjTab.RelaTabId4View);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.ParentClass, conPrjTab.ParentClass);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.CacheClassifyField, conPrjTab.CacheClassifyField);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.CacheClassifyField2, conPrjTab.CacheClassifyField2);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.CacheModeId, conPrjTab.CacheModeId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.CacheClassifyFieldTS, conPrjTab.CacheClassifyFieldTS);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.CacheClassifyField2TS, conPrjTab.CacheClassifyField2TS);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.ParaVar2TS, conPrjTab.ParaVar2TS);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.ParaVar1TS, conPrjTab.ParaVar1TS);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.WhereFormat, conPrjTab.WhereFormat);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.WhereFormatBack, conPrjTab.WhereFormatBack);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.KeyId4Test, conPrjTab.KeyId4Test);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.ErrMsg, conPrjTab.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.UpdUserId, conPrjTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.UpdDate, conPrjTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.Memo, conPrjTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.Owner, conPrjTab.Owner);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabEnName, conPrjTab.TabEnName);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.TabNameB, conPrjTab.TabNameB);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.RelaViewId, conPrjTab.RelaViewId);
clsCheckSql.CheckSqlInjection4Field(objPrjTabEN.DataBaseName, conPrjTab.DataBaseName);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objPrjTabEN.PrjId, 4, conPrjTab.PrjId);
clsCheckSql.CheckFieldForeignKey(objPrjTabEN.RelaTabId4View, 8, conPrjTab.RelaTabId4View);
 objPrjTabEN._IsCheckProperty = true;
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
string strSQL = "select TabId, TabName from PrjTab ";
 clsSpecSQLforSql mySql = clsPrjTabDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--PrjTab(工程表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objPrjTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsPrjTabEN objPrjTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objPrjTabEN.TabName);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objPrjTabEN.PrjId);
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjTabEN._CurrTabName);
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsPrjTabEN._CurrTabName, strCondition);
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
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
 objSQL = clsPrjTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}