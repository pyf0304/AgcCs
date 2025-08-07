
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvwf_StepPointRelaDA
 表名:vwf_StepPointRela(00050487)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:47:56
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:工作流管理(WorkFlow)
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
 /// v工作流与结点关系(vwf_StepPointRela)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvwf_StepPointRelaDA : clsCommBase4DA
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
 return clsvwf_StepPointRelaEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvwf_StepPointRelaEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvwf_StepPointRelaEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvwf_StepPointRelaEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvwf_StepPointRelaEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vwf_StepPointRela(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable_vwf_StepPointRela)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vwf_StepPointRela.* " + 
$"from vwf_StepPointRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vwf_StepPointRela.WorkFlowStepPointRelaId not in " + 
$"(Select top {intTop_In} vwf_StepPointRela.WorkFlowStepPointRelaId from vwf_StepPointRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1} and WorkFlowStepPointRelaId not in (Select top {2} WorkFlowStepPointRelaId from vwf_StepPointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1} and WorkFlowStepPointRelaId not in (Select top {3} WorkFlowStepPointRelaId from vwf_StepPointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vwf_StepPointRela.* " + 
$"from vwf_StepPointRela " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vwf_StepPointRela.WorkFlowStepPointRelaId not in " + 
$"(Select top {intTop_In} vwf_StepPointRela.WorkFlowStepPointRelaId from vwf_StepPointRela " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1} and WorkFlowStepPointRelaId not in (Select top {2} WorkFlowStepPointRelaId from vwf_StepPointRela where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vwf_StepPointRela where {1} and WorkFlowStepPointRelaId not in (Select top {3} WorkFlowStepPointRelaId from vwf_StepPointRela where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvwf_StepPointRelaEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA:GetObjLst)", objException.Message));
}
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = TransNullToInt(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvwf_StepPointRelaDA: GetObjLst)", objException.Message));
}
objvwf_StepPointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_StepPointRelaEN);
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
public List<clsvwf_StepPointRelaEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA:GetObjLstByTabName)", objException.Message));
}
List<clsvwf_StepPointRelaEN> arrObjLst = new List<clsvwf_StepPointRelaEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = TransNullToInt(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvwf_StepPointRelaDA: GetObjLst)", objException.Message));
}
objvwf_StepPointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvwf_StepPointRelaEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool Getvwf_StepPointRela(ref clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where WorkFlowStepPointRelaId = " + ""+ objvwf_StepPointRelaEN.WorkFlowStepPointRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = TransNullToInt(objDT.Rows[0][convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvwf_StepPointRelaEN.WorkFlowId = objDT.Rows[0][convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepPointRelaEN.WorkFlowName = objDT.Rows[0][convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepPointRelaEN.WorkFlowNameSim = objDT.Rows[0][convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_StepPointRelaEN.PrjId = objDT.Rows[0][convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepPointRelaEN.PrjName = objDT.Rows[0][convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_StepPointRelaEN.PointId = objDT.Rows[0][convwf_StepPointRela.PointId].ToString().Trim(); //结点Id(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepPointRelaEN.PointName = objDT.Rows[0][convwf_StepPointRela.PointName].ToString().Trim(); //结点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvwf_StepPointRelaEN.TabKeyId = objDT.Rows[0][convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvwf_StepPointRelaEN.PointTypeId = objDT.Rows[0][convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvwf_StepPointRelaEN.PointTypeName = objDT.Rows[0][convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepPointRelaEN.LevelNo = TransNullToInt(objDT.Rows[0][convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号(字段类型:int,字段长度:4,是否可空:True)
 objvwf_StepPointRelaEN.InDegree = TransNullToInt(objDT.Rows[0][convwf_StepPointRela.InDegree].ToString().Trim()); //入度(字段类型:int,字段长度:4,是否可空:True)
 objvwf_StepPointRelaEN.OutDegree = TransNullToInt(objDT.Rows[0][convwf_StepPointRela.OutDegree].ToString().Trim()); //出度(字段类型:int,字段长度:4,是否可空:True)
 objvwf_StepPointRelaEN.OrderNum = TransNullToInt(objDT.Rows[0][convwf_StepPointRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvwf_StepPointRelaEN.UpdDate = objDT.Rows[0][convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepPointRelaEN.UpdUser = objDT.Rows[0][convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepPointRelaEN.Memo = objDT.Rows[0][convwf_StepPointRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvwf_StepPointRelaDA: Getvwf_StepPointRela)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngWorkFlowStepPointRelaId">表关键字</param>
 /// <returns>表对象</returns>
public clsvwf_StepPointRelaEN GetObjByWorkFlowStepPointRelaId(long lngWorkFlowStepPointRelaId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where WorkFlowStepPointRelaId = " + ""+ lngWorkFlowStepPointRelaId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
 objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = Int32.Parse(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id(字段类型:bigint,字段长度:8,是否可空:False)
 objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称(字段类型:varchar,字段长度:30,是否可空:True)
 objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id(字段类型:char,字段长度:8,是否可空:False)
 objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id(字段类型:varchar,字段长度:50,是否可空:True)
 objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称(字段类型:varchar,字段长度:50,是否可空:False)
 objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号(字段类型:int,字段长度:4,是否可空:True)
 objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度(字段类型:int,字段长度:4,是否可空:True)
 objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度(字段类型:int,字段长度:4,是否可空:True)
 objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvwf_StepPointRelaDA: GetObjByWorkFlowStepPointRelaId)", objException.Message));
}
return objvwf_StepPointRelaEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvwf_StepPointRelaEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
strSQL = "Select * from vwf_StepPointRela where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN()
{
WorkFlowStepPointRelaId = TransNullToInt(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()), //工作流与结点关系Id
WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(), //工作流Id
WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(), //工作流名称
WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(), //工作流简称
PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(), //工程Id
PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(), //工程名称
PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(), //结点Id
PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(), //结点名称
TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(), //表关键字Id
PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(), //工作流结点类型Id
PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(), //工作流结点类型名称
LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()), //层序号
InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.InDegree].ToString().Trim()), //入度
OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()), //出度
OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()), //序号
UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim() //说明
};
objvwf_StepPointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepPointRelaEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvwf_StepPointRelaDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvwf_StepPointRelaEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = TransNullToInt(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvwf_StepPointRelaDA: GetObjByDataRowvwf_StepPointRela)", objException.Message));
}
objvwf_StepPointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepPointRelaEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvwf_StepPointRelaEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvwf_StepPointRelaEN objvwf_StepPointRelaEN = new clsvwf_StepPointRelaEN();
try
{
objvwf_StepPointRelaEN.WorkFlowStepPointRelaId = TransNullToInt(objRow[convwf_StepPointRela.WorkFlowStepPointRelaId].ToString().Trim()); //工作流与结点关系Id
objvwf_StepPointRelaEN.WorkFlowId = objRow[convwf_StepPointRela.WorkFlowId].ToString().Trim(); //工作流Id
objvwf_StepPointRelaEN.WorkFlowName = objRow[convwf_StepPointRela.WorkFlowName].ToString().Trim(); //工作流名称
objvwf_StepPointRelaEN.WorkFlowNameSim = objRow[convwf_StepPointRela.WorkFlowNameSim] == DBNull.Value ? null : objRow[convwf_StepPointRela.WorkFlowNameSim].ToString().Trim(); //工作流简称
objvwf_StepPointRelaEN.PrjId = objRow[convwf_StepPointRela.PrjId] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjId].ToString().Trim(); //工程Id
objvwf_StepPointRelaEN.PrjName = objRow[convwf_StepPointRela.PrjName] == DBNull.Value ? null : objRow[convwf_StepPointRela.PrjName].ToString().Trim(); //工程名称
objvwf_StepPointRelaEN.PointId = objRow[convwf_StepPointRela.PointId].ToString().Trim(); //结点Id
objvwf_StepPointRelaEN.PointName = objRow[convwf_StepPointRela.PointName].ToString().Trim(); //结点名称
objvwf_StepPointRelaEN.TabKeyId = objRow[convwf_StepPointRela.TabKeyId] == DBNull.Value ? null : objRow[convwf_StepPointRela.TabKeyId].ToString().Trim(); //表关键字Id
objvwf_StepPointRelaEN.PointTypeId = objRow[convwf_StepPointRela.PointTypeId].ToString().Trim(); //工作流结点类型Id
objvwf_StepPointRelaEN.PointTypeName = objRow[convwf_StepPointRela.PointTypeName].ToString().Trim(); //工作流结点类型名称
objvwf_StepPointRelaEN.LevelNo = objRow[convwf_StepPointRela.LevelNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.LevelNo].ToString().Trim()); //层序号
objvwf_StepPointRelaEN.InDegree = objRow[convwf_StepPointRela.InDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.InDegree].ToString().Trim()); //入度
objvwf_StepPointRelaEN.OutDegree = objRow[convwf_StepPointRela.OutDegree] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OutDegree].ToString().Trim()); //出度
objvwf_StepPointRelaEN.OrderNum = objRow[convwf_StepPointRela.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convwf_StepPointRela.OrderNum].ToString().Trim()); //序号
objvwf_StepPointRelaEN.UpdDate = objRow[convwf_StepPointRela.UpdDate] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdDate].ToString().Trim(); //修改日期
objvwf_StepPointRelaEN.UpdUser = objRow[convwf_StepPointRela.UpdUser] == DBNull.Value ? null : objRow[convwf_StepPointRela.UpdUser].ToString().Trim(); //修改者
objvwf_StepPointRelaEN.Memo = objRow[convwf_StepPointRela.Memo] == DBNull.Value ? null : objRow[convwf_StepPointRela.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvwf_StepPointRelaDA: GetObjByDataRow)", objException.Message));
}
objvwf_StepPointRelaEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvwf_StepPointRelaEN;
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
objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvwf_StepPointRelaEN._CurrTabName, convwf_StepPointRela.WorkFlowStepPointRelaId, 8, "");
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
objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvwf_StepPointRelaEN._CurrTabName, convwf_StepPointRela.WorkFlowStepPointRelaId, 8, strPrefix);
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WorkFlowStepPointRelaId from vwf_StepPointRela where " + strCondition;
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WorkFlowStepPointRelaId from vwf_StepPointRela where " + strCondition;
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
 /// <param name = "lngWorkFlowStepPointRelaId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngWorkFlowStepPointRelaId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vwf_StepPointRela", "WorkFlowStepPointRelaId = " + ""+ lngWorkFlowStepPointRelaId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvwf_StepPointRelaDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vwf_StepPointRela", strCondition))
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
objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vwf_StepPointRela");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvwf_StepPointRelaENS">源对象</param>
 /// <param name = "objvwf_StepPointRelaENT">目标对象</param>
public void CopyTo(clsvwf_StepPointRelaEN objvwf_StepPointRelaENS, clsvwf_StepPointRelaEN objvwf_StepPointRelaENT)
{
objvwf_StepPointRelaENT.WorkFlowStepPointRelaId = objvwf_StepPointRelaENS.WorkFlowStepPointRelaId; //工作流与结点关系Id
objvwf_StepPointRelaENT.WorkFlowId = objvwf_StepPointRelaENS.WorkFlowId; //工作流Id
objvwf_StepPointRelaENT.WorkFlowName = objvwf_StepPointRelaENS.WorkFlowName; //工作流名称
objvwf_StepPointRelaENT.WorkFlowNameSim = objvwf_StepPointRelaENS.WorkFlowNameSim; //工作流简称
objvwf_StepPointRelaENT.PrjId = objvwf_StepPointRelaENS.PrjId; //工程Id
objvwf_StepPointRelaENT.PrjName = objvwf_StepPointRelaENS.PrjName; //工程名称
objvwf_StepPointRelaENT.PointId = objvwf_StepPointRelaENS.PointId; //结点Id
objvwf_StepPointRelaENT.PointName = objvwf_StepPointRelaENS.PointName; //结点名称
objvwf_StepPointRelaENT.TabKeyId = objvwf_StepPointRelaENS.TabKeyId; //表关键字Id
objvwf_StepPointRelaENT.PointTypeId = objvwf_StepPointRelaENS.PointTypeId; //工作流结点类型Id
objvwf_StepPointRelaENT.PointTypeName = objvwf_StepPointRelaENS.PointTypeName; //工作流结点类型名称
objvwf_StepPointRelaENT.LevelNo = objvwf_StepPointRelaENS.LevelNo; //层序号
objvwf_StepPointRelaENT.InDegree = objvwf_StepPointRelaENS.InDegree; //入度
objvwf_StepPointRelaENT.OutDegree = objvwf_StepPointRelaENS.OutDegree; //出度
objvwf_StepPointRelaENT.OrderNum = objvwf_StepPointRelaENS.OrderNum; //序号
objvwf_StepPointRelaENT.UpdDate = objvwf_StepPointRelaENS.UpdDate; //修改日期
objvwf_StepPointRelaENT.UpdUser = objvwf_StepPointRelaENS.UpdUser; //修改者
objvwf_StepPointRelaENT.Memo = objvwf_StepPointRelaENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvwf_StepPointRelaEN objvwf_StepPointRelaEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.WorkFlowId, 4, convwf_StepPointRela.WorkFlowId);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.WorkFlowName, 50, convwf_StepPointRela.WorkFlowName);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.WorkFlowNameSim, 30, convwf_StepPointRela.WorkFlowNameSim);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.PrjId, 4, convwf_StepPointRela.PrjId);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.PrjName, 30, convwf_StepPointRela.PrjName);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.PointId, 8, convwf_StepPointRela.PointId);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.PointName, 100, convwf_StepPointRela.PointName);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.TabKeyId, 50, convwf_StepPointRela.TabKeyId);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.PointTypeId, 2, convwf_StepPointRela.PointTypeId);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.PointTypeName, 50, convwf_StepPointRela.PointTypeName);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.UpdDate, 20, convwf_StepPointRela.UpdDate);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.UpdUser, 20, convwf_StepPointRela.UpdUser);
clsCheckSql.CheckFieldLen(objvwf_StepPointRelaEN.Memo, 1000, convwf_StepPointRela.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.WorkFlowId, convwf_StepPointRela.WorkFlowId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.WorkFlowName, convwf_StepPointRela.WorkFlowName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.WorkFlowNameSim, convwf_StepPointRela.WorkFlowNameSim);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.PrjId, convwf_StepPointRela.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.PrjName, convwf_StepPointRela.PrjName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.PointId, convwf_StepPointRela.PointId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.PointName, convwf_StepPointRela.PointName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.TabKeyId, convwf_StepPointRela.TabKeyId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.PointTypeId, convwf_StepPointRela.PointTypeId);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.PointTypeName, convwf_StepPointRela.PointTypeName);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.UpdDate, convwf_StepPointRela.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.UpdUser, convwf_StepPointRela.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvwf_StepPointRelaEN.Memo, convwf_StepPointRela.Memo);
//检查外键字段长度
 objvwf_StepPointRelaEN._IsCheckProperty = true;
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvwf_StepPointRelaEN._CurrTabName);
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvwf_StepPointRelaEN._CurrTabName, strCondition);
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
 objSQL = clsvwf_StepPointRelaDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}