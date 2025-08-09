
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsEventTabDA
 表名:EventTab(00050031)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:13:45
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// 事件(EventTab)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsEventTabDA : clsCommBase4DA
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
 return clsEventTabEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsEventTabEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsEventTabEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsEventTabEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsEventTabEN._ConnectString);
 }
 return objSQL;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_EventTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable_EventTab)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EventTab where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EventTab where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsEventTabDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from EventTab where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsEventTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} EventTab.* " + 
$"from EventTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and EventTab.EventId not in " + 
$"(Select top {intTop_In} EventTab.EventId from EventTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EventTab where {1} and EventId not in (Select top {2} EventId from EventTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EventTab where {1} and EventId not in (Select top {3} EventId from EventTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsEventTabDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} EventTab.* " + 
$"from EventTab " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and EventTab.EventId not in " + 
$"(Select top {intTop_In} EventTab.EventId from EventTab " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from EventTab where {1} and EventId not in (Select top {2} EventId from EventTab where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from EventTab where {1} and EventId not in (Select top {3} EventId from EventTab where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsEventTabEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsEventTabDA:GetObjLst)", objException.Message));
}
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = TransNullToInt(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsEventTabDA: GetObjLst)", objException.Message));
}
objEventTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objEventTabEN);
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
public List<clsEventTabEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsEventTabDA:GetObjLstByTabName)", objException.Message));
}
List<clsEventTabEN> arrObjLst = new List<clsEventTabEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = TransNullToInt(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsEventTabDA: GetObjLst)", objException.Message));
}
objEventTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objEventTabEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetEventTab(ref clsEventTabEN objEventTabEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where EventId = " + ""+ objEventTabEN.EventId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objEventTabEN.EventId = TransNullToInt(objDT.Rows[0][conEventTab.EventId].ToString().Trim()); //EventId(字段类型:bigint,字段长度:8,是否可空:False)
 objEventTabEN.TabName = objDT.Rows[0][conEventTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objEventTabEN.ColName = objDT.Rows[0][conEventTab.ColName].ToString().Trim(); //ColName(字段类型:varchar,字段长度:30,是否可空:False)
 objEventTabEN.RecordId = objDT.Rows[0][conEventTab.RecordId].ToString().Trim(); //RecordId(字段类型:varchar,字段长度:30,是否可空:True)
 objEventTabEN.InitValue = objDT.Rows[0][conEventTab.InitValue].ToString().Trim(); //初始值(字段类型:varchar,字段长度:1000,是否可空:True)
 objEventTabEN.UpdateValue = objDT.Rows[0][conEventTab.UpdateValue].ToString().Trim(); //UpdateValue(字段类型:varchar,字段长度:1000,是否可空:True)
 objEventTabEN.UpdDate = objDT.Rows[0][conEventTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objEventTabEN.UpdTime = objDT.Rows[0][conEventTab.UpdTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:6,是否可空:True)
 objEventTabEN.UpdNameId = objDT.Rows[0][conEventTab.UpdNameId].ToString().Trim(); //UpdNameId(字段类型:varchar,字段长度:18,是否可空:True)
 objEventTabEN.OpdType = objDT.Rows[0][conEventTab.OpdType].ToString().Trim(); //OpdType(字段类型:varchar,字段长度:20,是否可空:True)
 objEventTabEN.Memo = objDT.Rows[0][conEventTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsEventTabDA: GetEventTab)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngEventId">表关键字</param>
 /// <returns>表对象</returns>
public clsEventTabEN GetObjByEventId(long lngEventId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where EventId = " + ""+ lngEventId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
 objEventTabEN.EventId = Int32.Parse(objRow[conEventTab.EventId].ToString().Trim()); //EventId(字段类型:bigint,字段长度:8,是否可空:False)
 objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName(字段类型:varchar,字段长度:30,是否可空:False)
 objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId(字段类型:varchar,字段长度:30,是否可空:True)
 objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值(字段类型:varchar,字段长度:1000,是否可空:True)
 objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue(字段类型:varchar,字段长度:1000,是否可空:True)
 objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间(字段类型:varchar,字段长度:6,是否可空:True)
 objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId(字段类型:varchar,字段长度:18,是否可空:True)
 objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType(字段类型:varchar,字段长度:20,是否可空:True)
 objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsEventTabDA: GetObjByEventId)", objException.Message));
}
return objEventTabEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsEventTabEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsEventTabDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsEventTabEN objEventTabEN = new clsEventTabEN()
{
EventId = TransNullToInt(objRow[conEventTab.EventId].ToString().Trim()), //EventId
TabName = objRow[conEventTab.TabName].ToString().Trim(), //表名
ColName = objRow[conEventTab.ColName].ToString().Trim(), //ColName
RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(), //RecordId
InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(), //初始值
UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(), //UpdateValue
UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(), //修改日期
UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(), //修改时间
UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(), //UpdNameId
OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(), //OpdType
Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim() //说明
};
objEventTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEventTabEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsEventTabDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsEventTabEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = TransNullToInt(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsEventTabDA: GetObjByDataRowEventTab)", objException.Message));
}
objEventTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEventTabEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsEventTabEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsEventTabEN objEventTabEN = new clsEventTabEN();
try
{
objEventTabEN.EventId = TransNullToInt(objRow[conEventTab.EventId].ToString().Trim()); //EventId
objEventTabEN.TabName = objRow[conEventTab.TabName].ToString().Trim(); //表名
objEventTabEN.ColName = objRow[conEventTab.ColName].ToString().Trim(); //ColName
objEventTabEN.RecordId = objRow[conEventTab.RecordId] == DBNull.Value ? null : objRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objEventTabEN.InitValue = objRow[conEventTab.InitValue] == DBNull.Value ? null : objRow[conEventTab.InitValue].ToString().Trim(); //初始值
objEventTabEN.UpdateValue = objRow[conEventTab.UpdateValue] == DBNull.Value ? null : objRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objEventTabEN.UpdDate = objRow[conEventTab.UpdDate] == DBNull.Value ? null : objRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objEventTabEN.UpdTime = objRow[conEventTab.UpdTime] == DBNull.Value ? null : objRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objEventTabEN.UpdNameId = objRow[conEventTab.UpdNameId] == DBNull.Value ? null : objRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objEventTabEN.OpdType = objRow[conEventTab.OpdType] == DBNull.Value ? null : objRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objEventTabEN.Memo = objRow[conEventTab.Memo] == DBNull.Value ? null : objRow[conEventTab.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsEventTabDA: GetObjByDataRow)", objException.Message));
}
objEventTabEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objEventTabEN;
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
objSQL = clsEventTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsEventTabEN._CurrTabName, conEventTab.EventId, 8, "");
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
objSQL = clsEventTabDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsEventTabEN._CurrTabName, conEventTab.EventId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public long GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select EventId from EventTab where " + strCondition;
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
return 0;
}
strKeyValue = objDT.Rows[0][0].ToString();
return long.Parse(strKeyValue);
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select EventId from EventTab where " + strCondition;
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
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngEventId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("EventTab", "EventId = " + ""+ lngEventId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsEventTabDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("EventTab", strCondition))
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
objSQL = clsEventTabDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("EventTab");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsEventTabEN objEventTabEN)
 {
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEventTabEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "EventTab");
objRow = objDS.Tables["EventTab"].NewRow();
objRow[conEventTab.TabName] = objEventTabEN.TabName; //表名
objRow[conEventTab.ColName] = objEventTabEN.ColName; //ColName
 if (objEventTabEN.RecordId !=  "")
 {
objRow[conEventTab.RecordId] = objEventTabEN.RecordId; //RecordId
 }
 if (objEventTabEN.InitValue !=  "")
 {
objRow[conEventTab.InitValue] = objEventTabEN.InitValue; //初始值
 }
 if (objEventTabEN.UpdateValue !=  "")
 {
objRow[conEventTab.UpdateValue] = objEventTabEN.UpdateValue; //UpdateValue
 }
 if (objEventTabEN.UpdDate !=  "")
 {
objRow[conEventTab.UpdDate] = objEventTabEN.UpdDate; //修改日期
 }
 if (objEventTabEN.UpdTime !=  "")
 {
objRow[conEventTab.UpdTime] = objEventTabEN.UpdTime; //修改时间
 }
 if (objEventTabEN.UpdNameId !=  "")
 {
objRow[conEventTab.UpdNameId] = objEventTabEN.UpdNameId; //UpdNameId
 }
 if (objEventTabEN.OpdType !=  "")
 {
objRow[conEventTab.OpdType] = objEventTabEN.OpdType; //OpdType
 }
 if (objEventTabEN.Memo !=  "")
 {
objRow[conEventTab.Memo] = objEventTabEN.Memo; //说明
 }
objDS.Tables[clsEventTabEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsEventTabEN._CurrTabName);
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsEventTabEN objEventTabEN)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEventTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEventTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.TabName);
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objEventTabEN.ColName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.ColName);
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColName + "'");
 }
 
 if (objEventTabEN.RecordId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.RecordId);
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecordId + "'");
 }
 
 if (objEventTabEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.InitValue);
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objEventTabEN.UpdateValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdateValue);
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdateValue + "'");
 }
 
 if (objEventTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdDate);
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEventTabEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdTime);
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objEventTabEN.UpdNameId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdNameId);
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdNameId + "'");
 }
 
 if (objEventTabEN.OpdType !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.OpdType);
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpdType + "'");
 }
 
 if (objEventTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.Memo);
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EventTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsEventTabEN objEventTabEN)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEventTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEventTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.TabName);
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objEventTabEN.ColName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.ColName);
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColName + "'");
 }
 
 if (objEventTabEN.RecordId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.RecordId);
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecordId + "'");
 }
 
 if (objEventTabEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.InitValue);
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objEventTabEN.UpdateValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdateValue);
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdateValue + "'");
 }
 
 if (objEventTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdDate);
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEventTabEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdTime);
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objEventTabEN.UpdNameId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdNameId);
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdNameId + "'");
 }
 
 if (objEventTabEN.OpdType !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.OpdType);
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpdType + "'");
 }
 
 if (objEventTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.Memo);
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EventTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsEventTabEN objEventTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEventTabEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEventTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.TabName);
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objEventTabEN.ColName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.ColName);
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColName + "'");
 }
 
 if (objEventTabEN.RecordId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.RecordId);
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecordId + "'");
 }
 
 if (objEventTabEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.InitValue);
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objEventTabEN.UpdateValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdateValue);
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdateValue + "'");
 }
 
 if (objEventTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdDate);
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEventTabEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdTime);
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objEventTabEN.UpdNameId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdNameId);
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdNameId + "'");
 }
 
 if (objEventTabEN.OpdType !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.OpdType);
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpdType + "'");
 }
 
 if (objEventTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.Memo);
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EventTab");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsEventTabEN objEventTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objEventTabEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objEventTabEN.TabName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.TabName);
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabName + "'");
 }
 
 if (objEventTabEN.ColName !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.ColName);
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strColName + "'");
 }
 
 if (objEventTabEN.RecordId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.RecordId);
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRecordId + "'");
 }
 
 if (objEventTabEN.InitValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.InitValue);
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strInitValue + "'");
 }
 
 if (objEventTabEN.UpdateValue !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdateValue);
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdateValue + "'");
 }
 
 if (objEventTabEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdDate);
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objEventTabEN.UpdTime !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdTime);
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdTime + "'");
 }
 
 if (objEventTabEN.UpdNameId !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.UpdNameId);
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdNameId + "'");
 }
 
 if (objEventTabEN.OpdType !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.OpdType);
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strOpdType + "'");
 }
 
 if (objEventTabEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conEventTab.Memo);
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into EventTab");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewEventTabs(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where EventId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "EventTab");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngEventId = TransNullToInt(oRow[conEventTab.EventId].ToString().Trim());
if (IsExist(lngEventId))
{
 string strResult = "关键字变量值为:" + string.Format("EventId = {0}", lngEventId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsEventTabEN._CurrTabName ].NewRow();
objRow[conEventTab.TabName] = oRow[conEventTab.TabName].ToString().Trim(); //表名
objRow[conEventTab.ColName] = oRow[conEventTab.ColName].ToString().Trim(); //ColName
objRow[conEventTab.RecordId] = oRow[conEventTab.RecordId].ToString().Trim(); //RecordId
objRow[conEventTab.InitValue] = oRow[conEventTab.InitValue].ToString().Trim(); //初始值
objRow[conEventTab.UpdateValue] = oRow[conEventTab.UpdateValue].ToString().Trim(); //UpdateValue
objRow[conEventTab.UpdDate] = oRow[conEventTab.UpdDate].ToString().Trim(); //修改日期
objRow[conEventTab.UpdTime] = oRow[conEventTab.UpdTime].ToString().Trim(); //修改时间
objRow[conEventTab.UpdNameId] = oRow[conEventTab.UpdNameId].ToString().Trim(); //UpdNameId
objRow[conEventTab.OpdType] = oRow[conEventTab.OpdType].ToString().Trim(); //OpdType
objRow[conEventTab.Memo] = oRow[conEventTab.Memo].ToString().Trim(); //说明
 objDS.Tables[clsEventTabEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsEventTabEN._CurrTabName);
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
 /// <param name = "objEventTabEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsEventTabEN objEventTabEN)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEventTabEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
strSQL = "Select * from EventTab where EventId = " + ""+ objEventTabEN.EventId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsEventTabEN._CurrTabName);
if (objDS.Tables[clsEventTabEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:EventId = " + ""+ objEventTabEN.EventId+"");
return false;
}
objRow = objDS.Tables[clsEventTabEN._CurrTabName].Rows[0];
 if (objEventTabEN.IsUpdated(conEventTab.TabName))
 {
objRow[conEventTab.TabName] = objEventTabEN.TabName; //表名
 }
 if (objEventTabEN.IsUpdated(conEventTab.ColName))
 {
objRow[conEventTab.ColName] = objEventTabEN.ColName; //ColName
 }
 if (objEventTabEN.IsUpdated(conEventTab.RecordId))
 {
objRow[conEventTab.RecordId] = objEventTabEN.RecordId; //RecordId
 }
 if (objEventTabEN.IsUpdated(conEventTab.InitValue))
 {
objRow[conEventTab.InitValue] = objEventTabEN.InitValue; //初始值
 }
 if (objEventTabEN.IsUpdated(conEventTab.UpdateValue))
 {
objRow[conEventTab.UpdateValue] = objEventTabEN.UpdateValue; //UpdateValue
 }
 if (objEventTabEN.IsUpdated(conEventTab.UpdDate))
 {
objRow[conEventTab.UpdDate] = objEventTabEN.UpdDate; //修改日期
 }
 if (objEventTabEN.IsUpdated(conEventTab.UpdTime))
 {
objRow[conEventTab.UpdTime] = objEventTabEN.UpdTime; //修改时间
 }
 if (objEventTabEN.IsUpdated(conEventTab.UpdNameId))
 {
objRow[conEventTab.UpdNameId] = objEventTabEN.UpdNameId; //UpdNameId
 }
 if (objEventTabEN.IsUpdated(conEventTab.OpdType))
 {
objRow[conEventTab.OpdType] = objEventTabEN.OpdType; //OpdType
 }
 if (objEventTabEN.IsUpdated(conEventTab.Memo))
 {
objRow[conEventTab.Memo] = objEventTabEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsEventTabEN._CurrTabName);
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsEventTabEN objEventTabEN)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEventTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update EventTab Set ");
 
 if (objEventTabEN.IsUpdated(conEventTab.TabName))
 {
 if (objEventTabEN.TabName !=  null)
 {
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conEventTab.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.TabName); //表名
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.ColName))
 {
 if (objEventTabEN.ColName !=  null)
 {
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strColName, conEventTab.ColName); //ColName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.ColName); //ColName
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.RecordId))
 {
 if (objEventTabEN.RecordId !=  null)
 {
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecordId, conEventTab.RecordId); //RecordId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.RecordId); //RecordId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.InitValue))
 {
 if (objEventTabEN.InitValue !=  null)
 {
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInitValue, conEventTab.InitValue); //初始值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.InitValue); //初始值
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdateValue))
 {
 if (objEventTabEN.UpdateValue !=  null)
 {
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdateValue, conEventTab.UpdateValue); //UpdateValue
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdateValue); //UpdateValue
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdDate))
 {
 if (objEventTabEN.UpdDate !=  null)
 {
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conEventTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdDate); //修改日期
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdTime))
 {
 if (objEventTabEN.UpdTime !=  null)
 {
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdTime, conEventTab.UpdTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdTime); //修改时间
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdNameId))
 {
 if (objEventTabEN.UpdNameId !=  null)
 {
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdNameId, conEventTab.UpdNameId); //UpdNameId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdNameId); //UpdNameId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.OpdType))
 {
 if (objEventTabEN.OpdType !=  null)
 {
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpdType, conEventTab.OpdType); //OpdType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.OpdType); //OpdType
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.Memo))
 {
 if (objEventTabEN.Memo !=  null)
 {
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conEventTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where EventId = {0}", objEventTabEN.EventId); 
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
 /// <param name = "objEventTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsEventTabEN objEventTabEN, string strCondition)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEventTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EventTab Set ");
 
 if (objEventTabEN.IsUpdated(conEventTab.TabName))
 {
 if (objEventTabEN.TabName !=  null)
 {
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.ColName))
 {
 if (objEventTabEN.ColName !=  null)
 {
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ColName = '{0}',", strColName); //ColName
 }
 else
 {
 sbSQL.Append(" ColName = null,"); //ColName
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.RecordId))
 {
 if (objEventTabEN.RecordId !=  null)
 {
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecordId = '{0}',", strRecordId); //RecordId
 }
 else
 {
 sbSQL.Append(" RecordId = null,"); //RecordId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.InitValue))
 {
 if (objEventTabEN.InitValue !=  null)
 {
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InitValue = '{0}',", strInitValue); //初始值
 }
 else
 {
 sbSQL.Append(" InitValue = null,"); //初始值
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdateValue))
 {
 if (objEventTabEN.UpdateValue !=  null)
 {
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdateValue = '{0}',", strUpdateValue); //UpdateValue
 }
 else
 {
 sbSQL.Append(" UpdateValue = null,"); //UpdateValue
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdDate))
 {
 if (objEventTabEN.UpdDate !=  null)
 {
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdTime))
 {
 if (objEventTabEN.UpdTime !=  null)
 {
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdTime = '{0}',", strUpdTime); //修改时间
 }
 else
 {
 sbSQL.Append(" UpdTime = null,"); //修改时间
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdNameId))
 {
 if (objEventTabEN.UpdNameId !=  null)
 {
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdNameId = '{0}',", strUpdNameId); //UpdNameId
 }
 else
 {
 sbSQL.Append(" UpdNameId = null,"); //UpdNameId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.OpdType))
 {
 if (objEventTabEN.OpdType !=  null)
 {
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpdType = '{0}',", strOpdType); //OpdType
 }
 else
 {
 sbSQL.Append(" OpdType = null,"); //OpdType
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.Memo))
 {
 if (objEventTabEN.Memo !=  null)
 {
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objEventTabEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsEventTabEN objEventTabEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEventTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EventTab Set ");
 
 if (objEventTabEN.IsUpdated(conEventTab.TabName))
 {
 if (objEventTabEN.TabName !=  null)
 {
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabName = '{0}',", strTabName); //表名
 }
 else
 {
 sbSQL.Append(" TabName = null,"); //表名
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.ColName))
 {
 if (objEventTabEN.ColName !=  null)
 {
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ColName = '{0}',", strColName); //ColName
 }
 else
 {
 sbSQL.Append(" ColName = null,"); //ColName
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.RecordId))
 {
 if (objEventTabEN.RecordId !=  null)
 {
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RecordId = '{0}',", strRecordId); //RecordId
 }
 else
 {
 sbSQL.Append(" RecordId = null,"); //RecordId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.InitValue))
 {
 if (objEventTabEN.InitValue !=  null)
 {
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" InitValue = '{0}',", strInitValue); //初始值
 }
 else
 {
 sbSQL.Append(" InitValue = null,"); //初始值
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdateValue))
 {
 if (objEventTabEN.UpdateValue !=  null)
 {
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdateValue = '{0}',", strUpdateValue); //UpdateValue
 }
 else
 {
 sbSQL.Append(" UpdateValue = null,"); //UpdateValue
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdDate))
 {
 if (objEventTabEN.UpdDate !=  null)
 {
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdTime))
 {
 if (objEventTabEN.UpdTime !=  null)
 {
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdTime = '{0}',", strUpdTime); //修改时间
 }
 else
 {
 sbSQL.Append(" UpdTime = null,"); //修改时间
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdNameId))
 {
 if (objEventTabEN.UpdNameId !=  null)
 {
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdNameId = '{0}',", strUpdNameId); //UpdNameId
 }
 else
 {
 sbSQL.Append(" UpdNameId = null,"); //UpdNameId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.OpdType))
 {
 if (objEventTabEN.OpdType !=  null)
 {
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" OpdType = '{0}',", strOpdType); //OpdType
 }
 else
 {
 sbSQL.Append(" OpdType = null,"); //OpdType
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.Memo))
 {
 if (objEventTabEN.Memo !=  null)
 {
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objEventTabEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsEventTabEN objEventTabEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objEventTabEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objEventTabEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objEventTabEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update EventTab Set ");
 
 if (objEventTabEN.IsUpdated(conEventTab.TabName))
 {
 if (objEventTabEN.TabName !=  null)
 {
 var strTabName = objEventTabEN.TabName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabName, conEventTab.TabName); //表名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.TabName); //表名
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.ColName))
 {
 if (objEventTabEN.ColName !=  null)
 {
 var strColName = objEventTabEN.ColName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strColName, conEventTab.ColName); //ColName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.ColName); //ColName
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.RecordId))
 {
 if (objEventTabEN.RecordId !=  null)
 {
 var strRecordId = objEventTabEN.RecordId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRecordId, conEventTab.RecordId); //RecordId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.RecordId); //RecordId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.InitValue))
 {
 if (objEventTabEN.InitValue !=  null)
 {
 var strInitValue = objEventTabEN.InitValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strInitValue, conEventTab.InitValue); //初始值
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.InitValue); //初始值
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdateValue))
 {
 if (objEventTabEN.UpdateValue !=  null)
 {
 var strUpdateValue = objEventTabEN.UpdateValue.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdateValue, conEventTab.UpdateValue); //UpdateValue
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdateValue); //UpdateValue
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdDate))
 {
 if (objEventTabEN.UpdDate !=  null)
 {
 var strUpdDate = objEventTabEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conEventTab.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdDate); //修改日期
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdTime))
 {
 if (objEventTabEN.UpdTime !=  null)
 {
 var strUpdTime = objEventTabEN.UpdTime.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdTime, conEventTab.UpdTime); //修改时间
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdTime); //修改时间
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.UpdNameId))
 {
 if (objEventTabEN.UpdNameId !=  null)
 {
 var strUpdNameId = objEventTabEN.UpdNameId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdNameId, conEventTab.UpdNameId); //UpdNameId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.UpdNameId); //UpdNameId
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.OpdType))
 {
 if (objEventTabEN.OpdType !=  null)
 {
 var strOpdType = objEventTabEN.OpdType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strOpdType, conEventTab.OpdType); //OpdType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.OpdType); //OpdType
 }
 }
 
 if (objEventTabEN.IsUpdated(conEventTab.Memo))
 {
 if (objEventTabEN.Memo !=  null)
 {
 var strMemo = objEventTabEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conEventTab.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conEventTab.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where EventId = {0}", objEventTabEN.EventId); 
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
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngEventId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngEventId,
};
 objSQL.ExecSP("EventTab_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngEventId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
//删除EventTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EventTab where EventId = " + ""+ lngEventId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelEventTab(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "" + lstKey[i].ToString() + "";
else strKeyList +=  "," + "" + lstKey[i].ToString() + "";
}
strSQL = "";
//删除EventTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EventTab where EventId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngEventId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngEventId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
//删除EventTab本表中与当前对象有关的记录
strSQL = strSQL + "Delete from EventTab where EventId = " + ""+ lngEventId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelEventTab(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsEventTabDA: DelEventTab)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from EventTab where " + strCondition ;
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
public bool DelEventTabWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsEventTabDA: DelEventTabWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsEventTabDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from EventTab where " + strCondition ;
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
 /// <param name = "objEventTabENS">源对象</param>
 /// <param name = "objEventTabENT">目标对象</param>
public void CopyTo(clsEventTabEN objEventTabENS, clsEventTabEN objEventTabENT)
{
objEventTabENT.EventId = objEventTabENS.EventId; //EventId
objEventTabENT.TabName = objEventTabENS.TabName; //表名
objEventTabENT.ColName = objEventTabENS.ColName; //ColName
objEventTabENT.RecordId = objEventTabENS.RecordId; //RecordId
objEventTabENT.InitValue = objEventTabENS.InitValue; //初始值
objEventTabENT.UpdateValue = objEventTabENS.UpdateValue; //UpdateValue
objEventTabENT.UpdDate = objEventTabENS.UpdDate; //修改日期
objEventTabENT.UpdTime = objEventTabENS.UpdTime; //修改时间
objEventTabENT.UpdNameId = objEventTabENS.UpdNameId; //UpdNameId
objEventTabENT.OpdType = objEventTabENS.OpdType; //OpdType
objEventTabENT.Memo = objEventTabENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsEventTabEN objEventTabEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objEventTabEN.TabName, conEventTab.TabName);
clsCheckSql.CheckFieldNotNull(objEventTabEN.ColName, conEventTab.ColName);
//检查字段长度
clsCheckSql.CheckFieldLen(objEventTabEN.TabName, 100, conEventTab.TabName);
clsCheckSql.CheckFieldLen(objEventTabEN.ColName, 30, conEventTab.ColName);
clsCheckSql.CheckFieldLen(objEventTabEN.RecordId, 30, conEventTab.RecordId);
clsCheckSql.CheckFieldLen(objEventTabEN.InitValue, 1000, conEventTab.InitValue);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdateValue, 1000, conEventTab.UpdateValue);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdDate, 20, conEventTab.UpdDate);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdTime, 6, conEventTab.UpdTime);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdNameId, 18, conEventTab.UpdNameId);
clsCheckSql.CheckFieldLen(objEventTabEN.OpdType, 20, conEventTab.OpdType);
clsCheckSql.CheckFieldLen(objEventTabEN.Memo, 1000, conEventTab.Memo);
//检查字段外键固定长度
 objEventTabEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsEventTabEN objEventTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objEventTabEN.TabName, 100, conEventTab.TabName);
clsCheckSql.CheckFieldLen(objEventTabEN.ColName, 30, conEventTab.ColName);
clsCheckSql.CheckFieldLen(objEventTabEN.RecordId, 30, conEventTab.RecordId);
clsCheckSql.CheckFieldLen(objEventTabEN.InitValue, 1000, conEventTab.InitValue);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdateValue, 1000, conEventTab.UpdateValue);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdDate, 20, conEventTab.UpdDate);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdTime, 6, conEventTab.UpdTime);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdNameId, 18, conEventTab.UpdNameId);
clsCheckSql.CheckFieldLen(objEventTabEN.OpdType, 20, conEventTab.OpdType);
clsCheckSql.CheckFieldLen(objEventTabEN.Memo, 1000, conEventTab.Memo);
//检查外键字段长度
 objEventTabEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsEventTabEN objEventTabEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objEventTabEN.TabName, 100, conEventTab.TabName);
clsCheckSql.CheckFieldLen(objEventTabEN.ColName, 30, conEventTab.ColName);
clsCheckSql.CheckFieldLen(objEventTabEN.RecordId, 30, conEventTab.RecordId);
clsCheckSql.CheckFieldLen(objEventTabEN.InitValue, 1000, conEventTab.InitValue);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdateValue, 1000, conEventTab.UpdateValue);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdDate, 20, conEventTab.UpdDate);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdTime, 6, conEventTab.UpdTime);
clsCheckSql.CheckFieldLen(objEventTabEN.UpdNameId, 18, conEventTab.UpdNameId);
clsCheckSql.CheckFieldLen(objEventTabEN.OpdType, 20, conEventTab.OpdType);
clsCheckSql.CheckFieldLen(objEventTabEN.Memo, 1000, conEventTab.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.TabName, conEventTab.TabName);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.ColName, conEventTab.ColName);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.RecordId, conEventTab.RecordId);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.InitValue, conEventTab.InitValue);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.UpdateValue, conEventTab.UpdateValue);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.UpdDate, conEventTab.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.UpdTime, conEventTab.UpdTime);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.UpdNameId, conEventTab.UpdNameId);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.OpdType, conEventTab.OpdType);
clsCheckSql.CheckSqlInjection4Field(objEventTabEN.Memo, conEventTab.Memo);
//检查外键字段长度
 objEventTabEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--EventTab(事件),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objEventTabEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsEventTabEN objEventTabEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabName = '{0}'", objEventTabEN.TabName);
 sbCondition.AppendFormat(" and ColName = '{0}'", objEventTabEN.ColName);
 if (objEventTabEN.OpdType == null)
{
 sbCondition.AppendFormat(" and OpdType is null");
}
else
{
 sbCondition.AppendFormat(" and OpdType = '{0}'", objEventTabEN.OpdType);
}
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsEventTabEN._CurrTabName);
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsEventTabEN._CurrTabName, strCondition);
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
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
 objSQL = clsEventTabDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}