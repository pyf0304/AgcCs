
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNode_SimDA
 表名:vDataNode_Sim(00050592)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:26:51
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:AI模块(AIModule)
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
 /// vDataNode_Sim(vDataNode_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDataNode_SimDA : clsCommBase4DA
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
 return clsvDataNode_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDataNode_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataNode_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDataNode_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDataNode_SimEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDataNode_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable_vDataNode_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDataNode_Sim.* " + 
$"from vDataNode_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDataNode_Sim.DataNodeId not in " + 
$"(Select top {intTop_In} vDataNode_Sim.DataNodeId from vDataNode_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1} and DataNodeId not in (Select top {2} DataNodeId from vDataNode_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1} and DataNodeId not in (Select top {3} DataNodeId from vDataNode_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDataNode_Sim.* " + 
$"from vDataNode_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDataNode_Sim.DataNodeId not in " + 
$"(Select top {intTop_In} vDataNode_Sim.DataNodeId from vDataNode_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1} and DataNodeId not in (Select top {2} DataNodeId from vDataNode_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNode_Sim where {1} and DataNodeId not in (Select top {3} DataNodeId from vDataNode_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDataNode_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDataNode_SimDA:GetObjLst)", objException.Message));
}
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = TransNullToInt(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataNode_SimDA: GetObjLst)", objException.Message));
}
objvDataNode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataNode_SimEN);
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
public List<clsvDataNode_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDataNode_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDataNode_SimEN> arrObjLst = new List<clsvDataNode_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = TransNullToInt(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataNode_SimDA: GetObjLst)", objException.Message));
}
objvDataNode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataNode_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDataNode_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDataNode_Sim(ref clsvDataNode_SimEN objvDataNode_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where DataNodeId = " + ""+ objvDataNode_SimEN.DataNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDataNode_SimEN.DataNodeId = TransNullToInt(objDT.Rows[0][convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDataNode_SimEN.DataNodeName = objDT.Rows[0][convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNode_SimEN.TabId = objDT.Rows[0][convDataNode_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDataNode_SimEN.FldId = objDT.Rows[0][convDataNode_Sim.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataNode_SimEN.KeyFldLst = objDT.Rows[0][convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNode_SimEN.DataNodeTypeId = objDT.Rows[0][convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNode_SimEN.VersionNo = TransNullToInt(objDT.Rows[0][convDataNode_Sim.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvDataNode_SimEN.PrjId = objDT.Rows[0][convDataNode_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataNode_SimEN.PosX = TransNullToDouble(objDT.Rows[0][convDataNode_Sim.PosX].ToString().Trim()); //位置X(字段类型:decimal,字段长度:7,是否可空:True)
 objvDataNode_SimEN.PosY = TransNullToDouble(objDT.Rows[0][convDataNode_Sim.PosY].ToString().Trim()); //位置Y(字段类型:decimal,字段长度:7,是否可空:True)
 objvDataNode_SimEN.UsedTimes = TransNullToInt(objDT.Rows[0][convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDataNode_SimDA: GetvDataNode_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDataNode_SimEN GetObjByDataNodeId(long lngDataNodeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where DataNodeId = " + ""+ lngDataNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
 objvDataNode_SimEN.DataNodeId = Int32.Parse(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X(字段类型:decimal,字段长度:7,是否可空:True)
 objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y(字段类型:decimal,字段长度:7,是否可空:True)
 objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDataNode_SimDA: GetObjByDataNodeId)", objException.Message));
}
return objvDataNode_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDataNode_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDataNode_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN()
{
DataNodeId = TransNullToInt(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()), //数据结点Id
DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(), //数据结点名
TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(), //表ID
FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(), //字段Id
KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(), //关键字段Id列表
DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(), //数据结点类型Id
VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.VersionNo].ToString().Trim()), //版本号
PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(), //工程Id
PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosX].ToString().Trim()), //位置X
PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosY].ToString().Trim()), //位置Y
UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()) //使用次数
};
objvDataNode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNode_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDataNode_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDataNode_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = TransNullToInt(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDataNode_SimDA: GetObjByDataRowvDataNode_Sim)", objException.Message));
}
objvDataNode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNode_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDataNode_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataNode_SimEN objvDataNode_SimEN = new clsvDataNode_SimEN();
try
{
objvDataNode_SimEN.DataNodeId = TransNullToInt(objRow[convDataNode_Sim.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNode_SimEN.DataNodeName = objRow[convDataNode_Sim.DataNodeName] == DBNull.Value ? null : objRow[convDataNode_Sim.DataNodeName].ToString().Trim(); //数据结点名
objvDataNode_SimEN.TabId = objRow[convDataNode_Sim.TabId].ToString().Trim(); //表ID
objvDataNode_SimEN.FldId = objRow[convDataNode_Sim.FldId].ToString().Trim(); //字段Id
objvDataNode_SimEN.KeyFldLst = objRow[convDataNode_Sim.KeyFldLst] == DBNull.Value ? null : objRow[convDataNode_Sim.KeyFldLst].ToString().Trim(); //关键字段Id列表
objvDataNode_SimEN.DataNodeTypeId = objRow[convDataNode_Sim.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNode_SimEN.VersionNo = objRow[convDataNode_Sim.VersionNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.VersionNo].ToString().Trim()); //版本号
objvDataNode_SimEN.PrjId = objRow[convDataNode_Sim.PrjId].ToString().Trim(); //工程Id
objvDataNode_SimEN.PosX = objRow[convDataNode_Sim.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosX].ToString().Trim()); //位置X
objvDataNode_SimEN.PosY = objRow[convDataNode_Sim.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[convDataNode_Sim.PosY].ToString().Trim()); //位置Y
objvDataNode_SimEN.UsedTimes = objRow[convDataNode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDataNode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDataNode_SimDA: GetObjByDataRow)", objException.Message));
}
objvDataNode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNode_SimEN;
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
objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataNode_SimEN._CurrTabName, convDataNode_Sim.DataNodeId, 8, "");
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
objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataNode_SimEN._CurrTabName, convDataNode_Sim.DataNodeId, 8, strPrefix);
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DataNodeId from vDataNode_Sim where " + strCondition;
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DataNodeId from vDataNode_Sim where " + strCondition;
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
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngDataNodeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataNode_Sim", "DataNodeId = " + ""+ lngDataNodeId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDataNode_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataNode_Sim", strCondition))
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
objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDataNode_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDataNode_SimENS">源对象</param>
 /// <param name = "objvDataNode_SimENT">目标对象</param>
public void CopyTo(clsvDataNode_SimEN objvDataNode_SimENS, clsvDataNode_SimEN objvDataNode_SimENT)
{
objvDataNode_SimENT.DataNodeId = objvDataNode_SimENS.DataNodeId; //数据结点Id
objvDataNode_SimENT.DataNodeName = objvDataNode_SimENS.DataNodeName; //数据结点名
objvDataNode_SimENT.TabId = objvDataNode_SimENS.TabId; //表ID
objvDataNode_SimENT.FldId = objvDataNode_SimENS.FldId; //字段Id
objvDataNode_SimENT.KeyFldLst = objvDataNode_SimENS.KeyFldLst; //关键字段Id列表
objvDataNode_SimENT.DataNodeTypeId = objvDataNode_SimENS.DataNodeTypeId; //数据结点类型Id
objvDataNode_SimENT.VersionNo = objvDataNode_SimENS.VersionNo; //版本号
objvDataNode_SimENT.PrjId = objvDataNode_SimENS.PrjId; //工程Id
objvDataNode_SimENT.PosX = objvDataNode_SimENS.PosX; //位置X
objvDataNode_SimENT.PosY = objvDataNode_SimENS.PosY; //位置Y
objvDataNode_SimENT.UsedTimes = objvDataNode_SimENS.UsedTimes; //使用次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDataNode_SimEN objvDataNode_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDataNode_SimEN.DataNodeName, 100, convDataNode_Sim.DataNodeName);
clsCheckSql.CheckFieldLen(objvDataNode_SimEN.TabId, 8, convDataNode_Sim.TabId);
clsCheckSql.CheckFieldLen(objvDataNode_SimEN.FldId, 8, convDataNode_Sim.FldId);
clsCheckSql.CheckFieldLen(objvDataNode_SimEN.KeyFldLst, 100, convDataNode_Sim.KeyFldLst);
clsCheckSql.CheckFieldLen(objvDataNode_SimEN.DataNodeTypeId, 2, convDataNode_Sim.DataNodeTypeId);
clsCheckSql.CheckFieldLen(objvDataNode_SimEN.PrjId, 4, convDataNode_Sim.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDataNode_SimEN.DataNodeName, convDataNode_Sim.DataNodeName);
clsCheckSql.CheckSqlInjection4Field(objvDataNode_SimEN.TabId, convDataNode_Sim.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDataNode_SimEN.FldId, convDataNode_Sim.FldId);
clsCheckSql.CheckSqlInjection4Field(objvDataNode_SimEN.KeyFldLst, convDataNode_Sim.KeyFldLst);
clsCheckSql.CheckSqlInjection4Field(objvDataNode_SimEN.DataNodeTypeId, convDataNode_Sim.DataNodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDataNode_SimEN.PrjId, convDataNode_Sim.PrjId);
//检查外键字段长度
 objvDataNode_SimEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetDataNodeId()
{
//获取某学院所有专业信息
string strSQL = "select DataNodeId, DataNodeName from vDataNode_Sim ";
 clsSpecSQLforSql mySql = clsvDataNode_SimDA.GetSpecSQLObj();
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataNode_SimEN._CurrTabName);
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataNode_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvDataNode_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}