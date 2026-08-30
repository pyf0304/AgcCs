
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsUiFileRelationNodeDA
 表名:UiFileRelationNode(00050654)
 * 版本:2026.07.20(服务器:WIN-SRV103-116)
 日期:2026/07/21 01:50:18
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
 /// UiFileRelationNode(UiFileRelationNode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsUiFileRelationNodeDA : clsCommBase4DA
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
 return clsUiFileRelationNodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsUiFileRelationNodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsUiFileRelationNodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsUiFileRelationNodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsUiFileRelationNodeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_UiFileRelationNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable_UiFileRelationNode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UiFileRelationNode.* " + 
$"from UiFileRelationNode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UiFileRelationNode.NodeId not in " + 
$"(Select top {intTop_In} UiFileRelationNode.NodeId from UiFileRelationNode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1} and NodeId not in (Select top {2} NodeId from UiFileRelationNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1} and NodeId not in (Select top {3} NodeId from UiFileRelationNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} UiFileRelationNode.* " + 
$"from UiFileRelationNode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and UiFileRelationNode.NodeId not in " + 
$"(Select top {intTop_In} UiFileRelationNode.NodeId from UiFileRelationNode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1} and NodeId not in (Select top {2} NodeId from UiFileRelationNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from UiFileRelationNode where {1} and NodeId not in (Select top {3} NodeId from UiFileRelationNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsUiFileRelationNodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA:GetObjLst)", objException.Message));
}
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = TransNullToInt(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = TransNullToInt(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = TransNullToInt(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetObjLst)", objException.Message));
}
objUiFileRelationNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUiFileRelationNodeEN);
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
public List<clsUiFileRelationNodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsUiFileRelationNodeEN> arrObjLst = new List<clsUiFileRelationNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = TransNullToInt(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = TransNullToInt(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = TransNullToInt(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetObjLst)", objException.Message));
}
objUiFileRelationNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objUiFileRelationNodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetUiFileRelationNode(ref clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where NodeId = " + ""+ objUiFileRelationNodeEN.NodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objUiFileRelationNodeEN.NodeId = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationNodeEN.TaskId = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationNodeEN.FileId = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.FileId].ToString().Trim()); //FileId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationNodeEN.NodeType = objDT.Rows[0][conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationNodeEN.SymbolName = objDT.Rows[0][conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName(字段类型:nvarchar,字段长度:400,是否可空:False)
 objUiFileRelationNodeEN.SymbolKey = objDT.Rows[0][conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey(字段类型:nvarchar,字段长度:600,是否可空:True)
 objUiFileRelationNodeEN.SourcePath = objDT.Rows[0][conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath(字段类型:nvarchar,字段长度:1000,是否可空:True)
 objUiFileRelationNodeEN.LineNo = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo(字段类型:int,字段长度:4,是否可空:True)
 objUiFileRelationNodeEN.ColumnNo = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo(字段类型:int,字段长度:4,是否可空:True)
 objUiFileRelationNodeEN.LevelNo = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号(字段类型:int,字段长度:4,是否可空:True)
 objUiFileRelationNodeEN.ParentNodeId = TransNullToInt(objDT.Rows[0][conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId(字段类型:bigint,字段长度:8,是否可空:True)
 objUiFileRelationNodeEN.ExtraJson = objDT.Rows[0][conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson(字段类型:ntext,字段长度:2147483646,是否可空:True)
 objUiFileRelationNodeEN.CreatedAt = TransNullToDate(objDT.Rows[0][conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetUiFileRelationNode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngNodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsUiFileRelationNodeEN GetObjByNodeId(long lngNodeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where NodeId = " + ""+ lngNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
 objUiFileRelationNodeEN.NodeId = Int32.Parse(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationNodeEN.TaskId = Int32.Parse(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId(字段类型:bigint,字段长度:8,是否可空:False)
 objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType(字段类型:varchar,字段长度:20,是否可空:False)
 objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName(字段类型:nvarchar,字段长度:400,是否可空:False)
 objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey(字段类型:nvarchar,字段长度:600,是否可空:True)
 objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath(字段类型:nvarchar,字段长度:1000,是否可空:True)
 objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo(字段类型:int,字段长度:4,是否可空:True)
 objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo(字段类型:int,字段长度:4,是否可空:True)
 objUiFileRelationNodeEN.LevelNo = Int32.Parse(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号(字段类型:int,字段长度:4,是否可空:True)
 objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId(字段类型:bigint,字段长度:8,是否可空:True)
 objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson(字段类型:ntext,字段长度:2147483646,是否可空:True)
 objUiFileRelationNodeEN.CreatedAt = System.DateTime.Parse(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt(字段类型:datetime,字段长度:16,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetObjByNodeId)", objException.Message));
}
return objUiFileRelationNodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsUiFileRelationNodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN()
{
NodeId = TransNullToInt(objRow[conUiFileRelationNode.NodeId].ToString().Trim()), //NodeId
TaskId = TransNullToInt(objRow[conUiFileRelationNode.TaskId].ToString().Trim()), //TaskId
FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.FileId].ToString().Trim()), //FileId
NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(), //NodeType
SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(), //SymbolName
SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(), //SymbolKey
SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(), //SourcePath
LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.LineNo].ToString().Trim()), //LineNo
ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()), //ColumnNo
LevelNo = TransNullToInt(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()), //层序号
ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()), //ParentNodeId
ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(), //ExtraJson
CreatedAt = TransNullToDate(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()) //CreatedAt
};
objUiFileRelationNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationNodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsUiFileRelationNodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = TransNullToInt(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = TransNullToInt(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = TransNullToInt(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetObjByDataRowUiFileRelationNode)", objException.Message));
}
objUiFileRelationNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationNodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsUiFileRelationNodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsUiFileRelationNodeEN objUiFileRelationNodeEN = new clsUiFileRelationNodeEN();
try
{
objUiFileRelationNodeEN.NodeId = TransNullToInt(objRow[conUiFileRelationNode.NodeId].ToString().Trim()); //NodeId
objUiFileRelationNodeEN.TaskId = TransNullToInt(objRow[conUiFileRelationNode.TaskId].ToString().Trim()); //TaskId
objUiFileRelationNodeEN.FileId = objRow[conUiFileRelationNode.FileId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.FileId].ToString().Trim()); //FileId
objUiFileRelationNodeEN.NodeType = objRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objUiFileRelationNodeEN.SymbolName = objRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objUiFileRelationNodeEN.SymbolKey = objRow[conUiFileRelationNode.SymbolKey] == DBNull.Value ? null : objRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objUiFileRelationNodeEN.SourcePath = objRow[conUiFileRelationNode.SourcePath] == DBNull.Value ? null : objRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objUiFileRelationNodeEN.LineNo = objRow[conUiFileRelationNode.LineNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.LineNo].ToString().Trim()); //LineNo
objUiFileRelationNodeEN.ColumnNo = objRow[conUiFileRelationNode.ColumnNo] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conUiFileRelationNode.ColumnNo].ToString().Trim()); //ColumnNo
objUiFileRelationNodeEN.LevelNo = TransNullToInt(objRow[conUiFileRelationNode.LevelNo].ToString().Trim()); //层序号
objUiFileRelationNodeEN.ParentNodeId = objRow[conUiFileRelationNode.ParentNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conUiFileRelationNode.ParentNodeId].ToString().Trim()); //ParentNodeId
objUiFileRelationNodeEN.ExtraJson = objRow[conUiFileRelationNode.ExtraJson] == DBNull.Value ? null : objRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objUiFileRelationNodeEN.CreatedAt = TransNullToDate(objRow[conUiFileRelationNode.CreatedAt].ToString().Trim()); //CreatedAt
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsUiFileRelationNodeDA: GetObjByDataRow)", objException.Message));
}
objUiFileRelationNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objUiFileRelationNodeEN;
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
objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUiFileRelationNodeEN._CurrTabName, conUiFileRelationNode.NodeId, 8, "");
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
objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsUiFileRelationNodeEN._CurrTabName, conUiFileRelationNode.NodeId, 8, strPrefix);
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select NodeId from UiFileRelationNode where " + strCondition;
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select NodeId from UiFileRelationNode where " + strCondition;
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
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(long lngNodeId)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UiFileRelationNode", "NodeId = " + ""+ lngNodeId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("UiFileRelationNode", strCondition))
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
objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("UiFileRelationNode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
 {
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationNodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UiFileRelationNode");
objRow = objDS.Tables["UiFileRelationNode"].NewRow();
objRow[conUiFileRelationNode.TaskId] = objUiFileRelationNodeEN.TaskId; //TaskId
objRow[conUiFileRelationNode.FileId] = objUiFileRelationNodeEN.FileId; //FileId
objRow[conUiFileRelationNode.NodeType] = objUiFileRelationNodeEN.NodeType; //NodeType
objRow[conUiFileRelationNode.SymbolName] = objUiFileRelationNodeEN.SymbolName; //SymbolName
 if (objUiFileRelationNodeEN.SymbolKey !=  "")
 {
objRow[conUiFileRelationNode.SymbolKey] = objUiFileRelationNodeEN.SymbolKey; //SymbolKey
 }
 if (objUiFileRelationNodeEN.SourcePath !=  "")
 {
objRow[conUiFileRelationNode.SourcePath] = objUiFileRelationNodeEN.SourcePath; //SourcePath
 }
objRow[conUiFileRelationNode.LineNo] = objUiFileRelationNodeEN.LineNo; //LineNo
objRow[conUiFileRelationNode.ColumnNo] = objUiFileRelationNodeEN.ColumnNo; //ColumnNo
objRow[conUiFileRelationNode.LevelNo] = objUiFileRelationNodeEN.LevelNo; //层序号
objRow[conUiFileRelationNode.ParentNodeId] = objUiFileRelationNodeEN.ParentNodeId; //ParentNodeId
 if (objUiFileRelationNodeEN.ExtraJson !=  "")
 {
objRow[conUiFileRelationNode.ExtraJson] = objUiFileRelationNodeEN.ExtraJson; //ExtraJson
 }
objRow[conUiFileRelationNode.CreatedAt] = objUiFileRelationNodeEN.CreatedAt; //CreatedAt
objDS.Tables[clsUiFileRelationNodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsUiFileRelationNodeEN._CurrTabName);
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationNode.TaskId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.TaskId.ToString());
 
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.FileId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.FileId.ToString());
 }
 
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.NodeType);
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeType + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolName);
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolKey);
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolKey + "'");
 }
 
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SourcePath);
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePath + "'");
 }
 
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.LineNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LineNo.ToString());
 }
 
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ColumnNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ColumnNo.ToString());
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.LevelNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LevelNo.ToString());
 
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ParentNodeId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ParentNodeId.ToString());
 }
 
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ExtraJson);
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtraJson + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.CreatedAt);
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationNode.TaskId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.TaskId.ToString());
 
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.FileId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.FileId.ToString());
 }
 
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.NodeType);
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeType + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolName);
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolKey);
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolKey + "'");
 }
 
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SourcePath);
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePath + "'");
 }
 
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.LineNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LineNo.ToString());
 }
 
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ColumnNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ColumnNo.ToString());
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.LevelNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LevelNo.ToString());
 
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ParentNodeId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ParentNodeId.ToString());
 }
 
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ExtraJson);
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtraJson + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.CreatedAt);
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsUiFileRelationNodeEN objUiFileRelationNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationNode.TaskId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.TaskId.ToString());
 
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.FileId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.FileId.ToString());
 }
 
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.NodeType);
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeType + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolName);
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolKey);
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolKey + "'");
 }
 
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SourcePath);
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePath + "'");
 }
 
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.LineNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LineNo.ToString());
 }
 
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ColumnNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ColumnNo.ToString());
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.LevelNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LevelNo.ToString());
 
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ParentNodeId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ParentNodeId.ToString());
 }
 
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ExtraJson);
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtraJson + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.CreatedAt);
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsUiFileRelationNodeEN objUiFileRelationNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objUiFileRelationNodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conUiFileRelationNode.TaskId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.TaskId.ToString());
 
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.FileId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.FileId.ToString());
 }
 
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.NodeType);
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strNodeType + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolName);
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolName + "'");
 }
 
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SymbolKey);
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSymbolKey + "'");
 }
 
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.SourcePath);
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSourcePath + "'");
 }
 
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.LineNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LineNo.ToString());
 }
 
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ColumnNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ColumnNo.ToString());
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.LevelNo);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.LevelNo.ToString());
 
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ParentNodeId);
 arrValueListForInsert.Add(objUiFileRelationNodeEN.ParentNodeId.ToString());
 }
 
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 arrFieldListForInsert.Add(conUiFileRelationNode.ExtraJson);
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strExtraJson + "'");
 }
 
 arrFieldListForInsert.Add(conUiFileRelationNode.CreatedAt);
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 arrValueListForInsert.Add("'" + dteCreatedAt + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into UiFileRelationNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewUiFileRelationNodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where NodeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "UiFileRelationNode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngNodeId = TransNullToInt(oRow[conUiFileRelationNode.NodeId].ToString().Trim());
if (IsExist(lngNodeId))
{
 string strResult = "关键字变量值为:" + string.Format("NodeId = {0}", lngNodeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsUiFileRelationNodeEN._CurrTabName ].NewRow();
objRow[conUiFileRelationNode.TaskId] = oRow[conUiFileRelationNode.TaskId].ToString().Trim(); //TaskId
objRow[conUiFileRelationNode.FileId] = oRow[conUiFileRelationNode.FileId].ToString().Trim(); //FileId
objRow[conUiFileRelationNode.NodeType] = oRow[conUiFileRelationNode.NodeType].ToString().Trim(); //NodeType
objRow[conUiFileRelationNode.SymbolName] = oRow[conUiFileRelationNode.SymbolName].ToString().Trim(); //SymbolName
objRow[conUiFileRelationNode.SymbolKey] = oRow[conUiFileRelationNode.SymbolKey].ToString().Trim(); //SymbolKey
objRow[conUiFileRelationNode.SourcePath] = oRow[conUiFileRelationNode.SourcePath].ToString().Trim(); //SourcePath
objRow[conUiFileRelationNode.LineNo] = oRow[conUiFileRelationNode.LineNo].ToString().Trim(); //LineNo
objRow[conUiFileRelationNode.ColumnNo] = oRow[conUiFileRelationNode.ColumnNo].ToString().Trim(); //ColumnNo
objRow[conUiFileRelationNode.LevelNo] = oRow[conUiFileRelationNode.LevelNo].ToString().Trim(); //层序号
objRow[conUiFileRelationNode.ParentNodeId] = oRow[conUiFileRelationNode.ParentNodeId].ToString().Trim(); //ParentNodeId
objRow[conUiFileRelationNode.ExtraJson] = oRow[conUiFileRelationNode.ExtraJson].ToString().Trim(); //ExtraJson
objRow[conUiFileRelationNode.CreatedAt] = oRow[conUiFileRelationNode.CreatedAt].ToString().Trim(); //CreatedAt
 objDS.Tables[clsUiFileRelationNodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsUiFileRelationNodeEN._CurrTabName);
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
 /// <param name = "objUiFileRelationNodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationNodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
strSQL = "Select * from UiFileRelationNode where NodeId = " + ""+ objUiFileRelationNodeEN.NodeId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsUiFileRelationNodeEN._CurrTabName);
if (objDS.Tables[clsUiFileRelationNodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:NodeId = " + ""+ objUiFileRelationNodeEN.NodeId+"");
return false;
}
objRow = objDS.Tables[clsUiFileRelationNodeEN._CurrTabName].Rows[0];
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.TaskId))
 {
objRow[conUiFileRelationNode.TaskId] = objUiFileRelationNodeEN.TaskId; //TaskId
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.FileId))
 {
objRow[conUiFileRelationNode.FileId] = objUiFileRelationNodeEN.FileId; //FileId
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.NodeType))
 {
objRow[conUiFileRelationNode.NodeType] = objUiFileRelationNodeEN.NodeType; //NodeType
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolName))
 {
objRow[conUiFileRelationNode.SymbolName] = objUiFileRelationNodeEN.SymbolName; //SymbolName
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolKey))
 {
objRow[conUiFileRelationNode.SymbolKey] = objUiFileRelationNodeEN.SymbolKey; //SymbolKey
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SourcePath))
 {
objRow[conUiFileRelationNode.SourcePath] = objUiFileRelationNodeEN.SourcePath; //SourcePath
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LineNo))
 {
objRow[conUiFileRelationNode.LineNo] = objUiFileRelationNodeEN.LineNo; //LineNo
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ColumnNo))
 {
objRow[conUiFileRelationNode.ColumnNo] = objUiFileRelationNodeEN.ColumnNo; //ColumnNo
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LevelNo))
 {
objRow[conUiFileRelationNode.LevelNo] = objUiFileRelationNodeEN.LevelNo; //层序号
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ParentNodeId))
 {
objRow[conUiFileRelationNode.ParentNodeId] = objUiFileRelationNodeEN.ParentNodeId; //ParentNodeId
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ExtraJson))
 {
objRow[conUiFileRelationNode.ExtraJson] = objUiFileRelationNodeEN.ExtraJson; //ExtraJson
 }
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.CreatedAt))
 {
objRow[conUiFileRelationNode.CreatedAt] = objUiFileRelationNodeEN.CreatedAt; //CreatedAt
 }
try
{
objDA.Update(objDS, clsUiFileRelationNodeEN._CurrTabName);
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update UiFileRelationNode Set ");
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.TaskId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.TaskId, conUiFileRelationNode.TaskId); //TaskId
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.FileId))
 {
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.FileId, conUiFileRelationNode.FileId); //FileId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.FileId); //FileId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.NodeType))
 {
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeType, conUiFileRelationNode.NodeType); //NodeType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.NodeType); //NodeType
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolName))
 {
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolName, conUiFileRelationNode.SymbolName); //SymbolName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.SymbolName); //SymbolName
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolKey))
 {
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolKey, conUiFileRelationNode.SymbolKey); //SymbolKey
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.SymbolKey); //SymbolKey
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SourcePath))
 {
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourcePath, conUiFileRelationNode.SourcePath); //SourcePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.SourcePath); //SourcePath
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LineNo))
 {
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.LineNo, conUiFileRelationNode.LineNo); //LineNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.LineNo); //LineNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ColumnNo))
 {
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ColumnNo, conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LevelNo))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.LevelNo, conUiFileRelationNode.LevelNo); //层序号
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ParentNodeId))
 {
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ParentNodeId, conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ExtraJson))
 {
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtraJson, conUiFileRelationNode.ExtraJson); //ExtraJson
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ExtraJson); //ExtraJson
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.CreatedAt))
 {
 if (objUiFileRelationNodeEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conUiFileRelationNode.CreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.CreatedAt); //CreatedAt
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where NodeId = {0}", objUiFileRelationNodeEN.NodeId); 
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
 /// <param name = "objUiFileRelationNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strCondition)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationNode Set ");
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.TaskId))
 {
 sbSQL.AppendFormat(" TaskId = {0},", objUiFileRelationNodeEN.TaskId); //TaskId
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.FileId))
 {
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.FileId, conUiFileRelationNode.FileId); //FileId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.FileId); //FileId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.NodeType))
 {
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeType = '{0}',", strNodeType); //NodeType
 }
 else
 {
 sbSQL.Append(" NodeType = null,"); //NodeType
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolName))
 {
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolName = '{0}',", strSymbolName); //SymbolName
 }
 else
 {
 sbSQL.Append(" SymbolName = null,"); //SymbolName
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolKey))
 {
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolKey = '{0}',", strSymbolKey); //SymbolKey
 }
 else
 {
 sbSQL.Append(" SymbolKey = null,"); //SymbolKey
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SourcePath))
 {
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourcePath = '{0}',", strSourcePath); //SourcePath
 }
 else
 {
 sbSQL.Append(" SourcePath = null,"); //SourcePath
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LineNo))
 {
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.LineNo, conUiFileRelationNode.LineNo); //LineNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.LineNo); //LineNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ColumnNo))
 {
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ColumnNo, conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LevelNo))
 {
 sbSQL.AppendFormat(" LevelNo = {0},", objUiFileRelationNodeEN.LevelNo); //层序号
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ParentNodeId))
 {
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ParentNodeId, conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ExtraJson))
 {
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExtraJson = '{0}',", strExtraJson); //ExtraJson
 }
 else
 {
 sbSQL.Append(" ExtraJson = null,"); //ExtraJson
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.CreatedAt))
 {
 if (objUiFileRelationNodeEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //CreatedAt
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
 /// <param name = "objUiFileRelationNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsUiFileRelationNodeEN objUiFileRelationNodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationNode Set ");
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.TaskId))
 {
 sbSQL.AppendFormat(" TaskId = {0},", objUiFileRelationNodeEN.TaskId); //TaskId
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.FileId))
 {
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.FileId, conUiFileRelationNode.FileId); //FileId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.FileId); //FileId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.NodeType))
 {
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" NodeType = '{0}',", strNodeType); //NodeType
 }
 else
 {
 sbSQL.Append(" NodeType = null,"); //NodeType
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolName))
 {
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolName = '{0}',", strSymbolName); //SymbolName
 }
 else
 {
 sbSQL.Append(" SymbolName = null,"); //SymbolName
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolKey))
 {
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SymbolKey = '{0}',", strSymbolKey); //SymbolKey
 }
 else
 {
 sbSQL.Append(" SymbolKey = null,"); //SymbolKey
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SourcePath))
 {
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SourcePath = '{0}',", strSourcePath); //SourcePath
 }
 else
 {
 sbSQL.Append(" SourcePath = null,"); //SourcePath
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LineNo))
 {
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.LineNo, conUiFileRelationNode.LineNo); //LineNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.LineNo); //LineNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ColumnNo))
 {
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ColumnNo, conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LevelNo))
 {
 sbSQL.AppendFormat(" LevelNo = {0},", objUiFileRelationNodeEN.LevelNo); //层序号
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ParentNodeId))
 {
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ParentNodeId, conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ExtraJson))
 {
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ExtraJson = '{0}',", strExtraJson); //ExtraJson
 }
 else
 {
 sbSQL.Append(" ExtraJson = null,"); //ExtraJson
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.CreatedAt))
 {
 if (objUiFileRelationNodeEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 sbSQL.AppendFormat(" CreatedAt = '{0}',", dteCreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.Append(" CreatedAt = null,"); //CreatedAt
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
 /// <param name = "objUiFileRelationNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsUiFileRelationNodeEN objUiFileRelationNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 if (objUiFileRelationNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objUiFileRelationNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update UiFileRelationNode Set ");
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.TaskId))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.TaskId, conUiFileRelationNode.TaskId); //TaskId
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.FileId))
 {
 if (objUiFileRelationNodeEN.FileId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.FileId, conUiFileRelationNode.FileId); //FileId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.FileId); //FileId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.NodeType))
 {
 if (objUiFileRelationNodeEN.NodeType !=  null)
 {
 var strNodeType = objUiFileRelationNodeEN.NodeType.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strNodeType, conUiFileRelationNode.NodeType); //NodeType
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.NodeType); //NodeType
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolName))
 {
 if (objUiFileRelationNodeEN.SymbolName !=  null)
 {
 var strSymbolName = objUiFileRelationNodeEN.SymbolName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolName, conUiFileRelationNode.SymbolName); //SymbolName
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.SymbolName); //SymbolName
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SymbolKey))
 {
 if (objUiFileRelationNodeEN.SymbolKey !=  null)
 {
 var strSymbolKey = objUiFileRelationNodeEN.SymbolKey.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSymbolKey, conUiFileRelationNode.SymbolKey); //SymbolKey
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.SymbolKey); //SymbolKey
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.SourcePath))
 {
 if (objUiFileRelationNodeEN.SourcePath !=  null)
 {
 var strSourcePath = objUiFileRelationNodeEN.SourcePath.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSourcePath, conUiFileRelationNode.SourcePath); //SourcePath
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.SourcePath); //SourcePath
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LineNo))
 {
 if (objUiFileRelationNodeEN.LineNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.LineNo, conUiFileRelationNode.LineNo); //LineNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.LineNo); //LineNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ColumnNo))
 {
 if (objUiFileRelationNodeEN.ColumnNo !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ColumnNo, conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ColumnNo); //ColumnNo
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.LevelNo))
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.LevelNo, conUiFileRelationNode.LevelNo); //层序号
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ParentNodeId))
 {
 if (objUiFileRelationNodeEN.ParentNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objUiFileRelationNodeEN.ParentNodeId, conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ParentNodeId); //ParentNodeId
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.ExtraJson))
 {
 if (objUiFileRelationNodeEN.ExtraJson !=  null)
 {
 var strExtraJson = objUiFileRelationNodeEN.ExtraJson.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strExtraJson, conUiFileRelationNode.ExtraJson); //ExtraJson
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.ExtraJson); //ExtraJson
 }
 }
 
 if (objUiFileRelationNodeEN.IsUpdated(conUiFileRelationNode.CreatedAt))
 {
 if (objUiFileRelationNodeEN.CreatedAt !=  null)
 {
 var dteCreatedAt = objUiFileRelationNodeEN.CreatedAt;
 sbSQL.AppendFormat("{1} = '{0}',", dteCreatedAt, conUiFileRelationNode.CreatedAt); //CreatedAt
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conUiFileRelationNode.CreatedAt); //CreatedAt
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where NodeId = {0}", objUiFileRelationNodeEN.NodeId); 
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
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngNodeId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngNodeId,
};
 objSQL.ExecSP("UiFileRelationNode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngNodeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
//删除UiFileRelationNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationNode where NodeId = " + ""+ lngNodeId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelUiFileRelationNode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
//删除UiFileRelationNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationNode where NodeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngNodeId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
//删除UiFileRelationNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from UiFileRelationNode where NodeId = " + ""+ lngNodeId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelUiFileRelationNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: DelUiFileRelationNode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UiFileRelationNode where " + strCondition ;
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
public bool DelUiFileRelationNodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsUiFileRelationNodeDA: DelUiFileRelationNodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from UiFileRelationNode where " + strCondition ;
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
 /// <param name = "objUiFileRelationNodeENS">源对象</param>
 /// <param name = "objUiFileRelationNodeENT">目标对象</param>
public void CopyTo(clsUiFileRelationNodeEN objUiFileRelationNodeENS, clsUiFileRelationNodeEN objUiFileRelationNodeENT)
{
objUiFileRelationNodeENT.NodeId = objUiFileRelationNodeENS.NodeId; //NodeId
objUiFileRelationNodeENT.TaskId = objUiFileRelationNodeENS.TaskId; //TaskId
objUiFileRelationNodeENT.FileId = objUiFileRelationNodeENS.FileId; //FileId
objUiFileRelationNodeENT.NodeType = objUiFileRelationNodeENS.NodeType; //NodeType
objUiFileRelationNodeENT.SymbolName = objUiFileRelationNodeENS.SymbolName; //SymbolName
objUiFileRelationNodeENT.SymbolKey = objUiFileRelationNodeENS.SymbolKey; //SymbolKey
objUiFileRelationNodeENT.SourcePath = objUiFileRelationNodeENS.SourcePath; //SourcePath
objUiFileRelationNodeENT.LineNo = objUiFileRelationNodeENS.LineNo; //LineNo
objUiFileRelationNodeENT.ColumnNo = objUiFileRelationNodeENS.ColumnNo; //ColumnNo
objUiFileRelationNodeENT.LevelNo = objUiFileRelationNodeENS.LevelNo; //层序号
objUiFileRelationNodeENT.ParentNodeId = objUiFileRelationNodeENS.ParentNodeId; //ParentNodeId
objUiFileRelationNodeENT.ExtraJson = objUiFileRelationNodeENS.ExtraJson; //ExtraJson
objUiFileRelationNodeENT.CreatedAt = objUiFileRelationNodeENS.CreatedAt; //CreatedAt
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objUiFileRelationNodeEN.TaskId, conUiFileRelationNode.TaskId);
clsCheckSql.CheckFieldNotNull(objUiFileRelationNodeEN.NodeType, conUiFileRelationNode.NodeType);
clsCheckSql.CheckFieldNotNull(objUiFileRelationNodeEN.SymbolName, conUiFileRelationNode.SymbolName);
clsCheckSql.CheckFieldNotNull(objUiFileRelationNodeEN.LevelNo, conUiFileRelationNode.LevelNo);
clsCheckSql.CheckFieldNotNull(objUiFileRelationNodeEN.CreatedAt, conUiFileRelationNode.CreatedAt);
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.NodeType, 20, conUiFileRelationNode.NodeType);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SymbolName, 400, conUiFileRelationNode.SymbolName);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SymbolKey, 600, conUiFileRelationNode.SymbolKey);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SourcePath, 1000, conUiFileRelationNode.SourcePath);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.ExtraJson, 2147483646, conUiFileRelationNode.ExtraJson);
//检查字段外键固定长度
 objUiFileRelationNodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.NodeType, 20, conUiFileRelationNode.NodeType);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SymbolName, 400, conUiFileRelationNode.SymbolName);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SymbolKey, 600, conUiFileRelationNode.SymbolKey);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SourcePath, 1000, conUiFileRelationNode.SourcePath);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.ExtraJson, 2147483646, conUiFileRelationNode.ExtraJson);
//检查外键字段长度
 objUiFileRelationNodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.NodeType, 20, conUiFileRelationNode.NodeType);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SymbolName, 400, conUiFileRelationNode.SymbolName);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SymbolKey, 600, conUiFileRelationNode.SymbolKey);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.SourcePath, 1000, conUiFileRelationNode.SourcePath);
clsCheckSql.CheckFieldLen(objUiFileRelationNodeEN.ExtraJson, 2147483646, conUiFileRelationNode.ExtraJson);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationNodeEN.NodeType, conUiFileRelationNode.NodeType);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationNodeEN.SymbolName, conUiFileRelationNode.SymbolName);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationNodeEN.SymbolKey, conUiFileRelationNode.SymbolKey);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationNodeEN.SourcePath, conUiFileRelationNode.SourcePath);
clsCheckSql.CheckSqlInjection4Field(objUiFileRelationNodeEN.ExtraJson, conUiFileRelationNode.ExtraJson);
//检查外键字段长度
 objUiFileRelationNodeEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--UiFileRelationNode(UiFileRelationNode),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objUiFileRelationNodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsUiFileRelationNodeEN objUiFileRelationNodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 if (objUiFileRelationNodeEN.FileId == null)
{
 sbCondition.AppendFormat(" and FileId is null");
}
else
{
 sbCondition.AppendFormat(" and FileId = '{0}'", objUiFileRelationNodeEN.FileId);
}
 sbCondition.AppendFormat(" and NodeId = '{0}'", objUiFileRelationNodeEN.NodeId);
 sbCondition.AppendFormat(" and NodeType = '{0}'", objUiFileRelationNodeEN.NodeType);
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUiFileRelationNodeEN._CurrTabName);
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsUiFileRelationNodeEN._CurrTabName, strCondition);
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
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
 objSQL = clsUiFileRelationNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}