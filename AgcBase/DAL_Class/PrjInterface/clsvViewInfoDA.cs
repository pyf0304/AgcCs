
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvViewInfoDA
 表名:vViewInfo(00050157)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:03
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
 /// v界面(vViewInfo)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvViewInfoDA : clsCommBase4DA
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
 return clsvViewInfoEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvViewInfoEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvViewInfoEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvViewInfoEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvViewInfoEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vViewInfo中,检查关键字,长度不正确!(clsvViewInfoDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strViewId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vViewInfo中,关键字不能为空 或 null!(clsvViewInfoDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strViewId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvViewInfoDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vViewInfo(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable_vViewInfo)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewInfo.* " + 
$"from vViewInfo " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewInfo.ViewId not in " + 
$"(Select top {intTop_In} vViewInfo.ViewId from vViewInfo " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1} and ViewId not in (Select top {2} ViewId from vViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1} and ViewId not in (Select top {3} ViewId from vViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvViewInfoDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vViewInfo.* " + 
$"from vViewInfo " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vViewInfo.ViewId not in " + 
$"(Select top {intTop_In} vViewInfo.ViewId from vViewInfo " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1} and ViewId not in (Select top {2} ViewId from vViewInfo where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vViewInfo where {1} and ViewId not in (Select top {3} ViewId from vViewInfo where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvViewInfoEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvViewInfoDA:GetObjLst)", objException.Message));
}
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = TransNullToBool(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewInfoDA: GetObjLst)", objException.Message));
}
objvViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewInfoEN);
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
public List<clsvViewInfoEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvViewInfoDA:GetObjLstByTabName)", objException.Message));
}
List<clsvViewInfoEN> arrObjLst = new List<clsvViewInfoEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = TransNullToBool(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvViewInfoDA: GetObjLst)", objException.Message));
}
objvViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvViewInfoEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvViewInfoEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvViewInfo(ref clsvViewInfoEN objvViewInfoEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where ViewId = " + "'"+ objvViewInfoEN.ViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvViewInfoEN.ViewId = objDT.Rows[0][convViewInfo.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewInfoEN.TitleStyleId = objDT.Rows[0][convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvViewInfoEN.TitleStyleName = objDT.Rows[0][convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvViewInfoEN.DgStyleId = objDT.Rows[0][convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvViewInfoEN.DgStyleName = objDT.Rows[0][convViewInfo.DgStyleName].ToString().Trim(); //DG模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.ViewName = objDT.Rows[0][convViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfoEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewInfoEN.ApplicationTypeSimName = objDT.Rows[0][convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewInfoEN.FuncModuleAgcId = objDT.Rows[0][convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfoEN.FuncModuleName = objDT.Rows[0][convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.FuncModuleEnName = objDT.Rows[0][convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewInfoEN.DataBaseName = objDT.Rows[0][convViewInfo.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewInfoEN.KeyForMainTab = objDT.Rows[0][convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.KeyForDetailTab = objDT.Rows[0][convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.IsNeedSort = TransNullToBool(objDT.Rows[0][convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfoEN.IsNeedTransCode = TransNullToBool(objDT.Rows[0][convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfoEN.IsNeedSetExportFld = TransNullToBool(objDT.Rows[0][convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfoEN.UserId = objDT.Rows[0][convViewInfo.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvViewInfoEN.PrjId = objDT.Rows[0][convViewInfo.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewInfoEN.PrjName = objDT.Rows[0][convViewInfo.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.ViewFunction = objDT.Rows[0][convViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfoEN.ViewDetail = objDT.Rows[0][convViewInfo.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewInfoEN.DefaMenuName = objDT.Rows[0][convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfoEN.DetailTabId = objDT.Rows[0][convViewInfo.DetailTabId].ToString().Trim(); //明细表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfoEN.FileName = objDT.Rows[0][convViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewInfoEN.FilePath = objDT.Rows[0][convViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewInfoEN.MainTabId = objDT.Rows[0][convViewInfo.MainTabId].ToString().Trim(); //主表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfoEN.ViewCnName = objDT.Rows[0][convViewInfo.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfoEN.ViewGroupId = objDT.Rows[0][convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfoEN.ViewGroupName = objDT.Rows[0][convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.InSqlDsTypeId = objDT.Rows[0][convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfoEN.OutSqlDsTypeId = objDT.Rows[0][convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfoEN.GeneCodeDate = objDT.Rows[0][convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfoEN.TaskId = objDT.Rows[0][convViewInfo.TaskId].ToString().Trim(); //任务Id(字段类型:char,字段长度:16,是否可空:True)
 objvViewInfoEN.KeyId4Test = objDT.Rows[0][convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.ViewMasterId = objDT.Rows[0][convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewInfoEN.ViewMasterName = objDT.Rows[0][convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.UpdDate = objDT.Rows[0][convViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfoEN.UpdUserId = objDT.Rows[0][convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfoEN.Memo = objDT.Rows[0][convViewInfo.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewInfoEN.MainTabName = objDT.Rows[0][convViewInfo.MainTabName].ToString().Trim(); //主表(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfoEN.DetailTabName = objDT.Rows[0][convViewInfo.DetailTabName].ToString().Trim(); //详细表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewInfoEN.MainTabKeyFld = objDT.Rows[0][convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.RegionNum = TransNullToInt(objDT.Rows[0][convViewInfo.RegionNum].ToString().Trim()); //区域数(字段类型:int,字段长度:4,是否可空:True)
 objvViewInfoEN.DetailTabKeyFld = objDT.Rows[0][convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvViewInfoDA: GetvViewInfo)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strViewId">表关键字</param>
 /// <returns>表对象</returns>
public clsvViewInfoEN GetObjByViewId(string strViewId)
{
CheckPrimaryKey(strViewId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where ViewId = " + "'"+ strViewId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
 objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id(字段类型:varchar,字段长度:8,是否可空:False)
 objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID(字段类型:varchar,字段长度:4,是否可空:False)
 objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfoEN.ApplicationTypeId = Int32.Parse(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称(字段类型:varchar,字段长度:30,是否可空:True)
 objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名(字段类型:varchar,字段长度:50,是否可空:False)
 objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.IsNeedSort = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfoEN.IsNeedTransCode = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfoEN.IsNeedSetExportFld = clsEntityBase2.TransNullToBool_S(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段(字段类型:bit,字段长度:1,是否可空:False)
 objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名(字段类型:varchar,字段长度:100,是否可空:False)
 objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名(字段类型:varchar,字段长度:150,是否可空:False)
 objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径(字段类型:varchar,字段长度:500,是否可空:False)
 objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID(字段类型:varchar,字段长度:8,是否可空:True)
 objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID(字段类型:char,字段长度:8,是否可空:False)
 objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型(字段类型:char,字段长度:2,是否可空:True)
 objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id(字段类型:char,字段长度:16,是否可空:True)
 objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id(字段类型:char,字段长度:8,是否可空:True)
 objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表(字段类型:varchar,字段长度:100,是否可空:True)
 objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表(字段类型:varchar,字段长度:40,是否可空:True)
 objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字(字段类型:varchar,字段长度:50,是否可空:True)
 objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数(字段类型:int,字段长度:4,是否可空:True)
 objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvViewInfoDA: GetObjByViewId)", objException.Message));
}
return objvViewInfoEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvViewInfoEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvViewInfoDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
strSQL = "Select * from vViewInfo where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN()
{
ViewId = objRow[convViewInfo.ViewId].ToString().Trim(), //界面Id
TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(), //标题类型Id
TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(), //标题类型名
DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(), //DG模式ID
DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(), //DG模式名
ViewName = objRow[convViewInfo.ViewName].ToString().Trim(), //界面名称
ApplicationTypeId = TransNullToInt(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(), //应用程序类型简称
FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(), //功能模块Id
FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(), //功能模块名称
FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(), //功能模块英文名称
DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(), //数据库名
KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(), //主表关键字
KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(), //明细表关键字
IsNeedSort = TransNullToBool(objRow[convViewInfo.IsNeedSort].ToString().Trim()), //是否需要排序
IsNeedTransCode = TransNullToBool(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()), //是否需要转换代码
IsNeedSetExportFld = TransNullToBool(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()), //是否需要设置导出字段
UserId = objRow[convViewInfo.UserId].ToString().Trim(), //用户Id
PrjId = objRow[convViewInfo.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convViewInfo.PrjName].ToString().Trim(), //工程名称
ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(), //界面功能
ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(), //界面说明
DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(), //缺省菜单名
DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(), //明细表ID
FileName = objRow[convViewInfo.FileName].ToString().Trim(), //文件名
FilePath = objRow[convViewInfo.FilePath].ToString().Trim(), //文件路径
MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(), //主表ID
ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(), //视图中文名
ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(), //界面组ID
ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(), //界面组名称
InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(), //输入数据源类型
OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(), //输出数据源类型
GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(), //生成代码日期
TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(), //任务Id
KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(), //测试关键字Id
ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(), //界面母版Id
ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(), //界面母版名
UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(), //说明
MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(), //主表
DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(), //详细表
MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(), //主表关键字
RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo.RegionNum].ToString().Trim()), //区域数
DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim() //详细表关键字
};
objvViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewInfoEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvViewInfoDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvViewInfoEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = TransNullToBool(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvViewInfoDA: GetObjByDataRowvViewInfo)", objException.Message));
}
objvViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewInfoEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvViewInfoEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvViewInfoEN objvViewInfoEN = new clsvViewInfoEN();
try
{
objvViewInfoEN.ViewId = objRow[convViewInfo.ViewId].ToString().Trim(); //界面Id
objvViewInfoEN.TitleStyleId = objRow[convViewInfo.TitleStyleId] == DBNull.Value ? null : objRow[convViewInfo.TitleStyleId].ToString().Trim(); //标题类型Id
objvViewInfoEN.TitleStyleName = objRow[convViewInfo.TitleStyleName].ToString().Trim(); //标题类型名
objvViewInfoEN.DgStyleId = objRow[convViewInfo.DgStyleId] == DBNull.Value ? null : objRow[convViewInfo.DgStyleId].ToString().Trim(); //DG模式ID
objvViewInfoEN.DgStyleName = objRow[convViewInfo.DgStyleName].ToString().Trim(); //DG模式名
objvViewInfoEN.ViewName = objRow[convViewInfo.ViewName].ToString().Trim(); //界面名称
objvViewInfoEN.ApplicationTypeId = TransNullToInt(objRow[convViewInfo.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvViewInfoEN.ApplicationTypeSimName = objRow[convViewInfo.ApplicationTypeSimName] == DBNull.Value ? null : objRow[convViewInfo.ApplicationTypeSimName].ToString().Trim(); //应用程序类型简称
objvViewInfoEN.FuncModuleAgcId = objRow[convViewInfo.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvViewInfoEN.FuncModuleName = objRow[convViewInfo.FuncModuleName].ToString().Trim(); //功能模块名称
objvViewInfoEN.FuncModuleEnName = objRow[convViewInfo.FuncModuleEnName] == DBNull.Value ? null : objRow[convViewInfo.FuncModuleEnName].ToString().Trim(); //功能模块英文名称
objvViewInfoEN.DataBaseName = objRow[convViewInfo.DataBaseName] == DBNull.Value ? null : objRow[convViewInfo.DataBaseName].ToString().Trim(); //数据库名
objvViewInfoEN.KeyForMainTab = objRow[convViewInfo.KeyForMainTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForMainTab].ToString().Trim(); //主表关键字
objvViewInfoEN.KeyForDetailTab = objRow[convViewInfo.KeyForDetailTab] == DBNull.Value ? null : objRow[convViewInfo.KeyForDetailTab].ToString().Trim(); //明细表关键字
objvViewInfoEN.IsNeedSort = TransNullToBool(objRow[convViewInfo.IsNeedSort].ToString().Trim()); //是否需要排序
objvViewInfoEN.IsNeedTransCode = TransNullToBool(objRow[convViewInfo.IsNeedTransCode].ToString().Trim()); //是否需要转换代码
objvViewInfoEN.IsNeedSetExportFld = TransNullToBool(objRow[convViewInfo.IsNeedSetExportFld].ToString().Trim()); //是否需要设置导出字段
objvViewInfoEN.UserId = objRow[convViewInfo.UserId].ToString().Trim(); //用户Id
objvViewInfoEN.PrjId = objRow[convViewInfo.PrjId].ToString().Trim(); //工程Id
objvViewInfoEN.PrjName = objRow[convViewInfo.PrjName].ToString().Trim(); //工程名称
objvViewInfoEN.ViewFunction = objRow[convViewInfo.ViewFunction] == DBNull.Value ? null : objRow[convViewInfo.ViewFunction].ToString().Trim(); //界面功能
objvViewInfoEN.ViewDetail = objRow[convViewInfo.ViewDetail] == DBNull.Value ? null : objRow[convViewInfo.ViewDetail].ToString().Trim(); //界面说明
objvViewInfoEN.DefaMenuName = objRow[convViewInfo.DefaMenuName].ToString().Trim(); //缺省菜单名
objvViewInfoEN.DetailTabId = objRow[convViewInfo.DetailTabId] == DBNull.Value ? null : objRow[convViewInfo.DetailTabId].ToString().Trim(); //明细表ID
objvViewInfoEN.FileName = objRow[convViewInfo.FileName].ToString().Trim(); //文件名
objvViewInfoEN.FilePath = objRow[convViewInfo.FilePath].ToString().Trim(); //文件路径
objvViewInfoEN.MainTabId = objRow[convViewInfo.MainTabId] == DBNull.Value ? null : objRow[convViewInfo.MainTabId].ToString().Trim(); //主表ID
objvViewInfoEN.ViewCnName = objRow[convViewInfo.ViewCnName] == DBNull.Value ? null : objRow[convViewInfo.ViewCnName].ToString().Trim(); //视图中文名
objvViewInfoEN.ViewGroupId = objRow[convViewInfo.ViewGroupId].ToString().Trim(); //界面组ID
objvViewInfoEN.ViewGroupName = objRow[convViewInfo.ViewGroupName].ToString().Trim(); //界面组名称
objvViewInfoEN.InSqlDsTypeId = objRow[convViewInfo.InSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.InSqlDsTypeId].ToString().Trim(); //输入数据源类型
objvViewInfoEN.OutSqlDsTypeId = objRow[convViewInfo.OutSqlDsTypeId] == DBNull.Value ? null : objRow[convViewInfo.OutSqlDsTypeId].ToString().Trim(); //输出数据源类型
objvViewInfoEN.GeneCodeDate = objRow[convViewInfo.GeneCodeDate] == DBNull.Value ? null : objRow[convViewInfo.GeneCodeDate].ToString().Trim(); //生成代码日期
objvViewInfoEN.TaskId = objRow[convViewInfo.TaskId] == DBNull.Value ? null : objRow[convViewInfo.TaskId].ToString().Trim(); //任务Id
objvViewInfoEN.KeyId4Test = objRow[convViewInfo.KeyId4Test] == DBNull.Value ? null : objRow[convViewInfo.KeyId4Test].ToString().Trim(); //测试关键字Id
objvViewInfoEN.ViewMasterId = objRow[convViewInfo.ViewMasterId] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterId].ToString().Trim(); //界面母版Id
objvViewInfoEN.ViewMasterName = objRow[convViewInfo.ViewMasterName] == DBNull.Value ? null : objRow[convViewInfo.ViewMasterName].ToString().Trim(); //界面母版名
objvViewInfoEN.UpdDate = objRow[convViewInfo.UpdDate] == DBNull.Value ? null : objRow[convViewInfo.UpdDate].ToString().Trim(); //修改日期
objvViewInfoEN.UpdUserId = objRow[convViewInfo.UpdUserId] == DBNull.Value ? null : objRow[convViewInfo.UpdUserId].ToString().Trim(); //修改用户Id
objvViewInfoEN.Memo = objRow[convViewInfo.Memo] == DBNull.Value ? null : objRow[convViewInfo.Memo].ToString().Trim(); //说明
objvViewInfoEN.MainTabName = objRow[convViewInfo.MainTabName] == DBNull.Value ? null : objRow[convViewInfo.MainTabName].ToString().Trim(); //主表
objvViewInfoEN.DetailTabName = objRow[convViewInfo.DetailTabName] == DBNull.Value ? null : objRow[convViewInfo.DetailTabName].ToString().Trim(); //详细表
objvViewInfoEN.MainTabKeyFld = objRow[convViewInfo.MainTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.MainTabKeyFld].ToString().Trim(); //主表关键字
objvViewInfoEN.RegionNum = objRow[convViewInfo.RegionNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convViewInfo.RegionNum].ToString().Trim()); //区域数
objvViewInfoEN.DetailTabKeyFld = objRow[convViewInfo.DetailTabKeyFld] == DBNull.Value ? null : objRow[convViewInfo.DetailTabKeyFld].ToString().Trim(); //详细表关键字
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvViewInfoDA: GetObjByDataRow)", objException.Message));
}
objvViewInfoEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvViewInfoEN;
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
objSQL = clsvViewInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewInfoEN._CurrTabName, convViewInfo.ViewId, 8, "");
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
objSQL = clsvViewInfoDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvViewInfoEN._CurrTabName, convViewInfo.ViewId, 8, strPrefix);
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select ViewId from vViewInfo where " + strCondition;
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select ViewId from vViewInfo where " + strCondition;
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewInfo", "ViewId = " + "'"+ strViewId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvViewInfoDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vViewInfo", strCondition))
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
objSQL = clsvViewInfoDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vViewInfo");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvViewInfoENS">源对象</param>
 /// <param name = "objvViewInfoENT">目标对象</param>
public void CopyTo(clsvViewInfoEN objvViewInfoENS, clsvViewInfoEN objvViewInfoENT)
{
objvViewInfoENT.ViewId = objvViewInfoENS.ViewId; //界面Id
objvViewInfoENT.TitleStyleId = objvViewInfoENS.TitleStyleId; //标题类型Id
objvViewInfoENT.TitleStyleName = objvViewInfoENS.TitleStyleName; //标题类型名
objvViewInfoENT.DgStyleId = objvViewInfoENS.DgStyleId; //DG模式ID
objvViewInfoENT.DgStyleName = objvViewInfoENS.DgStyleName; //DG模式名
objvViewInfoENT.ViewName = objvViewInfoENS.ViewName; //界面名称
objvViewInfoENT.ApplicationTypeId = objvViewInfoENS.ApplicationTypeId; //应用程序类型ID
objvViewInfoENT.ApplicationTypeSimName = objvViewInfoENS.ApplicationTypeSimName; //应用程序类型简称
objvViewInfoENT.FuncModuleAgcId = objvViewInfoENS.FuncModuleAgcId; //功能模块Id
objvViewInfoENT.FuncModuleName = objvViewInfoENS.FuncModuleName; //功能模块名称
objvViewInfoENT.FuncModuleEnName = objvViewInfoENS.FuncModuleEnName; //功能模块英文名称
objvViewInfoENT.DataBaseName = objvViewInfoENS.DataBaseName; //数据库名
objvViewInfoENT.KeyForMainTab = objvViewInfoENS.KeyForMainTab; //主表关键字
objvViewInfoENT.KeyForDetailTab = objvViewInfoENS.KeyForDetailTab; //明细表关键字
objvViewInfoENT.IsNeedSort = objvViewInfoENS.IsNeedSort; //是否需要排序
objvViewInfoENT.IsNeedTransCode = objvViewInfoENS.IsNeedTransCode; //是否需要转换代码
objvViewInfoENT.IsNeedSetExportFld = objvViewInfoENS.IsNeedSetExportFld; //是否需要设置导出字段
objvViewInfoENT.UserId = objvViewInfoENS.UserId; //用户Id
objvViewInfoENT.PrjId = objvViewInfoENS.PrjId; //工程Id
objvViewInfoENT.PrjName = objvViewInfoENS.PrjName; //工程名称
objvViewInfoENT.ViewFunction = objvViewInfoENS.ViewFunction; //界面功能
objvViewInfoENT.ViewDetail = objvViewInfoENS.ViewDetail; //界面说明
objvViewInfoENT.DefaMenuName = objvViewInfoENS.DefaMenuName; //缺省菜单名
objvViewInfoENT.DetailTabId = objvViewInfoENS.DetailTabId; //明细表ID
objvViewInfoENT.FileName = objvViewInfoENS.FileName; //文件名
objvViewInfoENT.FilePath = objvViewInfoENS.FilePath; //文件路径
objvViewInfoENT.MainTabId = objvViewInfoENS.MainTabId; //主表ID
objvViewInfoENT.ViewCnName = objvViewInfoENS.ViewCnName; //视图中文名
objvViewInfoENT.ViewGroupId = objvViewInfoENS.ViewGroupId; //界面组ID
objvViewInfoENT.ViewGroupName = objvViewInfoENS.ViewGroupName; //界面组名称
objvViewInfoENT.InSqlDsTypeId = objvViewInfoENS.InSqlDsTypeId; //输入数据源类型
objvViewInfoENT.OutSqlDsTypeId = objvViewInfoENS.OutSqlDsTypeId; //输出数据源类型
objvViewInfoENT.GeneCodeDate = objvViewInfoENS.GeneCodeDate; //生成代码日期
objvViewInfoENT.TaskId = objvViewInfoENS.TaskId; //任务Id
objvViewInfoENT.KeyId4Test = objvViewInfoENS.KeyId4Test; //测试关键字Id
objvViewInfoENT.ViewMasterId = objvViewInfoENS.ViewMasterId; //界面母版Id
objvViewInfoENT.ViewMasterName = objvViewInfoENS.ViewMasterName; //界面母版名
objvViewInfoENT.UpdDate = objvViewInfoENS.UpdDate; //修改日期
objvViewInfoENT.UpdUserId = objvViewInfoENS.UpdUserId; //修改用户Id
objvViewInfoENT.Memo = objvViewInfoENS.Memo; //说明
objvViewInfoENT.MainTabName = objvViewInfoENS.MainTabName; //主表
objvViewInfoENT.DetailTabName = objvViewInfoENS.DetailTabName; //详细表
objvViewInfoENT.MainTabKeyFld = objvViewInfoENS.MainTabKeyFld; //主表关键字
objvViewInfoENT.RegionNum = objvViewInfoENS.RegionNum; //区域数
objvViewInfoENT.DetailTabKeyFld = objvViewInfoENS.DetailTabKeyFld; //详细表关键字
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvViewInfoEN objvViewInfoEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewId, 8, convViewInfo.ViewId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.TitleStyleId, 8, convViewInfo.TitleStyleId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.TitleStyleName, 20, convViewInfo.TitleStyleName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DgStyleId, 4, convViewInfo.DgStyleId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DgStyleName, 30, convViewInfo.DgStyleName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewName, 100, convViewInfo.ViewName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ApplicationTypeSimName, 30, convViewInfo.ApplicationTypeSimName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.FuncModuleAgcId, 8, convViewInfo.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.FuncModuleName, 30, convViewInfo.FuncModuleName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.FuncModuleEnName, 30, convViewInfo.FuncModuleEnName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DataBaseName, 50, convViewInfo.DataBaseName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.KeyForMainTab, 50, convViewInfo.KeyForMainTab);
clsCheckSql.CheckFieldLen(objvViewInfoEN.KeyForDetailTab, 50, convViewInfo.KeyForDetailTab);
clsCheckSql.CheckFieldLen(objvViewInfoEN.UserId, 18, convViewInfo.UserId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.PrjId, 4, convViewInfo.PrjId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.PrjName, 30, convViewInfo.PrjName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewFunction, 100, convViewInfo.ViewFunction);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewDetail, 1000, convViewInfo.ViewDetail);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DefaMenuName, 100, convViewInfo.DefaMenuName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DetailTabId, 8, convViewInfo.DetailTabId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.FileName, 150, convViewInfo.FileName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.FilePath, 500, convViewInfo.FilePath);
clsCheckSql.CheckFieldLen(objvViewInfoEN.MainTabId, 8, convViewInfo.MainTabId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewCnName, 100, convViewInfo.ViewCnName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewGroupId, 8, convViewInfo.ViewGroupId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewGroupName, 30, convViewInfo.ViewGroupName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.InSqlDsTypeId, 2, convViewInfo.InSqlDsTypeId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.OutSqlDsTypeId, 2, convViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.GeneCodeDate, 20, convViewInfo.GeneCodeDate);
clsCheckSql.CheckFieldLen(objvViewInfoEN.TaskId, 16, convViewInfo.TaskId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.KeyId4Test, 50, convViewInfo.KeyId4Test);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewMasterId, 8, convViewInfo.ViewMasterId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.ViewMasterName, 50, convViewInfo.ViewMasterName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.UpdDate, 20, convViewInfo.UpdDate);
clsCheckSql.CheckFieldLen(objvViewInfoEN.UpdUserId, 20, convViewInfo.UpdUserId);
clsCheckSql.CheckFieldLen(objvViewInfoEN.Memo, 1000, convViewInfo.Memo);
clsCheckSql.CheckFieldLen(objvViewInfoEN.MainTabName, 100, convViewInfo.MainTabName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DetailTabName, 40, convViewInfo.DetailTabName);
clsCheckSql.CheckFieldLen(objvViewInfoEN.MainTabKeyFld, 50, convViewInfo.MainTabKeyFld);
clsCheckSql.CheckFieldLen(objvViewInfoEN.DetailTabKeyFld, 50, convViewInfo.DetailTabKeyFld);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewId, convViewInfo.ViewId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.TitleStyleId, convViewInfo.TitleStyleId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.TitleStyleName, convViewInfo.TitleStyleName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DgStyleId, convViewInfo.DgStyleId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DgStyleName, convViewInfo.DgStyleName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewName, convViewInfo.ViewName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ApplicationTypeSimName, convViewInfo.ApplicationTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.FuncModuleAgcId, convViewInfo.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.FuncModuleName, convViewInfo.FuncModuleName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.FuncModuleEnName, convViewInfo.FuncModuleEnName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DataBaseName, convViewInfo.DataBaseName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.KeyForMainTab, convViewInfo.KeyForMainTab);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.KeyForDetailTab, convViewInfo.KeyForDetailTab);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.UserId, convViewInfo.UserId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.PrjId, convViewInfo.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.PrjName, convViewInfo.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewFunction, convViewInfo.ViewFunction);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewDetail, convViewInfo.ViewDetail);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DefaMenuName, convViewInfo.DefaMenuName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DetailTabId, convViewInfo.DetailTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.FileName, convViewInfo.FileName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.FilePath, convViewInfo.FilePath);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.MainTabId, convViewInfo.MainTabId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewCnName, convViewInfo.ViewCnName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewGroupId, convViewInfo.ViewGroupId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewGroupName, convViewInfo.ViewGroupName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.InSqlDsTypeId, convViewInfo.InSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.OutSqlDsTypeId, convViewInfo.OutSqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.GeneCodeDate, convViewInfo.GeneCodeDate);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.TaskId, convViewInfo.TaskId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.KeyId4Test, convViewInfo.KeyId4Test);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewMasterId, convViewInfo.ViewMasterId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.ViewMasterName, convViewInfo.ViewMasterName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.UpdDate, convViewInfo.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.UpdUserId, convViewInfo.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.Memo, convViewInfo.Memo);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.MainTabName, convViewInfo.MainTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DetailTabName, convViewInfo.DetailTabName);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.MainTabKeyFld, convViewInfo.MainTabKeyFld);
clsCheckSql.CheckSqlInjection4Field(objvViewInfoEN.DetailTabKeyFld, convViewInfo.DetailTabKeyFld);
//检查外键字段长度
 objvViewInfoEN._IsCheckProperty = true;
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
string strSQL = "select ViewId, ViewName from vViewInfo ";
 clsSpecSQLforSql mySql = clsvViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewInfoEN._CurrTabName);
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvViewInfoEN._CurrTabName, strCondition);
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
 objSQL = clsvViewInfoDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}