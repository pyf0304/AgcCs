
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsViewInfoDA
 表名:ViewInfo(00050006)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:01:06
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:界面管理(PrjInterface)
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
 /// 界面(ViewInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsViewInfoDA : clsCommBase4DA
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
 return clsViewInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsViewInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsViewInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsViewInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsViewInfoEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strViewId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strViewId)
{
strViewId = strViewId.Replace("'", "''");
if (strViewId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:ViewInfo中,检查关键字,长度不正确!(clsViewInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:ViewInfo中,关键字不能为空 或 null!(clsViewInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsViewInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_ViewInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable_ViewInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewInfo.* " + 
$"from ViewInfo " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewInfo.ViewId not in " + 
$"(Select top {intTop_In} ViewInfo.ViewId from ViewInfo " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1} and ViewId not in (Select top {2} ViewId from ViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1} and ViewId not in (Select top {3} ViewId from ViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} ViewInfo.* " + 
$"from ViewInfo " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and ViewInfo.ViewId not in " + 
$"(Select top {intTop_In} ViewInfo.ViewId from ViewInfo " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1} and ViewId not in (Select top {2} ViewId from ViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from ViewInfo where {1} and ViewId not in (Select top {3} ViewId from ViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsViewInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsViewInfoDA:GetObjLst)", objException.Message));
}
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = TransNullToBool(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = TransNullToBool(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewInfoDA: GetObjLst)", objException.Message));
}
objViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewInfoEN);
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
public List<clsViewInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsViewInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsViewInfoEN> arrObjLst = new List<clsViewInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = TransNullToBool(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = TransNullToBool(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsViewInfoDA: GetObjLst)", objException.Message));
}
objViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objViewInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetViewInfo(ref clsViewInfoEN objViewInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where ViewId = " + "'"+ objViewInfoEN.ViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objViewInfoEN.ViewId = objDT.Rows[0][conViewInfo.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewInfoEN.ViewName = objDT.Rows[0][conViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objViewInfoEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objViewInfoEN.FuncModuleAgcId = objDT.Rows[0][conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objViewInfoEN.DataBaseName = objDT.Rows[0][conViewInfo.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objViewInfoEN.KeyForMainTab = objDT.Rows[0][conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objViewInfoEN.KeyForDetailTab = objDT.Rows[0][conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objViewInfoEN.IsNeedSort = TransNullToBool(objDT.Rows[0][conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objViewInfoEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objViewInfoEN.IsNeedSetExportFld = TransNullToBool(objDT.Rows[0][conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段(字段类型:bit,字段长度:1,是否可空:False)
 objViewInfoEN.UserId = objDT.Rows[0][conViewInfo.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewInfoEN.PrjId = objDT.Rows[0][conViewInfo.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewInfoEN.ViewFunction = objDT.Rows[0][conViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objViewInfoEN.ViewDetail = objDT.Rows[0][conViewInfo.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewInfoEN.DefaMenuName = objDT.Rows[0][conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:100,是否可空:False)
 objViewInfoEN.DetailTabId = objDT.Rows[0][conViewInfo.DetailTabId].ToString().Trim(); //明细表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.FileName = objDT.Rows[0][conViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objViewInfoEN.FilePath = objDT.Rows[0][conViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objViewInfoEN.MainTabId = objDT.Rows[0][conViewInfo.MainTabId].ToString().Trim(); //主表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.ViewCnName = objDT.Rows[0][conViewInfo.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objViewInfoEN.ViewGroupId = objDT.Rows[0][conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewInfoEN.InRelaTabId = objDT.Rows[0][conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID(字段类型:char,字段长度:8,是否可空:True)
 objViewInfoEN.InSqlDsTypeId = objDT.Rows[0][conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewInfoEN.OutRelaTabId = objDT.Rows[0][conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewInfoEN.OutSqlDsTypeId = objDT.Rows[0][conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewInfoEN.DetailTabType = objDT.Rows[0][conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType(字段类型:varchar,字段长度:10,是否可空:True)
 objViewInfoEN.DetailViewId = objDT.Rows[0][conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.MainTabType = objDT.Rows[0][conViewInfo.MainTabType].ToString().Trim(); //MainTabType(字段类型:varchar,字段长度:10,是否可空:True)
 objViewInfoEN.MainViewId = objDT.Rows[0][conViewInfo.MainViewId].ToString().Trim(); //MainViewId(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.GeneCodeDate = objDT.Rows[0][conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewInfoEN.TaskId = objDT.Rows[0][conViewInfo.TaskId].ToString().Trim(); //任务Id(字段类型:char,字段长度:16,是否可空:True)
 objViewInfoEN.KeyId4Test = objDT.Rows[0][conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objViewInfoEN.ViewMasterId = objDT.Rows[0][conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objViewInfoEN.IsShare = TransNullToBool(objDT.Rows[0][conViewInfo.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
 objViewInfoEN.ErrMsg = objDT.Rows[0][conViewInfo.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewInfoEN.UpdDate = objDT.Rows[0][conViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewInfoEN.UpdUserId = objDT.Rows[0][conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objViewInfoEN.Memo = objDT.Rows[0][conViewInfo.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewInfoEN.RegionNum = TransNullToInt(objDT.Rows[0][conViewInfo.RegionNum].ToString().Trim()); //区域数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsViewInfoDA: GetViewInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsViewInfoEN GetObjByViewId(string strViewId)
{
CheckPrimaryKey(strViewId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where ViewId = " + "'"+ strViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
 objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段(字段类型:bit,字段长度:1,是否可空:False)
 objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:100,是否可空:False)
 objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID(字段类型:char,字段长度:8,是否可空:True)
 objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID(字段类型:char,字段长度:8,是否可空:False)
 objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType(字段类型:varchar,字段长度:10,是否可空:True)
 objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType(字段类型:varchar,字段长度:10,是否可空:True)
 objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId(字段类型:varchar,字段长度:8,是否可空:True)
 objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id(字段类型:char,字段长度:16,是否可空:True)
 objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objViewInfoEN.IsShare = clsEntityBase2.TransNullToBool_S(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享(字段类型:bit,字段长度:1,是否可空:True)
 objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsViewInfoDA: GetObjByViewId)", objException.Message));
}
return objViewInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsViewInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsViewInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN()
{
ViewId = objRow[conViewInfo.ViewId].ToString().Trim(), //界面Id
ViewName = objRow[conViewInfo.ViewName].ToString().Trim(), //界面名称
ApplicationTypeId = TransNullToInt(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(), //功能模块Id
DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(), //数据库名
KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(), //主表关键字
KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(), //明细表关键字
IsNeedSort = TransNullToBool(objRow[conViewInfo.IsNeedSort].ToString().Trim()), //是否需要排序
IsNeedTransCode = TransNullToBool(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
IsNeedSetExportFld = TransNullToBool(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()), //是否需要设置导出字段
UserId = objRow[conViewInfo.UserId].ToString().Trim(), //用户Id
PrjId = objRow[conViewInfo.PrjId].ToString().Trim(), //工程Id
ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(), //界面功能
ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(), //界面说明
DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(), //缺省菜单名
DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(), //明细表ID
FileName = objRow[conViewInfo.FileName].ToString().Trim(), //文件名
FilePath = objRow[conViewInfo.FilePath].ToString().Trim(), //文件路径
MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(), //主表ID
ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(), //视图中文名
ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(), //界面组ID
InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(), //输入数据源表ID
InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(), //输入数据源类型
OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(), //输出数据源表ID
OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(), //输出数据源类型
DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(), //DetailTabType
DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(), //DetailViewId
MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(), //MainTabType
MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(), //MainViewId
GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(), //生成代码日期
TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(), //任务Id
KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(), //测试关键字Id
ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(), //界面母版Id
IsShare = TransNullToBool(objRow[conViewInfo.IsShare].ToString().Trim()), //是否共享
ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(), //错误信息
UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(), //说明
RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewInfo.RegionNum].ToString().Trim()) //区域数
};
objViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsViewInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsViewInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = TransNullToBool(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = TransNullToBool(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsViewInfoDA: GetObjByDataRowViewInfo)", objException.Message));
}
objViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsViewInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsViewInfoEN objViewInfoEN = new clsViewInfoEN();
try
{
objViewInfoEN.ViewId = objRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objViewInfoEN.ViewName = objRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[conViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objViewInfoEN.FuncModuleAgcId = objRow[conViewInfo.FuncModuleAgcId] == DBNull.Value ? null : objRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objViewInfoEN.DataBaseName = objRow[conViewInfo.DataBaseName] == DBNull.Value ? null : objRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objViewInfoEN.KeyForMainTab = objRow[conViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objViewInfoEN.KeyForDetailTab = objRow[conViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objViewInfoEN.IsNeedSort = TransNullToBool(objRow[conViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[conViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[conViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objViewInfoEN.UserId = objRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objViewInfoEN.PrjId = objRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objViewInfoEN.ViewFunction = objRow[conViewInfo.ViewFunction] == DBNull.Value ? null : objRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objViewInfoEN.ViewDetail = objRow[conViewInfo.ViewDetail] == DBNull.Value ? null : objRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objViewInfoEN.DefaMenuName = objRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objViewInfoEN.DetailTabId = objRow[conViewInfo.DetailTabId] == DBNull.Value ? null : objRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objViewInfoEN.FileName = objRow[conViewInfo.FileName].ToString().Trim(); //文件名
objViewInfoEN.FilePath = objRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objViewInfoEN.MainTabId = objRow[conViewInfo.MainTabId] == DBNull.Value ? null : objRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objViewInfoEN.ViewCnName = objRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objViewInfoEN.ViewGroupId = objRow[conViewInfo.ViewGroupId] == DBNull.Value ? null : objRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objViewInfoEN.InRelaTabId = objRow[conViewInfo.InRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objViewInfoEN.InSqlDsTypeId = objRow[conViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objViewInfoEN.OutRelaTabId = objRow[conViewInfo.OutRelaTabId] == DBNull.Value ? null : objRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objViewInfoEN.OutSqlDsTypeId = objRow[conViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objViewInfoEN.DetailTabType = objRow[conViewInfo.DetailTabType] == DBNull.Value ? null : objRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objViewInfoEN.DetailViewId = objRow[conViewInfo.DetailViewId] == DBNull.Value ? null : objRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objViewInfoEN.MainTabType = objRow[conViewInfo.MainTabType] == DBNull.Value ? null : objRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objViewInfoEN.MainViewId = objRow[conViewInfo.MainViewId] == DBNull.Value ? null : objRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objViewInfoEN.GeneCodeDate = objRow[conViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objViewInfoEN.TaskId = objRow[conViewInfo.TaskId] == DBNull.Value ? null : objRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objViewInfoEN.KeyId4Test = objRow[conViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objViewInfoEN.ViewMasterId = objRow[conViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objViewInfoEN.IsShare = TransNullToBool(objRow[conViewInfo.IsShare].ToString().Trim()); //是否共享
objViewInfoEN.ErrMsg = objRow[conViewInfo.ErrMsg] == DBNull.Value ? null : objRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objViewInfoEN.UpdDate = objRow[conViewInfo.UpdDate] == DBNull.Value ? null : objRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objViewInfoEN.UpdUserId = objRow[conViewInfo.UpdUserId] == DBNull.Value ? null : objRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objViewInfoEN.Memo = objRow[conViewInfo.Memo] == DBNull.Value ? null : objRow[conViewInfo.Memo].ToString().Trim(); //说明
objViewInfoEN.RegionNum = objRow[conViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conViewInfo.RegionNum].ToString().Trim()); //区域数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsViewInfoDA: GetObjByDataRow)", objException.Message));
}
objViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objViewInfoEN;
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
objSQL = clsViewInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewInfoEN._CurrTabName, conViewInfo.ViewId, 8, "");
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
objSQL = clsViewInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsViewInfoEN._CurrTabName, conViewInfo.ViewId, 8, strPrefix);
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewId from ViewInfo where " + strCondition;
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewId from ViewInfo where " + strCondition;
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strViewId)
{
CheckPrimaryKey(strViewId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewInfo", "ViewId = " + "'"+ strViewId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsViewInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("ViewInfo", strCondition))
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
objSQL = clsViewInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("ViewInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsViewInfoEN objViewInfoEN)
 {
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewInfoEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewInfo");
objRow = objDS.Tables["ViewInfo"].NewRow();
objRow[conViewInfo.ViewId] = objViewInfoEN.ViewId; //界面Id
objRow[conViewInfo.ViewName] = objViewInfoEN.ViewName; //界面名称
objRow[conViewInfo.ApplicationTypeId] = objViewInfoEN.ApplicationTypeId; //应用程序类型ID
 if (objViewInfoEN.FuncModuleAgcId !=  "")
 {
objRow[conViewInfo.FuncModuleAgcId] = objViewInfoEN.FuncModuleAgcId; //功能模块Id
 }
 if (objViewInfoEN.DataBaseName !=  "")
 {
objRow[conViewInfo.DataBaseName] = objViewInfoEN.DataBaseName; //数据库名
 }
 if (objViewInfoEN.KeyForMainTab !=  "")
 {
objRow[conViewInfo.KeyForMainTab] = objViewInfoEN.KeyForMainTab; //主表关键字
 }
 if (objViewInfoEN.KeyForDetailTab !=  "")
 {
objRow[conViewInfo.KeyForDetailTab] = objViewInfoEN.KeyForDetailTab; //明细表关键字
 }
objRow[conViewInfo.IsNeedSort] = objViewInfoEN.IsNeedSort; //是否需要排序
objRow[conViewInfo.IsNeedTransCode] = objViewInfoEN.IsNeedTransCode; //是否需要转换代码
objRow[conViewInfo.IsNeedSetExportFld] = objViewInfoEN.IsNeedSetExportFld; //是否需要设置导出字段
objRow[conViewInfo.UserId] = objViewInfoEN.UserId; //用户Id
objRow[conViewInfo.PrjId] = objViewInfoEN.PrjId; //工程Id
 if (objViewInfoEN.ViewFunction !=  "")
 {
objRow[conViewInfo.ViewFunction] = objViewInfoEN.ViewFunction; //界面功能
 }
 if (objViewInfoEN.ViewDetail !=  "")
 {
objRow[conViewInfo.ViewDetail] = objViewInfoEN.ViewDetail; //界面说明
 }
objRow[conViewInfo.DefaMenuName] = objViewInfoEN.DefaMenuName; //缺省菜单名
 if (objViewInfoEN.DetailTabId !=  "")
 {
objRow[conViewInfo.DetailTabId] = objViewInfoEN.DetailTabId; //明细表ID
 }
objRow[conViewInfo.FileName] = objViewInfoEN.FileName; //文件名
objRow[conViewInfo.FilePath] = objViewInfoEN.FilePath; //文件路径
 if (objViewInfoEN.MainTabId !=  "")
 {
objRow[conViewInfo.MainTabId] = objViewInfoEN.MainTabId; //主表ID
 }
objRow[conViewInfo.ViewCnName] = objViewInfoEN.ViewCnName; //视图中文名
 if (objViewInfoEN.ViewGroupId !=  "")
 {
objRow[conViewInfo.ViewGroupId] = objViewInfoEN.ViewGroupId; //界面组ID
 }
 if (objViewInfoEN.InRelaTabId !=  "")
 {
objRow[conViewInfo.InRelaTabId] = objViewInfoEN.InRelaTabId; //输入数据源表ID
 }
 if (objViewInfoEN.InSqlDsTypeId !=  "")
 {
objRow[conViewInfo.InSqlDsTypeId] = objViewInfoEN.InSqlDsTypeId; //输入数据源类型
 }
 if (objViewInfoEN.OutRelaTabId !=  "")
 {
objRow[conViewInfo.OutRelaTabId] = objViewInfoEN.OutRelaTabId; //输出数据源表ID
 }
 if (objViewInfoEN.OutSqlDsTypeId !=  "")
 {
objRow[conViewInfo.OutSqlDsTypeId] = objViewInfoEN.OutSqlDsTypeId; //输出数据源类型
 }
 if (objViewInfoEN.DetailTabType !=  "")
 {
objRow[conViewInfo.DetailTabType] = objViewInfoEN.DetailTabType; //DetailTabType
 }
 if (objViewInfoEN.DetailViewId !=  "")
 {
objRow[conViewInfo.DetailViewId] = objViewInfoEN.DetailViewId; //DetailViewId
 }
 if (objViewInfoEN.MainTabType !=  "")
 {
objRow[conViewInfo.MainTabType] = objViewInfoEN.MainTabType; //MainTabType
 }
 if (objViewInfoEN.MainViewId !=  "")
 {
objRow[conViewInfo.MainViewId] = objViewInfoEN.MainViewId; //MainViewId
 }
 if (objViewInfoEN.GeneCodeDate !=  "")
 {
objRow[conViewInfo.GeneCodeDate] = objViewInfoEN.GeneCodeDate; //生成代码日期
 }
 if (objViewInfoEN.TaskId !=  "")
 {
objRow[conViewInfo.TaskId] = objViewInfoEN.TaskId; //任务Id
 }
 if (objViewInfoEN.KeyId4Test !=  "")
 {
objRow[conViewInfo.KeyId4Test] = objViewInfoEN.KeyId4Test; //测试关键字Id
 }
 if (objViewInfoEN.ViewMasterId !=  "")
 {
objRow[conViewInfo.ViewMasterId] = objViewInfoEN.ViewMasterId; //界面母版Id
 }
objRow[conViewInfo.IsShare] = objViewInfoEN.IsShare; //是否共享
 if (objViewInfoEN.ErrMsg !=  "")
 {
objRow[conViewInfo.ErrMsg] = objViewInfoEN.ErrMsg; //错误信息
 }
 if (objViewInfoEN.UpdDate !=  "")
 {
objRow[conViewInfo.UpdDate] = objViewInfoEN.UpdDate; //修改日期
 }
 if (objViewInfoEN.UpdUserId !=  "")
 {
objRow[conViewInfo.UpdUserId] = objViewInfoEN.UpdUserId; //修改用户Id
 }
 if (objViewInfoEN.Memo !=  "")
 {
objRow[conViewInfo.Memo] = objViewInfoEN.Memo; //说明
 }
objRow[conViewInfo.RegionNum] = objViewInfoEN.RegionNum; //区域数
objDS.Tables[clsViewInfoEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsViewInfoEN._CurrTabName);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewInfoEN objViewInfoEN)
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewId);
 var strViewId = objViewInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewInfoEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewName);
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.ApplicationTypeId);
 arrValueListForInsert.Add(objViewInfoEN.ApplicationTypeId.ToString());
 
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FuncModuleAgcId);
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objViewInfoEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DataBaseName);
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyForMainTab);
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyForMainTab + "'");
 }
 
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyForDetailTab);
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyForDetailTab + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedSort);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedSetExportFld);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedSetExportFld  ==  false ? "0" : "1") + "'");
 
 if (objViewInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UserId);
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.PrjId);
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewInfoEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewFunction);
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewInfoEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewDetail);
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DefaMenuName);
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaMenuName + "'");
 }
 
 if (objViewInfoEN.DetailTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailTabId);
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailTabId + "'");
 }
 
 if (objViewInfoEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FileName);
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewInfoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FilePath);
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objViewInfoEN.MainTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainTabId);
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainTabId + "'");
 }
 
 if (objViewInfoEN.ViewCnName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewCnName);
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewCnName + "'");
 }
 
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewGroupId);
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupId + "'");
 }
 
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.InRelaTabId);
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInRelaTabId + "'");
 }
 
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.InSqlDsTypeId);
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInSqlDsTypeId + "'");
 }
 
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.OutRelaTabId);
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutRelaTabId + "'");
 }
 
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.OutSqlDsTypeId);
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutSqlDsTypeId + "'");
 }
 
 if (objViewInfoEN.DetailTabType !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailTabType);
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailTabType + "'");
 }
 
 if (objViewInfoEN.DetailViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailViewId);
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailViewId + "'");
 }
 
 if (objViewInfoEN.MainTabType !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainTabType);
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainTabType + "'");
 }
 
 if (objViewInfoEN.MainViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainViewId);
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainViewId + "'");
 }
 
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.GeneCodeDate);
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objViewInfoEN.TaskId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.TaskId);
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTaskId + "'");
 }
 
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyId4Test);
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewMasterId);
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.IsShare);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsShare  ==  false ? "0" : "1") + "'");
 
 if (objViewInfoEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ErrMsg);
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UpdDate);
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UpdUserId);
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objViewInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.Memo);
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsViewInfoEN objViewInfoEN)
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewInfoEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewId);
 var strViewId = objViewInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewInfoEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewName);
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.ApplicationTypeId);
 arrValueListForInsert.Add(objViewInfoEN.ApplicationTypeId.ToString());
 
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FuncModuleAgcId);
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objViewInfoEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DataBaseName);
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyForMainTab);
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyForMainTab + "'");
 }
 
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyForDetailTab);
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyForDetailTab + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedSort);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedSetExportFld);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedSetExportFld  ==  false ? "0" : "1") + "'");
 
 if (objViewInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UserId);
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.PrjId);
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewInfoEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewFunction);
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewInfoEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewDetail);
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DefaMenuName);
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaMenuName + "'");
 }
 
 if (objViewInfoEN.DetailTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailTabId);
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailTabId + "'");
 }
 
 if (objViewInfoEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FileName);
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewInfoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FilePath);
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objViewInfoEN.MainTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainTabId);
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainTabId + "'");
 }
 
 if (objViewInfoEN.ViewCnName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewCnName);
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewCnName + "'");
 }
 
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewGroupId);
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupId + "'");
 }
 
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.InRelaTabId);
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInRelaTabId + "'");
 }
 
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.InSqlDsTypeId);
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInSqlDsTypeId + "'");
 }
 
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.OutRelaTabId);
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutRelaTabId + "'");
 }
 
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.OutSqlDsTypeId);
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutSqlDsTypeId + "'");
 }
 
 if (objViewInfoEN.DetailTabType !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailTabType);
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailTabType + "'");
 }
 
 if (objViewInfoEN.DetailViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailViewId);
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailViewId + "'");
 }
 
 if (objViewInfoEN.MainTabType !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainTabType);
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainTabType + "'");
 }
 
 if (objViewInfoEN.MainViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainViewId);
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainViewId + "'");
 }
 
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.GeneCodeDate);
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objViewInfoEN.TaskId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.TaskId);
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTaskId + "'");
 }
 
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyId4Test);
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewMasterId);
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.IsShare);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsShare  ==  false ? "0" : "1") + "'");
 
 if (objViewInfoEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ErrMsg);
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UpdDate);
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UpdUserId);
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objViewInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.Memo);
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewInfo");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objViewInfoEN.ViewId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsViewInfoEN objViewInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objViewInfoEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objViewInfoEN.ViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewId);
 var strViewId = objViewInfoEN.ViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewId + "'");
 }
 
 if (objViewInfoEN.ViewName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewName);
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewName + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.ApplicationTypeId);
 arrValueListForInsert.Add(objViewInfoEN.ApplicationTypeId.ToString());
 
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FuncModuleAgcId);
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncModuleAgcId + "'");
 }
 
 if (objViewInfoEN.DataBaseName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DataBaseName);
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataBaseName + "'");
 }
 
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyForMainTab);
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyForMainTab + "'");
 }
 
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyForDetailTab);
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyForDetailTab + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedSort);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedSort  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedTransCode);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedTransCode  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conViewInfo.IsNeedSetExportFld);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsNeedSetExportFld  ==  false ? "0" : "1") + "'");
 
 if (objViewInfoEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UserId);
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.PrjId);
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objViewInfoEN.ViewFunction !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewFunction);
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewFunction + "'");
 }
 
 if (objViewInfoEN.ViewDetail !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewDetail);
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewDetail + "'");
 }
 
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DefaMenuName);
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDefaMenuName + "'");
 }
 
 if (objViewInfoEN.DetailTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailTabId);
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailTabId + "'");
 }
 
 if (objViewInfoEN.FileName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FileName);
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFileName + "'");
 }
 
 if (objViewInfoEN.FilePath !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.FilePath);
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFilePath + "'");
 }
 
 if (objViewInfoEN.MainTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainTabId);
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainTabId + "'");
 }
 
 if (objViewInfoEN.ViewCnName !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewCnName);
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewCnName + "'");
 }
 
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewGroupId);
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewGroupId + "'");
 }
 
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.InRelaTabId);
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInRelaTabId + "'");
 }
 
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.InSqlDsTypeId);
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInSqlDsTypeId + "'");
 }
 
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.OutRelaTabId);
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutRelaTabId + "'");
 }
 
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.OutSqlDsTypeId);
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOutSqlDsTypeId + "'");
 }
 
 if (objViewInfoEN.DetailTabType !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailTabType);
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailTabType + "'");
 }
 
 if (objViewInfoEN.DetailViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.DetailViewId);
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDetailViewId + "'");
 }
 
 if (objViewInfoEN.MainTabType !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainTabType);
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainTabType + "'");
 }
 
 if (objViewInfoEN.MainViewId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.MainViewId);
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMainViewId + "'");
 }
 
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.GeneCodeDate);
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strGeneCodeDate + "'");
 }
 
 if (objViewInfoEN.TaskId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.TaskId);
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTaskId + "'");
 }
 
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.KeyId4Test);
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyId4Test + "'");
 }
 
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ViewMasterId);
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strViewMasterId + "'");
 }
 
 arrFieldListForInsert.Add(conViewInfo.IsShare);
 arrValueListForInsert.Add("'" + (objViewInfoEN.IsShare  ==  false ? "0" : "1") + "'");
 
 if (objViewInfoEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.ErrMsg);
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objViewInfoEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UpdDate);
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objViewInfoEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.UpdUserId);
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objViewInfoEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conViewInfo.Memo);
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into ViewInfo");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewViewInfos(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where ViewId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "ViewInfo");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strViewId = oRow[conViewInfo.ViewId].ToString().Trim();
if (IsExist(strViewId))
{
 string strResult = "关键字变量值为:" + string.Format("ViewId = {0}", strViewId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsViewInfoEN._CurrTabName ].NewRow();
objRow[conViewInfo.ViewId] = oRow[conViewInfo.ViewId].ToString().Trim(); //界面Id
objRow[conViewInfo.ViewName] = oRow[conViewInfo.ViewName].ToString().Trim(); //界面名称
objRow[conViewInfo.ApplicationTypeId] = oRow[conViewInfo.ApplicationTypeId].ToString().Trim(); //应用程序类型ID
objRow[conViewInfo.FuncModuleAgcId] = oRow[conViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objRow[conViewInfo.DataBaseName] = oRow[conViewInfo.DataBaseName].ToString().Trim(); //数据库名
objRow[conViewInfo.KeyForMainTab] = oRow[conViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objRow[conViewInfo.KeyForDetailTab] = oRow[conViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objRow[conViewInfo.IsNeedSort] = oRow[conViewInfo.IsNeedSort].ToString().Trim(); //是否需要排序
objRow[conViewInfo.IsNeedTransCode] = oRow[conViewInfo.IsNeedTransCode].ToString().Trim(); //是否需要转换代码
objRow[conViewInfo.IsNeedSetExportFld] = oRow[conViewInfo.IsNeedSetExportFld].ToString().Trim(); //是否需要设置导出字段
objRow[conViewInfo.UserId] = oRow[conViewInfo.UserId].ToString().Trim(); //用户Id
objRow[conViewInfo.PrjId] = oRow[conViewInfo.PrjId].ToString().Trim(); //工程Id
objRow[conViewInfo.ViewFunction] = oRow[conViewInfo.ViewFunction].ToString().Trim(); //界面功能
objRow[conViewInfo.ViewDetail] = oRow[conViewInfo.ViewDetail].ToString().Trim(); //界面说明
objRow[conViewInfo.DefaMenuName] = oRow[conViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objRow[conViewInfo.DetailTabId] = oRow[conViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objRow[conViewInfo.FileName] = oRow[conViewInfo.FileName].ToString().Trim(); //文件名
objRow[conViewInfo.FilePath] = oRow[conViewInfo.FilePath].ToString().Trim(); //文件路径
objRow[conViewInfo.MainTabId] = oRow[conViewInfo.MainTabId].ToString().Trim(); //主表ID
objRow[conViewInfo.ViewCnName] = oRow[conViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objRow[conViewInfo.ViewGroupId] = oRow[conViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objRow[conViewInfo.InRelaTabId] = oRow[conViewInfo.InRelaTabId].ToString().Trim(); //输入数据源表ID
objRow[conViewInfo.InSqlDsTypeId] = oRow[conViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objRow[conViewInfo.OutRelaTabId] = oRow[conViewInfo.OutRelaTabId].ToString().Trim(); //输出数据源表ID
objRow[conViewInfo.OutSqlDsTypeId] = oRow[conViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objRow[conViewInfo.DetailTabType] = oRow[conViewInfo.DetailTabType].ToString().Trim(); //DetailTabType
objRow[conViewInfo.DetailViewId] = oRow[conViewInfo.DetailViewId].ToString().Trim(); //DetailViewId
objRow[conViewInfo.MainTabType] = oRow[conViewInfo.MainTabType].ToString().Trim(); //MainTabType
objRow[conViewInfo.MainViewId] = oRow[conViewInfo.MainViewId].ToString().Trim(); //MainViewId
objRow[conViewInfo.GeneCodeDate] = oRow[conViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objRow[conViewInfo.TaskId] = oRow[conViewInfo.TaskId].ToString().Trim(); //任务Id
objRow[conViewInfo.KeyId4Test] = oRow[conViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objRow[conViewInfo.ViewMasterId] = oRow[conViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objRow[conViewInfo.IsShare] = oRow[conViewInfo.IsShare].ToString().Trim(); //是否共享
objRow[conViewInfo.ErrMsg] = oRow[conViewInfo.ErrMsg].ToString().Trim(); //错误信息
objRow[conViewInfo.UpdDate] = oRow[conViewInfo.UpdDate].ToString().Trim(); //修改日期
objRow[conViewInfo.UpdUserId] = oRow[conViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conViewInfo.Memo] = oRow[conViewInfo.Memo].ToString().Trim(); //说明
objRow[conViewInfo.RegionNum] = oRow[conViewInfo.RegionNum].ToString().Trim(); //区域数
 objDS.Tables[clsViewInfoEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsViewInfoEN._CurrTabName);
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
 /// <param name = "objViewInfoEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsViewInfoEN objViewInfoEN)
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewInfoEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from ViewInfo where ViewId = " + "'"+ objViewInfoEN.ViewId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsViewInfoEN._CurrTabName);
if (objDS.Tables[clsViewInfoEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:ViewId = " + "'"+ objViewInfoEN.ViewId+"'");
return false;
}
objRow = objDS.Tables[clsViewInfoEN._CurrTabName].Rows[0];
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewId))
 {
objRow[conViewInfo.ViewId] = objViewInfoEN.ViewId; //界面Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewName))
 {
objRow[conViewInfo.ViewName] = objViewInfoEN.ViewName; //界面名称
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ApplicationTypeId))
 {
objRow[conViewInfo.ApplicationTypeId] = objViewInfoEN.ApplicationTypeId; //应用程序类型ID
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.FuncModuleAgcId))
 {
objRow[conViewInfo.FuncModuleAgcId] = objViewInfoEN.FuncModuleAgcId; //功能模块Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.DataBaseName))
 {
objRow[conViewInfo.DataBaseName] = objViewInfoEN.DataBaseName; //数据库名
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForMainTab))
 {
objRow[conViewInfo.KeyForMainTab] = objViewInfoEN.KeyForMainTab; //主表关键字
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForDetailTab))
 {
objRow[conViewInfo.KeyForDetailTab] = objViewInfoEN.KeyForDetailTab; //明细表关键字
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSort))
 {
objRow[conViewInfo.IsNeedSort] = objViewInfoEN.IsNeedSort; //是否需要排序
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedTransCode))
 {
objRow[conViewInfo.IsNeedTransCode] = objViewInfoEN.IsNeedTransCode; //是否需要转换代码
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSetExportFld))
 {
objRow[conViewInfo.IsNeedSetExportFld] = objViewInfoEN.IsNeedSetExportFld; //是否需要设置导出字段
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.UserId))
 {
objRow[conViewInfo.UserId] = objViewInfoEN.UserId; //用户Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.PrjId))
 {
objRow[conViewInfo.PrjId] = objViewInfoEN.PrjId; //工程Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewFunction))
 {
objRow[conViewInfo.ViewFunction] = objViewInfoEN.ViewFunction; //界面功能
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewDetail))
 {
objRow[conViewInfo.ViewDetail] = objViewInfoEN.ViewDetail; //界面说明
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.DefaMenuName))
 {
objRow[conViewInfo.DefaMenuName] = objViewInfoEN.DefaMenuName; //缺省菜单名
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabId))
 {
objRow[conViewInfo.DetailTabId] = objViewInfoEN.DetailTabId; //明细表ID
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.FileName))
 {
objRow[conViewInfo.FileName] = objViewInfoEN.FileName; //文件名
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.FilePath))
 {
objRow[conViewInfo.FilePath] = objViewInfoEN.FilePath; //文件路径
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabId))
 {
objRow[conViewInfo.MainTabId] = objViewInfoEN.MainTabId; //主表ID
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewCnName))
 {
objRow[conViewInfo.ViewCnName] = objViewInfoEN.ViewCnName; //视图中文名
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewGroupId))
 {
objRow[conViewInfo.ViewGroupId] = objViewInfoEN.ViewGroupId; //界面组ID
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.InRelaTabId))
 {
objRow[conViewInfo.InRelaTabId] = objViewInfoEN.InRelaTabId; //输入数据源表ID
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.InSqlDsTypeId))
 {
objRow[conViewInfo.InSqlDsTypeId] = objViewInfoEN.InSqlDsTypeId; //输入数据源类型
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.OutRelaTabId))
 {
objRow[conViewInfo.OutRelaTabId] = objViewInfoEN.OutRelaTabId; //输出数据源表ID
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.OutSqlDsTypeId))
 {
objRow[conViewInfo.OutSqlDsTypeId] = objViewInfoEN.OutSqlDsTypeId; //输出数据源类型
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabType))
 {
objRow[conViewInfo.DetailTabType] = objViewInfoEN.DetailTabType; //DetailTabType
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailViewId))
 {
objRow[conViewInfo.DetailViewId] = objViewInfoEN.DetailViewId; //DetailViewId
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabType))
 {
objRow[conViewInfo.MainTabType] = objViewInfoEN.MainTabType; //MainTabType
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.MainViewId))
 {
objRow[conViewInfo.MainViewId] = objViewInfoEN.MainViewId; //MainViewId
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.GeneCodeDate))
 {
objRow[conViewInfo.GeneCodeDate] = objViewInfoEN.GeneCodeDate; //生成代码日期
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.TaskId))
 {
objRow[conViewInfo.TaskId] = objViewInfoEN.TaskId; //任务Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyId4Test))
 {
objRow[conViewInfo.KeyId4Test] = objViewInfoEN.KeyId4Test; //测试关键字Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewMasterId))
 {
objRow[conViewInfo.ViewMasterId] = objViewInfoEN.ViewMasterId; //界面母版Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.IsShare))
 {
objRow[conViewInfo.IsShare] = objViewInfoEN.IsShare; //是否共享
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.ErrMsg))
 {
objRow[conViewInfo.ErrMsg] = objViewInfoEN.ErrMsg; //错误信息
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdDate))
 {
objRow[conViewInfo.UpdDate] = objViewInfoEN.UpdDate; //修改日期
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdUserId))
 {
objRow[conViewInfo.UpdUserId] = objViewInfoEN.UpdUserId; //修改用户Id
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.Memo))
 {
objRow[conViewInfo.Memo] = objViewInfoEN.Memo; //说明
 }
 if (objViewInfoEN.IsUpdated(conViewInfo.RegionNum))
 {
objRow[conViewInfo.RegionNum] = objViewInfoEN.RegionNum; //区域数
 }
try
{
objDA.Update(objDS, clsViewInfoEN._CurrTabName);
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewInfoEN objViewInfoEN)
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update ViewInfo Set ");
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewName))
 {
 if (objViewInfoEN.ViewName !=  null)
 {
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conViewInfo.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewName); //界面名称
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewInfoEN.ApplicationTypeId, conViewInfo.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FuncModuleAgcId))
 {
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conViewInfo.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DataBaseName))
 {
 if (objViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conViewInfo.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DataBaseName); //数据库名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForMainTab))
 {
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyForMainTab, conViewInfo.KeyForMainTab); //主表关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.KeyForMainTab); //主表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForDetailTab))
 {
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyForDetailTab, conViewInfo.KeyForDetailTab); //明细表关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.KeyForDetailTab); //明细表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsNeedSort == true?"1":"0", conViewInfo.IsNeedSort); //是否需要排序
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsNeedTransCode == true?"1":"0", conViewInfo.IsNeedTransCode); //是否需要转换代码
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSetExportFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsNeedSetExportFld == true?"1":"0", conViewInfo.IsNeedSetExportFld); //是否需要设置导出字段
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UserId))
 {
 if (objViewInfoEN.UserId !=  null)
 {
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conViewInfo.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.UserId); //用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.PrjId))
 {
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewInfo.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.PrjId); //工程Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewFunction))
 {
 if (objViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFunction, conViewInfo.ViewFunction); //界面功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewFunction); //界面功能
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewDetail))
 {
 if (objViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDetail, conViewInfo.ViewDetail); //界面说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewDetail); //界面说明
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DefaMenuName))
 {
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaMenuName, conViewInfo.DefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DefaMenuName); //缺省菜单名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabId))
 {
 if (objViewInfoEN.DetailTabId !=  null)
 {
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailTabId, conViewInfo.DetailTabId); //明细表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DetailTabId); //明细表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FileName))
 {
 if (objViewInfoEN.FileName !=  null)
 {
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conViewInfo.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.FileName); //文件名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FilePath))
 {
 if (objViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conViewInfo.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.FilePath); //文件路径
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabId))
 {
 if (objViewInfoEN.MainTabId !=  null)
 {
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMainTabId, conViewInfo.MainTabId); //主表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.MainTabId); //主表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewCnName))
 {
 if (objViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewCnName, conViewInfo.ViewCnName); //视图中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewCnName); //视图中文名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewGroupId))
 {
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewGroupId, conViewInfo.ViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewGroupId); //界面组ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InRelaTabId))
 {
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInRelaTabId, conViewInfo.InRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.InRelaTabId); //输入数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InSqlDsTypeId))
 {
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInSqlDsTypeId, conViewInfo.InSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.InSqlDsTypeId); //输入数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutRelaTabId))
 {
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutRelaTabId, conViewInfo.OutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.OutRelaTabId); //输出数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutSqlDsTypeId))
 {
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutSqlDsTypeId, conViewInfo.OutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.OutSqlDsTypeId); //输出数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabType))
 {
 if (objViewInfoEN.DetailTabType !=  null)
 {
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailTabType, conViewInfo.DetailTabType); //DetailTabType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DetailTabType); //DetailTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailViewId))
 {
 if (objViewInfoEN.DetailViewId !=  null)
 {
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailViewId, conViewInfo.DetailViewId); //DetailViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DetailViewId); //DetailViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabType))
 {
 if (objViewInfoEN.MainTabType !=  null)
 {
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMainTabType, conViewInfo.MainTabType); //MainTabType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.MainTabType); //MainTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainViewId))
 {
 if (objViewInfoEN.MainViewId !=  null)
 {
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMainViewId, conViewInfo.MainViewId); //MainViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.MainViewId); //MainViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.GeneCodeDate))
 {
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneCodeDate, conViewInfo.GeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.GeneCodeDate); //生成代码日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.TaskId))
 {
 if (objViewInfoEN.TaskId !=  null)
 {
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTaskId, conViewInfo.TaskId); //任务Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.TaskId); //任务Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyId4Test))
 {
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conViewInfo.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewMasterId))
 {
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewMasterId, conViewInfo.ViewMasterId); //界面母版Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewMasterId); //界面母版Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsShare))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsShare == true?"1":"0", conViewInfo.IsShare); //是否共享
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ErrMsg))
 {
 if (objViewInfoEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conViewInfo.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ErrMsg); //错误信息
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdDate))
 {
 if (objViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.UpdDate); //修改日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdUserId))
 {
 if (objViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conViewInfo.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.UpdUserId); //修改用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.Memo))
 {
 if (objViewInfoEN.Memo !=  null)
 {
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewInfo.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewId = '{0}'", objViewInfoEN.ViewId); 
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
 /// <param name = "objViewInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsViewInfoEN objViewInfoEN, string strCondition)
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewInfo Set ");
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewName))
 {
 if (objViewInfoEN.ViewName !=  null)
 {
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objViewInfoEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FuncModuleAgcId))
 {
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DataBaseName))
 {
 if (objViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForMainTab))
 {
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyForMainTab = '{0}',", strKeyForMainTab); //主表关键字
 }
 else
 {
 sbSQL.Append(" KeyForMainTab = null,"); //主表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForDetailTab))
 {
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyForDetailTab = '{0}',", strKeyForDetailTab); //明细表关键字
 }
 else
 {
 sbSQL.Append(" KeyForDetailTab = null,"); //明细表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSort))
 {
 sbSQL.AppendFormat(" IsNeedSort = '{0}',", objViewInfoEN.IsNeedSort == true?"1":"0"); //是否需要排序
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" IsNeedTransCode = '{0}',", objViewInfoEN.IsNeedTransCode == true?"1":"0"); //是否需要转换代码
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSetExportFld))
 {
 sbSQL.AppendFormat(" IsNeedSetExportFld = '{0}',", objViewInfoEN.IsNeedSetExportFld == true?"1":"0"); //是否需要设置导出字段
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UserId))
 {
 if (objViewInfoEN.UserId !=  null)
 {
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.PrjId))
 {
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewFunction))
 {
 if (objViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFunction = '{0}',", strViewFunction); //界面功能
 }
 else
 {
 sbSQL.Append(" ViewFunction = null,"); //界面功能
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewDetail))
 {
 if (objViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDetail = '{0}',", strViewDetail); //界面说明
 }
 else
 {
 sbSQL.Append(" ViewDetail = null,"); //界面说明
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DefaMenuName))
 {
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaMenuName = '{0}',", strDefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.Append(" DefaMenuName = null,"); //缺省菜单名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabId))
 {
 if (objViewInfoEN.DetailTabId !=  null)
 {
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailTabId = '{0}',", strDetailTabId); //明细表ID
 }
 else
 {
 sbSQL.Append(" DetailTabId = null,"); //明细表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FileName))
 {
 if (objViewInfoEN.FileName !=  null)
 {
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FilePath))
 {
 if (objViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabId))
 {
 if (objViewInfoEN.MainTabId !=  null)
 {
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MainTabId = '{0}',", strMainTabId); //主表ID
 }
 else
 {
 sbSQL.Append(" MainTabId = null,"); //主表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewCnName))
 {
 if (objViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewCnName = '{0}',", strViewCnName); //视图中文名
 }
 else
 {
 sbSQL.Append(" ViewCnName = null,"); //视图中文名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewGroupId))
 {
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewGroupId = '{0}',", strViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.Append(" ViewGroupId = null,"); //界面组ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InRelaTabId))
 {
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InRelaTabId = '{0}',", strInRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.Append(" InRelaTabId = null,"); //输入数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InSqlDsTypeId))
 {
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InSqlDsTypeId = '{0}',", strInSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.Append(" InSqlDsTypeId = null,"); //输入数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutRelaTabId))
 {
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutRelaTabId = '{0}',", strOutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.Append(" OutRelaTabId = null,"); //输出数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutSqlDsTypeId))
 {
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutSqlDsTypeId = '{0}',", strOutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.Append(" OutSqlDsTypeId = null,"); //输出数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabType))
 {
 if (objViewInfoEN.DetailTabType !=  null)
 {
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailTabType = '{0}',", strDetailTabType); //DetailTabType
 }
 else
 {
 sbSQL.Append(" DetailTabType = null,"); //DetailTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailViewId))
 {
 if (objViewInfoEN.DetailViewId !=  null)
 {
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailViewId = '{0}',", strDetailViewId); //DetailViewId
 }
 else
 {
 sbSQL.Append(" DetailViewId = null,"); //DetailViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabType))
 {
 if (objViewInfoEN.MainTabType !=  null)
 {
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MainTabType = '{0}',", strMainTabType); //MainTabType
 }
 else
 {
 sbSQL.Append(" MainTabType = null,"); //MainTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainViewId))
 {
 if (objViewInfoEN.MainViewId !=  null)
 {
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MainViewId = '{0}',", strMainViewId); //MainViewId
 }
 else
 {
 sbSQL.Append(" MainViewId = null,"); //MainViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.GeneCodeDate))
 {
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneCodeDate = '{0}',", strGeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.Append(" GeneCodeDate = null,"); //生成代码日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.TaskId))
 {
 if (objViewInfoEN.TaskId !=  null)
 {
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TaskId = '{0}',", strTaskId); //任务Id
 }
 else
 {
 sbSQL.Append(" TaskId = null,"); //任务Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyId4Test))
 {
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewMasterId))
 {
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewMasterId = '{0}',", strViewMasterId); //界面母版Id
 }
 else
 {
 sbSQL.Append(" ViewMasterId = null,"); //界面母版Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsShare))
 {
 sbSQL.AppendFormat(" IsShare = '{0}',", objViewInfoEN.IsShare == true?"1":"0"); //是否共享
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ErrMsg))
 {
 if (objViewInfoEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdDate))
 {
 if (objViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdUserId))
 {
 if (objViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.Memo))
 {
 if (objViewInfoEN.Memo !=  null)
 {
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewInfoEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsViewInfoEN objViewInfoEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewInfo Set ");
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewName))
 {
 if (objViewInfoEN.ViewName !=  null)
 {
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewName = '{0}',", strViewName); //界面名称
 }
 else
 {
 sbSQL.Append(" ViewName = null,"); //界面名称
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ApplicationTypeId))
 {
 sbSQL.AppendFormat(" ApplicationTypeId = {0},", objViewInfoEN.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FuncModuleAgcId))
 {
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncModuleAgcId = '{0}',", strFuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.Append(" FuncModuleAgcId = null,"); //功能模块Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DataBaseName))
 {
 if (objViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataBaseName = '{0}',", strDataBaseName); //数据库名
 }
 else
 {
 sbSQL.Append(" DataBaseName = null,"); //数据库名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForMainTab))
 {
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyForMainTab = '{0}',", strKeyForMainTab); //主表关键字
 }
 else
 {
 sbSQL.Append(" KeyForMainTab = null,"); //主表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForDetailTab))
 {
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyForDetailTab = '{0}',", strKeyForDetailTab); //明细表关键字
 }
 else
 {
 sbSQL.Append(" KeyForDetailTab = null,"); //明细表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSort))
 {
 sbSQL.AppendFormat(" IsNeedSort = '{0}',", objViewInfoEN.IsNeedSort == true?"1":"0"); //是否需要排序
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" IsNeedTransCode = '{0}',", objViewInfoEN.IsNeedTransCode == true?"1":"0"); //是否需要转换代码
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSetExportFld))
 {
 sbSQL.AppendFormat(" IsNeedSetExportFld = '{0}',", objViewInfoEN.IsNeedSetExportFld == true?"1":"0"); //是否需要设置导出字段
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UserId))
 {
 if (objViewInfoEN.UserId !=  null)
 {
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.PrjId))
 {
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewFunction))
 {
 if (objViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewFunction = '{0}',", strViewFunction); //界面功能
 }
 else
 {
 sbSQL.Append(" ViewFunction = null,"); //界面功能
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewDetail))
 {
 if (objViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewDetail = '{0}',", strViewDetail); //界面说明
 }
 else
 {
 sbSQL.Append(" ViewDetail = null,"); //界面说明
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DefaMenuName))
 {
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DefaMenuName = '{0}',", strDefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.Append(" DefaMenuName = null,"); //缺省菜单名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabId))
 {
 if (objViewInfoEN.DetailTabId !=  null)
 {
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailTabId = '{0}',", strDetailTabId); //明细表ID
 }
 else
 {
 sbSQL.Append(" DetailTabId = null,"); //明细表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FileName))
 {
 if (objViewInfoEN.FileName !=  null)
 {
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FileName = '{0}',", strFileName); //文件名
 }
 else
 {
 sbSQL.Append(" FileName = null,"); //文件名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FilePath))
 {
 if (objViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FilePath = '{0}',", strFilePath); //文件路径
 }
 else
 {
 sbSQL.Append(" FilePath = null,"); //文件路径
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabId))
 {
 if (objViewInfoEN.MainTabId !=  null)
 {
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MainTabId = '{0}',", strMainTabId); //主表ID
 }
 else
 {
 sbSQL.Append(" MainTabId = null,"); //主表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewCnName))
 {
 if (objViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewCnName = '{0}',", strViewCnName); //视图中文名
 }
 else
 {
 sbSQL.Append(" ViewCnName = null,"); //视图中文名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewGroupId))
 {
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewGroupId = '{0}',", strViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.Append(" ViewGroupId = null,"); //界面组ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InRelaTabId))
 {
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InRelaTabId = '{0}',", strInRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.Append(" InRelaTabId = null,"); //输入数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InSqlDsTypeId))
 {
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InSqlDsTypeId = '{0}',", strInSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.Append(" InSqlDsTypeId = null,"); //输入数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutRelaTabId))
 {
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutRelaTabId = '{0}',", strOutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.Append(" OutRelaTabId = null,"); //输出数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutSqlDsTypeId))
 {
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OutSqlDsTypeId = '{0}',", strOutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.Append(" OutSqlDsTypeId = null,"); //输出数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabType))
 {
 if (objViewInfoEN.DetailTabType !=  null)
 {
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailTabType = '{0}',", strDetailTabType); //DetailTabType
 }
 else
 {
 sbSQL.Append(" DetailTabType = null,"); //DetailTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailViewId))
 {
 if (objViewInfoEN.DetailViewId !=  null)
 {
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DetailViewId = '{0}',", strDetailViewId); //DetailViewId
 }
 else
 {
 sbSQL.Append(" DetailViewId = null,"); //DetailViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabType))
 {
 if (objViewInfoEN.MainTabType !=  null)
 {
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MainTabType = '{0}',", strMainTabType); //MainTabType
 }
 else
 {
 sbSQL.Append(" MainTabType = null,"); //MainTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainViewId))
 {
 if (objViewInfoEN.MainViewId !=  null)
 {
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" MainViewId = '{0}',", strMainViewId); //MainViewId
 }
 else
 {
 sbSQL.Append(" MainViewId = null,"); //MainViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.GeneCodeDate))
 {
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" GeneCodeDate = '{0}',", strGeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.Append(" GeneCodeDate = null,"); //生成代码日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.TaskId))
 {
 if (objViewInfoEN.TaskId !=  null)
 {
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TaskId = '{0}',", strTaskId); //任务Id
 }
 else
 {
 sbSQL.Append(" TaskId = null,"); //任务Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyId4Test))
 {
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyId4Test = '{0}',", strKeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.Append(" KeyId4Test = null,"); //测试关键字Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewMasterId))
 {
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ViewMasterId = '{0}',", strViewMasterId); //界面母版Id
 }
 else
 {
 sbSQL.Append(" ViewMasterId = null,"); //界面母版Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsShare))
 {
 sbSQL.AppendFormat(" IsShare = '{0}',", objViewInfoEN.IsShare == true?"1":"0"); //是否共享
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ErrMsg))
 {
 if (objViewInfoEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdDate))
 {
 if (objViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdUserId))
 {
 if (objViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.Memo))
 {
 if (objViewInfoEN.Memo !=  null)
 {
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objViewInfoEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsViewInfoEN objViewInfoEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objViewInfoEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objViewInfoEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objViewInfoEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update ViewInfo Set ");
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewName))
 {
 if (objViewInfoEN.ViewName !=  null)
 {
 var strViewName = objViewInfoEN.ViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewName, conViewInfo.ViewName); //界面名称
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewName); //界面名称
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ApplicationTypeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objViewInfoEN.ApplicationTypeId, conViewInfo.ApplicationTypeId); //应用程序类型ID
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FuncModuleAgcId))
 {
 if (objViewInfoEN.FuncModuleAgcId  ==  "")
 {
 objViewInfoEN.FuncModuleAgcId = null;
 }
 if (objViewInfoEN.FuncModuleAgcId !=  null)
 {
 var strFuncModuleAgcId = objViewInfoEN.FuncModuleAgcId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncModuleAgcId, conViewInfo.FuncModuleAgcId); //功能模块Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.FuncModuleAgcId); //功能模块Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DataBaseName))
 {
 if (objViewInfoEN.DataBaseName !=  null)
 {
 var strDataBaseName = objViewInfoEN.DataBaseName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataBaseName, conViewInfo.DataBaseName); //数据库名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DataBaseName); //数据库名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForMainTab))
 {
 if (objViewInfoEN.KeyForMainTab !=  null)
 {
 var strKeyForMainTab = objViewInfoEN.KeyForMainTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyForMainTab, conViewInfo.KeyForMainTab); //主表关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.KeyForMainTab); //主表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyForDetailTab))
 {
 if (objViewInfoEN.KeyForDetailTab !=  null)
 {
 var strKeyForDetailTab = objViewInfoEN.KeyForDetailTab.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyForDetailTab, conViewInfo.KeyForDetailTab); //明细表关键字
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.KeyForDetailTab); //明细表关键字
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSort))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsNeedSort == true?"1":"0", conViewInfo.IsNeedSort); //是否需要排序
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedTransCode))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsNeedTransCode == true?"1":"0", conViewInfo.IsNeedTransCode); //是否需要转换代码
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsNeedSetExportFld))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsNeedSetExportFld == true?"1":"0", conViewInfo.IsNeedSetExportFld); //是否需要设置导出字段
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UserId))
 {
 if (objViewInfoEN.UserId !=  null)
 {
 var strUserId = objViewInfoEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conViewInfo.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.UserId); //用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.PrjId))
 {
 if (objViewInfoEN.PrjId  ==  "")
 {
 objViewInfoEN.PrjId = null;
 }
 if (objViewInfoEN.PrjId !=  null)
 {
 var strPrjId = objViewInfoEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conViewInfo.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.PrjId); //工程Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewFunction))
 {
 if (objViewInfoEN.ViewFunction !=  null)
 {
 var strViewFunction = objViewInfoEN.ViewFunction.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewFunction, conViewInfo.ViewFunction); //界面功能
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewFunction); //界面功能
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewDetail))
 {
 if (objViewInfoEN.ViewDetail !=  null)
 {
 var strViewDetail = objViewInfoEN.ViewDetail.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewDetail, conViewInfo.ViewDetail); //界面说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewDetail); //界面说明
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DefaMenuName))
 {
 if (objViewInfoEN.DefaMenuName !=  null)
 {
 var strDefaMenuName = objViewInfoEN.DefaMenuName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDefaMenuName, conViewInfo.DefaMenuName); //缺省菜单名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DefaMenuName); //缺省菜单名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabId))
 {
 if (objViewInfoEN.DetailTabId !=  null)
 {
 var strDetailTabId = objViewInfoEN.DetailTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailTabId, conViewInfo.DetailTabId); //明细表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DetailTabId); //明细表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FileName))
 {
 if (objViewInfoEN.FileName !=  null)
 {
 var strFileName = objViewInfoEN.FileName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFileName, conViewInfo.FileName); //文件名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.FileName); //文件名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.FilePath))
 {
 if (objViewInfoEN.FilePath !=  null)
 {
 var strFilePath = objViewInfoEN.FilePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFilePath, conViewInfo.FilePath); //文件路径
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.FilePath); //文件路径
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabId))
 {
 if (objViewInfoEN.MainTabId !=  null)
 {
 var strMainTabId = objViewInfoEN.MainTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMainTabId, conViewInfo.MainTabId); //主表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.MainTabId); //主表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewCnName))
 {
 if (objViewInfoEN.ViewCnName !=  null)
 {
 var strViewCnName = objViewInfoEN.ViewCnName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewCnName, conViewInfo.ViewCnName); //视图中文名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewCnName); //视图中文名
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewGroupId))
 {
 if (objViewInfoEN.ViewGroupId !=  null)
 {
 var strViewGroupId = objViewInfoEN.ViewGroupId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewGroupId, conViewInfo.ViewGroupId); //界面组ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewGroupId); //界面组ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InRelaTabId))
 {
 if (objViewInfoEN.InRelaTabId !=  null)
 {
 var strInRelaTabId = objViewInfoEN.InRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInRelaTabId, conViewInfo.InRelaTabId); //输入数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.InRelaTabId); //输入数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.InSqlDsTypeId))
 {
 if (objViewInfoEN.InSqlDsTypeId !=  null)
 {
 var strInSqlDsTypeId = objViewInfoEN.InSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInSqlDsTypeId, conViewInfo.InSqlDsTypeId); //输入数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.InSqlDsTypeId); //输入数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutRelaTabId))
 {
 if (objViewInfoEN.OutRelaTabId !=  null)
 {
 var strOutRelaTabId = objViewInfoEN.OutRelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutRelaTabId, conViewInfo.OutRelaTabId); //输出数据源表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.OutRelaTabId); //输出数据源表ID
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.OutSqlDsTypeId))
 {
 if (objViewInfoEN.OutSqlDsTypeId !=  null)
 {
 var strOutSqlDsTypeId = objViewInfoEN.OutSqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOutSqlDsTypeId, conViewInfo.OutSqlDsTypeId); //输出数据源类型
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.OutSqlDsTypeId); //输出数据源类型
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailTabType))
 {
 if (objViewInfoEN.DetailTabType !=  null)
 {
 var strDetailTabType = objViewInfoEN.DetailTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailTabType, conViewInfo.DetailTabType); //DetailTabType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DetailTabType); //DetailTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.DetailViewId))
 {
 if (objViewInfoEN.DetailViewId !=  null)
 {
 var strDetailViewId = objViewInfoEN.DetailViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDetailViewId, conViewInfo.DetailViewId); //DetailViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.DetailViewId); //DetailViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainTabType))
 {
 if (objViewInfoEN.MainTabType !=  null)
 {
 var strMainTabType = objViewInfoEN.MainTabType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMainTabType, conViewInfo.MainTabType); //MainTabType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.MainTabType); //MainTabType
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.MainViewId))
 {
 if (objViewInfoEN.MainViewId !=  null)
 {
 var strMainViewId = objViewInfoEN.MainViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMainViewId, conViewInfo.MainViewId); //MainViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.MainViewId); //MainViewId
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.GeneCodeDate))
 {
 if (objViewInfoEN.GeneCodeDate !=  null)
 {
 var strGeneCodeDate = objViewInfoEN.GeneCodeDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strGeneCodeDate, conViewInfo.GeneCodeDate); //生成代码日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.GeneCodeDate); //生成代码日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.TaskId))
 {
 if (objViewInfoEN.TaskId !=  null)
 {
 var strTaskId = objViewInfoEN.TaskId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTaskId, conViewInfo.TaskId); //任务Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.TaskId); //任务Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.KeyId4Test))
 {
 if (objViewInfoEN.KeyId4Test !=  null)
 {
 var strKeyId4Test = objViewInfoEN.KeyId4Test.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyId4Test, conViewInfo.KeyId4Test); //测试关键字Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.KeyId4Test); //测试关键字Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ViewMasterId))
 {
 if (objViewInfoEN.ViewMasterId !=  null)
 {
 var strViewMasterId = objViewInfoEN.ViewMasterId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strViewMasterId, conViewInfo.ViewMasterId); //界面母版Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ViewMasterId); //界面母版Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.IsShare))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objViewInfoEN.IsShare == true?"1":"0", conViewInfo.IsShare); //是否共享
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.ErrMsg))
 {
 if (objViewInfoEN.ErrMsg !=  null)
 {
 var strErrMsg = objViewInfoEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conViewInfo.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.ErrMsg); //错误信息
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdDate))
 {
 if (objViewInfoEN.UpdDate !=  null)
 {
 var strUpdDate = objViewInfoEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conViewInfo.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.UpdDate); //修改日期
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.UpdUserId))
 {
 if (objViewInfoEN.UpdUserId !=  null)
 {
 var strUpdUserId = objViewInfoEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conViewInfo.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.UpdUserId); //修改用户Id
 }
 }
 
 if (objViewInfoEN.IsUpdated(conViewInfo.Memo))
 {
 if (objViewInfoEN.Memo !=  null)
 {
 var strMemo = objViewInfoEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conViewInfo.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conViewInfo.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where ViewId = '{0}'", objViewInfoEN.ViewId); 
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
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strViewId) 
{
CheckPrimaryKey(strViewId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strViewId,
};
 objSQL.ExecSP("ViewInfo_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strViewId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strViewId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
//删除ViewInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewInfo where ViewId = " + "'"+ strViewId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelViewInfo(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
//删除ViewInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewInfo where ViewId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strViewId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strViewId) 
{
CheckPrimaryKey(strViewId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
//删除ViewInfo本表中与当前对象有关的记录
strSQL = strSQL + "Delete from ViewInfo where ViewId = " + "'"+ strViewId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelViewInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsViewInfoDA: DelViewInfo)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewInfo where " + strCondition ;
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
public bool DelViewInfoWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsViewInfoDA: DelViewInfoWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsViewInfoDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from ViewInfo where " + strCondition ;
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
 /// <param name = "objViewInfoENS">源对象</param>
 /// <param name = "objViewInfoENT">目标对象</param>
public void CopyTo(clsViewInfoEN objViewInfoENS, clsViewInfoEN objViewInfoENT)
{
objViewInfoENT.ViewId = objViewInfoENS.ViewId; //界面Id
objViewInfoENT.ViewName = objViewInfoENS.ViewName; //界面名称
objViewInfoENT.ApplicationTypeId = objViewInfoENS.ApplicationTypeId; //应用程序类型ID
objViewInfoENT.FuncModuleAgcId = objViewInfoENS.FuncModuleAgcId; //功能模块Id
objViewInfoENT.DataBaseName = objViewInfoENS.DataBaseName; //数据库名
objViewInfoENT.KeyForMainTab = objViewInfoENS.KeyForMainTab; //主表关键字
objViewInfoENT.KeyForDetailTab = objViewInfoENS.KeyForDetailTab; //明细表关键字
objViewInfoENT.IsNeedSort = objViewInfoENS.IsNeedSort; //是否需要排序
objViewInfoENT.IsNeedTransCode = objViewInfoENS.IsNeedTransCode; //是否需要转换代码
objViewInfoENT.IsNeedSetExportFld = objViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objViewInfoENT.UserId = objViewInfoENS.UserId; //用户Id
objViewInfoENT.PrjId = objViewInfoENS.PrjId; //工程Id
objViewInfoENT.ViewFunction = objViewInfoENS.ViewFunction; //界面功能
objViewInfoENT.ViewDetail = objViewInfoENS.ViewDetail; //界面说明
objViewInfoENT.DefaMenuName = objViewInfoENS.DefaMenuName; //缺省菜单名
objViewInfoENT.DetailTabId = objViewInfoENS.DetailTabId; //明细表ID
objViewInfoENT.FileName = objViewInfoENS.FileName; //文件名
objViewInfoENT.FilePath = objViewInfoENS.FilePath; //文件路径
objViewInfoENT.MainTabId = objViewInfoENS.MainTabId; //主表ID
objViewInfoENT.ViewCnName = objViewInfoENS.ViewCnName; //视图中文名
objViewInfoENT.ViewGroupId = objViewInfoENS.ViewGroupId; //界面组ID
objViewInfoENT.InRelaTabId = objViewInfoENS.InRelaTabId; //输入数据源表ID
objViewInfoENT.InSqlDsTypeId = objViewInfoENS.InSqlDsTypeId; //输入数据源类型
objViewInfoENT.OutRelaTabId = objViewInfoENS.OutRelaTabId; //输出数据源表ID
objViewInfoENT.OutSqlDsTypeId = objViewInfoENS.OutSqlDsTypeId; //输出数据源类型
objViewInfoENT.DetailTabType = objViewInfoENS.DetailTabType; //DetailTabType
objViewInfoENT.DetailViewId = objViewInfoENS.DetailViewId; //DetailViewId
objViewInfoENT.MainTabType = objViewInfoENS.MainTabType; //MainTabType
objViewInfoENT.MainViewId = objViewInfoENS.MainViewId; //MainViewId
objViewInfoENT.GeneCodeDate = objViewInfoENS.GeneCodeDate; //生成代码日期
objViewInfoENT.TaskId = objViewInfoENS.TaskId; //任务Id
objViewInfoENT.KeyId4Test = objViewInfoENS.KeyId4Test; //测试关键字Id
objViewInfoENT.ViewMasterId = objViewInfoENS.ViewMasterId; //界面母版Id
objViewInfoENT.IsShare = objViewInfoENS.IsShare; //是否共享
objViewInfoENT.ErrMsg = objViewInfoENS.ErrMsg; //错误信息
objViewInfoENT.UpdDate = objViewInfoENS.UpdDate; //修改日期
objViewInfoENT.UpdUserId = objViewInfoENS.UpdUserId; //修改用户Id
objViewInfoENT.Memo = objViewInfoENS.Memo; //说明
objViewInfoENT.RegionNum = objViewInfoENS.RegionNum; //区域数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsViewInfoEN objViewInfoEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objViewInfoEN.ViewName, conViewInfo.ViewName);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.ApplicationTypeId, conViewInfo.ApplicationTypeId);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.IsNeedSort, conViewInfo.IsNeedSort);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.IsNeedTransCode, conViewInfo.IsNeedTransCode);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.IsNeedSetExportFld, conViewInfo.IsNeedSetExportFld);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.UserId, conViewInfo.UserId);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.PrjId, conViewInfo.PrjId);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.DefaMenuName, conViewInfo.DefaMenuName);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.FileName, conViewInfo.FileName);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.FilePath, conViewInfo.FilePath);
clsCheckSql.CheckFieldNotNull(objViewInfoEN.ViewCnName, conViewInfo.ViewCnName);
//检查字段长度
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewId, 8, conViewInfo.ViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewName, 100, conViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objViewInfoEN.FuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objViewInfoEN.DataBaseName, 50, conViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyForMainTab, 50, conViewInfo.KeyForMainTab);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyForDetailTab, 50, conViewInfo.KeyForDetailTab);
clsCheckSql.CheckFieldLen(objViewInfoEN.UserId, 18, conViewInfo.UserId);
clsCheckSql.CheckFieldLen(objViewInfoEN.PrjId, 4, conViewInfo.PrjId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewFunction, 100, conViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewDetail, 1000, conViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objViewInfoEN.DefaMenuName, 100, conViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailTabId, 8, conViewInfo.DetailTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.FileName, 150, conViewInfo.FileName);
clsCheckSql.CheckFieldLen(objViewInfoEN.FilePath, 500, conViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainTabId, 8, conViewInfo.MainTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewCnName, 100, conViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewGroupId, 8, conViewInfo.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewInfoEN.InRelaTabId, 8, conViewInfo.InRelaTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.InSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewInfoEN.OutRelaTabId, 8, conViewInfo.OutRelaTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.OutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailTabType, 10, conViewInfo.DetailTabType);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailViewId, 8, conViewInfo.DetailViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainTabType, 10, conViewInfo.MainTabType);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainViewId, 8, conViewInfo.MainViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.GeneCodeDate, 20, conViewInfo.GeneCodeDate);
clsCheckSql.CheckFieldLen(objViewInfoEN.TaskId, 16, conViewInfo.TaskId);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyId4Test, 50, conViewInfo.KeyId4Test);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewMasterId, 8, conViewInfo.ViewMasterId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ErrMsg, 2000, conViewInfo.ErrMsg);
clsCheckSql.CheckFieldLen(objViewInfoEN.UpdDate, 20, conViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objViewInfoEN.UpdUserId, 20, conViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objViewInfoEN.Memo, 1000, conViewInfo.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objViewInfoEN.FuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(objViewInfoEN.PrjId, 4, conViewInfo.PrjId);
 objViewInfoEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsViewInfoEN objViewInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewName, 100, conViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objViewInfoEN.FuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objViewInfoEN.DataBaseName, 50, conViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyForMainTab, 50, conViewInfo.KeyForMainTab);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyForDetailTab, 50, conViewInfo.KeyForDetailTab);
clsCheckSql.CheckFieldLen(objViewInfoEN.UserId, 18, conViewInfo.UserId);
clsCheckSql.CheckFieldLen(objViewInfoEN.PrjId, 4, conViewInfo.PrjId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewFunction, 100, conViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewDetail, 1000, conViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objViewInfoEN.DefaMenuName, 100, conViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailTabId, 8, conViewInfo.DetailTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.FileName, 150, conViewInfo.FileName);
clsCheckSql.CheckFieldLen(objViewInfoEN.FilePath, 500, conViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainTabId, 8, conViewInfo.MainTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewCnName, 100, conViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewGroupId, 8, conViewInfo.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewInfoEN.InRelaTabId, 8, conViewInfo.InRelaTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.InSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewInfoEN.OutRelaTabId, 8, conViewInfo.OutRelaTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.OutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailTabType, 10, conViewInfo.DetailTabType);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailViewId, 8, conViewInfo.DetailViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainTabType, 10, conViewInfo.MainTabType);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainViewId, 8, conViewInfo.MainViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.GeneCodeDate, 20, conViewInfo.GeneCodeDate);
clsCheckSql.CheckFieldLen(objViewInfoEN.TaskId, 16, conViewInfo.TaskId);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyId4Test, 50, conViewInfo.KeyId4Test);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewMasterId, 8, conViewInfo.ViewMasterId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ErrMsg, 2000, conViewInfo.ErrMsg);
clsCheckSql.CheckFieldLen(objViewInfoEN.UpdDate, 20, conViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objViewInfoEN.UpdUserId, 20, conViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objViewInfoEN.Memo, 1000, conViewInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewInfoEN.FuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(objViewInfoEN.PrjId, 4, conViewInfo.PrjId);
 objViewInfoEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsViewInfoEN objViewInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewId, 8, conViewInfo.ViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewName, 100, conViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objViewInfoEN.FuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objViewInfoEN.DataBaseName, 50, conViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyForMainTab, 50, conViewInfo.KeyForMainTab);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyForDetailTab, 50, conViewInfo.KeyForDetailTab);
clsCheckSql.CheckFieldLen(objViewInfoEN.UserId, 18, conViewInfo.UserId);
clsCheckSql.CheckFieldLen(objViewInfoEN.PrjId, 4, conViewInfo.PrjId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewFunction, 100, conViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewDetail, 1000, conViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objViewInfoEN.DefaMenuName, 100, conViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailTabId, 8, conViewInfo.DetailTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.FileName, 150, conViewInfo.FileName);
clsCheckSql.CheckFieldLen(objViewInfoEN.FilePath, 500, conViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainTabId, 8, conViewInfo.MainTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewCnName, 100, conViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewGroupId, 8, conViewInfo.ViewGroupId);
clsCheckSql.CheckFieldLen(objViewInfoEN.InRelaTabId, 8, conViewInfo.InRelaTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.InSqlDsTypeId, 2, conViewInfo.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewInfoEN.OutRelaTabId, 8, conViewInfo.OutRelaTabId);
clsCheckSql.CheckFieldLen(objViewInfoEN.OutSqlDsTypeId, 2, conViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailTabType, 10, conViewInfo.DetailTabType);
clsCheckSql.CheckFieldLen(objViewInfoEN.DetailViewId, 8, conViewInfo.DetailViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainTabType, 10, conViewInfo.MainTabType);
clsCheckSql.CheckFieldLen(objViewInfoEN.MainViewId, 8, conViewInfo.MainViewId);
clsCheckSql.CheckFieldLen(objViewInfoEN.GeneCodeDate, 20, conViewInfo.GeneCodeDate);
clsCheckSql.CheckFieldLen(objViewInfoEN.TaskId, 16, conViewInfo.TaskId);
clsCheckSql.CheckFieldLen(objViewInfoEN.KeyId4Test, 50, conViewInfo.KeyId4Test);
clsCheckSql.CheckFieldLen(objViewInfoEN.ViewMasterId, 8, conViewInfo.ViewMasterId);
clsCheckSql.CheckFieldLen(objViewInfoEN.ErrMsg, 2000, conViewInfo.ErrMsg);
clsCheckSql.CheckFieldLen(objViewInfoEN.UpdDate, 20, conViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objViewInfoEN.UpdUserId, 20, conViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objViewInfoEN.Memo, 1000, conViewInfo.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewId, conViewInfo.ViewId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewName, conViewInfo.ViewName);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.FuncModuleAgcId, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.DataBaseName, conViewInfo.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.KeyForMainTab, conViewInfo.KeyForMainTab);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.KeyForDetailTab, conViewInfo.KeyForDetailTab);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.UserId, conViewInfo.UserId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.PrjId, conViewInfo.PrjId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewFunction, conViewInfo.ViewFunction);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewDetail, conViewInfo.ViewDetail);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.DefaMenuName, conViewInfo.DefaMenuName);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.DetailTabId, conViewInfo.DetailTabId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.FileName, conViewInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.FilePath, conViewInfo.FilePath);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.MainTabId, conViewInfo.MainTabId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewCnName, conViewInfo.ViewCnName);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewGroupId, conViewInfo.ViewGroupId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.InRelaTabId, conViewInfo.InRelaTabId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.InSqlDsTypeId, conViewInfo.InSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.OutRelaTabId, conViewInfo.OutRelaTabId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.OutSqlDsTypeId, conViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.DetailTabType, conViewInfo.DetailTabType);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.DetailViewId, conViewInfo.DetailViewId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.MainTabType, conViewInfo.MainTabType);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.MainViewId, conViewInfo.MainViewId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.GeneCodeDate, conViewInfo.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.TaskId, conViewInfo.TaskId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.KeyId4Test, conViewInfo.KeyId4Test);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ViewMasterId, conViewInfo.ViewMasterId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.ErrMsg, conViewInfo.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.UpdDate, conViewInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.UpdUserId, conViewInfo.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objViewInfoEN.Memo, conViewInfo.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objViewInfoEN.FuncModuleAgcId, 8, conViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldForeignKey(objViewInfoEN.PrjId, 4, conViewInfo.PrjId);
 objViewInfoEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetViewId()
{
//获取某学院所有专业信息
string strSQL = "select ViewId, ViewName from ViewInfo ";
 clsSpecSQLforSql mySql = clsViewInfoDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--ViewInfo(界面),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objViewInfoEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsViewInfoEN objViewInfoEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objViewInfoEN.PrjId);
 sbCondition.AppendFormat(" and ViewName = '{0}'", objViewInfoEN.ViewName);
 sbCondition.AppendFormat(" and ApplicationTypeId = '{0}'", objViewInfoEN.ApplicationTypeId);
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewInfoEN._CurrTabName);
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsViewInfoEN._CurrTabName, strCondition);
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}