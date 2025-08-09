
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsTabCheckStatusDA
 表名:TabCheckStatus(00050568)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:08:05
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:日志管理(LogManage)
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
 /// 表检查状态(TabCheckStatus)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsTabCheckStatusDA : clsCommBase4DA
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
 return clsTabCheckStatusEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsTabCheckStatusEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsTabCheckStatusEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsTabCheckStatusEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsTabCheckStatusEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_TabCheckStatus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable_TabCheckStatus)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabCheckStatus.* " + 
$"from TabCheckStatus " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabCheckStatus.mId not in " + 
$"(Select top {intTop_In} TabCheckStatus.mId from TabCheckStatus " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1} and mId not in (Select top {2} mId from TabCheckStatus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1} and mId not in (Select top {3} mId from TabCheckStatus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} TabCheckStatus.* " + 
$"from TabCheckStatus " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and TabCheckStatus.mId not in " + 
$"(Select top {intTop_In} TabCheckStatus.mId from TabCheckStatus " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1} and mId not in (Select top {2} mId from TabCheckStatus where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from TabCheckStatus where {1} and mId not in (Select top {3} mId from TabCheckStatus where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsTabCheckStatusEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsTabCheckStatusDA:GetObjLst)", objException.Message));
}
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = TransNullToInt(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = TransNullToBool(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = TransNullToInt(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabCheckStatusDA: GetObjLst)", objException.Message));
}
objTabCheckStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabCheckStatusEN);
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
public List<clsTabCheckStatusEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsTabCheckStatusDA:GetObjLstByTabName)", objException.Message));
}
List<clsTabCheckStatusEN> arrObjLst = new List<clsTabCheckStatusEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = TransNullToInt(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = TransNullToBool(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = TransNullToInt(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsTabCheckStatusDA: GetObjLst)", objException.Message));
}
objTabCheckStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objTabCheckStatusEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetTabCheckStatus(ref clsTabCheckStatusEN objTabCheckStatusEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where mId = " + ""+ objTabCheckStatusEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objTabCheckStatusEN.mId = TransNullToInt(objDT.Rows[0][conTabCheckStatus.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objTabCheckStatusEN.PrjId = objDT.Rows[0][conTabCheckStatus.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabCheckStatusEN.PrjDataBaseId = objDT.Rows[0][conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objTabCheckStatusEN.TabId = objDT.Rows[0][conTabCheckStatus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabCheckStatusEN.IsNeedCheckTab = TransNullToBool(objDT.Rows[0][conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段(字段类型:bit,字段长度:1,是否可空:True)
 objTabCheckStatusEN.ErrorLevelId = TransNullToInt(objDT.Rows[0][conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id(字段类型:int,字段长度:4,是否可空:False)
 objTabCheckStatusEN.ErrorMsg = objDT.Rows[0][conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:5000,是否可空:False)
 objTabCheckStatusEN.TabCheckErrorTypeId = objDT.Rows[0][conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTabCheckStatusEN.UpdDate = objDT.Rows[0][conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTabCheckStatusEN.UpdUser = objDT.Rows[0][conTabCheckStatus.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objTabCheckStatusEN.Memo = objDT.Rows[0][conTabCheckStatus.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsTabCheckStatusDA: GetTabCheckStatus)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsTabCheckStatusEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
 objTabCheckStatusEN.mId = Int32.Parse(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id(字段类型:char,字段长度:4,是否可空:False)
 objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objTabCheckStatusEN.IsNeedCheckTab = clsEntityBase2.TransNullToBool_S(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段(字段类型:bit,字段长度:1,是否可空:True)
 objTabCheckStatusEN.ErrorLevelId = Int32.Parse(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id(字段类型:int,字段长度:4,是否可空:False)
 objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:5000,是否可空:False)
 objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id(字段类型:char,字段长度:2,是否可空:False)
 objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsTabCheckStatusDA: GetObjBymId)", objException.Message));
}
return objTabCheckStatusEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsTabCheckStatusEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN()
{
mId = TransNullToInt(objRow[conTabCheckStatus.mId].ToString().Trim()), //mId
PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(), //工程Id
PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(), //项目数据库Id
TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(), //表ID
IsNeedCheckTab = TransNullToBool(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()), //是否需要检查表字段
ErrorLevelId = TransNullToInt(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()), //错误等级Id
ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(), //错误信息
TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(), //表检查错误类型Id
UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim() //说明
};
objTabCheckStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabCheckStatusEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsTabCheckStatusDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsTabCheckStatusEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = TransNullToInt(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = TransNullToBool(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = TransNullToInt(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsTabCheckStatusDA: GetObjByDataRowTabCheckStatus)", objException.Message));
}
objTabCheckStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabCheckStatusEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsTabCheckStatusEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsTabCheckStatusEN objTabCheckStatusEN = new clsTabCheckStatusEN();
try
{
objTabCheckStatusEN.mId = TransNullToInt(objRow[conTabCheckStatus.mId].ToString().Trim()); //mId
objTabCheckStatusEN.PrjId = objRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objTabCheckStatusEN.PrjDataBaseId = objRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objTabCheckStatusEN.TabId = objRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objTabCheckStatusEN.IsNeedCheckTab = TransNullToBool(objRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim()); //是否需要检查表字段
objTabCheckStatusEN.ErrorLevelId = TransNullToInt(objRow[conTabCheckStatus.ErrorLevelId].ToString().Trim()); //错误等级Id
objTabCheckStatusEN.ErrorMsg = objRow[conTabCheckStatus.ErrorMsg] == DBNull.Value ? null : objRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objTabCheckStatusEN.TabCheckErrorTypeId = objRow[conTabCheckStatus.TabCheckErrorTypeId] == DBNull.Value ? null : objRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objTabCheckStatusEN.UpdDate = objRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objTabCheckStatusEN.UpdUser = objRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objTabCheckStatusEN.Memo = objRow[conTabCheckStatus.Memo] == DBNull.Value ? null : objRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsTabCheckStatusDA: GetObjByDataRow)", objException.Message));
}
objTabCheckStatusEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objTabCheckStatusEN;
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
objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabCheckStatusEN._CurrTabName, conTabCheckStatus.mId, 8, "");
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
objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsTabCheckStatusEN._CurrTabName, conTabCheckStatus.mId, 8, strPrefix);
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from TabCheckStatus where " + strCondition;
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from TabCheckStatus where " + strCondition;
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngmId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabCheckStatus", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsTabCheckStatusDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("TabCheckStatus", strCondition))
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
objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("TabCheckStatus");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsTabCheckStatusEN objTabCheckStatusEN)
 {
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabCheckStatusEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabCheckStatus");
objRow = objDS.Tables["TabCheckStatus"].NewRow();
objRow[conTabCheckStatus.PrjId] = objTabCheckStatusEN.PrjId; //工程Id
objRow[conTabCheckStatus.PrjDataBaseId] = objTabCheckStatusEN.PrjDataBaseId; //项目数据库Id
objRow[conTabCheckStatus.TabId] = objTabCheckStatusEN.TabId; //表ID
objRow[conTabCheckStatus.IsNeedCheckTab] = objTabCheckStatusEN.IsNeedCheckTab; //是否需要检查表字段
objRow[conTabCheckStatus.ErrorLevelId] = objTabCheckStatusEN.ErrorLevelId; //错误等级Id
 if (objTabCheckStatusEN.ErrorMsg !=  "")
 {
objRow[conTabCheckStatus.ErrorMsg] = objTabCheckStatusEN.ErrorMsg; //错误信息
 }
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  "")
 {
objRow[conTabCheckStatus.TabCheckErrorTypeId] = objTabCheckStatusEN.TabCheckErrorTypeId; //表检查错误类型Id
 }
objRow[conTabCheckStatus.UpdDate] = objTabCheckStatusEN.UpdDate; //修改日期
objRow[conTabCheckStatus.UpdUser] = objTabCheckStatusEN.UpdUser; //修改者
 if (objTabCheckStatusEN.Memo !=  "")
 {
objRow[conTabCheckStatus.Memo] = objTabCheckStatusEN.Memo; //说明
 }
objDS.Tables[clsTabCheckStatusEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsTabCheckStatusEN._CurrTabName);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabCheckStatusEN objTabCheckStatusEN)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabCheckStatusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjId);
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjDataBaseId);
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objTabCheckStatusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabId);
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 arrFieldListForInsert.Add(conTabCheckStatus.IsNeedCheckTab);
 arrValueListForInsert.Add("'" + (objTabCheckStatusEN.IsNeedCheckTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorLevelId);
 arrValueListForInsert.Add(objTabCheckStatusEN.ErrorLevelId.ToString());
 
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorMsg);
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabCheckErrorTypeId);
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCheckErrorTypeId + "'");
 }
 
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdDate);
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdUser);
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabCheckStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.Memo);
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabCheckStatus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabCheckStatusEN objTabCheckStatusEN)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabCheckStatusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjId);
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjDataBaseId);
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objTabCheckStatusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabId);
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 arrFieldListForInsert.Add(conTabCheckStatus.IsNeedCheckTab);
 arrValueListForInsert.Add("'" + (objTabCheckStatusEN.IsNeedCheckTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorLevelId);
 arrValueListForInsert.Add(objTabCheckStatusEN.ErrorLevelId.ToString());
 
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorMsg);
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabCheckErrorTypeId);
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCheckErrorTypeId + "'");
 }
 
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdDate);
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdUser);
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabCheckStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.Memo);
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabCheckStatus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsTabCheckStatusEN objTabCheckStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabCheckStatusEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjId);
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjDataBaseId);
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objTabCheckStatusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabId);
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 arrFieldListForInsert.Add(conTabCheckStatus.IsNeedCheckTab);
 arrValueListForInsert.Add("'" + (objTabCheckStatusEN.IsNeedCheckTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorLevelId);
 arrValueListForInsert.Add(objTabCheckStatusEN.ErrorLevelId.ToString());
 
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorMsg);
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabCheckErrorTypeId);
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCheckErrorTypeId + "'");
 }
 
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdDate);
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdUser);
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabCheckStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.Memo);
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabCheckStatus");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsTabCheckStatusEN objTabCheckStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objTabCheckStatusEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjId);
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.PrjDataBaseId);
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjDataBaseId + "'");
 }
 
 if (objTabCheckStatusEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabId);
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 arrFieldListForInsert.Add(conTabCheckStatus.IsNeedCheckTab);
 arrValueListForInsert.Add("'" + (objTabCheckStatusEN.IsNeedCheckTab  ==  false ? "0" : "1") + "'");
 
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorLevelId);
 arrValueListForInsert.Add(objTabCheckStatusEN.ErrorLevelId.ToString());
 
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.ErrorMsg);
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMsg + "'");
 }
 
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.TabCheckErrorTypeId);
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabCheckErrorTypeId + "'");
 }
 
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdDate);
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.UpdUser);
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objTabCheckStatusEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conTabCheckStatus.Memo);
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into TabCheckStatus");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewTabCheckStatuss(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "TabCheckStatus");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conTabCheckStatus.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsTabCheckStatusEN._CurrTabName ].NewRow();
objRow[conTabCheckStatus.PrjId] = oRow[conTabCheckStatus.PrjId].ToString().Trim(); //工程Id
objRow[conTabCheckStatus.PrjDataBaseId] = oRow[conTabCheckStatus.PrjDataBaseId].ToString().Trim(); //项目数据库Id
objRow[conTabCheckStatus.TabId] = oRow[conTabCheckStatus.TabId].ToString().Trim(); //表ID
objRow[conTabCheckStatus.IsNeedCheckTab] = oRow[conTabCheckStatus.IsNeedCheckTab].ToString().Trim(); //是否需要检查表字段
objRow[conTabCheckStatus.ErrorLevelId] = oRow[conTabCheckStatus.ErrorLevelId].ToString().Trim(); //错误等级Id
objRow[conTabCheckStatus.ErrorMsg] = oRow[conTabCheckStatus.ErrorMsg].ToString().Trim(); //错误信息
objRow[conTabCheckStatus.TabCheckErrorTypeId] = oRow[conTabCheckStatus.TabCheckErrorTypeId].ToString().Trim(); //表检查错误类型Id
objRow[conTabCheckStatus.UpdDate] = oRow[conTabCheckStatus.UpdDate].ToString().Trim(); //修改日期
objRow[conTabCheckStatus.UpdUser] = oRow[conTabCheckStatus.UpdUser].ToString().Trim(); //修改者
objRow[conTabCheckStatus.Memo] = oRow[conTabCheckStatus.Memo].ToString().Trim(); //说明
 objDS.Tables[clsTabCheckStatusEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsTabCheckStatusEN._CurrTabName);
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
 /// <param name = "objTabCheckStatusEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsTabCheckStatusEN objTabCheckStatusEN)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabCheckStatusEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
strSQL = "Select * from TabCheckStatus where mId = " + ""+ objTabCheckStatusEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsTabCheckStatusEN._CurrTabName);
if (objDS.Tables[clsTabCheckStatusEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objTabCheckStatusEN.mId+"");
return false;
}
objRow = objDS.Tables[clsTabCheckStatusEN._CurrTabName].Rows[0];
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjId))
 {
objRow[conTabCheckStatus.PrjId] = objTabCheckStatusEN.PrjId; //工程Id
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjDataBaseId))
 {
objRow[conTabCheckStatus.PrjDataBaseId] = objTabCheckStatusEN.PrjDataBaseId; //项目数据库Id
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabId))
 {
objRow[conTabCheckStatus.TabId] = objTabCheckStatusEN.TabId; //表ID
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.IsNeedCheckTab))
 {
objRow[conTabCheckStatus.IsNeedCheckTab] = objTabCheckStatusEN.IsNeedCheckTab; //是否需要检查表字段
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorLevelId))
 {
objRow[conTabCheckStatus.ErrorLevelId] = objTabCheckStatusEN.ErrorLevelId; //错误等级Id
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorMsg))
 {
objRow[conTabCheckStatus.ErrorMsg] = objTabCheckStatusEN.ErrorMsg; //错误信息
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId))
 {
objRow[conTabCheckStatus.TabCheckErrorTypeId] = objTabCheckStatusEN.TabCheckErrorTypeId; //表检查错误类型Id
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdDate))
 {
objRow[conTabCheckStatus.UpdDate] = objTabCheckStatusEN.UpdDate; //修改日期
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdUser))
 {
objRow[conTabCheckStatus.UpdUser] = objTabCheckStatusEN.UpdUser; //修改者
 }
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.Memo))
 {
objRow[conTabCheckStatus.Memo] = objTabCheckStatusEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsTabCheckStatusEN._CurrTabName);
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabCheckStatusEN objTabCheckStatusEN)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabCheckStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update TabCheckStatus Set ");
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjId))
 {
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabCheckStatus.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.PrjId); //工程Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjDataBaseId))
 {
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDataBaseId, conTabCheckStatus.PrjDataBaseId); //项目数据库Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.PrjDataBaseId); //项目数据库Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabId))
 {
 if (objTabCheckStatusEN.TabId !=  null)
 {
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabCheckStatus.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.TabId); //表ID
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.IsNeedCheckTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabCheckStatusEN.IsNeedCheckTab == true?"1":"0", conTabCheckStatus.IsNeedCheckTab); //是否需要检查表字段
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorLevelId))
 {
 sbSQL.AppendFormat("{1} = {0},",objTabCheckStatusEN.ErrorLevelId, conTabCheckStatus.ErrorLevelId); //错误等级Id
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorMsg))
 {
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMsg, conTabCheckStatus.ErrorMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.ErrorMsg); //错误信息
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId))
 {
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCheckErrorTypeId, conTabCheckStatus.TabCheckErrorTypeId); //表检查错误类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.TabCheckErrorTypeId); //表检查错误类型Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdDate))
 {
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTabCheckStatus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.UpdDate); //修改日期
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdUser))
 {
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTabCheckStatus.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.UpdUser); //修改者
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.Memo))
 {
 if (objTabCheckStatusEN.Memo !=  null)
 {
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabCheckStatus.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objTabCheckStatusEN.mId); 
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
 /// <param name = "objTabCheckStatusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsTabCheckStatusEN objTabCheckStatusEN, string strCondition)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabCheckStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabCheckStatus Set ");
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjId))
 {
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjDataBaseId))
 {
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDataBaseId = '{0}',", strPrjDataBaseId); //项目数据库Id
 }
 else
 {
 sbSQL.Append(" PrjDataBaseId = null,"); //项目数据库Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabId))
 {
 if (objTabCheckStatusEN.TabId !=  null)
 {
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.IsNeedCheckTab))
 {
 sbSQL.AppendFormat(" IsNeedCheckTab = '{0}',", objTabCheckStatusEN.IsNeedCheckTab == true?"1":"0"); //是否需要检查表字段
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorLevelId))
 {
 sbSQL.AppendFormat(" ErrorLevelId = {0},", objTabCheckStatusEN.ErrorLevelId); //错误等级Id
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorMsg))
 {
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMsg = '{0}',", strErrorMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrorMsg = null,"); //错误信息
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId))
 {
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCheckErrorTypeId = '{0}',", strTabCheckErrorTypeId); //表检查错误类型Id
 }
 else
 {
 sbSQL.Append(" TabCheckErrorTypeId = null,"); //表检查错误类型Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdDate))
 {
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdUser))
 {
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.Memo))
 {
 if (objTabCheckStatusEN.Memo !=  null)
 {
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabCheckStatusEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsTabCheckStatusEN objTabCheckStatusEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabCheckStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabCheckStatus Set ");
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjId))
 {
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjDataBaseId))
 {
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjDataBaseId = '{0}',", strPrjDataBaseId); //项目数据库Id
 }
 else
 {
 sbSQL.Append(" PrjDataBaseId = null,"); //项目数据库Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabId))
 {
 if (objTabCheckStatusEN.TabId !=  null)
 {
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.IsNeedCheckTab))
 {
 sbSQL.AppendFormat(" IsNeedCheckTab = '{0}',", objTabCheckStatusEN.IsNeedCheckTab == true?"1":"0"); //是否需要检查表字段
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorLevelId))
 {
 sbSQL.AppendFormat(" ErrorLevelId = {0},", objTabCheckStatusEN.ErrorLevelId); //错误等级Id
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorMsg))
 {
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMsg = '{0}',", strErrorMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrorMsg = null,"); //错误信息
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId))
 {
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabCheckErrorTypeId = '{0}',", strTabCheckErrorTypeId); //表检查错误类型Id
 }
 else
 {
 sbSQL.Append(" TabCheckErrorTypeId = null,"); //表检查错误类型Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdDate))
 {
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdUser))
 {
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.Memo))
 {
 if (objTabCheckStatusEN.Memo !=  null)
 {
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objTabCheckStatusEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsTabCheckStatusEN objTabCheckStatusEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objTabCheckStatusEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objTabCheckStatusEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objTabCheckStatusEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update TabCheckStatus Set ");
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjId))
 {
 if (objTabCheckStatusEN.PrjId !=  null)
 {
 var strPrjId = objTabCheckStatusEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conTabCheckStatus.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.PrjId); //工程Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.PrjDataBaseId))
 {
 if (objTabCheckStatusEN.PrjDataBaseId !=  null)
 {
 var strPrjDataBaseId = objTabCheckStatusEN.PrjDataBaseId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjDataBaseId, conTabCheckStatus.PrjDataBaseId); //项目数据库Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.PrjDataBaseId); //项目数据库Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabId))
 {
 if (objTabCheckStatusEN.TabId !=  null)
 {
 var strTabId = objTabCheckStatusEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conTabCheckStatus.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.TabId); //表ID
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.IsNeedCheckTab))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objTabCheckStatusEN.IsNeedCheckTab == true?"1":"0", conTabCheckStatus.IsNeedCheckTab); //是否需要检查表字段
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorLevelId))
 {
 sbSQL.AppendFormat("{1} = {0},",objTabCheckStatusEN.ErrorLevelId, conTabCheckStatus.ErrorLevelId); //错误等级Id
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.ErrorMsg))
 {
 if (objTabCheckStatusEN.ErrorMsg !=  null)
 {
 var strErrorMsg = objTabCheckStatusEN.ErrorMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMsg, conTabCheckStatus.ErrorMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.ErrorMsg); //错误信息
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.TabCheckErrorTypeId))
 {
 if (objTabCheckStatusEN.TabCheckErrorTypeId !=  null)
 {
 var strTabCheckErrorTypeId = objTabCheckStatusEN.TabCheckErrorTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabCheckErrorTypeId, conTabCheckStatus.TabCheckErrorTypeId); //表检查错误类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.TabCheckErrorTypeId); //表检查错误类型Id
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdDate))
 {
 if (objTabCheckStatusEN.UpdDate !=  null)
 {
 var strUpdDate = objTabCheckStatusEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conTabCheckStatus.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.UpdDate); //修改日期
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.UpdUser))
 {
 if (objTabCheckStatusEN.UpdUser !=  null)
 {
 var strUpdUser = objTabCheckStatusEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conTabCheckStatus.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.UpdUser); //修改者
 }
 }
 
 if (objTabCheckStatusEN.IsUpdated(conTabCheckStatus.Memo))
 {
 if (objTabCheckStatusEN.Memo !=  null)
 {
 var strMemo = objTabCheckStatusEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conTabCheckStatus.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conTabCheckStatus.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objTabCheckStatusEN.mId); 
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
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngmId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("TabCheckStatus_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngmId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
//删除TabCheckStatus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabCheckStatus where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelTabCheckStatus(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
//删除TabCheckStatus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabCheckStatus where mId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngmId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngmId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
//删除TabCheckStatus本表中与当前对象有关的记录
strSQL = strSQL + "Delete from TabCheckStatus where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelTabCheckStatus(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: DelTabCheckStatus)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabCheckStatus where " + strCondition ;
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
public bool DelTabCheckStatusWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsTabCheckStatusDA: DelTabCheckStatusWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from TabCheckStatus where " + strCondition ;
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
 /// <param name = "objTabCheckStatusENS">源对象</param>
 /// <param name = "objTabCheckStatusENT">目标对象</param>
public void CopyTo(clsTabCheckStatusEN objTabCheckStatusENS, clsTabCheckStatusEN objTabCheckStatusENT)
{
objTabCheckStatusENT.mId = objTabCheckStatusENS.mId; //mId
objTabCheckStatusENT.PrjId = objTabCheckStatusENS.PrjId; //工程Id
objTabCheckStatusENT.PrjDataBaseId = objTabCheckStatusENS.PrjDataBaseId; //项目数据库Id
objTabCheckStatusENT.TabId = objTabCheckStatusENS.TabId; //表ID
objTabCheckStatusENT.IsNeedCheckTab = objTabCheckStatusENS.IsNeedCheckTab; //是否需要检查表字段
objTabCheckStatusENT.ErrorLevelId = objTabCheckStatusENS.ErrorLevelId; //错误等级Id
objTabCheckStatusENT.ErrorMsg = objTabCheckStatusENS.ErrorMsg; //错误信息
objTabCheckStatusENT.TabCheckErrorTypeId = objTabCheckStatusENS.TabCheckErrorTypeId; //表检查错误类型Id
objTabCheckStatusENT.UpdDate = objTabCheckStatusENS.UpdDate; //修改日期
objTabCheckStatusENT.UpdUser = objTabCheckStatusENS.UpdUser; //修改者
objTabCheckStatusENT.Memo = objTabCheckStatusENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsTabCheckStatusEN objTabCheckStatusEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.PrjId, conTabCheckStatus.PrjId);
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.PrjDataBaseId, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.TabId, conTabCheckStatus.TabId);
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.IsNeedCheckTab, conTabCheckStatus.IsNeedCheckTab);
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.ErrorLevelId, conTabCheckStatus.ErrorLevelId);
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.UpdDate, conTabCheckStatus.UpdDate);
clsCheckSql.CheckFieldNotNull(objTabCheckStatusEN.UpdUser, conTabCheckStatus.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.PrjId, 4, conTabCheckStatus.PrjId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.PrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.TabId, 8, conTabCheckStatus.TabId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.ErrorMsg, 5000, conTabCheckStatus.ErrorMsg);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.TabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.UpdDate, 20, conTabCheckStatus.UpdDate);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.UpdUser, 20, conTabCheckStatus.UpdUser);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.Memo, 1000, conTabCheckStatus.Memo);
//检查字段外键固定长度
 objTabCheckStatusEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsTabCheckStatusEN objTabCheckStatusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.PrjId, 4, conTabCheckStatus.PrjId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.PrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.TabId, 8, conTabCheckStatus.TabId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.ErrorMsg, 5000, conTabCheckStatus.ErrorMsg);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.TabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.UpdDate, 20, conTabCheckStatus.UpdDate);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.UpdUser, 20, conTabCheckStatus.UpdUser);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.Memo, 1000, conTabCheckStatus.Memo);
//检查外键字段长度
 objTabCheckStatusEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsTabCheckStatusEN objTabCheckStatusEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.PrjId, 4, conTabCheckStatus.PrjId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.PrjDataBaseId, 4, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.TabId, 8, conTabCheckStatus.TabId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.ErrorMsg, 5000, conTabCheckStatus.ErrorMsg);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.TabCheckErrorTypeId, 2, conTabCheckStatus.TabCheckErrorTypeId);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.UpdDate, 20, conTabCheckStatus.UpdDate);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.UpdUser, 20, conTabCheckStatus.UpdUser);
clsCheckSql.CheckFieldLen(objTabCheckStatusEN.Memo, 1000, conTabCheckStatus.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.PrjId, conTabCheckStatus.PrjId);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.PrjDataBaseId, conTabCheckStatus.PrjDataBaseId);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.TabId, conTabCheckStatus.TabId);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.ErrorMsg, conTabCheckStatus.ErrorMsg);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.TabCheckErrorTypeId, conTabCheckStatus.TabCheckErrorTypeId);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.UpdDate, conTabCheckStatus.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.UpdUser, conTabCheckStatus.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objTabCheckStatusEN.Memo, conTabCheckStatus.Memo);
//检查外键字段长度
 objTabCheckStatusEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--TabCheckStatus(表检查状态),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objTabCheckStatusEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsTabCheckStatusEN objTabCheckStatusEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and PrjId = '{0}'", objTabCheckStatusEN.PrjId);
 sbCondition.AppendFormat(" and PrjDataBaseId = '{0}'", objTabCheckStatusEN.PrjDataBaseId);
 sbCondition.AppendFormat(" and TabId = '{0}'", objTabCheckStatusEN.TabId);
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabCheckStatusEN._CurrTabName);
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsTabCheckStatusEN._CurrTabName, strCondition);
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
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
 objSQL = clsTabCheckStatusDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}