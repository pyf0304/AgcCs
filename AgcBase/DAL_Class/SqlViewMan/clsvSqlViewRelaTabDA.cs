
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvSqlViewRelaTabDA
 表名:vSqlViewRelaTab(00050251)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:11:23
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
 /// vSql视图相关(vSqlViewRelaTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvSqlViewRelaTabDA : clsCommBase4DA
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
 return clsvSqlViewRelaTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvSqlViewRelaTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvSqlViewRelaTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvSqlViewRelaTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvSqlViewRelaTabEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strRelaTabId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strRelaTabId)
{
strRelaTabId = strRelaTabId.Replace("'", "''");
if (strRelaTabId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vSqlViewRelaTab中,检查关键字,长度不正确!(clsvSqlViewRelaTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRelaTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vSqlViewRelaTab中,关键字不能为空 或 null!(clsvSqlViewRelaTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelaTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvSqlViewRelaTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vSqlViewRelaTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable_vSqlViewRelaTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlViewRelaTab.* " + 
$"from vSqlViewRelaTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlViewRelaTab.RelaTabId not in " + 
$"(Select top {intTop_In} vSqlViewRelaTab.RelaTabId from vSqlViewRelaTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1} and RelaTabId not in (Select top {2} RelaTabId from vSqlViewRelaTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1} and RelaTabId not in (Select top {3} RelaTabId from vSqlViewRelaTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vSqlViewRelaTab.* " + 
$"from vSqlViewRelaTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vSqlViewRelaTab.RelaTabId not in " + 
$"(Select top {intTop_In} vSqlViewRelaTab.RelaTabId from vSqlViewRelaTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1} and RelaTabId not in (Select top {2} RelaTabId from vSqlViewRelaTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vSqlViewRelaTab where {1} and RelaTabId not in (Select top {3} RelaTabId from vSqlViewRelaTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvSqlViewRelaTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA:GetObjLst)", objException.Message));
}
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetObjLst)", objException.Message));
}
objvSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlViewRelaTabEN);
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
public List<clsvSqlViewRelaTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsvSqlViewRelaTabEN> arrObjLst = new List<clsvSqlViewRelaTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetObjLst)", objException.Message));
}
objvSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvSqlViewRelaTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvSqlViewRelaTab(ref clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where RelaTabId = " + "'"+ objvSqlViewRelaTabEN.RelaTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvSqlViewRelaTabEN.RelaTabId = objDT.Rows[0][convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewRelaTabEN.SqlViewId = objDT.Rows[0][convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewRelaTabEN.SqlViewCNName = objDT.Rows[0][convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.SqlViewName = objDT.Rows[0][convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewRelaTabEN.TabId = objDT.Rows[0][convSqlViewRelaTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewRelaTabEN.TabName = objDT.Rows[0][convSqlViewRelaTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewRelaTabEN.TabCnName = objDT.Rows[0][convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.TabAliases = objDT.Rows[0][convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewRelaTabEN.SvRelaTabTypeName = objDT.Rows[0][convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewRelaTabEN.SvRelaTabTypeId = objDT.Rows[0][convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewRelaTabEN.TabRelationTypeId = objDT.Rows[0][convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewRelaTabEN.TabRelationTypeName = objDT.Rows[0][convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewRelaTabEN.TabRelationText = objDT.Rows[0][convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewRelaTabEN.OrderNum = TransNullToInt(objDT.Rows[0][convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvSqlViewRelaTabEN.OtherFldCnName = objDT.Rows[0][convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.OtherFldName = objDT.Rows[0][convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewRelaTabEN.OtherTabName = objDT.Rows[0][convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewRelaTabEN.RelaFldCnName = objDT.Rows[0][convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.RelaFldName = objDT.Rows[0][convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewRelaTabEN.RelaFldId = objDT.Rows[0][convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段(字段类型:char,字段长度:8,是否可空:True)
 objvSqlViewRelaTabEN.OtherFldId = objDT.Rows[0][convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段(字段类型:char,字段长度:8,是否可空:True)
 objvSqlViewRelaTabEN.OtherTabId = objDT.Rows[0][convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id(字段类型:char,字段长度:8,是否可空:True)
 objvSqlViewRelaTabEN.PrjId = objDT.Rows[0][convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlViewRelaTabEN.UpdDate = objDT.Rows[0][convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewRelaTabEN.UpdUserId = objDT.Rows[0][convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewRelaTabEN.Memo = objDT.Rows[0][convSqlViewRelaTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlViewRelaTabEN.RelaTabId4SqlView = objDT.Rows[0][convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetvSqlViewRelaTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsvSqlViewRelaTabEN GetObjByRelaTabId(string strRelaTabId)
{
CheckPrimaryKey(strRelaTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where RelaTabId = " + "'"+ strRelaTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
 objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本(字段类型:varchar,字段长度:500,是否可空:True)
 objvSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名(字段类型:varchar,字段长度:100,是否可空:True)
 objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名(字段类型:varchar,字段长度:200,是否可空:True)
 objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名(字段类型:varchar,字段长度:50,是否可空:True)
 objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段(字段类型:char,字段长度:8,是否可空:True)
 objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段(字段类型:char,字段长度:8,是否可空:True)
 objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id(字段类型:char,字段长度:8,是否可空:True)
 objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView(字段类型:char,字段长度:8,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetObjByRelaTabId)", objException.Message));
}
return objvSqlViewRelaTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvSqlViewRelaTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from vSqlViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN()
{
RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(), //相关表Id
SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(), //Sql视图Id
SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(), //Sql视图中文名
SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(), //数据视图名称
TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(), //表ID
TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(), //表名
TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(), //表中文名
TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(), //表别名
SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(), //Sql视图相关表类型名
SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(), //Sql视图相关表类型Id
TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(), //表关系类型Id
TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(), //表关系类型名
TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(), //表关系文本
OrderNum = TransNullToInt(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()), //序号
OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(), //他表字段中文名
OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(), //他表字段名
OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(), //他表名
RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(), //关系字段中文名
RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(), //关系字段名
RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(), //关系字段
OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(), //其他表字段
OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(), //其他表Id
PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(), //说明
RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim() //RelaTabId4SqlView
};
objvSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewRelaTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvSqlViewRelaTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetObjByDataRowvSqlViewRelaTab)", objException.Message));
}
objvSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewRelaTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvSqlViewRelaTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvSqlViewRelaTabEN objvSqlViewRelaTabEN = new clsvSqlViewRelaTabEN();
try
{
objvSqlViewRelaTabEN.RelaTabId = objRow[convSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objvSqlViewRelaTabEN.SqlViewId = objRow[convSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objvSqlViewRelaTabEN.SqlViewCNName = objRow[convSqlViewRelaTab.SqlViewCNName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.SqlViewCNName].ToString().Trim(); //Sql视图中文名
objvSqlViewRelaTabEN.SqlViewName = objRow[convSqlViewRelaTab.SqlViewName].ToString().Trim(); //数据视图名称
objvSqlViewRelaTabEN.TabId = objRow[convSqlViewRelaTab.TabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objvSqlViewRelaTabEN.TabName = objRow[convSqlViewRelaTab.TabName].ToString().Trim(); //表名
objvSqlViewRelaTabEN.TabCnName = objRow[convSqlViewRelaTab.TabCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabCnName].ToString().Trim(); //表中文名
objvSqlViewRelaTabEN.TabAliases = objRow[convSqlViewRelaTab.TabAliases] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objvSqlViewRelaTabEN.SvRelaTabTypeName = objRow[convSqlViewRelaTab.SvRelaTabTypeName].ToString().Trim(); //Sql视图相关表类型名
objvSqlViewRelaTabEN.SvRelaTabTypeId = objRow[convSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objvSqlViewRelaTabEN.TabRelationTypeId = objRow[convSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objvSqlViewRelaTabEN.TabRelationTypeName = objRow[convSqlViewRelaTab.TabRelationTypeName].ToString().Trim(); //表关系类型名
objvSqlViewRelaTabEN.TabRelationText = objRow[convSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[convSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objvSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[convSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objvSqlViewRelaTabEN.OtherFldCnName = objRow[convSqlViewRelaTab.OtherFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldCnName].ToString().Trim(); //他表字段中文名
objvSqlViewRelaTabEN.OtherFldName = objRow[convSqlViewRelaTab.OtherFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldName].ToString().Trim(); //他表字段名
objvSqlViewRelaTabEN.OtherTabName = objRow[convSqlViewRelaTab.OtherTabName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabName].ToString().Trim(); //他表名
objvSqlViewRelaTabEN.RelaFldCnName = objRow[convSqlViewRelaTab.RelaFldCnName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldCnName].ToString().Trim(); //关系字段中文名
objvSqlViewRelaTabEN.RelaFldName = objRow[convSqlViewRelaTab.RelaFldName] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldName].ToString().Trim(); //关系字段名
objvSqlViewRelaTabEN.RelaFldId = objRow[convSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objvSqlViewRelaTabEN.OtherFldId = objRow[convSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objvSqlViewRelaTabEN.OtherTabId = objRow[convSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objvSqlViewRelaTabEN.PrjId = objRow[convSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objvSqlViewRelaTabEN.UpdDate = objRow[convSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objvSqlViewRelaTabEN.UpdUserId = objRow[convSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[convSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objvSqlViewRelaTabEN.Memo = objRow[convSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[convSqlViewRelaTab.Memo].ToString().Trim(); //说明
objvSqlViewRelaTabEN.RelaTabId4SqlView = objRow[convSqlViewRelaTab.RelaTabId4SqlView] == DBNull.Value ? null : objRow[convSqlViewRelaTab.RelaTabId4SqlView].ToString().Trim(); //RelaTabId4SqlView
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvSqlViewRelaTabDA: GetObjByDataRow)", objException.Message));
}
objvSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvSqlViewRelaTabEN;
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
objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlViewRelaTabEN._CurrTabName, convSqlViewRelaTab.RelaTabId, 8, "");
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
objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvSqlViewRelaTabEN._CurrTabName, convSqlViewRelaTab.RelaTabId, 8, strPrefix);
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RelaTabId from vSqlViewRelaTab where " + strCondition;
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RelaTabId from vSqlViewRelaTab where " + strCondition;
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
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strRelaTabId)
{
CheckPrimaryKey(strRelaTabId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlViewRelaTab", "RelaTabId = " + "'"+ strRelaTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvSqlViewRelaTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vSqlViewRelaTab", strCondition))
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
objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vSqlViewRelaTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvSqlViewRelaTabENS">源对象</param>
 /// <param name = "objvSqlViewRelaTabENT">目标对象</param>
public void CopyTo(clsvSqlViewRelaTabEN objvSqlViewRelaTabENS, clsvSqlViewRelaTabEN objvSqlViewRelaTabENT)
{
objvSqlViewRelaTabENT.RelaTabId = objvSqlViewRelaTabENS.RelaTabId; //相关表Id
objvSqlViewRelaTabENT.SqlViewId = objvSqlViewRelaTabENS.SqlViewId; //Sql视图Id
objvSqlViewRelaTabENT.SqlViewCNName = objvSqlViewRelaTabENS.SqlViewCNName; //Sql视图中文名
objvSqlViewRelaTabENT.SqlViewName = objvSqlViewRelaTabENS.SqlViewName; //数据视图名称
objvSqlViewRelaTabENT.TabId = objvSqlViewRelaTabENS.TabId; //表ID
objvSqlViewRelaTabENT.TabName = objvSqlViewRelaTabENS.TabName; //表名
objvSqlViewRelaTabENT.TabCnName = objvSqlViewRelaTabENS.TabCnName; //表中文名
objvSqlViewRelaTabENT.TabAliases = objvSqlViewRelaTabENS.TabAliases; //表别名
objvSqlViewRelaTabENT.SvRelaTabTypeName = objvSqlViewRelaTabENS.SvRelaTabTypeName; //Sql视图相关表类型名
objvSqlViewRelaTabENT.SvRelaTabTypeId = objvSqlViewRelaTabENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objvSqlViewRelaTabENT.TabRelationTypeId = objvSqlViewRelaTabENS.TabRelationTypeId; //表关系类型Id
objvSqlViewRelaTabENT.TabRelationTypeName = objvSqlViewRelaTabENS.TabRelationTypeName; //表关系类型名
objvSqlViewRelaTabENT.TabRelationText = objvSqlViewRelaTabENS.TabRelationText; //表关系文本
objvSqlViewRelaTabENT.OrderNum = objvSqlViewRelaTabENS.OrderNum; //序号
objvSqlViewRelaTabENT.OtherFldCnName = objvSqlViewRelaTabENS.OtherFldCnName; //他表字段中文名
objvSqlViewRelaTabENT.OtherFldName = objvSqlViewRelaTabENS.OtherFldName; //他表字段名
objvSqlViewRelaTabENT.OtherTabName = objvSqlViewRelaTabENS.OtherTabName; //他表名
objvSqlViewRelaTabENT.RelaFldCnName = objvSqlViewRelaTabENS.RelaFldCnName; //关系字段中文名
objvSqlViewRelaTabENT.RelaFldName = objvSqlViewRelaTabENS.RelaFldName; //关系字段名
objvSqlViewRelaTabENT.RelaFldId = objvSqlViewRelaTabENS.RelaFldId; //关系字段
objvSqlViewRelaTabENT.OtherFldId = objvSqlViewRelaTabENS.OtherFldId; //其他表字段
objvSqlViewRelaTabENT.OtherTabId = objvSqlViewRelaTabENS.OtherTabId; //其他表Id
objvSqlViewRelaTabENT.PrjId = objvSqlViewRelaTabENS.PrjId; //工程Id
objvSqlViewRelaTabENT.UpdDate = objvSqlViewRelaTabENS.UpdDate; //修改日期
objvSqlViewRelaTabENT.UpdUserId = objvSqlViewRelaTabENS.UpdUserId; //修改用户Id
objvSqlViewRelaTabENT.Memo = objvSqlViewRelaTabENS.Memo; //说明
objvSqlViewRelaTabENT.RelaTabId4SqlView = objvSqlViewRelaTabENS.RelaTabId4SqlView; //RelaTabId4SqlView
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvSqlViewRelaTabEN objvSqlViewRelaTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.RelaTabId, 8, convSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.SqlViewId, 8, convSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.SqlViewCNName, 200, convSqlViewRelaTab.SqlViewCNName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.SqlViewName, 100, convSqlViewRelaTab.SqlViewName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabId, 8, convSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabName, 100, convSqlViewRelaTab.TabName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabCnName, 200, convSqlViewRelaTab.TabCnName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabAliases, 100, convSqlViewRelaTab.TabAliases);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.SvRelaTabTypeName, 30, convSqlViewRelaTab.SvRelaTabTypeName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.SvRelaTabTypeId, 2, convSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabRelationTypeId, 2, convSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabRelationTypeName, 30, convSqlViewRelaTab.TabRelationTypeName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.TabRelationText, 500, convSqlViewRelaTab.TabRelationText);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.OtherFldCnName, 200, convSqlViewRelaTab.OtherFldCnName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.OtherFldName, 50, convSqlViewRelaTab.OtherFldName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.OtherTabName, 100, convSqlViewRelaTab.OtherTabName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.RelaFldCnName, 200, convSqlViewRelaTab.RelaFldCnName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.RelaFldName, 50, convSqlViewRelaTab.RelaFldName);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.RelaFldId, 8, convSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.OtherFldId, 8, convSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.OtherTabId, 8, convSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.PrjId, 4, convSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.UpdDate, 20, convSqlViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.UpdUserId, 20, convSqlViewRelaTab.UpdUserId);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.Memo, 1000, convSqlViewRelaTab.Memo);
clsCheckSql.CheckFieldLen(objvSqlViewRelaTabEN.RelaTabId4SqlView, 8, convSqlViewRelaTab.RelaTabId4SqlView);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.RelaTabId, convSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.SqlViewId, convSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.SqlViewCNName, convSqlViewRelaTab.SqlViewCNName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.SqlViewName, convSqlViewRelaTab.SqlViewName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabId, convSqlViewRelaTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabName, convSqlViewRelaTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabCnName, convSqlViewRelaTab.TabCnName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabAliases, convSqlViewRelaTab.TabAliases);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.SvRelaTabTypeName, convSqlViewRelaTab.SvRelaTabTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.SvRelaTabTypeId, convSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabRelationTypeId, convSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabRelationTypeName, convSqlViewRelaTab.TabRelationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.TabRelationText, convSqlViewRelaTab.TabRelationText);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.OtherFldCnName, convSqlViewRelaTab.OtherFldCnName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.OtherFldName, convSqlViewRelaTab.OtherFldName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.OtherTabName, convSqlViewRelaTab.OtherTabName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.RelaFldCnName, convSqlViewRelaTab.RelaFldCnName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.RelaFldName, convSqlViewRelaTab.RelaFldName);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.RelaFldId, convSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.OtherFldId, convSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.OtherTabId, convSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.PrjId, convSqlViewRelaTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.UpdDate, convSqlViewRelaTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.UpdUserId, convSqlViewRelaTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.Memo, convSqlViewRelaTab.Memo);
clsCheckSql.CheckSqlInjection4Field(objvSqlViewRelaTabEN.RelaTabId4SqlView, convSqlViewRelaTab.RelaTabId4SqlView);
//检查外键字段长度
 objvSqlViewRelaTabEN._IsCheckProperty = true;
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlViewRelaTabEN._CurrTabName);
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvSqlViewRelaTabEN._CurrTabName, strCondition);
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
 objSQL = clsvSqlViewRelaTabDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}