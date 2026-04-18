
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskDA
 表名:CopyTask(00050643)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:20:25
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
 /// CopyTask(CopyTask)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCopyTaskDA : clsCommBase4DA
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
 return clsCopyTaskEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCopyTaskEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCopyTaskEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCopyTaskEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCopyTaskEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CopyTask(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable_CopyTask)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CopyTask where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CopyTask where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CopyTask where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CopyTask.* " + 
$"from CopyTask " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CopyTask.TaskId not in " + 
$"(Select top {intTop_In} CopyTask.TaskId from CopyTask " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CopyTask where {1} and TaskId not in (Select top {2} TaskId from CopyTask where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CopyTask where {1} and TaskId not in (Select top {3} TaskId from CopyTask where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCopyTaskDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CopyTask.* " + 
$"from CopyTask " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CopyTask.TaskId not in " + 
$"(Select top {intTop_In} CopyTask.TaskId from CopyTask " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CopyTask where {1} and TaskId not in (Select top {2} TaskId from CopyTask where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CopyTask where {1} and TaskId not in (Select top {3} TaskId from CopyTask where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCopyTaskEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCopyTaskDA:GetObjLst)", objException.Message));
}
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = TransNullToInt(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = TransNullToDate(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = TransNullToDate(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCopyTaskDA: GetObjLst)", objException.Message));
}
objCopyTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCopyTaskEN);
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
public List<clsCopyTaskEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCopyTaskDA:GetObjLstByTabName)", objException.Message));
}
List<clsCopyTaskEN> arrObjLst = new List<clsCopyTaskEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = TransNullToInt(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = TransNullToDate(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = TransNullToDate(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCopyTaskDA: GetObjLst)", objException.Message));
}
objCopyTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCopyTaskEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCopyTask(ref clsCopyTaskEN objCopyTaskEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where TaskId = " + ""+ objCopyTaskEN.TaskId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCopyTaskEN.TaskId = TransNullToInt(objDT.Rows[0][conCopyTask.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objCopyTaskEN.SourcePrjId = objDT.Rows[0][conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId(字段类型:char,字段长度:4,是否可空:False)
 objCopyTaskEN.TargetPrjId = objDT.Rows[0][conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId(字段类型:char,字段长度:4,是否可空:False)
 objCopyTaskEN.SourceViewId = objDT.Rows[0][conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId(字段类型:char,字段长度:8,是否可空:False)
 objCopyTaskEN.TargetViewId = objDT.Rows[0][conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId(字段类型:char,字段长度:8,是否可空:True)
 objCopyTaskEN.ConflictStrategy = objDT.Rows[0][conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskEN.Status = objDT.Rows[0][conCopyTask.Status].ToString().Trim(); //Status(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskEN.CurrentStep = objDT.Rows[0][conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep(字段类型:varchar,字段长度:30,是否可空:False)
 objCopyTaskEN.ErrorMessage = objDT.Rows[0][conCopyTask.ErrorMessage].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:50,是否可空:False)
 objCopyTaskEN.CreatedBy = objDT.Rows[0][conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy(字段类型:varchar,字段长度:50,是否可空:False)
 objCopyTaskEN.CreatedTime = TransNullToDate(objDT.Rows[0][conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime(字段类型:datetime,字段长度:16,是否可空:False)
 objCopyTaskEN.UpdatedTime = TransNullToDate(objDT.Rows[0][conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime(字段类型:datetime,字段长度:16,是否可空:False)
 objCopyTaskEN.TargetViewName = objDT.Rows[0][conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCopyTaskDA: GetCopyTask)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngTaskId">表关键字</param>
 /// <returns>表对象</returns>
public clsCopyTaskEN GetObjByTaskId(long lngTaskId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where TaskId = " + ""+ lngTaskId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
 objCopyTaskEN.TaskId = Int32.Parse(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId(字段类型:char,字段长度:4,是否可空:False)
 objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId(字段类型:char,字段长度:4,是否可空:False)
 objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId(字段类型:char,字段长度:8,是否可空:False)
 objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId(字段类型:char,字段长度:8,是否可空:True)
 objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep(字段类型:varchar,字段长度:30,是否可空:False)
 objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:50,是否可空:False)
 objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy(字段类型:varchar,字段长度:50,是否可空:False)
 objCopyTaskEN.CreatedTime = System.DateTime.Parse(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime(字段类型:datetime,字段长度:16,是否可空:False)
 objCopyTaskEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime(字段类型:datetime,字段长度:16,是否可空:False)
 objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCopyTaskDA: GetObjByTaskId)", objException.Message));
}
return objCopyTaskEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCopyTaskEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCopyTaskDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN()
{
TaskId = TransNullToInt(objRow[conCopyTask.TaskId].ToString().Trim()), //TaskId
SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(), //SourcePrjId
TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(), //TargetPrjId
SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(), //SourceViewId
TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(), //TargetViewId
ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(), //ConflictStrategy
Status = objRow[conCopyTask.Status].ToString().Trim(), //Status
CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(), //CurrentStep
ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(), //错误信息
CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(), //CreatedBy
CreatedTime = TransNullToDate(objRow[conCopyTask.CreatedTime].ToString().Trim()), //CreatedTime
UpdatedTime = TransNullToDate(objRow[conCopyTask.UpdatedTime].ToString().Trim()), //UpdatedTime
TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim() //TargetViewName
};
objCopyTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCopyTaskEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCopyTaskDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCopyTaskEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = TransNullToInt(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = TransNullToDate(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = TransNullToDate(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCopyTaskDA: GetObjByDataRowCopyTask)", objException.Message));
}
objCopyTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCopyTaskEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCopyTaskEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCopyTaskEN objCopyTaskEN = new clsCopyTaskEN();
try
{
objCopyTaskEN.TaskId = TransNullToInt(objRow[conCopyTask.TaskId].ToString().Trim()); //TaskId
objCopyTaskEN.SourcePrjId = objRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objCopyTaskEN.TargetPrjId = objRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objCopyTaskEN.SourceViewId = objRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objCopyTaskEN.TargetViewId = objRow[conCopyTask.TargetViewId] == DBNull.Value ? null : objRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objCopyTaskEN.ConflictStrategy = objRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objCopyTaskEN.Status = objRow[conCopyTask.Status].ToString().Trim(); //Status
objCopyTaskEN.CurrentStep = objRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objCopyTaskEN.ErrorMessage = objRow[conCopyTask.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskEN.CreatedBy = objRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objCopyTaskEN.CreatedTime = TransNullToDate(objRow[conCopyTask.CreatedTime].ToString().Trim()); //CreatedTime
objCopyTaskEN.UpdatedTime = TransNullToDate(objRow[conCopyTask.UpdatedTime].ToString().Trim()); //UpdatedTime
objCopyTaskEN.TargetViewName = objRow[conCopyTask.TargetViewName] == DBNull.Value ? null : objRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCopyTaskDA: GetObjByDataRow)", objException.Message));
}
objCopyTaskEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCopyTaskEN;
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
objSQL = clsCopyTaskDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCopyTaskEN._CurrTabName, conCopyTask.TaskId, 8, "");
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
objSQL = clsCopyTaskDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCopyTaskEN._CurrTabName, conCopyTask.TaskId, 8, strPrefix);
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select TaskId from CopyTask where " + strCondition;
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select TaskId from CopyTask where " + strCondition;
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngTaskId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CopyTask", "TaskId = " + ""+ lngTaskId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCopyTaskDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CopyTask", strCondition))
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
objSQL = clsCopyTaskDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CopyTask");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCopyTaskEN objCopyTaskEN)
 {
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CopyTask");
objRow = objDS.Tables["CopyTask"].NewRow();
objRow[conCopyTask.SourcePrjId] = objCopyTaskEN.SourcePrjId; //SourcePrjId
objRow[conCopyTask.TargetPrjId] = objCopyTaskEN.TargetPrjId; //TargetPrjId
objRow[conCopyTask.SourceViewId] = objCopyTaskEN.SourceViewId; //SourceViewId
 if (objCopyTaskEN.TargetViewId !=  "")
 {
objRow[conCopyTask.TargetViewId] = objCopyTaskEN.TargetViewId; //TargetViewId
 }
objRow[conCopyTask.ConflictStrategy] = objCopyTaskEN.ConflictStrategy; //ConflictStrategy
objRow[conCopyTask.Status] = objCopyTaskEN.Status; //Status
objRow[conCopyTask.CurrentStep] = objCopyTaskEN.CurrentStep; //CurrentStep
 if (objCopyTaskEN.ErrorMessage !=  "")
 {
objRow[conCopyTask.ErrorMessage] = objCopyTaskEN.ErrorMessage; //错误信息
 }
objRow[conCopyTask.CreatedBy] = objCopyTaskEN.CreatedBy; //CreatedBy
objRow[conCopyTask.CreatedTime] = objCopyTaskEN.CreatedTime; //CreatedTime
objRow[conCopyTask.UpdatedTime] = objCopyTaskEN.UpdatedTime; //UpdatedTime
 if (objCopyTaskEN.TargetViewName !=  "")
 {
objRow[conCopyTask.TargetViewName] = objCopyTaskEN.TargetViewName; //TargetViewName
 }
objDS.Tables[clsCopyTaskEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCopyTaskEN._CurrTabName);
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourcePrjId);
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePrjId + "'");
 }
 
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetPrjId);
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetPrjId + "'");
 }
 
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourceViewId);
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceViewId + "'");
 }
 
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewId);
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewId + "'");
 }
 
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ConflictStrategy);
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConflictStrategy + "'");
 }
 
 if (objCopyTaskEN.Status !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.Status);
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CurrentStep);
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrentStep + "'");
 }
 
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ErrorMessage);
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CreatedBy);
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreatedBy + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTask.CreatedTime);
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 arrValueListForInsert.Add("'" + dteCreatedTime + "'");
 
 arrFieldListForInsert.Add(conCopyTask.UpdatedTime);
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewName);
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTask");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourcePrjId);
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePrjId + "'");
 }
 
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetPrjId);
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetPrjId + "'");
 }
 
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourceViewId);
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceViewId + "'");
 }
 
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewId);
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewId + "'");
 }
 
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ConflictStrategy);
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConflictStrategy + "'");
 }
 
 if (objCopyTaskEN.Status !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.Status);
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CurrentStep);
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrentStep + "'");
 }
 
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ErrorMessage);
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CreatedBy);
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreatedBy + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTask.CreatedTime);
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 arrValueListForInsert.Add("'" + dteCreatedTime + "'");
 
 arrFieldListForInsert.Add(conCopyTask.UpdatedTime);
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewName);
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTask");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCopyTaskEN objCopyTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourcePrjId);
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePrjId + "'");
 }
 
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetPrjId);
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetPrjId + "'");
 }
 
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourceViewId);
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceViewId + "'");
 }
 
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewId);
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewId + "'");
 }
 
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ConflictStrategy);
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConflictStrategy + "'");
 }
 
 if (objCopyTaskEN.Status !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.Status);
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CurrentStep);
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrentStep + "'");
 }
 
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ErrorMessage);
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CreatedBy);
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreatedBy + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTask.CreatedTime);
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 arrValueListForInsert.Add("'" + dteCreatedTime + "'");
 
 arrFieldListForInsert.Add(conCopyTask.UpdatedTime);
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewName);
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTask");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCopyTaskEN objCopyTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourcePrjId);
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePrjId + "'");
 }
 
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetPrjId);
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetPrjId + "'");
 }
 
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.SourceViewId);
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceViewId + "'");
 }
 
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewId);
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewId + "'");
 }
 
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ConflictStrategy);
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strConflictStrategy + "'");
 }
 
 if (objCopyTaskEN.Status !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.Status);
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strStatus + "'");
 }
 
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CurrentStep);
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCurrentStep + "'");
 }
 
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.ErrorMessage);
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.CreatedBy);
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCreatedBy + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTask.CreatedTime);
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 arrValueListForInsert.Add("'" + dteCreatedTime + "'");
 
 arrFieldListForInsert.Add(conCopyTask.UpdatedTime);
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTask.TargetViewName);
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetViewName + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTask");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCopyTasks(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where TaskId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CopyTask");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngTaskId = TransNullToInt(oRow[conCopyTask.TaskId].ToString().Trim());
if (IsExist(lngTaskId))
{
 string strResult = "关键字变量值为:" + string.Format("TaskId = {0}", lngTaskId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCopyTaskEN._CurrTabName ].NewRow();
objRow[conCopyTask.SourcePrjId] = oRow[conCopyTask.SourcePrjId].ToString().Trim(); //SourcePrjId
objRow[conCopyTask.TargetPrjId] = oRow[conCopyTask.TargetPrjId].ToString().Trim(); //TargetPrjId
objRow[conCopyTask.SourceViewId] = oRow[conCopyTask.SourceViewId].ToString().Trim(); //SourceViewId
objRow[conCopyTask.TargetViewId] = oRow[conCopyTask.TargetViewId].ToString().Trim(); //TargetViewId
objRow[conCopyTask.ConflictStrategy] = oRow[conCopyTask.ConflictStrategy].ToString().Trim(); //ConflictStrategy
objRow[conCopyTask.Status] = oRow[conCopyTask.Status].ToString().Trim(); //Status
objRow[conCopyTask.CurrentStep] = oRow[conCopyTask.CurrentStep].ToString().Trim(); //CurrentStep
objRow[conCopyTask.ErrorMessage] = oRow[conCopyTask.ErrorMessage].ToString().Trim(); //错误信息
objRow[conCopyTask.CreatedBy] = oRow[conCopyTask.CreatedBy].ToString().Trim(); //CreatedBy
objRow[conCopyTask.CreatedTime] = oRow[conCopyTask.CreatedTime].ToString().Trim(); //CreatedTime
objRow[conCopyTask.UpdatedTime] = oRow[conCopyTask.UpdatedTime].ToString().Trim(); //UpdatedTime
objRow[conCopyTask.TargetViewName] = oRow[conCopyTask.TargetViewName].ToString().Trim(); //TargetViewName
 objDS.Tables[clsCopyTaskEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCopyTaskEN._CurrTabName);
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
 /// <param name = "objCopyTaskEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
strSQL = "Select * from CopyTask where TaskId = " + ""+ objCopyTaskEN.TaskId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCopyTaskEN._CurrTabName);
if (objDS.Tables[clsCopyTaskEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:TaskId = " + ""+ objCopyTaskEN.TaskId+"");
return false;
}
objRow = objDS.Tables[clsCopyTaskEN._CurrTabName].Rows[0];
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourcePrjId))
 {
objRow[conCopyTask.SourcePrjId] = objCopyTaskEN.SourcePrjId; //SourcePrjId
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetPrjId))
 {
objRow[conCopyTask.TargetPrjId] = objCopyTaskEN.TargetPrjId; //TargetPrjId
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourceViewId))
 {
objRow[conCopyTask.SourceViewId] = objCopyTaskEN.SourceViewId; //SourceViewId
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewId))
 {
objRow[conCopyTask.TargetViewId] = objCopyTaskEN.TargetViewId; //TargetViewId
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.ConflictStrategy))
 {
objRow[conCopyTask.ConflictStrategy] = objCopyTaskEN.ConflictStrategy; //ConflictStrategy
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.Status))
 {
objRow[conCopyTask.Status] = objCopyTaskEN.Status; //Status
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.CurrentStep))
 {
objRow[conCopyTask.CurrentStep] = objCopyTaskEN.CurrentStep; //CurrentStep
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.ErrorMessage))
 {
objRow[conCopyTask.ErrorMessage] = objCopyTaskEN.ErrorMessage; //错误信息
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedBy))
 {
objRow[conCopyTask.CreatedBy] = objCopyTaskEN.CreatedBy; //CreatedBy
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedTime))
 {
objRow[conCopyTask.CreatedTime] = objCopyTaskEN.CreatedTime; //CreatedTime
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.UpdatedTime))
 {
objRow[conCopyTask.UpdatedTime] = objCopyTaskEN.UpdatedTime; //UpdatedTime
 }
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewName))
 {
objRow[conCopyTask.TargetViewName] = objCopyTaskEN.TargetViewName; //TargetViewName
 }
try
{
objDA.Update(objDS, clsCopyTaskEN._CurrTabName);
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCopyTaskEN objCopyTaskEN)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CopyTask Set ");
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourcePrjId))
 {
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourcePrjId, conCopyTask.SourcePrjId); //SourcePrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.SourcePrjId); //SourcePrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetPrjId))
 {
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetPrjId, conCopyTask.TargetPrjId); //TargetPrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.TargetPrjId); //TargetPrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourceViewId))
 {
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceViewId, conCopyTask.SourceViewId); //SourceViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.SourceViewId); //SourceViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewId))
 {
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetViewId, conCopyTask.TargetViewId); //TargetViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.TargetViewId); //TargetViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ConflictStrategy))
 {
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConflictStrategy, conCopyTask.ConflictStrategy); //ConflictStrategy
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.ConflictStrategy); //ConflictStrategy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.Status))
 {
 if (objCopyTaskEN.Status !=  null)
 {
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatus, conCopyTask.Status); //Status
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.Status); //Status
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CurrentStep))
 {
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrentStep, conCopyTask.CurrentStep); //CurrentStep
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.CurrentStep); //CurrentStep
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ErrorMessage))
 {
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMessage, conCopyTask.ErrorMessage); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.ErrorMessage); //错误信息
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedBy))
 {
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreatedBy, conCopyTask.CreatedBy); //CreatedBy
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.CreatedBy); //CreatedBy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedTime))
 {
 if (objCopyTaskEN.CreatedTime !=  null)
 {
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedTime, conCopyTask.CreatedTime); //CreatedTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.CreatedTime); //CreatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.UpdatedTime))
 {
 if (objCopyTaskEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 sbSQL.AppendFormat("{1} = '{0}',", dteUpdatedTime, conCopyTask.UpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.UpdatedTime); //UpdatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewName))
 {
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetViewName, conCopyTask.TargetViewName); //TargetViewName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.TargetViewName); //TargetViewName
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TaskId = {0}", objCopyTaskEN.TaskId); 
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
 /// <param name = "objCopyTaskEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCopyTaskEN objCopyTaskEN, string strCondition)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CopyTask Set ");
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourcePrjId))
 {
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourcePrjId = '{0}',", strSourcePrjId); //SourcePrjId
 }
 else
 {
 sbSQL.Append(" SourcePrjId = null,"); //SourcePrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetPrjId))
 {
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetPrjId = '{0}',", strTargetPrjId); //TargetPrjId
 }
 else
 {
 sbSQL.Append(" TargetPrjId = null,"); //TargetPrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourceViewId))
 {
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceViewId = '{0}',", strSourceViewId); //SourceViewId
 }
 else
 {
 sbSQL.Append(" SourceViewId = null,"); //SourceViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewId))
 {
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetViewId = '{0}',", strTargetViewId); //TargetViewId
 }
 else
 {
 sbSQL.Append(" TargetViewId = null,"); //TargetViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ConflictStrategy))
 {
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConflictStrategy = '{0}',", strConflictStrategy); //ConflictStrategy
 }
 else
 {
 sbSQL.Append(" ConflictStrategy = null,"); //ConflictStrategy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.Status))
 {
 if (objCopyTaskEN.Status !=  null)
 {
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Status = '{0}',", strStatus); //Status
 }
 else
 {
 sbSQL.Append(" Status = null,"); //Status
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CurrentStep))
 {
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrentStep = '{0}',", strCurrentStep); //CurrentStep
 }
 else
 {
 sbSQL.Append(" CurrentStep = null,"); //CurrentStep
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ErrorMessage))
 {
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMessage = '{0}',", strErrorMessage); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrorMessage = null,"); //错误信息
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedBy))
 {
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreatedBy = '{0}',", strCreatedBy); //CreatedBy
 }
 else
 {
 sbSQL.Append(" CreatedBy = null,"); //CreatedBy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedTime))
 {
 if (objCopyTaskEN.CreatedTime !=  null)
 {
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 sbSQL.AppendFormat(" CreatedTime = '{0}',", dteCreatedTime); //CreatedTime
 }
 else
 {
 sbSQL.Append(" CreatedTime = null,"); //CreatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.UpdatedTime))
 {
 if (objCopyTaskEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 sbSQL.AppendFormat(" UpdatedTime = '{0}',", dteUpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.Append(" UpdatedTime = null,"); //UpdatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewName))
 {
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetViewName = '{0}',", strTargetViewName); //TargetViewName
 }
 else
 {
 sbSQL.Append(" TargetViewName = null,"); //TargetViewName
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
 /// <param name = "objCopyTaskEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCopyTaskEN objCopyTaskEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CopyTask Set ");
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourcePrjId))
 {
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourcePrjId = '{0}',", strSourcePrjId); //SourcePrjId
 }
 else
 {
 sbSQL.Append(" SourcePrjId = null,"); //SourcePrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetPrjId))
 {
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetPrjId = '{0}',", strTargetPrjId); //TargetPrjId
 }
 else
 {
 sbSQL.Append(" TargetPrjId = null,"); //TargetPrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourceViewId))
 {
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceViewId = '{0}',", strSourceViewId); //SourceViewId
 }
 else
 {
 sbSQL.Append(" SourceViewId = null,"); //SourceViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewId))
 {
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetViewId = '{0}',", strTargetViewId); //TargetViewId
 }
 else
 {
 sbSQL.Append(" TargetViewId = null,"); //TargetViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ConflictStrategy))
 {
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ConflictStrategy = '{0}',", strConflictStrategy); //ConflictStrategy
 }
 else
 {
 sbSQL.Append(" ConflictStrategy = null,"); //ConflictStrategy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.Status))
 {
 if (objCopyTaskEN.Status !=  null)
 {
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Status = '{0}',", strStatus); //Status
 }
 else
 {
 sbSQL.Append(" Status = null,"); //Status
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CurrentStep))
 {
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CurrentStep = '{0}',", strCurrentStep); //CurrentStep
 }
 else
 {
 sbSQL.Append(" CurrentStep = null,"); //CurrentStep
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ErrorMessage))
 {
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMessage = '{0}',", strErrorMessage); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrorMessage = null,"); //错误信息
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedBy))
 {
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CreatedBy = '{0}',", strCreatedBy); //CreatedBy
 }
 else
 {
 sbSQL.Append(" CreatedBy = null,"); //CreatedBy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedTime))
 {
 if (objCopyTaskEN.CreatedTime !=  null)
 {
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 sbSQL.AppendFormat(" CreatedTime = '{0}',", dteCreatedTime); //CreatedTime
 }
 else
 {
 sbSQL.Append(" CreatedTime = null,"); //CreatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.UpdatedTime))
 {
 if (objCopyTaskEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 sbSQL.AppendFormat(" UpdatedTime = '{0}',", dteUpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.Append(" UpdatedTime = null,"); //UpdatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewName))
 {
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetViewName = '{0}',", strTargetViewName); //TargetViewName
 }
 else
 {
 sbSQL.Append(" TargetViewName = null,"); //TargetViewName
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
 /// <param name = "objCopyTaskEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCopyTaskEN objCopyTaskEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCopyTaskEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CopyTask Set ");
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourcePrjId))
 {
 if (objCopyTaskEN.SourcePrjId !=  null)
 {
 var strSourcePrjId = objCopyTaskEN.SourcePrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourcePrjId, conCopyTask.SourcePrjId); //SourcePrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.SourcePrjId); //SourcePrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetPrjId))
 {
 if (objCopyTaskEN.TargetPrjId !=  null)
 {
 var strTargetPrjId = objCopyTaskEN.TargetPrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetPrjId, conCopyTask.TargetPrjId); //TargetPrjId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.TargetPrjId); //TargetPrjId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.SourceViewId))
 {
 if (objCopyTaskEN.SourceViewId !=  null)
 {
 var strSourceViewId = objCopyTaskEN.SourceViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceViewId, conCopyTask.SourceViewId); //SourceViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.SourceViewId); //SourceViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewId))
 {
 if (objCopyTaskEN.TargetViewId !=  null)
 {
 var strTargetViewId = objCopyTaskEN.TargetViewId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetViewId, conCopyTask.TargetViewId); //TargetViewId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.TargetViewId); //TargetViewId
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ConflictStrategy))
 {
 if (objCopyTaskEN.ConflictStrategy !=  null)
 {
 var strConflictStrategy = objCopyTaskEN.ConflictStrategy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strConflictStrategy, conCopyTask.ConflictStrategy); //ConflictStrategy
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.ConflictStrategy); //ConflictStrategy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.Status))
 {
 if (objCopyTaskEN.Status !=  null)
 {
 var strStatus = objCopyTaskEN.Status.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strStatus, conCopyTask.Status); //Status
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.Status); //Status
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CurrentStep))
 {
 if (objCopyTaskEN.CurrentStep !=  null)
 {
 var strCurrentStep = objCopyTaskEN.CurrentStep.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCurrentStep, conCopyTask.CurrentStep); //CurrentStep
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.CurrentStep); //CurrentStep
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.ErrorMessage))
 {
 if (objCopyTaskEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMessage, conCopyTask.ErrorMessage); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.ErrorMessage); //错误信息
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedBy))
 {
 if (objCopyTaskEN.CreatedBy !=  null)
 {
 var strCreatedBy = objCopyTaskEN.CreatedBy.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCreatedBy, conCopyTask.CreatedBy); //CreatedBy
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.CreatedBy); //CreatedBy
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.CreatedTime))
 {
 if (objCopyTaskEN.CreatedTime !=  null)
 {
 var dteCreatedTime = objCopyTaskEN.CreatedTime;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedTime, conCopyTask.CreatedTime); //CreatedTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.CreatedTime); //CreatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.UpdatedTime))
 {
 if (objCopyTaskEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskEN.UpdatedTime;
 sbSQL.AppendFormat("{1} = '{0}',", dteUpdatedTime, conCopyTask.UpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.UpdatedTime); //UpdatedTime
 }
 }
 
 if (objCopyTaskEN.IsUpdated(conCopyTask.TargetViewName))
 {
 if (objCopyTaskEN.TargetViewName !=  null)
 {
 var strTargetViewName = objCopyTaskEN.TargetViewName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetViewName, conCopyTask.TargetViewName); //TargetViewName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTask.TargetViewName); //TargetViewName
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where TaskId = {0}", objCopyTaskEN.TaskId); 
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
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngTaskId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngTaskId,
};
 objSQL.ExecSP("CopyTask_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngTaskId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
//删除CopyTask本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CopyTask where TaskId = " + ""+ lngTaskId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCopyTask(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
//删除CopyTask本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CopyTask where TaskId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngTaskId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngTaskId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
//删除CopyTask本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CopyTask where TaskId = " + ""+ lngTaskId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCopyTask(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCopyTaskDA: DelCopyTask)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CopyTask where " + strCondition ;
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
public bool DelCopyTaskWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCopyTaskDA: DelCopyTaskWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CopyTask where " + strCondition ;
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
 /// <param name = "objCopyTaskENS">源对象</param>
 /// <param name = "objCopyTaskENT">目标对象</param>
public void CopyTo(clsCopyTaskEN objCopyTaskENS, clsCopyTaskEN objCopyTaskENT)
{
objCopyTaskENT.TaskId = objCopyTaskENS.TaskId; //TaskId
objCopyTaskENT.SourcePrjId = objCopyTaskENS.SourcePrjId; //SourcePrjId
objCopyTaskENT.TargetPrjId = objCopyTaskENS.TargetPrjId; //TargetPrjId
objCopyTaskENT.SourceViewId = objCopyTaskENS.SourceViewId; //SourceViewId
objCopyTaskENT.TargetViewId = objCopyTaskENS.TargetViewId; //TargetViewId
objCopyTaskENT.ConflictStrategy = objCopyTaskENS.ConflictStrategy; //ConflictStrategy
objCopyTaskENT.Status = objCopyTaskENS.Status; //Status
objCopyTaskENT.CurrentStep = objCopyTaskENS.CurrentStep; //CurrentStep
objCopyTaskENT.ErrorMessage = objCopyTaskENS.ErrorMessage; //错误信息
objCopyTaskENT.CreatedBy = objCopyTaskENS.CreatedBy; //CreatedBy
objCopyTaskENT.CreatedTime = objCopyTaskENS.CreatedTime; //CreatedTime
objCopyTaskENT.UpdatedTime = objCopyTaskENS.UpdatedTime; //UpdatedTime
objCopyTaskENT.TargetViewName = objCopyTaskENS.TargetViewName; //TargetViewName
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCopyTaskEN objCopyTaskEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.SourcePrjId, conCopyTask.SourcePrjId);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.TargetPrjId, conCopyTask.TargetPrjId);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.SourceViewId, conCopyTask.SourceViewId);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.ConflictStrategy, conCopyTask.ConflictStrategy);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.Status, conCopyTask.Status);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.CurrentStep, conCopyTask.CurrentStep);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.CreatedBy, conCopyTask.CreatedBy);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.CreatedTime, conCopyTask.CreatedTime);
clsCheckSql.CheckFieldNotNull(objCopyTaskEN.UpdatedTime, conCopyTask.UpdatedTime);
//检查字段长度
clsCheckSql.CheckFieldLen(objCopyTaskEN.SourcePrjId, 4, conCopyTask.SourcePrjId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetPrjId, 4, conCopyTask.TargetPrjId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.SourceViewId, 8, conCopyTask.SourceViewId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetViewId, 8, conCopyTask.TargetViewId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.ConflictStrategy, 20, conCopyTask.ConflictStrategy);
clsCheckSql.CheckFieldLen(objCopyTaskEN.Status, 20, conCopyTask.Status);
clsCheckSql.CheckFieldLen(objCopyTaskEN.CurrentStep, 30, conCopyTask.CurrentStep);
clsCheckSql.CheckFieldLen(objCopyTaskEN.ErrorMessage, 50, conCopyTask.ErrorMessage);
clsCheckSql.CheckFieldLen(objCopyTaskEN.CreatedBy, 50, conCopyTask.CreatedBy);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetViewName, 50, conCopyTask.TargetViewName);
//检查字段外键固定长度
 objCopyTaskEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCopyTaskEN objCopyTaskEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCopyTaskEN.SourcePrjId, 4, conCopyTask.SourcePrjId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetPrjId, 4, conCopyTask.TargetPrjId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.SourceViewId, 8, conCopyTask.SourceViewId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetViewId, 8, conCopyTask.TargetViewId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.ConflictStrategy, 20, conCopyTask.ConflictStrategy);
clsCheckSql.CheckFieldLen(objCopyTaskEN.Status, 20, conCopyTask.Status);
clsCheckSql.CheckFieldLen(objCopyTaskEN.CurrentStep, 30, conCopyTask.CurrentStep);
clsCheckSql.CheckFieldLen(objCopyTaskEN.ErrorMessage, 50, conCopyTask.ErrorMessage);
clsCheckSql.CheckFieldLen(objCopyTaskEN.CreatedBy, 50, conCopyTask.CreatedBy);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetViewName, 50, conCopyTask.TargetViewName);
//检查外键字段长度
 objCopyTaskEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCopyTaskEN objCopyTaskEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCopyTaskEN.SourcePrjId, 4, conCopyTask.SourcePrjId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetPrjId, 4, conCopyTask.TargetPrjId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.SourceViewId, 8, conCopyTask.SourceViewId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetViewId, 8, conCopyTask.TargetViewId);
clsCheckSql.CheckFieldLen(objCopyTaskEN.ConflictStrategy, 20, conCopyTask.ConflictStrategy);
clsCheckSql.CheckFieldLen(objCopyTaskEN.Status, 20, conCopyTask.Status);
clsCheckSql.CheckFieldLen(objCopyTaskEN.CurrentStep, 30, conCopyTask.CurrentStep);
clsCheckSql.CheckFieldLen(objCopyTaskEN.ErrorMessage, 50, conCopyTask.ErrorMessage);
clsCheckSql.CheckFieldLen(objCopyTaskEN.CreatedBy, 50, conCopyTask.CreatedBy);
clsCheckSql.CheckFieldLen(objCopyTaskEN.TargetViewName, 50, conCopyTask.TargetViewName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.SourcePrjId, conCopyTask.SourcePrjId);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.TargetPrjId, conCopyTask.TargetPrjId);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.SourceViewId, conCopyTask.SourceViewId);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.TargetViewId, conCopyTask.TargetViewId);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.ConflictStrategy, conCopyTask.ConflictStrategy);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.Status, conCopyTask.Status);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.CurrentStep, conCopyTask.CurrentStep);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.ErrorMessage, conCopyTask.ErrorMessage);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.CreatedBy, conCopyTask.CreatedBy);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskEN.TargetViewName, conCopyTask.TargetViewName);
//检查外键字段长度
 objCopyTaskEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CopyTask(CopyTask),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCopyTaskEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCopyTaskEN objCopyTaskEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and SourceViewId = '{0}'", objCopyTaskEN.SourceViewId);
 sbCondition.AppendFormat(" and TargetPrjId = '{0}'", objCopyTaskEN.TargetPrjId);
 sbCondition.AppendFormat(" and Status = '{0}'", objCopyTaskEN.Status);
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCopyTaskEN._CurrTabName);
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCopyTaskEN._CurrTabName, strCondition);
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
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
 objSQL = clsCopyTaskDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}