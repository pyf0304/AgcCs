
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsCopyTaskRegionDA
 表名:CopyTaskRegion(00050644)
 * 版本:2026.04.01.1(服务器:WIN-SRV103-116)
 日期:2026/04/05 23:41:46
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
 /// CopyTaskRegion(CopyTaskRegion)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsCopyTaskRegionDA : clsCommBase4DA
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
 return clsCopyTaskRegionEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsCopyTaskRegionEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsCopyTaskRegionEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsCopyTaskRegionEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsCopyTaskRegionEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_CopyTaskRegion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable_CopyTaskRegion)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CopyTaskRegion.* " + 
$"from CopyTaskRegion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CopyTaskRegion.RowId not in " + 
$"(Select top {intTop_In} CopyTaskRegion.RowId from CopyTaskRegion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1} and RowId not in (Select top {2} RowId from CopyTaskRegion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1} and RowId not in (Select top {3} RowId from CopyTaskRegion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} CopyTaskRegion.* " + 
$"from CopyTaskRegion " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and CopyTaskRegion.RowId not in " + 
$"(Select top {intTop_In} CopyTaskRegion.RowId from CopyTaskRegion " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1} and RowId not in (Select top {2} RowId from CopyTaskRegion where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from CopyTaskRegion where {1} and RowId not in (Select top {3} RowId from CopyTaskRegion where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsCopyTaskRegionEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA:GetObjLst)", objException.Message));
}
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = TransNullToInt(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = TransNullToInt(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = TransNullToInt(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = TransNullToDate(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCopyTaskRegionDA: GetObjLst)", objException.Message));
}
objCopyTaskRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCopyTaskRegionEN);
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
public List<clsCopyTaskRegionEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA:GetObjLstByTabName)", objException.Message));
}
List<clsCopyTaskRegionEN> arrObjLst = new List<clsCopyTaskRegionEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = TransNullToInt(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = TransNullToInt(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = TransNullToInt(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = TransNullToDate(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsCopyTaskRegionDA: GetObjLst)", objException.Message));
}
objCopyTaskRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objCopyTaskRegionEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetCopyTaskRegion(ref clsCopyTaskRegionEN objCopyTaskRegionEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where RowId = " + ""+ objCopyTaskRegionEN.RowId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objCopyTaskRegionEN.RowId = TransNullToInt(objDT.Rows[0][conCopyTaskRegion.RowId].ToString().Trim()); //RowId(字段类型:bigint,字段长度:8,是否可空:False)
 objCopyTaskRegionEN.TaskId = TransNullToInt(objDT.Rows[0][conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objCopyTaskRegionEN.SourceRegionId = objDT.Rows[0][conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId(字段类型:char,字段长度:10,是否可空:False)
 objCopyTaskRegionEN.SourceClsName = objDT.Rows[0][conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName(字段类型:varchar,字段长度:100,是否可空:False)
 objCopyTaskRegionEN.TargetRegionId = objDT.Rows[0][conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId(字段类型:char,字段长度:10,是否可空:True)
 objCopyTaskRegionEN.CopyStatus = objDT.Rows[0][conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskRegionEN.RelationStatus = objDT.Rows[0][conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskRegionEN.ErrorMessage = objDT.Rows[0][conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:50,是否可空:False)
 objCopyTaskRegionEN.StepOrder = TransNullToInt(objDT.Rows[0][conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder(字段类型:int,字段长度:4,是否可空:False)
 objCopyTaskRegionEN.UpdatedTime = TransNullToDate(objDT.Rows[0][conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsCopyTaskRegionDA: GetCopyTaskRegion)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngRowId">表关键字</param>
 /// <returns>表对象</returns>
public clsCopyTaskRegionEN GetObjByRowId(long lngRowId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where RowId = " + ""+ lngRowId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
 objCopyTaskRegionEN.RowId = Int32.Parse(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId(字段类型:bigint,字段长度:8,是否可空:False)
 objCopyTaskRegionEN.TaskId = Int32.Parse(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId(字段类型:char,字段长度:10,是否可空:False)
 objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName(字段类型:varchar,字段长度:100,是否可空:False)
 objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId(字段类型:char,字段长度:10,是否可空:True)
 objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus(字段类型:varchar,字段长度:20,是否可空:False)
 objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:50,是否可空:False)
 objCopyTaskRegionEN.StepOrder = Int32.Parse(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder(字段类型:int,字段长度:4,是否可空:False)
 objCopyTaskRegionEN.UpdatedTime = System.DateTime.Parse(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsCopyTaskRegionDA: GetObjByRowId)", objException.Message));
}
return objCopyTaskRegionEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsCopyTaskRegionEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN()
{
RowId = TransNullToInt(objRow[conCopyTaskRegion.RowId].ToString().Trim()), //RowId
TaskId = TransNullToInt(objRow[conCopyTaskRegion.TaskId].ToString().Trim()), //TaskId
SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(), //SourceRegionId
SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(), //SourceClsName
TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(), //TargetRegionId
CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(), //CopyStatus
RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(), //RelationStatus
ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(), //错误信息
StepOrder = TransNullToInt(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()), //StepOrder
UpdatedTime = TransNullToDate(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()) //UpdatedTime
};
objCopyTaskRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCopyTaskRegionEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsCopyTaskRegionDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsCopyTaskRegionEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = TransNullToInt(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = TransNullToInt(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = TransNullToInt(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = TransNullToDate(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsCopyTaskRegionDA: GetObjByDataRowCopyTaskRegion)", objException.Message));
}
objCopyTaskRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCopyTaskRegionEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsCopyTaskRegionEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsCopyTaskRegionEN objCopyTaskRegionEN = new clsCopyTaskRegionEN();
try
{
objCopyTaskRegionEN.RowId = TransNullToInt(objRow[conCopyTaskRegion.RowId].ToString().Trim()); //RowId
objCopyTaskRegionEN.TaskId = TransNullToInt(objRow[conCopyTaskRegion.TaskId].ToString().Trim()); //TaskId
objCopyTaskRegionEN.SourceRegionId = objRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objCopyTaskRegionEN.SourceClsName = objRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objCopyTaskRegionEN.TargetRegionId = objRow[conCopyTaskRegion.TargetRegionId] == DBNull.Value ? null : objRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objCopyTaskRegionEN.CopyStatus = objRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objCopyTaskRegionEN.RelationStatus = objRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objCopyTaskRegionEN.ErrorMessage = objRow[conCopyTaskRegion.ErrorMessage] == DBNull.Value ? null : objRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objCopyTaskRegionEN.StepOrder = TransNullToInt(objRow[conCopyTaskRegion.StepOrder].ToString().Trim()); //StepOrder
objCopyTaskRegionEN.UpdatedTime = TransNullToDate(objRow[conCopyTaskRegion.UpdatedTime].ToString().Trim()); //UpdatedTime
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsCopyTaskRegionDA: GetObjByDataRow)", objException.Message));
}
objCopyTaskRegionEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objCopyTaskRegionEN;
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
objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCopyTaskRegionEN._CurrTabName, conCopyTaskRegion.RowId, 8, "");
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
objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsCopyTaskRegionEN._CurrTabName, conCopyTaskRegion.RowId, 8, strPrefix);
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select RowId from CopyTaskRegion where " + strCondition;
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select RowId from CopyTaskRegion where " + strCondition;
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
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngRowId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CopyTaskRegion", "RowId = " + ""+ lngRowId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("CopyTaskRegion", strCondition))
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
objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("CopyTaskRegion");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsCopyTaskRegionEN objCopyTaskRegionEN)
 {
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskRegionEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CopyTaskRegion");
objRow = objDS.Tables["CopyTaskRegion"].NewRow();
objRow[conCopyTaskRegion.TaskId] = objCopyTaskRegionEN.TaskId; //TaskId
objRow[conCopyTaskRegion.SourceRegionId] = objCopyTaskRegionEN.SourceRegionId; //SourceRegionId
objRow[conCopyTaskRegion.SourceClsName] = objCopyTaskRegionEN.SourceClsName; //SourceClsName
 if (objCopyTaskRegionEN.TargetRegionId !=  "")
 {
objRow[conCopyTaskRegion.TargetRegionId] = objCopyTaskRegionEN.TargetRegionId; //TargetRegionId
 }
objRow[conCopyTaskRegion.CopyStatus] = objCopyTaskRegionEN.CopyStatus; //CopyStatus
objRow[conCopyTaskRegion.RelationStatus] = objCopyTaskRegionEN.RelationStatus; //RelationStatus
 if (objCopyTaskRegionEN.ErrorMessage !=  "")
 {
objRow[conCopyTaskRegion.ErrorMessage] = objCopyTaskRegionEN.ErrorMessage; //错误信息
 }
objRow[conCopyTaskRegion.StepOrder] = objCopyTaskRegionEN.StepOrder; //StepOrder
objRow[conCopyTaskRegion.UpdatedTime] = objCopyTaskRegionEN.UpdatedTime; //UpdatedTime
objDS.Tables[clsCopyTaskRegionEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsCopyTaskRegionEN._CurrTabName);
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskRegionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conCopyTaskRegion.TaskId);
 arrValueListForInsert.Add(objCopyTaskRegionEN.TaskId.ToString());
 
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceRegionId);
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceClsName);
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceClsName + "'");
 }
 
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.TargetRegionId);
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.CopyStatus);
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCopyStatus + "'");
 }
 
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.RelationStatus);
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationStatus + "'");
 }
 
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.ErrorMessage);
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTaskRegion.StepOrder);
 arrValueListForInsert.Add(objCopyTaskRegionEN.StepOrder.ToString());
 
 arrFieldListForInsert.Add(conCopyTaskRegion.UpdatedTime);
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTaskRegion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskRegionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conCopyTaskRegion.TaskId);
 arrValueListForInsert.Add(objCopyTaskRegionEN.TaskId.ToString());
 
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceRegionId);
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceClsName);
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceClsName + "'");
 }
 
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.TargetRegionId);
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.CopyStatus);
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCopyStatus + "'");
 }
 
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.RelationStatus);
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationStatus + "'");
 }
 
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.ErrorMessage);
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTaskRegion.StepOrder);
 arrValueListForInsert.Add(objCopyTaskRegionEN.StepOrder.ToString());
 
 arrFieldListForInsert.Add(conCopyTaskRegion.UpdatedTime);
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTaskRegion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsCopyTaskRegionEN objCopyTaskRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskRegionEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conCopyTaskRegion.TaskId);
 arrValueListForInsert.Add(objCopyTaskRegionEN.TaskId.ToString());
 
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceRegionId);
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceClsName);
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceClsName + "'");
 }
 
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.TargetRegionId);
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.CopyStatus);
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCopyStatus + "'");
 }
 
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.RelationStatus);
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationStatus + "'");
 }
 
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.ErrorMessage);
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTaskRegion.StepOrder);
 arrValueListForInsert.Add(objCopyTaskRegionEN.StepOrder.ToString());
 
 arrFieldListForInsert.Add(conCopyTaskRegion.UpdatedTime);
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTaskRegion");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsCopyTaskRegionEN objCopyTaskRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objCopyTaskRegionEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conCopyTaskRegion.TaskId);
 arrValueListForInsert.Add(objCopyTaskRegionEN.TaskId.ToString());
 
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceRegionId);
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.SourceClsName);
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourceClsName + "'");
 }
 
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.TargetRegionId);
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTargetRegionId + "'");
 }
 
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.CopyStatus);
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCopyStatus + "'");
 }
 
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.RelationStatus);
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strRelationStatus + "'");
 }
 
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 arrFieldListForInsert.Add(conCopyTaskRegion.ErrorMessage);
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrorMessage + "'");
 }
 
 arrFieldListForInsert.Add(conCopyTaskRegion.StepOrder);
 arrValueListForInsert.Add(objCopyTaskRegionEN.StepOrder.ToString());
 
 arrFieldListForInsert.Add(conCopyTaskRegion.UpdatedTime);
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 arrValueListForInsert.Add("'" + dteUpdatedTime + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into CopyTaskRegion");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewCopyTaskRegions(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where RowId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "CopyTaskRegion");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngRowId = TransNullToInt(oRow[conCopyTaskRegion.RowId].ToString().Trim());
if (IsExist(lngRowId))
{
 string strResult = "关键字变量值为:" + string.Format("RowId = {0}", lngRowId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsCopyTaskRegionEN._CurrTabName ].NewRow();
objRow[conCopyTaskRegion.TaskId] = oRow[conCopyTaskRegion.TaskId].ToString().Trim(); //TaskId
objRow[conCopyTaskRegion.SourceRegionId] = oRow[conCopyTaskRegion.SourceRegionId].ToString().Trim(); //SourceRegionId
objRow[conCopyTaskRegion.SourceClsName] = oRow[conCopyTaskRegion.SourceClsName].ToString().Trim(); //SourceClsName
objRow[conCopyTaskRegion.TargetRegionId] = oRow[conCopyTaskRegion.TargetRegionId].ToString().Trim(); //TargetRegionId
objRow[conCopyTaskRegion.CopyStatus] = oRow[conCopyTaskRegion.CopyStatus].ToString().Trim(); //CopyStatus
objRow[conCopyTaskRegion.RelationStatus] = oRow[conCopyTaskRegion.RelationStatus].ToString().Trim(); //RelationStatus
objRow[conCopyTaskRegion.ErrorMessage] = oRow[conCopyTaskRegion.ErrorMessage].ToString().Trim(); //错误信息
objRow[conCopyTaskRegion.StepOrder] = oRow[conCopyTaskRegion.StepOrder].ToString().Trim(); //StepOrder
objRow[conCopyTaskRegion.UpdatedTime] = oRow[conCopyTaskRegion.UpdatedTime].ToString().Trim(); //UpdatedTime
 objDS.Tables[clsCopyTaskRegionEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsCopyTaskRegionEN._CurrTabName);
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
 /// <param name = "objCopyTaskRegionEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskRegionEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
strSQL = "Select * from CopyTaskRegion where RowId = " + ""+ objCopyTaskRegionEN.RowId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsCopyTaskRegionEN._CurrTabName);
if (objDS.Tables[clsCopyTaskRegionEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:RowId = " + ""+ objCopyTaskRegionEN.RowId+"");
return false;
}
objRow = objDS.Tables[clsCopyTaskRegionEN._CurrTabName].Rows[0];
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TaskId))
 {
objRow[conCopyTaskRegion.TaskId] = objCopyTaskRegionEN.TaskId; //TaskId
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceRegionId))
 {
objRow[conCopyTaskRegion.SourceRegionId] = objCopyTaskRegionEN.SourceRegionId; //SourceRegionId
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceClsName))
 {
objRow[conCopyTaskRegion.SourceClsName] = objCopyTaskRegionEN.SourceClsName; //SourceClsName
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TargetRegionId))
 {
objRow[conCopyTaskRegion.TargetRegionId] = objCopyTaskRegionEN.TargetRegionId; //TargetRegionId
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.CopyStatus))
 {
objRow[conCopyTaskRegion.CopyStatus] = objCopyTaskRegionEN.CopyStatus; //CopyStatus
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.RelationStatus))
 {
objRow[conCopyTaskRegion.RelationStatus] = objCopyTaskRegionEN.RelationStatus; //RelationStatus
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.ErrorMessage))
 {
objRow[conCopyTaskRegion.ErrorMessage] = objCopyTaskRegionEN.ErrorMessage; //错误信息
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.StepOrder))
 {
objRow[conCopyTaskRegion.StepOrder] = objCopyTaskRegionEN.StepOrder; //StepOrder
 }
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.UpdatedTime))
 {
objRow[conCopyTaskRegion.UpdatedTime] = objCopyTaskRegionEN.UpdatedTime; //UpdatedTime
 }
try
{
objDA.Update(objDS, clsCopyTaskRegionEN._CurrTabName);
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update CopyTaskRegion Set ");
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TaskId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCopyTaskRegionEN.TaskId, conCopyTaskRegion.TaskId); //TaskId
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceRegionId))
 {
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceRegionId, conCopyTaskRegion.SourceRegionId); //SourceRegionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.SourceRegionId); //SourceRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceClsName))
 {
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceClsName, conCopyTaskRegion.SourceClsName); //SourceClsName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.SourceClsName); //SourceClsName
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TargetRegionId))
 {
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetRegionId, conCopyTaskRegion.TargetRegionId); //TargetRegionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.TargetRegionId); //TargetRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.CopyStatus))
 {
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCopyStatus, conCopyTaskRegion.CopyStatus); //CopyStatus
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.CopyStatus); //CopyStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.RelationStatus))
 {
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationStatus, conCopyTaskRegion.RelationStatus); //RelationStatus
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.RelationStatus); //RelationStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.ErrorMessage))
 {
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMessage, conCopyTaskRegion.ErrorMessage); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.ErrorMessage); //错误信息
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.StepOrder))
 {
 sbSQL.AppendFormat("{1} = {0},",objCopyTaskRegionEN.StepOrder, conCopyTaskRegion.StepOrder); //StepOrder
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.UpdatedTime))
 {
 if (objCopyTaskRegionEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 sbSQL.AppendFormat("{1} = '{0}',", dteUpdatedTime, conCopyTaskRegion.UpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.UpdatedTime); //UpdatedTime
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RowId = {0}", objCopyTaskRegionEN.RowId); 
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
 /// <param name = "objCopyTaskRegionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsCopyTaskRegionEN objCopyTaskRegionEN, string strCondition)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CopyTaskRegion Set ");
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TaskId))
 {
 sbSQL.AppendFormat(" TaskId = {0},", objCopyTaskRegionEN.TaskId); //TaskId
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceRegionId))
 {
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceRegionId = '{0}',", strSourceRegionId); //SourceRegionId
 }
 else
 {
 sbSQL.Append(" SourceRegionId = null,"); //SourceRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceClsName))
 {
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceClsName = '{0}',", strSourceClsName); //SourceClsName
 }
 else
 {
 sbSQL.Append(" SourceClsName = null,"); //SourceClsName
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TargetRegionId))
 {
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetRegionId = '{0}',", strTargetRegionId); //TargetRegionId
 }
 else
 {
 sbSQL.Append(" TargetRegionId = null,"); //TargetRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.CopyStatus))
 {
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CopyStatus = '{0}',", strCopyStatus); //CopyStatus
 }
 else
 {
 sbSQL.Append(" CopyStatus = null,"); //CopyStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.RelationStatus))
 {
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationStatus = '{0}',", strRelationStatus); //RelationStatus
 }
 else
 {
 sbSQL.Append(" RelationStatus = null,"); //RelationStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.ErrorMessage))
 {
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMessage = '{0}',", strErrorMessage); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrorMessage = null,"); //错误信息
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.StepOrder))
 {
 sbSQL.AppendFormat(" StepOrder = {0},", objCopyTaskRegionEN.StepOrder); //StepOrder
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.UpdatedTime))
 {
 if (objCopyTaskRegionEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 sbSQL.AppendFormat(" UpdatedTime = '{0}',", dteUpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.Append(" UpdatedTime = null,"); //UpdatedTime
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
 /// <param name = "objCopyTaskRegionEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsCopyTaskRegionEN objCopyTaskRegionEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CopyTaskRegion Set ");
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TaskId))
 {
 sbSQL.AppendFormat(" TaskId = {0},", objCopyTaskRegionEN.TaskId); //TaskId
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceRegionId))
 {
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceRegionId = '{0}',", strSourceRegionId); //SourceRegionId
 }
 else
 {
 sbSQL.Append(" SourceRegionId = null,"); //SourceRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceClsName))
 {
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourceClsName = '{0}',", strSourceClsName); //SourceClsName
 }
 else
 {
 sbSQL.Append(" SourceClsName = null,"); //SourceClsName
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TargetRegionId))
 {
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TargetRegionId = '{0}',", strTargetRegionId); //TargetRegionId
 }
 else
 {
 sbSQL.Append(" TargetRegionId = null,"); //TargetRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.CopyStatus))
 {
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CopyStatus = '{0}',", strCopyStatus); //CopyStatus
 }
 else
 {
 sbSQL.Append(" CopyStatus = null,"); //CopyStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.RelationStatus))
 {
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" RelationStatus = '{0}',", strRelationStatus); //RelationStatus
 }
 else
 {
 sbSQL.Append(" RelationStatus = null,"); //RelationStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.ErrorMessage))
 {
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrorMessage = '{0}',", strErrorMessage); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrorMessage = null,"); //错误信息
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.StepOrder))
 {
 sbSQL.AppendFormat(" StepOrder = {0},", objCopyTaskRegionEN.StepOrder); //StepOrder
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.UpdatedTime))
 {
 if (objCopyTaskRegionEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 sbSQL.AppendFormat(" UpdatedTime = '{0}',", dteUpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.Append(" UpdatedTime = null,"); //UpdatedTime
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
 /// <param name = "objCopyTaskRegionEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsCopyTaskRegionEN objCopyTaskRegionEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objCopyTaskRegionEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objCopyTaskRegionEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update CopyTaskRegion Set ");
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TaskId))
 {
 sbSQL.AppendFormat("{1} = {0},",objCopyTaskRegionEN.TaskId, conCopyTaskRegion.TaskId); //TaskId
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceRegionId))
 {
 if (objCopyTaskRegionEN.SourceRegionId !=  null)
 {
 var strSourceRegionId = objCopyTaskRegionEN.SourceRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceRegionId, conCopyTaskRegion.SourceRegionId); //SourceRegionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.SourceRegionId); //SourceRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.SourceClsName))
 {
 if (objCopyTaskRegionEN.SourceClsName !=  null)
 {
 var strSourceClsName = objCopyTaskRegionEN.SourceClsName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourceClsName, conCopyTaskRegion.SourceClsName); //SourceClsName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.SourceClsName); //SourceClsName
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.TargetRegionId))
 {
 if (objCopyTaskRegionEN.TargetRegionId !=  null)
 {
 var strTargetRegionId = objCopyTaskRegionEN.TargetRegionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTargetRegionId, conCopyTaskRegion.TargetRegionId); //TargetRegionId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.TargetRegionId); //TargetRegionId
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.CopyStatus))
 {
 if (objCopyTaskRegionEN.CopyStatus !=  null)
 {
 var strCopyStatus = objCopyTaskRegionEN.CopyStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCopyStatus, conCopyTaskRegion.CopyStatus); //CopyStatus
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.CopyStatus); //CopyStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.RelationStatus))
 {
 if (objCopyTaskRegionEN.RelationStatus !=  null)
 {
 var strRelationStatus = objCopyTaskRegionEN.RelationStatus.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strRelationStatus, conCopyTaskRegion.RelationStatus); //RelationStatus
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.RelationStatus); //RelationStatus
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.ErrorMessage))
 {
 if (objCopyTaskRegionEN.ErrorMessage !=  null)
 {
 var strErrorMessage = objCopyTaskRegionEN.ErrorMessage.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrorMessage, conCopyTaskRegion.ErrorMessage); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.ErrorMessage); //错误信息
 }
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.StepOrder))
 {
 sbSQL.AppendFormat("{1} = {0},",objCopyTaskRegionEN.StepOrder, conCopyTaskRegion.StepOrder); //StepOrder
 }
 
 if (objCopyTaskRegionEN.IsUpdated(conCopyTaskRegion.UpdatedTime))
 {
 if (objCopyTaskRegionEN.UpdatedTime !=  null)
 {
 var dteUpdatedTime = objCopyTaskRegionEN.UpdatedTime;
 sbSQL.AppendFormat("{1} = '{0}',", dteUpdatedTime, conCopyTaskRegion.UpdatedTime); //UpdatedTime
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conCopyTaskRegion.UpdatedTime); //UpdatedTime
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where RowId = {0}", objCopyTaskRegionEN.RowId); 
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
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngRowId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngRowId,
};
 objSQL.ExecSP("CopyTaskRegion_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngRowId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
//删除CopyTaskRegion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CopyTaskRegion where RowId = " + ""+ lngRowId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelCopyTaskRegion(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
//删除CopyTaskRegion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CopyTaskRegion where RowId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngRowId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngRowId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
//删除CopyTaskRegion本表中与当前对象有关的记录
strSQL = strSQL + "Delete from CopyTaskRegion where RowId = " + ""+ lngRowId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelCopyTaskRegion(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: DelCopyTaskRegion)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CopyTaskRegion where " + strCondition ;
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
public bool DelCopyTaskRegionWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsCopyTaskRegionDA: DelCopyTaskRegionWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from CopyTaskRegion where " + strCondition ;
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
 /// <param name = "objCopyTaskRegionENS">源对象</param>
 /// <param name = "objCopyTaskRegionENT">目标对象</param>
public void CopyTo(clsCopyTaskRegionEN objCopyTaskRegionENS, clsCopyTaskRegionEN objCopyTaskRegionENT)
{
objCopyTaskRegionENT.RowId = objCopyTaskRegionENS.RowId; //RowId
objCopyTaskRegionENT.TaskId = objCopyTaskRegionENS.TaskId; //TaskId
objCopyTaskRegionENT.SourceRegionId = objCopyTaskRegionENS.SourceRegionId; //SourceRegionId
objCopyTaskRegionENT.SourceClsName = objCopyTaskRegionENS.SourceClsName; //SourceClsName
objCopyTaskRegionENT.TargetRegionId = objCopyTaskRegionENS.TargetRegionId; //TargetRegionId
objCopyTaskRegionENT.CopyStatus = objCopyTaskRegionENS.CopyStatus; //CopyStatus
objCopyTaskRegionENT.RelationStatus = objCopyTaskRegionENS.RelationStatus; //RelationStatus
objCopyTaskRegionENT.ErrorMessage = objCopyTaskRegionENS.ErrorMessage; //错误信息
objCopyTaskRegionENT.StepOrder = objCopyTaskRegionENS.StepOrder; //StepOrder
objCopyTaskRegionENT.UpdatedTime = objCopyTaskRegionENS.UpdatedTime; //UpdatedTime
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.TaskId, conCopyTaskRegion.TaskId);
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.SourceRegionId, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.SourceClsName, conCopyTaskRegion.SourceClsName);
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.CopyStatus, conCopyTaskRegion.CopyStatus);
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.RelationStatus, conCopyTaskRegion.RelationStatus);
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.StepOrder, conCopyTaskRegion.StepOrder);
clsCheckSql.CheckFieldNotNull(objCopyTaskRegionEN.UpdatedTime, conCopyTaskRegion.UpdatedTime);
//检查字段长度
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.SourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.SourceClsName, 100, conCopyTaskRegion.SourceClsName);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.TargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.CopyStatus, 20, conCopyTaskRegion.CopyStatus);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.RelationStatus, 20, conCopyTaskRegion.RelationStatus);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.ErrorMessage, 50, conCopyTaskRegion.ErrorMessage);
//检查字段外键固定长度
 objCopyTaskRegionEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.SourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.SourceClsName, 100, conCopyTaskRegion.SourceClsName);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.TargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.CopyStatus, 20, conCopyTaskRegion.CopyStatus);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.RelationStatus, 20, conCopyTaskRegion.RelationStatus);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.ErrorMessage, 50, conCopyTaskRegion.ErrorMessage);
//检查外键字段长度
 objCopyTaskRegionEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.SourceRegionId, 10, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.SourceClsName, 100, conCopyTaskRegion.SourceClsName);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.TargetRegionId, 10, conCopyTaskRegion.TargetRegionId);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.CopyStatus, 20, conCopyTaskRegion.CopyStatus);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.RelationStatus, 20, conCopyTaskRegion.RelationStatus);
clsCheckSql.CheckFieldLen(objCopyTaskRegionEN.ErrorMessage, 50, conCopyTaskRegion.ErrorMessage);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objCopyTaskRegionEN.SourceRegionId, conCopyTaskRegion.SourceRegionId);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskRegionEN.SourceClsName, conCopyTaskRegion.SourceClsName);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskRegionEN.TargetRegionId, conCopyTaskRegion.TargetRegionId);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskRegionEN.CopyStatus, conCopyTaskRegion.CopyStatus);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskRegionEN.RelationStatus, conCopyTaskRegion.RelationStatus);
clsCheckSql.CheckSqlInjection4Field(objCopyTaskRegionEN.ErrorMessage, conCopyTaskRegion.ErrorMessage);
//检查外键字段长度
 objCopyTaskRegionEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--CopyTaskRegion(CopyTaskRegion),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objCopyTaskRegionEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsCopyTaskRegionEN objCopyTaskRegionEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and RelationStatus = '{0}'", objCopyTaskRegionEN.RelationStatus);
 sbCondition.AppendFormat(" and TaskId = '{0}'", objCopyTaskRegionEN.TaskId);
 sbCondition.AppendFormat(" and SourceRegionId = '{0}'", objCopyTaskRegionEN.SourceRegionId);
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCopyTaskRegionEN._CurrTabName);
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsCopyTaskRegionEN._CurrTabName, strCondition);
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
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
 objSQL = clsCopyTaskRegionDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}