
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsSqlViewRelaTabDA
 表名:SqlViewRelaTab(00050247)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:34:42
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
 /// Sql视图相关表(SqlViewRelaTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsSqlViewRelaTabDA : clsCommBase4DA
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
 return clsSqlViewRelaTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsSqlViewRelaTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsSqlViewRelaTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsSqlViewRelaTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsSqlViewRelaTabEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:SqlViewRelaTab中,检查关键字,长度不正确!(clsSqlViewRelaTabDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strRelaTabId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:SqlViewRelaTab中,关键字不能为空 或 null!(clsSqlViewRelaTabDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strRelaTabId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsSqlViewRelaTabDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_SqlViewRelaTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable_SqlViewRelaTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlViewRelaTab.* " + 
$"from SqlViewRelaTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlViewRelaTab.RelaTabId not in " + 
$"(Select top {intTop_In} SqlViewRelaTab.RelaTabId from SqlViewRelaTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1} and RelaTabId not in (Select top {2} RelaTabId from SqlViewRelaTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1} and RelaTabId not in (Select top {3} RelaTabId from SqlViewRelaTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} SqlViewRelaTab.* " + 
$"from SqlViewRelaTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and SqlViewRelaTab.RelaTabId not in " + 
$"(Select top {intTop_In} SqlViewRelaTab.RelaTabId from SqlViewRelaTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1} and RelaTabId not in (Select top {2} RelaTabId from SqlViewRelaTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from SqlViewRelaTab where {1} and RelaTabId not in (Select top {3} RelaTabId from SqlViewRelaTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsSqlViewRelaTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA:GetObjLst)", objException.Message));
}
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetObjLst)", objException.Message));
}
objSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlViewRelaTabEN);
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
public List<clsSqlViewRelaTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsSqlViewRelaTabEN> arrObjLst = new List<clsSqlViewRelaTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetObjLst)", objException.Message));
}
objSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objSqlViewRelaTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetSqlViewRelaTab(ref clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where RelaTabId = " + "'"+ objSqlViewRelaTabEN.RelaTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objSqlViewRelaTabEN.RelaTabId = objDT.Rows[0][conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewRelaTabEN.SqlViewId = objDT.Rows[0][conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewRelaTabEN.TabId = objDT.Rows[0][conSqlViewRelaTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewRelaTabEN.TabAliases = objDT.Rows[0][conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名(字段类型:varchar,字段长度:100,是否可空:True)
 objSqlViewRelaTabEN.RelaFldId = objDT.Rows[0][conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段(字段类型:char,字段长度:8,是否可空:True)
 objSqlViewRelaTabEN.OtherFldId = objDT.Rows[0][conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段(字段类型:char,字段长度:8,是否可空:True)
 objSqlViewRelaTabEN.OtherTabId = objDT.Rows[0][conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id(字段类型:char,字段长度:8,是否可空:True)
 objSqlViewRelaTabEN.SvRelaTabTypeId = objDT.Rows[0][conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlViewRelaTabEN.TabRelationTypeId = objDT.Rows[0][conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlViewRelaTabEN.TabRelationText = objDT.Rows[0][conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本(字段类型:varchar,字段长度:500,是否可空:True)
 objSqlViewRelaTabEN.OrderNum = TransNullToInt(objDT.Rows[0][conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objSqlViewRelaTabEN.PrjId = objDT.Rows[0][conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlViewRelaTabEN.UpdDate = objDT.Rows[0][conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewRelaTabEN.UpdUserId = objDT.Rows[0][conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewRelaTabEN.Memo = objDT.Rows[0][conSqlViewRelaTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetSqlViewRelaTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strRelaTabId">表关键字</param>
 /// <returns>表对象</returns>
public clsSqlViewRelaTabEN GetObjByRelaTabId(string strRelaTabId)
{
CheckPrimaryKey(strRelaTabId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where RelaTabId = " + "'"+ strRelaTabId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
 objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名(字段类型:varchar,字段长度:100,是否可空:True)
 objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段(字段类型:char,字段长度:8,是否可空:True)
 objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段(字段类型:char,字段长度:8,是否可空:True)
 objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id(字段类型:char,字段长度:8,是否可空:True)
 objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id(字段类型:char,字段长度:2,是否可空:False)
 objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本(字段类型:varchar,字段长度:500,是否可空:True)
 objSqlViewRelaTabEN.OrderNum = Int32.Parse(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id(字段类型:varchar,字段长度:20,是否可空:True)
 objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetObjByRelaTabId)", objException.Message));
}
return objSqlViewRelaTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsSqlViewRelaTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN()
{
RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(), //相关表Id
SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(), //Sql视图Id
TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(), //表ID
TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(), //表别名
RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(), //关系字段
OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(), //其他表字段
OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(), //其他表Id
SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(), //Sql视图相关表类型Id
TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(), //表关系类型Id
TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(), //表关系文本
OrderNum = TransNullToInt(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()), //序号
PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(), //修改日期
UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(), //修改用户Id
Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim() //说明
};
objSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlViewRelaTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsSqlViewRelaTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetObjByDataRowSqlViewRelaTab)", objException.Message));
}
objSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlViewRelaTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsSqlViewRelaTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsSqlViewRelaTabEN objSqlViewRelaTabEN = new clsSqlViewRelaTabEN();
try
{
objSqlViewRelaTabEN.RelaTabId = objRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objSqlViewRelaTabEN.SqlViewId = objRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objSqlViewRelaTabEN.TabId = objRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objSqlViewRelaTabEN.TabAliases = objRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objSqlViewRelaTabEN.RelaFldId = objRow[conSqlViewRelaTab.RelaFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objSqlViewRelaTabEN.OtherFldId = objRow[conSqlViewRelaTab.OtherFldId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objSqlViewRelaTabEN.OtherTabId = objRow[conSqlViewRelaTab.OtherTabId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objSqlViewRelaTabEN.SvRelaTabTypeId = objRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objSqlViewRelaTabEN.TabRelationTypeId = objRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objSqlViewRelaTabEN.TabRelationText = objRow[conSqlViewRelaTab.TabRelationText] == DBNull.Value ? null : objRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objSqlViewRelaTabEN.OrderNum = TransNullToInt(objRow[conSqlViewRelaTab.OrderNum].ToString().Trim()); //序号
objSqlViewRelaTabEN.PrjId = objRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objSqlViewRelaTabEN.UpdDate = objRow[conSqlViewRelaTab.UpdDate] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objSqlViewRelaTabEN.UpdUserId = objRow[conSqlViewRelaTab.UpdUserId] == DBNull.Value ? null : objRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objSqlViewRelaTabEN.Memo = objRow[conSqlViewRelaTab.Memo] == DBNull.Value ? null : objRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsSqlViewRelaTabDA: GetObjByDataRow)", objException.Message));
}
objSqlViewRelaTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objSqlViewRelaTabEN;
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
objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlViewRelaTabEN._CurrTabName, conSqlViewRelaTab.RelaTabId, 8, "");
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
objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsSqlViewRelaTabEN._CurrTabName, conSqlViewRelaTab.RelaTabId, 8, strPrefix);
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RelaTabId from SqlViewRelaTab where " + strCondition;
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RelaTabId from SqlViewRelaTab where " + strCondition;
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlViewRelaTab", "RelaTabId = " + "'"+ strRelaTabId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("SqlViewRelaTab", strCondition))
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
objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("SqlViewRelaTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
 {
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewRelaTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlViewRelaTab");
objRow = objDS.Tables["SqlViewRelaTab"].NewRow();
objRow[conSqlViewRelaTab.RelaTabId] = objSqlViewRelaTabEN.RelaTabId; //相关表Id
objRow[conSqlViewRelaTab.SqlViewId] = objSqlViewRelaTabEN.SqlViewId; //Sql视图Id
objRow[conSqlViewRelaTab.TabId] = objSqlViewRelaTabEN.TabId; //表ID
objRow[conSqlViewRelaTab.TabAliases] = objSqlViewRelaTabEN.TabAliases; //表别名
 if (objSqlViewRelaTabEN.RelaFldId !=  "")
 {
objRow[conSqlViewRelaTab.RelaFldId] = objSqlViewRelaTabEN.RelaFldId; //关系字段
 }
 if (objSqlViewRelaTabEN.OtherFldId !=  "")
 {
objRow[conSqlViewRelaTab.OtherFldId] = objSqlViewRelaTabEN.OtherFldId; //其他表字段
 }
 if (objSqlViewRelaTabEN.OtherTabId !=  "")
 {
objRow[conSqlViewRelaTab.OtherTabId] = objSqlViewRelaTabEN.OtherTabId; //其他表Id
 }
objRow[conSqlViewRelaTab.SvRelaTabTypeId] = objSqlViewRelaTabEN.SvRelaTabTypeId; //Sql视图相关表类型Id
objRow[conSqlViewRelaTab.TabRelationTypeId] = objSqlViewRelaTabEN.TabRelationTypeId; //表关系类型Id
 if (objSqlViewRelaTabEN.TabRelationText !=  "")
 {
objRow[conSqlViewRelaTab.TabRelationText] = objSqlViewRelaTabEN.TabRelationText; //表关系文本
 }
objRow[conSqlViewRelaTab.OrderNum] = objSqlViewRelaTabEN.OrderNum; //序号
objRow[conSqlViewRelaTab.PrjId] = objSqlViewRelaTabEN.PrjId; //工程Id
 if (objSqlViewRelaTabEN.UpdDate !=  "")
 {
objRow[conSqlViewRelaTab.UpdDate] = objSqlViewRelaTabEN.UpdDate; //修改日期
 }
 if (objSqlViewRelaTabEN.UpdUserId !=  "")
 {
objRow[conSqlViewRelaTab.UpdUserId] = objSqlViewRelaTabEN.UpdUserId; //修改用户Id
 }
 if (objSqlViewRelaTabEN.Memo !=  "")
 {
objRow[conSqlViewRelaTab.Memo] = objSqlViewRelaTabEN.Memo; //说明
 }
objDS.Tables[clsSqlViewRelaTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsSqlViewRelaTabEN._CurrTabName);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewRelaTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlViewRelaTabEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaTabId);
 var strRelaTabId = objSqlViewRelaTabEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SqlViewId);
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabId);
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabAliases);
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabAliases + "'");
 }
 
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaFldId);
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherFldId);
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherTabId);
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SvRelaTabTypeId);
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSvRelaTabTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationTypeId);
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationText);
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationText + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewRelaTab.OrderNum);
 arrValueListForInsert.Add(objSqlViewRelaTabEN.OrderNum.ToString());
 
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.PrjId);
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdDate);
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdUserId);
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.Memo);
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewRelaTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlViewRelaTabEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaTabId);
 var strRelaTabId = objSqlViewRelaTabEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SqlViewId);
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabId);
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabAliases);
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabAliases + "'");
 }
 
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaFldId);
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherFldId);
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherTabId);
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SvRelaTabTypeId);
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSvRelaTabTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationTypeId);
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationText);
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationText + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewRelaTab.OrderNum);
 arrValueListForInsert.Add(objSqlViewRelaTabEN.OrderNum.ToString());
 
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.PrjId);
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdDate);
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdUserId);
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.Memo);
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objSqlViewRelaTabEN.RelaTabId;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsSqlViewRelaTabEN objSqlViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewRelaTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlViewRelaTabEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaTabId);
 var strRelaTabId = objSqlViewRelaTabEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SqlViewId);
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabId);
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabAliases);
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabAliases + "'");
 }
 
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaFldId);
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherFldId);
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherTabId);
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SvRelaTabTypeId);
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSvRelaTabTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationTypeId);
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationText);
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationText + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewRelaTab.OrderNum);
 arrValueListForInsert.Add(objSqlViewRelaTabEN.OrderNum.ToString());
 
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.PrjId);
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdDate);
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdUserId);
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.Memo);
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objSqlViewRelaTabEN.RelaTabId;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsSqlViewRelaTabEN objSqlViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objSqlViewRelaTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objSqlViewRelaTabEN.RelaTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaTabId);
 var strRelaTabId = objSqlViewRelaTabEN.RelaTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SqlViewId);
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlViewId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabId);
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabAliases);
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabAliases + "'");
 }
 
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.RelaFldId);
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelaFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherFldId);
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherFldId + "'");
 }
 
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.OtherTabId);
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOtherTabId + "'");
 }
 
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.SvRelaTabTypeId);
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSvRelaTabTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationTypeId);
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationTypeId + "'");
 }
 
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.TabRelationText);
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabRelationText + "'");
 }
 
 arrFieldListForInsert.Add(conSqlViewRelaTab.OrderNum);
 arrValueListForInsert.Add(objSqlViewRelaTabEN.OrderNum.ToString());
 
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.PrjId);
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdDate);
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.UpdUserId);
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUserId + "'");
 }
 
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conSqlViewRelaTab.Memo);
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into SqlViewRelaTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewSqlViewRelaTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where RelaTabId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "SqlViewRelaTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strRelaTabId = oRow[conSqlViewRelaTab.RelaTabId].ToString().Trim();
if (IsExist(strRelaTabId))
{
 string strResult = "关键字变量值为:" + string.Format("RelaTabId = {0}", strRelaTabId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsSqlViewRelaTabEN._CurrTabName ].NewRow();
objRow[conSqlViewRelaTab.RelaTabId] = oRow[conSqlViewRelaTab.RelaTabId].ToString().Trim(); //相关表Id
objRow[conSqlViewRelaTab.SqlViewId] = oRow[conSqlViewRelaTab.SqlViewId].ToString().Trim(); //Sql视图Id
objRow[conSqlViewRelaTab.TabId] = oRow[conSqlViewRelaTab.TabId].ToString().Trim(); //表ID
objRow[conSqlViewRelaTab.TabAliases] = oRow[conSqlViewRelaTab.TabAliases].ToString().Trim(); //表别名
objRow[conSqlViewRelaTab.RelaFldId] = oRow[conSqlViewRelaTab.RelaFldId].ToString().Trim(); //关系字段
objRow[conSqlViewRelaTab.OtherFldId] = oRow[conSqlViewRelaTab.OtherFldId].ToString().Trim(); //其他表字段
objRow[conSqlViewRelaTab.OtherTabId] = oRow[conSqlViewRelaTab.OtherTabId].ToString().Trim(); //其他表Id
objRow[conSqlViewRelaTab.SvRelaTabTypeId] = oRow[conSqlViewRelaTab.SvRelaTabTypeId].ToString().Trim(); //Sql视图相关表类型Id
objRow[conSqlViewRelaTab.TabRelationTypeId] = oRow[conSqlViewRelaTab.TabRelationTypeId].ToString().Trim(); //表关系类型Id
objRow[conSqlViewRelaTab.TabRelationText] = oRow[conSqlViewRelaTab.TabRelationText].ToString().Trim(); //表关系文本
objRow[conSqlViewRelaTab.OrderNum] = oRow[conSqlViewRelaTab.OrderNum].ToString().Trim(); //序号
objRow[conSqlViewRelaTab.PrjId] = oRow[conSqlViewRelaTab.PrjId].ToString().Trim(); //工程Id
objRow[conSqlViewRelaTab.UpdDate] = oRow[conSqlViewRelaTab.UpdDate].ToString().Trim(); //修改日期
objRow[conSqlViewRelaTab.UpdUserId] = oRow[conSqlViewRelaTab.UpdUserId].ToString().Trim(); //修改用户Id
objRow[conSqlViewRelaTab.Memo] = oRow[conSqlViewRelaTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsSqlViewRelaTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsSqlViewRelaTabEN._CurrTabName);
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
 /// <param name = "objSqlViewRelaTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewRelaTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
strSQL = "Select * from SqlViewRelaTab where RelaTabId = " + "'"+ objSqlViewRelaTabEN.RelaTabId+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsSqlViewRelaTabEN._CurrTabName);
if (objDS.Tables[clsSqlViewRelaTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RelaTabId = " + "'"+ objSqlViewRelaTabEN.RelaTabId+"'");
return false;
}
objRow = objDS.Tables[clsSqlViewRelaTabEN._CurrTabName].Rows[0];
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.RelaTabId))
 {
objRow[conSqlViewRelaTab.RelaTabId] = objSqlViewRelaTabEN.RelaTabId; //相关表Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SqlViewId))
 {
objRow[conSqlViewRelaTab.SqlViewId] = objSqlViewRelaTabEN.SqlViewId; //Sql视图Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabId))
 {
objRow[conSqlViewRelaTab.TabId] = objSqlViewRelaTabEN.TabId; //表ID
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabAliases))
 {
objRow[conSqlViewRelaTab.TabAliases] = objSqlViewRelaTabEN.TabAliases; //表别名
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.RelaFldId))
 {
objRow[conSqlViewRelaTab.RelaFldId] = objSqlViewRelaTabEN.RelaFldId; //关系字段
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherFldId))
 {
objRow[conSqlViewRelaTab.OtherFldId] = objSqlViewRelaTabEN.OtherFldId; //其他表字段
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherTabId))
 {
objRow[conSqlViewRelaTab.OtherTabId] = objSqlViewRelaTabEN.OtherTabId; //其他表Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId))
 {
objRow[conSqlViewRelaTab.SvRelaTabTypeId] = objSqlViewRelaTabEN.SvRelaTabTypeId; //Sql视图相关表类型Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationTypeId))
 {
objRow[conSqlViewRelaTab.TabRelationTypeId] = objSqlViewRelaTabEN.TabRelationTypeId; //表关系类型Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationText))
 {
objRow[conSqlViewRelaTab.TabRelationText] = objSqlViewRelaTabEN.TabRelationText; //表关系文本
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OrderNum))
 {
objRow[conSqlViewRelaTab.OrderNum] = objSqlViewRelaTabEN.OrderNum; //序号
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.PrjId))
 {
objRow[conSqlViewRelaTab.PrjId] = objSqlViewRelaTabEN.PrjId; //工程Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdDate))
 {
objRow[conSqlViewRelaTab.UpdDate] = objSqlViewRelaTabEN.UpdDate; //修改日期
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdUserId))
 {
objRow[conSqlViewRelaTab.UpdUserId] = objSqlViewRelaTabEN.UpdUserId; //修改用户Id
 }
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.Memo))
 {
objRow[conSqlViewRelaTab.Memo] = objSqlViewRelaTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsSqlViewRelaTabEN._CurrTabName);
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update SqlViewRelaTab Set ");
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SqlViewId))
 {
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlViewId, conSqlViewRelaTab.SqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.SqlViewId); //Sql视图Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabId))
 {
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conSqlViewRelaTab.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabId); //表ID
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabAliases))
 {
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabAliases, conSqlViewRelaTab.TabAliases); //表别名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabAliases); //表别名
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.RelaFldId))
 {
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaFldId, conSqlViewRelaTab.RelaFldId); //关系字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.RelaFldId); //关系字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherFldId))
 {
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOtherFldId, conSqlViewRelaTab.OtherFldId); //其他表字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.OtherFldId); //其他表字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherTabId))
 {
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOtherTabId, conSqlViewRelaTab.OtherTabId); //其他表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.OtherTabId); //其他表Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId))
 {
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSvRelaTabTypeId, conSqlViewRelaTab.SvRelaTabTypeId); //Sql视图相关表类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.SvRelaTabTypeId); //Sql视图相关表类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationTypeId))
 {
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabRelationTypeId, conSqlViewRelaTab.TabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabRelationTypeId); //表关系类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationText))
 {
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabRelationText, conSqlViewRelaTab.TabRelationText); //表关系文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabRelationText); //表关系文本
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlViewRelaTabEN.OrderNum, conSqlViewRelaTab.OrderNum); //序号
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.PrjId))
 {
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSqlViewRelaTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.PrjId); //工程Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdDate))
 {
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSqlViewRelaTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.UpdDate); //修改日期
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdUserId))
 {
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSqlViewRelaTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.Memo))
 {
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSqlViewRelaTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelaTabId = '{0}'", objSqlViewRelaTabEN.RelaTabId); 
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
 /// <param name = "objSqlViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strCondition)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlViewRelaTab Set ");
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SqlViewId))
 {
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlViewId = '{0}',", strSqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.Append(" SqlViewId = null,"); //Sql视图Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabId))
 {
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabAliases))
 {
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabAliases = '{0}',", strTabAliases); //表别名
 }
 else
 {
 sbSQL.Append(" TabAliases = null,"); //表别名
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.RelaFldId))
 {
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaFldId = '{0}',", strRelaFldId); //关系字段
 }
 else
 {
 sbSQL.Append(" RelaFldId = null,"); //关系字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherFldId))
 {
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OtherFldId = '{0}',", strOtherFldId); //其他表字段
 }
 else
 {
 sbSQL.Append(" OtherFldId = null,"); //其他表字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherTabId))
 {
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OtherTabId = '{0}',", strOtherTabId); //其他表Id
 }
 else
 {
 sbSQL.Append(" OtherTabId = null,"); //其他表Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId))
 {
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SvRelaTabTypeId = '{0}',", strSvRelaTabTypeId); //Sql视图相关表类型Id
 }
 else
 {
 sbSQL.Append(" SvRelaTabTypeId = null,"); //Sql视图相关表类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationTypeId))
 {
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabRelationTypeId = '{0}',", strTabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.Append(" TabRelationTypeId = null,"); //表关系类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationText))
 {
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabRelationText = '{0}',", strTabRelationText); //表关系文本
 }
 else
 {
 sbSQL.Append(" TabRelationText = null,"); //表关系文本
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objSqlViewRelaTabEN.OrderNum); //序号
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.PrjId))
 {
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdDate))
 {
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdUserId))
 {
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.Memo))
 {
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSqlViewRelaTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsSqlViewRelaTabEN objSqlViewRelaTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlViewRelaTab Set ");
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SqlViewId))
 {
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlViewId = '{0}',", strSqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.Append(" SqlViewId = null,"); //Sql视图Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabId))
 {
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabAliases))
 {
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabAliases = '{0}',", strTabAliases); //表别名
 }
 else
 {
 sbSQL.Append(" TabAliases = null,"); //表别名
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.RelaFldId))
 {
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelaFldId = '{0}',", strRelaFldId); //关系字段
 }
 else
 {
 sbSQL.Append(" RelaFldId = null,"); //关系字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherFldId))
 {
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OtherFldId = '{0}',", strOtherFldId); //其他表字段
 }
 else
 {
 sbSQL.Append(" OtherFldId = null,"); //其他表字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherTabId))
 {
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OtherTabId = '{0}',", strOtherTabId); //其他表Id
 }
 else
 {
 sbSQL.Append(" OtherTabId = null,"); //其他表Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId))
 {
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SvRelaTabTypeId = '{0}',", strSvRelaTabTypeId); //Sql视图相关表类型Id
 }
 else
 {
 sbSQL.Append(" SvRelaTabTypeId = null,"); //Sql视图相关表类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationTypeId))
 {
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabRelationTypeId = '{0}',", strTabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.Append(" TabRelationTypeId = null,"); //表关系类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationText))
 {
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabRelationText = '{0}',", strTabRelationText); //表关系文本
 }
 else
 {
 sbSQL.Append(" TabRelationText = null,"); //表关系文本
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objSqlViewRelaTabEN.OrderNum); //序号
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.PrjId))
 {
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdDate))
 {
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdUserId))
 {
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUserId = '{0}',", strUpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.Append(" UpdUserId = null,"); //修改用户Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.Memo))
 {
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objSqlViewRelaTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsSqlViewRelaTabEN objSqlViewRelaTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objSqlViewRelaTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objSqlViewRelaTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objSqlViewRelaTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update SqlViewRelaTab Set ");
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SqlViewId))
 {
 if (objSqlViewRelaTabEN.SqlViewId  ==  "")
 {
 objSqlViewRelaTabEN.SqlViewId = null;
 }
 if (objSqlViewRelaTabEN.SqlViewId !=  null)
 {
 var strSqlViewId = objSqlViewRelaTabEN.SqlViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlViewId, conSqlViewRelaTab.SqlViewId); //Sql视图Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.SqlViewId); //Sql视图Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabId))
 {
 if (objSqlViewRelaTabEN.TabId !=  null)
 {
 var strTabId = objSqlViewRelaTabEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conSqlViewRelaTab.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabId); //表ID
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabAliases))
 {
 if (objSqlViewRelaTabEN.TabAliases !=  null)
 {
 var strTabAliases = objSqlViewRelaTabEN.TabAliases.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabAliases, conSqlViewRelaTab.TabAliases); //表别名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabAliases); //表别名
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.RelaFldId))
 {
 if (objSqlViewRelaTabEN.RelaFldId !=  null)
 {
 var strRelaFldId = objSqlViewRelaTabEN.RelaFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelaFldId, conSqlViewRelaTab.RelaFldId); //关系字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.RelaFldId); //关系字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherFldId))
 {
 if (objSqlViewRelaTabEN.OtherFldId !=  null)
 {
 var strOtherFldId = objSqlViewRelaTabEN.OtherFldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOtherFldId, conSqlViewRelaTab.OtherFldId); //其他表字段
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.OtherFldId); //其他表字段
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OtherTabId))
 {
 if (objSqlViewRelaTabEN.OtherTabId !=  null)
 {
 var strOtherTabId = objSqlViewRelaTabEN.OtherTabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOtherTabId, conSqlViewRelaTab.OtherTabId); //其他表Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.OtherTabId); //其他表Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.SvRelaTabTypeId))
 {
 if (objSqlViewRelaTabEN.SvRelaTabTypeId !=  null)
 {
 var strSvRelaTabTypeId = objSqlViewRelaTabEN.SvRelaTabTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSvRelaTabTypeId, conSqlViewRelaTab.SvRelaTabTypeId); //Sql视图相关表类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.SvRelaTabTypeId); //Sql视图相关表类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationTypeId))
 {
 if (objSqlViewRelaTabEN.TabRelationTypeId !=  null)
 {
 var strTabRelationTypeId = objSqlViewRelaTabEN.TabRelationTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabRelationTypeId, conSqlViewRelaTab.TabRelationTypeId); //表关系类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabRelationTypeId); //表关系类型Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.TabRelationText))
 {
 if (objSqlViewRelaTabEN.TabRelationText !=  null)
 {
 var strTabRelationText = objSqlViewRelaTabEN.TabRelationText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabRelationText, conSqlViewRelaTab.TabRelationText); //表关系文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.TabRelationText); //表关系文本
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objSqlViewRelaTabEN.OrderNum, conSqlViewRelaTab.OrderNum); //序号
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.PrjId))
 {
 if (objSqlViewRelaTabEN.PrjId !=  null)
 {
 var strPrjId = objSqlViewRelaTabEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conSqlViewRelaTab.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.PrjId); //工程Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdDate))
 {
 if (objSqlViewRelaTabEN.UpdDate !=  null)
 {
 var strUpdDate = objSqlViewRelaTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conSqlViewRelaTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.UpdDate); //修改日期
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.UpdUserId))
 {
 if (objSqlViewRelaTabEN.UpdUserId !=  null)
 {
 var strUpdUserId = objSqlViewRelaTabEN.UpdUserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUserId, conSqlViewRelaTab.UpdUserId); //修改用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.UpdUserId); //修改用户Id
 }
 }
 
 if (objSqlViewRelaTabEN.IsUpdated(conSqlViewRelaTab.Memo))
 {
 if (objSqlViewRelaTabEN.Memo !=  null)
 {
 var strMemo = objSqlViewRelaTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conSqlViewRelaTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conSqlViewRelaTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RelaTabId = '{0}'", objSqlViewRelaTabEN.RelaTabId); 
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
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strRelaTabId) 
{
CheckPrimaryKey(strRelaTabId);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strRelaTabId,
};
 objSQL.ExecSP("SqlViewRelaTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strRelaTabId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strRelaTabId);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
//删除SqlViewRelaTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlViewRelaTab where RelaTabId = " + "'"+ strRelaTabId+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelSqlViewRelaTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
//删除SqlViewRelaTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlViewRelaTab where RelaTabId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strRelaTabId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strRelaTabId) 
{
CheckPrimaryKey(strRelaTabId);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
//删除SqlViewRelaTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from SqlViewRelaTab where RelaTabId = " + "'"+ strRelaTabId+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelSqlViewRelaTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: DelSqlViewRelaTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlViewRelaTab where " + strCondition ;
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
public bool DelSqlViewRelaTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsSqlViewRelaTabDA: DelSqlViewRelaTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from SqlViewRelaTab where " + strCondition ;
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
 /// <param name = "objSqlViewRelaTabENS">源对象</param>
 /// <param name = "objSqlViewRelaTabENT">目标对象</param>
public void CopyTo(clsSqlViewRelaTabEN objSqlViewRelaTabENS, clsSqlViewRelaTabEN objSqlViewRelaTabENT)
{
objSqlViewRelaTabENT.RelaTabId = objSqlViewRelaTabENS.RelaTabId; //相关表Id
objSqlViewRelaTabENT.SqlViewId = objSqlViewRelaTabENS.SqlViewId; //Sql视图Id
objSqlViewRelaTabENT.TabId = objSqlViewRelaTabENS.TabId; //表ID
objSqlViewRelaTabENT.TabAliases = objSqlViewRelaTabENS.TabAliases; //表别名
objSqlViewRelaTabENT.RelaFldId = objSqlViewRelaTabENS.RelaFldId; //关系字段
objSqlViewRelaTabENT.OtherFldId = objSqlViewRelaTabENS.OtherFldId; //其他表字段
objSqlViewRelaTabENT.OtherTabId = objSqlViewRelaTabENS.OtherTabId; //其他表Id
objSqlViewRelaTabENT.SvRelaTabTypeId = objSqlViewRelaTabENS.SvRelaTabTypeId; //Sql视图相关表类型Id
objSqlViewRelaTabENT.TabRelationTypeId = objSqlViewRelaTabENS.TabRelationTypeId; //表关系类型Id
objSqlViewRelaTabENT.TabRelationText = objSqlViewRelaTabENS.TabRelationText; //表关系文本
objSqlViewRelaTabENT.OrderNum = objSqlViewRelaTabENS.OrderNum; //序号
objSqlViewRelaTabENT.PrjId = objSqlViewRelaTabENS.PrjId; //工程Id
objSqlViewRelaTabENT.UpdDate = objSqlViewRelaTabENS.UpdDate; //修改日期
objSqlViewRelaTabENT.UpdUserId = objSqlViewRelaTabENS.UpdUserId; //修改用户Id
objSqlViewRelaTabENT.Memo = objSqlViewRelaTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.SqlViewId, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.TabId, conSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.TabAliases, conSqlViewRelaTab.TabAliases);
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.SvRelaTabTypeId, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.TabRelationTypeId, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.OrderNum, conSqlViewRelaTab.OrderNum);
clsCheckSql.CheckFieldNotNull(objSqlViewRelaTabEN.PrjId, conSqlViewRelaTab.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.RelaTabId, 8, conSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.SqlViewId, 8, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabId, 8, conSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabAliases, 100, conSqlViewRelaTab.TabAliases);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.RelaFldId, 8, conSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.OtherFldId, 8, conSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.OtherTabId, 8, conSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.SvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabRelationText, 500, conSqlViewRelaTab.TabRelationText);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.PrjId, 4, conSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.UpdDate, 20, conSqlViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.UpdUserId, 20, conSqlViewRelaTab.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.Memo, 1000, conSqlViewRelaTab.Memo);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objSqlViewRelaTabEN.SqlViewId, 8, conSqlViewRelaTab.SqlViewId);
 objSqlViewRelaTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.SqlViewId, 8, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabId, 8, conSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabAliases, 100, conSqlViewRelaTab.TabAliases);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.RelaFldId, 8, conSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.OtherFldId, 8, conSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.OtherTabId, 8, conSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.SvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabRelationText, 500, conSqlViewRelaTab.TabRelationText);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.PrjId, 4, conSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.UpdDate, 20, conSqlViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.UpdUserId, 20, conSqlViewRelaTab.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.Memo, 1000, conSqlViewRelaTab.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSqlViewRelaTabEN.SqlViewId, 8, conSqlViewRelaTab.SqlViewId);
 objSqlViewRelaTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.RelaTabId, 8, conSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.SqlViewId, 8, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabId, 8, conSqlViewRelaTab.TabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabAliases, 100, conSqlViewRelaTab.TabAliases);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.RelaFldId, 8, conSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.OtherFldId, 8, conSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.OtherTabId, 8, conSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.SvRelaTabTypeId, 2, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabRelationTypeId, 2, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.TabRelationText, 500, conSqlViewRelaTab.TabRelationText);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.PrjId, 4, conSqlViewRelaTab.PrjId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.UpdDate, 20, conSqlViewRelaTab.UpdDate);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.UpdUserId, 20, conSqlViewRelaTab.UpdUserId);
clsCheckSql.CheckFieldLen(objSqlViewRelaTabEN.Memo, 1000, conSqlViewRelaTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.RelaTabId, conSqlViewRelaTab.RelaTabId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.SqlViewId, conSqlViewRelaTab.SqlViewId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.TabId, conSqlViewRelaTab.TabId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.TabAliases, conSqlViewRelaTab.TabAliases);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.RelaFldId, conSqlViewRelaTab.RelaFldId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.OtherFldId, conSqlViewRelaTab.OtherFldId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.OtherTabId, conSqlViewRelaTab.OtherTabId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.SvRelaTabTypeId, conSqlViewRelaTab.SvRelaTabTypeId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.TabRelationTypeId, conSqlViewRelaTab.TabRelationTypeId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.TabRelationText, conSqlViewRelaTab.TabRelationText);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.PrjId, conSqlViewRelaTab.PrjId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.UpdDate, conSqlViewRelaTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.UpdUserId, conSqlViewRelaTab.UpdUserId);
clsCheckSql.CheckSqlInjection4Field(objSqlViewRelaTabEN.Memo, conSqlViewRelaTab.Memo);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objSqlViewRelaTabEN.SqlViewId, 8, conSqlViewRelaTab.SqlViewId);
 objSqlViewRelaTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--SqlViewRelaTab(Sql视图相关表),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objSqlViewRelaTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsSqlViewRelaTabEN objSqlViewRelaTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SqlViewId = '{0}'", objSqlViewRelaTabEN.SqlViewId);
 sbCondition.AppendFormat(" and TabAliases = '{0}'", objSqlViewRelaTabEN.TabAliases);
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlViewRelaTabEN._CurrTabName);
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsSqlViewRelaTabEN._CurrTabName, strCondition);
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
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
 objSQL = clsSqlViewRelaTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}