
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeDA
 表名:DataNode(00050547)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:27:54
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
 /// 数据结点(DataNode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDataNodeDA : clsCommBase4DA
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
 return clsDataNodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataNodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataNodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDataNodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataNodeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable_DataNode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataNode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataNode.* " + 
$"from DataNode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataNode.DataNodeId not in " + 
$"(Select top {intTop_In} DataNode.DataNodeId from DataNode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNode where {1} and DataNodeId not in (Select top {2} DataNodeId from DataNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNode where {1} and DataNodeId not in (Select top {3} DataNodeId from DataNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataNode.* " + 
$"from DataNode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataNode.DataNodeId not in " + 
$"(Select top {intTop_In} DataNode.DataNodeId from DataNode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNode where {1} and DataNodeId not in (Select top {2} DataNodeId from DataNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNode where {1} and DataNodeId not in (Select top {3} DataNodeId from DataNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDataNodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataNodeDA:GetObjLst)", objException.Message));
}
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = TransNullToInt(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = TransNullToInt(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataNodeDA: GetObjLst)", objException.Message));
}
objDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataNodeEN);
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
public List<clsDataNodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataNodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataNodeEN> arrObjLst = new List<clsDataNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = TransNullToInt(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = TransNullToInt(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataNodeDA: GetObjLst)", objException.Message));
}
objDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataNodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataNode(ref clsDataNodeEN objDataNodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where DataNodeId = " + ""+ objDataNodeEN.DataNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataNodeEN.DataNodeId = TransNullToInt(objDT.Rows[0][conDataNode.DataNodeId].ToString().Trim()); //数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeEN.DataNodeName = objDT.Rows[0][conDataNode.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objDataNodeEN.TabId = objDT.Rows[0][conDataNode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeEN.FldId = objDT.Rows[0][conDataNode.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeEN.KeyFldLst = objDT.Rows[0][conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表(字段类型:varchar,字段长度:100,是否可空:True)
 objDataNodeEN.VersionNo = TransNullToInt(objDT.Rows[0][conDataNode.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objDataNodeEN.DataNodeTypeId = objDT.Rows[0][conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeEN.Depth = TransNullToInt(objDT.Rows[0][conDataNode.Depth].ToString().Trim()); //深度(字段类型:int,字段长度:4,是否可空:True)
 objDataNodeEN.PrevDataNodeId = TransNullToInt(objDT.Rows[0][conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeEN.NextDataNodeId = TransNullToInt(objDT.Rows[0][conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeEN.SubGraphName = objDT.Rows[0][conDataNode.SubGraphName].ToString().Trim(); //子图名(字段类型:varchar,字段长度:50,是否可空:True)
 objDataNodeEN.ErrMsg = objDT.Rows[0][conDataNode.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDataNodeEN.PrjId = objDT.Rows[0][conDataNode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDataNodeEN.PosX = TransNullToDouble(objDT.Rows[0][conDataNode.PosX].ToString().Trim()); //位置X(字段类型:decimal,字段长度:7,是否可空:True)
 objDataNodeEN.PosY = TransNullToDouble(objDT.Rows[0][conDataNode.PosY].ToString().Trim()); //位置Y(字段类型:decimal,字段长度:7,是否可空:True)
 objDataNodeEN.UsedTimes = TransNullToInt(objDT.Rows[0][conDataNode.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
 objDataNodeEN.UpdDate = objDT.Rows[0][conDataNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeEN.UpdUser = objDT.Rows[0][conDataNode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeEN.Memo = objDT.Rows[0][conDataNode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataNodeDA: GetDataNode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataNodeEN GetObjByDataNodeId(long lngDataNodeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where DataNodeId = " + ""+ lngDataNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
 objDataNodeEN.DataNodeId = Int32.Parse(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表(字段类型:varchar,字段长度:100,是否可空:True)
 objDataNodeEN.VersionNo = Int32.Parse(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.Depth].ToString().Trim()); //深度(字段类型:int,字段长度:4,是否可空:True)
 objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名(字段类型:varchar,字段长度:50,是否可空:True)
 objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息(字段类型:varchar,字段长度:2000,是否可空:True)
 objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosX].ToString().Trim()); //位置X(字段类型:decimal,字段长度:7,是否可空:True)
 objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : clsEntityBase2.TransNullToDouble_S(objRow[conDataNode.PosY].ToString().Trim()); //位置Y(字段类型:decimal,字段长度:7,是否可空:True)
 objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
 objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataNodeDA: GetObjByDataNodeId)", objException.Message));
}
return objDataNodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataNodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataNodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN()
{
DataNodeId = TransNullToInt(objRow[conDataNode.DataNodeId].ToString().Trim()), //数据结点Id
DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(), //数据结点名
TabId = objRow[conDataNode.TabId].ToString().Trim(), //表ID
FldId = objRow[conDataNode.FldId].ToString().Trim(), //字段Id
KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(), //关键字段Id列表
VersionNo = TransNullToInt(objRow[conDataNode.VersionNo].ToString().Trim()), //版本号
DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(), //数据结点类型Id
Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.Depth].ToString().Trim()), //深度
PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.PrevDataNodeId].ToString().Trim()), //前置数据结点Id
NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.NextDataNodeId].ToString().Trim()), //后继数据结点Id
SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(), //子图名
ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(), //错误信息
PrjId = objRow[conDataNode.PrjId].ToString().Trim(), //工程Id
PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosX].ToString().Trim()), //位置X
PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosY].ToString().Trim()), //位置Y
UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.UsedTimes].ToString().Trim()), //使用次数
UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim() //说明
};
objDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataNodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataNodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = TransNullToInt(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = TransNullToInt(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataNodeDA: GetObjByDataRowDataNode)", objException.Message));
}
objDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataNodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataNodeEN objDataNodeEN = new clsDataNodeEN();
try
{
objDataNodeEN.DataNodeId = TransNullToInt(objRow[conDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objDataNodeEN.DataNodeName = objRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objDataNodeEN.TabId = objRow[conDataNode.TabId].ToString().Trim(); //表ID
objDataNodeEN.FldId = objRow[conDataNode.FldId].ToString().Trim(); //字段Id
objDataNodeEN.KeyFldLst = objRow[conDataNode.KeyFldLst] == DBNull.Value ? null : objRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objDataNodeEN.VersionNo = TransNullToInt(objRow[conDataNode.VersionNo].ToString().Trim()); //版本号
objDataNodeEN.DataNodeTypeId = objRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objDataNodeEN.Depth = objRow[conDataNode.Depth] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.Depth].ToString().Trim()); //深度
objDataNodeEN.PrevDataNodeId = objRow[conDataNode.PrevDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.PrevDataNodeId].ToString().Trim()); //前置数据结点Id
objDataNodeEN.NextDataNodeId = objRow[conDataNode.NextDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[conDataNode.NextDataNodeId].ToString().Trim()); //后继数据结点Id
objDataNodeEN.SubGraphName = objRow[conDataNode.SubGraphName] == DBNull.Value ? null : objRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objDataNodeEN.ErrMsg = objRow[conDataNode.ErrMsg] == DBNull.Value ? null : objRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objDataNodeEN.PrjId = objRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objDataNodeEN.PosX = objRow[conDataNode.PosX] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosX].ToString().Trim()); //位置X
objDataNodeEN.PosY = objRow[conDataNode.PosY] == DBNull.Value ? (double?)null : TransNullToDouble(objRow[conDataNode.PosY].ToString().Trim()); //位置Y
objDataNodeEN.UsedTimes = objRow[conDataNode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conDataNode.UsedTimes].ToString().Trim()); //使用次数
objDataNodeEN.UpdDate = objRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objDataNodeEN.UpdUser = objRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objDataNodeEN.Memo = objRow[conDataNode.Memo] == DBNull.Value ? null : objRow[conDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataNodeDA: GetObjByDataRow)", objException.Message));
}
objDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeEN;
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
objSQL = clsDataNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataNodeEN._CurrTabName, conDataNode.DataNodeId, 8, "");
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
objSQL = clsDataNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataNodeEN._CurrTabName, conDataNode.DataNodeId, 8, strPrefix);
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DataNodeId from DataNode where " + strCondition;
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DataNodeId from DataNode where " + strCondition;
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataNode", "DataNodeId = " + ""+ lngDataNodeId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataNodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataNode", strCondition))
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
objSQL = clsDataNodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataNode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataNodeEN objDataNodeEN)
 {
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataNode");
objRow = objDS.Tables["DataNode"].NewRow();
objRow[conDataNode.DataNodeName] = objDataNodeEN.DataNodeName; //数据结点名
objRow[conDataNode.TabId] = objDataNodeEN.TabId; //表ID
objRow[conDataNode.FldId] = objDataNodeEN.FldId; //字段Id
 if (objDataNodeEN.KeyFldLst !=  "")
 {
objRow[conDataNode.KeyFldLst] = objDataNodeEN.KeyFldLst; //关键字段Id列表
 }
objRow[conDataNode.VersionNo] = objDataNodeEN.VersionNo; //版本号
objRow[conDataNode.DataNodeTypeId] = objDataNodeEN.DataNodeTypeId; //数据结点类型Id
objRow[conDataNode.Depth] = objDataNodeEN.Depth; //深度
objRow[conDataNode.PrevDataNodeId] = objDataNodeEN.PrevDataNodeId; //前置数据结点Id
objRow[conDataNode.NextDataNodeId] = objDataNodeEN.NextDataNodeId; //后继数据结点Id
 if (objDataNodeEN.SubGraphName !=  "")
 {
objRow[conDataNode.SubGraphName] = objDataNodeEN.SubGraphName; //子图名
 }
 if (objDataNodeEN.ErrMsg !=  "")
 {
objRow[conDataNode.ErrMsg] = objDataNodeEN.ErrMsg; //错误信息
 }
objRow[conDataNode.PrjId] = objDataNodeEN.PrjId; //工程Id
objRow[conDataNode.PosX] = objDataNodeEN.PosX; //位置X
objRow[conDataNode.PosY] = objDataNodeEN.PosY; //位置Y
objRow[conDataNode.UsedTimes] = objDataNodeEN.UsedTimes; //使用次数
objRow[conDataNode.UpdDate] = objDataNodeEN.UpdDate; //修改日期
objRow[conDataNode.UpdUser] = objDataNodeEN.UpdUser; //修改者
 if (objDataNodeEN.Memo !=  "")
 {
objRow[conDataNode.Memo] = objDataNodeEN.Memo; //说明
 }
objDS.Tables[clsDataNodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataNodeEN._CurrTabName);
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataNodeEN objDataNodeEN)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataNodeEN.DataNodeName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeName);
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeName + "'");
 }
 
 if (objDataNodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.TabId);
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.FldId);
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.KeyFldLst);
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldLst + "'");
 }
 
 arrFieldListForInsert.Add(conDataNode.VersionNo);
 arrValueListForInsert.Add(objDataNodeEN.VersionNo.ToString());
 
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeTypeId);
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeTypeId + "'");
 }
 
 if (objDataNodeEN.Depth !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Depth);
 arrValueListForInsert.Add(objDataNodeEN.Depth.ToString());
 }
 
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrevDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.PrevDataNodeId.ToString());
 }
 
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.NextDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.NextDataNodeId.ToString());
 }
 
 if (objDataNodeEN.SubGraphName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.SubGraphName);
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubGraphName + "'");
 }
 
 if (objDataNodeEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.ErrMsg);
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDataNodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrjId);
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosX);
 arrValueListForInsert.Add(objDataNodeEN.PosX.ToString());
 }
 
 if (objDataNodeEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosY);
 arrValueListForInsert.Add(objDataNodeEN.PosY.ToString());
 }
 
 if (objDataNodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UsedTimes);
 arrValueListForInsert.Add(objDataNodeEN.UsedTimes.ToString());
 }
 
 if (objDataNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdDate);
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdUser);
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Memo);
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataNodeEN objDataNodeEN)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataNodeEN.DataNodeName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeName);
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeName + "'");
 }
 
 if (objDataNodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.TabId);
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.FldId);
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.KeyFldLst);
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldLst + "'");
 }
 
 arrFieldListForInsert.Add(conDataNode.VersionNo);
 arrValueListForInsert.Add(objDataNodeEN.VersionNo.ToString());
 
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeTypeId);
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeTypeId + "'");
 }
 
 if (objDataNodeEN.Depth !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Depth);
 arrValueListForInsert.Add(objDataNodeEN.Depth.ToString());
 }
 
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrevDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.PrevDataNodeId.ToString());
 }
 
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.NextDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.NextDataNodeId.ToString());
 }
 
 if (objDataNodeEN.SubGraphName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.SubGraphName);
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubGraphName + "'");
 }
 
 if (objDataNodeEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.ErrMsg);
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDataNodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrjId);
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosX);
 arrValueListForInsert.Add(objDataNodeEN.PosX.ToString());
 }
 
 if (objDataNodeEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosY);
 arrValueListForInsert.Add(objDataNodeEN.PosY.ToString());
 }
 
 if (objDataNodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UsedTimes);
 arrValueListForInsert.Add(objDataNodeEN.UsedTimes.ToString());
 }
 
 if (objDataNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdDate);
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdUser);
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Memo);
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataNodeEN.DataNodeName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeName);
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeName + "'");
 }
 
 if (objDataNodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.TabId);
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.FldId);
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.KeyFldLst);
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldLst + "'");
 }
 
 arrFieldListForInsert.Add(conDataNode.VersionNo);
 arrValueListForInsert.Add(objDataNodeEN.VersionNo.ToString());
 
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeTypeId);
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeTypeId + "'");
 }
 
 if (objDataNodeEN.Depth !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Depth);
 arrValueListForInsert.Add(objDataNodeEN.Depth.ToString());
 }
 
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrevDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.PrevDataNodeId.ToString());
 }
 
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.NextDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.NextDataNodeId.ToString());
 }
 
 if (objDataNodeEN.SubGraphName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.SubGraphName);
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubGraphName + "'");
 }
 
 if (objDataNodeEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.ErrMsg);
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDataNodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrjId);
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosX);
 arrValueListForInsert.Add(objDataNodeEN.PosX.ToString());
 }
 
 if (objDataNodeEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosY);
 arrValueListForInsert.Add(objDataNodeEN.PosY.ToString());
 }
 
 if (objDataNodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UsedTimes);
 arrValueListForInsert.Add(objDataNodeEN.UsedTimes.ToString());
 }
 
 if (objDataNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdDate);
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdUser);
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Memo);
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 if (objDataNodeEN.DataNodeName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeName);
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeName + "'");
 }
 
 if (objDataNodeEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.TabId);
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeEN.FldId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.FldId);
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFldId + "'");
 }
 
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.KeyFldLst);
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strKeyFldLst + "'");
 }
 
 arrFieldListForInsert.Add(conDataNode.VersionNo);
 arrValueListForInsert.Add(objDataNodeEN.VersionNo.ToString());
 
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.DataNodeTypeId);
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDataNodeTypeId + "'");
 }
 
 if (objDataNodeEN.Depth !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Depth);
 arrValueListForInsert.Add(objDataNodeEN.Depth.ToString());
 }
 
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrevDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.PrevDataNodeId.ToString());
 }
 
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.NextDataNodeId);
 arrValueListForInsert.Add(objDataNodeEN.NextDataNodeId.ToString());
 }
 
 if (objDataNodeEN.SubGraphName !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.SubGraphName);
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSubGraphName + "'");
 }
 
 if (objDataNodeEN.ErrMsg !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.ErrMsg);
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strErrMsg + "'");
 }
 
 if (objDataNodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PrjId);
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeEN.PosX !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosX);
 arrValueListForInsert.Add(objDataNodeEN.PosX.ToString());
 }
 
 if (objDataNodeEN.PosY !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.PosY);
 arrValueListForInsert.Add(objDataNodeEN.PosY.ToString());
 }
 
 if (objDataNodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UsedTimes);
 arrValueListForInsert.Add(objDataNodeEN.UsedTimes.ToString());
 }
 
 if (objDataNodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdDate);
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.UpdUser);
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNode.Memo);
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataNodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where DataNodeId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataNode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngDataNodeId = TransNullToInt(oRow[conDataNode.DataNodeId].ToString().Trim());
if (IsExist(lngDataNodeId))
{
 string strResult = "关键字变量值为:" + string.Format("DataNodeId = {0}", lngDataNodeId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataNodeEN._CurrTabName ].NewRow();
objRow[conDataNode.DataNodeName] = oRow[conDataNode.DataNodeName].ToString().Trim(); //数据结点名
objRow[conDataNode.TabId] = oRow[conDataNode.TabId].ToString().Trim(); //表ID
objRow[conDataNode.FldId] = oRow[conDataNode.FldId].ToString().Trim(); //字段Id
objRow[conDataNode.KeyFldLst] = oRow[conDataNode.KeyFldLst].ToString().Trim(); //关键字段Id列表
objRow[conDataNode.VersionNo] = oRow[conDataNode.VersionNo].ToString().Trim(); //版本号
objRow[conDataNode.DataNodeTypeId] = oRow[conDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objRow[conDataNode.Depth] = oRow[conDataNode.Depth].ToString().Trim(); //深度
objRow[conDataNode.PrevDataNodeId] = oRow[conDataNode.PrevDataNodeId].ToString().Trim(); //前置数据结点Id
objRow[conDataNode.NextDataNodeId] = oRow[conDataNode.NextDataNodeId].ToString().Trim(); //后继数据结点Id
objRow[conDataNode.SubGraphName] = oRow[conDataNode.SubGraphName].ToString().Trim(); //子图名
objRow[conDataNode.ErrMsg] = oRow[conDataNode.ErrMsg].ToString().Trim(); //错误信息
objRow[conDataNode.PrjId] = oRow[conDataNode.PrjId].ToString().Trim(); //工程Id
objRow[conDataNode.PosX] = oRow[conDataNode.PosX].ToString().Trim(); //位置X
objRow[conDataNode.PosY] = oRow[conDataNode.PosY].ToString().Trim(); //位置Y
objRow[conDataNode.UsedTimes] = oRow[conDataNode.UsedTimes].ToString().Trim(); //使用次数
objRow[conDataNode.UpdDate] = oRow[conDataNode.UpdDate].ToString().Trim(); //修改日期
objRow[conDataNode.UpdUser] = oRow[conDataNode.UpdUser].ToString().Trim(); //修改者
objRow[conDataNode.Memo] = oRow[conDataNode.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDataNodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataNodeEN._CurrTabName);
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
 /// <param name = "objDataNodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataNodeEN objDataNodeEN)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from DataNode where DataNodeId = " + ""+ objDataNodeEN.DataNodeId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataNodeEN._CurrTabName);
if (objDS.Tables[clsDataNodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:DataNodeId = " + ""+ objDataNodeEN.DataNodeId+"");
return false;
}
objRow = objDS.Tables[clsDataNodeEN._CurrTabName].Rows[0];
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeName))
 {
objRow[conDataNode.DataNodeName] = objDataNodeEN.DataNodeName; //数据结点名
 }
 if (objDataNodeEN.IsUpdated(conDataNode.TabId))
 {
objRow[conDataNode.TabId] = objDataNodeEN.TabId; //表ID
 }
 if (objDataNodeEN.IsUpdated(conDataNode.FldId))
 {
objRow[conDataNode.FldId] = objDataNodeEN.FldId; //字段Id
 }
 if (objDataNodeEN.IsUpdated(conDataNode.KeyFldLst))
 {
objRow[conDataNode.KeyFldLst] = objDataNodeEN.KeyFldLst; //关键字段Id列表
 }
 if (objDataNodeEN.IsUpdated(conDataNode.VersionNo))
 {
objRow[conDataNode.VersionNo] = objDataNodeEN.VersionNo; //版本号
 }
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeTypeId))
 {
objRow[conDataNode.DataNodeTypeId] = objDataNodeEN.DataNodeTypeId; //数据结点类型Id
 }
 if (objDataNodeEN.IsUpdated(conDataNode.Depth))
 {
objRow[conDataNode.Depth] = objDataNodeEN.Depth; //深度
 }
 if (objDataNodeEN.IsUpdated(conDataNode.PrevDataNodeId))
 {
objRow[conDataNode.PrevDataNodeId] = objDataNodeEN.PrevDataNodeId; //前置数据结点Id
 }
 if (objDataNodeEN.IsUpdated(conDataNode.NextDataNodeId))
 {
objRow[conDataNode.NextDataNodeId] = objDataNodeEN.NextDataNodeId; //后继数据结点Id
 }
 if (objDataNodeEN.IsUpdated(conDataNode.SubGraphName))
 {
objRow[conDataNode.SubGraphName] = objDataNodeEN.SubGraphName; //子图名
 }
 if (objDataNodeEN.IsUpdated(conDataNode.ErrMsg))
 {
objRow[conDataNode.ErrMsg] = objDataNodeEN.ErrMsg; //错误信息
 }
 if (objDataNodeEN.IsUpdated(conDataNode.PrjId))
 {
objRow[conDataNode.PrjId] = objDataNodeEN.PrjId; //工程Id
 }
 if (objDataNodeEN.IsUpdated(conDataNode.PosX))
 {
objRow[conDataNode.PosX] = objDataNodeEN.PosX; //位置X
 }
 if (objDataNodeEN.IsUpdated(conDataNode.PosY))
 {
objRow[conDataNode.PosY] = objDataNodeEN.PosY; //位置Y
 }
 if (objDataNodeEN.IsUpdated(conDataNode.UsedTimes))
 {
objRow[conDataNode.UsedTimes] = objDataNodeEN.UsedTimes; //使用次数
 }
 if (objDataNodeEN.IsUpdated(conDataNode.UpdDate))
 {
objRow[conDataNode.UpdDate] = objDataNodeEN.UpdDate; //修改日期
 }
 if (objDataNodeEN.IsUpdated(conDataNode.UpdUser))
 {
objRow[conDataNode.UpdUser] = objDataNodeEN.UpdUser; //修改者
 }
 if (objDataNodeEN.IsUpdated(conDataNode.Memo))
 {
objRow[conDataNode.Memo] = objDataNodeEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDataNodeEN._CurrTabName);
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataNodeEN objDataNodeEN)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataNode Set ");
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeName))
 {
 if (objDataNodeEN.DataNodeName !=  null)
 {
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataNodeName, conDataNode.DataNodeName); //数据结点名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.DataNodeName); //数据结点名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.TabId))
 {
 if (objDataNodeEN.TabId !=  null)
 {
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conDataNode.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.TabId); //表ID
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.FldId))
 {
 if (objDataNodeEN.FldId !=  null)
 {
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conDataNode.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.FldId); //字段Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.KeyFldLst))
 {
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyFldLst, conDataNode.KeyFldLst); //关键字段Id列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.KeyFldLst); //关键字段Id列表
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.VersionNo))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.VersionNo, conDataNode.VersionNo); //版本号
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeTypeId))
 {
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataNodeTypeId, conDataNode.DataNodeTypeId); //数据结点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.DataNodeTypeId); //数据结点类型Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Depth))
 {
 if (objDataNodeEN.Depth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.Depth, conDataNode.Depth); //深度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.Depth); //深度
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrevDataNodeId))
 {
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PrevDataNodeId, conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.NextDataNodeId))
 {
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.NextDataNodeId, conDataNode.NextDataNodeId); //后继数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.NextDataNodeId); //后继数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.SubGraphName))
 {
 if (objDataNodeEN.SubGraphName !=  null)
 {
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubGraphName, conDataNode.SubGraphName); //子图名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.SubGraphName); //子图名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.ErrMsg))
 {
 if (objDataNodeEN.ErrMsg !=  null)
 {
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDataNode.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.ErrMsg); //错误信息
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrjId))
 {
 if (objDataNodeEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDataNode.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PrjId); //工程Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosX))
 {
 if (objDataNodeEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosX, conDataNode.PosX); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosX); //位置X
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosY))
 {
 if (objDataNodeEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosY, conDataNode.PosY); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosY); //位置Y
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UsedTimes))
 {
 if (objDataNodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.UsedTimes, conDataNode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UsedTimes); //使用次数
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdDate))
 {
 if (objDataNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDataNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UpdDate); //修改日期
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdUser))
 {
 if (objDataNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDataNode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UpdUser); //修改者
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Memo))
 {
 if (objDataNodeEN.Memo !=  null)
 {
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDataNode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataNodeId = {0}", objDataNodeEN.DataNodeId); 
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
 /// <param name = "objDataNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataNodeEN objDataNodeEN, string strCondition)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNode Set ");
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeName))
 {
 if (objDataNodeEN.DataNodeName !=  null)
 {
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataNodeName = '{0}',", strDataNodeName); //数据结点名
 }
 else
 {
 sbSQL.Append(" DataNodeName = null,"); //数据结点名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.TabId))
 {
 if (objDataNodeEN.TabId !=  null)
 {
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.FldId))
 {
 if (objDataNodeEN.FldId !=  null)
 {
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.KeyFldLst))
 {
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyFldLst = '{0}',", strKeyFldLst); //关键字段Id列表
 }
 else
 {
 sbSQL.Append(" KeyFldLst = null,"); //关键字段Id列表
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.VersionNo))
 {
 sbSQL.AppendFormat(" VersionNo = {0},", objDataNodeEN.VersionNo); //版本号
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeTypeId))
 {
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataNodeTypeId = '{0}',", strDataNodeTypeId); //数据结点类型Id
 }
 else
 {
 sbSQL.Append(" DataNodeTypeId = null,"); //数据结点类型Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Depth))
 {
 if (objDataNodeEN.Depth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.Depth, conDataNode.Depth); //深度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.Depth); //深度
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrevDataNodeId))
 {
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PrevDataNodeId, conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.NextDataNodeId))
 {
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.NextDataNodeId, conDataNode.NextDataNodeId); //后继数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.NextDataNodeId); //后继数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.SubGraphName))
 {
 if (objDataNodeEN.SubGraphName !=  null)
 {
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubGraphName = '{0}',", strSubGraphName); //子图名
 }
 else
 {
 sbSQL.Append(" SubGraphName = null,"); //子图名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.ErrMsg))
 {
 if (objDataNodeEN.ErrMsg !=  null)
 {
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrjId))
 {
 if (objDataNodeEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosX))
 {
 if (objDataNodeEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosX, conDataNode.PosX); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosX); //位置X
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosY))
 {
 if (objDataNodeEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosY, conDataNode.PosY); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosY); //位置Y
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UsedTimes))
 {
 if (objDataNodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.UsedTimes, conDataNode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UsedTimes); //使用次数
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdDate))
 {
 if (objDataNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdUser))
 {
 if (objDataNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Memo))
 {
 if (objDataNodeEN.Memo !=  null)
 {
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDataNodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataNodeEN objDataNodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNode Set ");
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeName))
 {
 if (objDataNodeEN.DataNodeName !=  null)
 {
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataNodeName = '{0}',", strDataNodeName); //数据结点名
 }
 else
 {
 sbSQL.Append(" DataNodeName = null,"); //数据结点名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.TabId))
 {
 if (objDataNodeEN.TabId !=  null)
 {
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.FldId))
 {
 if (objDataNodeEN.FldId !=  null)
 {
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FldId = '{0}',", strFldId); //字段Id
 }
 else
 {
 sbSQL.Append(" FldId = null,"); //字段Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.KeyFldLst))
 {
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" KeyFldLst = '{0}',", strKeyFldLst); //关键字段Id列表
 }
 else
 {
 sbSQL.Append(" KeyFldLst = null,"); //关键字段Id列表
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.VersionNo))
 {
 sbSQL.AppendFormat(" VersionNo = {0},", objDataNodeEN.VersionNo); //版本号
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeTypeId))
 {
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DataNodeTypeId = '{0}',", strDataNodeTypeId); //数据结点类型Id
 }
 else
 {
 sbSQL.Append(" DataNodeTypeId = null,"); //数据结点类型Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Depth))
 {
 if (objDataNodeEN.Depth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.Depth, conDataNode.Depth); //深度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.Depth); //深度
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrevDataNodeId))
 {
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PrevDataNodeId, conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.NextDataNodeId))
 {
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.NextDataNodeId, conDataNode.NextDataNodeId); //后继数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.NextDataNodeId); //后继数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.SubGraphName))
 {
 if (objDataNodeEN.SubGraphName !=  null)
 {
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SubGraphName = '{0}',", strSubGraphName); //子图名
 }
 else
 {
 sbSQL.Append(" SubGraphName = null,"); //子图名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.ErrMsg))
 {
 if (objDataNodeEN.ErrMsg !=  null)
 {
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ErrMsg = '{0}',", strErrMsg); //错误信息
 }
 else
 {
 sbSQL.Append(" ErrMsg = null,"); //错误信息
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrjId))
 {
 if (objDataNodeEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosX))
 {
 if (objDataNodeEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosX, conDataNode.PosX); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosX); //位置X
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosY))
 {
 if (objDataNodeEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosY, conDataNode.PosY); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosY); //位置Y
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UsedTimes))
 {
 if (objDataNodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.UsedTimes, conDataNode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UsedTimes); //使用次数
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdDate))
 {
 if (objDataNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdUser))
 {
 if (objDataNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Memo))
 {
 if (objDataNodeEN.Memo !=  null)
 {
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDataNodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataNodeEN objDataNodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataNodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNode Set ");
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeName))
 {
 if (objDataNodeEN.DataNodeName !=  null)
 {
 var strDataNodeName = objDataNodeEN.DataNodeName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataNodeName, conDataNode.DataNodeName); //数据结点名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.DataNodeName); //数据结点名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.TabId))
 {
 if (objDataNodeEN.TabId !=  null)
 {
 var strTabId = objDataNodeEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conDataNode.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.TabId); //表ID
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.FldId))
 {
 if (objDataNodeEN.FldId !=  null)
 {
 var strFldId = objDataNodeEN.FldId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFldId, conDataNode.FldId); //字段Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.FldId); //字段Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.KeyFldLst))
 {
 if (objDataNodeEN.KeyFldLst !=  null)
 {
 var strKeyFldLst = objDataNodeEN.KeyFldLst.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strKeyFldLst, conDataNode.KeyFldLst); //关键字段Id列表
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.KeyFldLst); //关键字段Id列表
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.VersionNo))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.VersionNo, conDataNode.VersionNo); //版本号
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.DataNodeTypeId))
 {
 if (objDataNodeEN.DataNodeTypeId !=  null)
 {
 var strDataNodeTypeId = objDataNodeEN.DataNodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDataNodeTypeId, conDataNode.DataNodeTypeId); //数据结点类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.DataNodeTypeId); //数据结点类型Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Depth))
 {
 if (objDataNodeEN.Depth !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.Depth, conDataNode.Depth); //深度
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.Depth); //深度
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrevDataNodeId))
 {
 if (objDataNodeEN.PrevDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PrevDataNodeId, conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PrevDataNodeId); //前置数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.NextDataNodeId))
 {
 if (objDataNodeEN.NextDataNodeId !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.NextDataNodeId, conDataNode.NextDataNodeId); //后继数据结点Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.NextDataNodeId); //后继数据结点Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.SubGraphName))
 {
 if (objDataNodeEN.SubGraphName !=  null)
 {
 var strSubGraphName = objDataNodeEN.SubGraphName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSubGraphName, conDataNode.SubGraphName); //子图名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.SubGraphName); //子图名
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.ErrMsg))
 {
 if (objDataNodeEN.ErrMsg !=  null)
 {
 var strErrMsg = objDataNodeEN.ErrMsg.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strErrMsg, conDataNode.ErrMsg); //错误信息
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.ErrMsg); //错误信息
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PrjId))
 {
 if (objDataNodeEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDataNode.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PrjId); //工程Id
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosX))
 {
 if (objDataNodeEN.PosX !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosX, conDataNode.PosX); //位置X
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosX); //位置X
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.PosY))
 {
 if (objDataNodeEN.PosY !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.PosY, conDataNode.PosY); //位置Y
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.PosY); //位置Y
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UsedTimes))
 {
 if (objDataNodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeEN.UsedTimes, conDataNode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UsedTimes); //使用次数
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdDate))
 {
 if (objDataNodeEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDataNode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UpdDate); //修改日期
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.UpdUser))
 {
 if (objDataNodeEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDataNode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.UpdUser); //修改者
 }
 }
 
 if (objDataNodeEN.IsUpdated(conDataNode.Memo))
 {
 if (objDataNodeEN.Memo !=  null)
 {
 var strMemo = objDataNodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDataNode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNode.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where DataNodeId = {0}", objDataNodeEN.DataNodeId); 
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
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(long lngDataNodeId) 
{
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngDataNodeId,
};
 objSQL.ExecSP("DataNode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(long lngDataNodeId, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
//删除DataNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNode where DataNodeId = " + ""+ lngDataNodeId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataNode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
//删除DataNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNode where DataNodeId in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "lngDataNodeId">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(long lngDataNodeId) 
{
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
//删除DataNode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNode where DataNodeId = " + ""+ lngDataNodeId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataNodeDA: DelDataNode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataNode where " + strCondition ;
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
public bool DelDataNodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataNodeDA: DelDataNodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataNode where " + strCondition ;
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
 /// <param name = "objDataNodeENS">源对象</param>
 /// <param name = "objDataNodeENT">目标对象</param>
public void CopyTo(clsDataNodeEN objDataNodeENS, clsDataNodeEN objDataNodeENT)
{
objDataNodeENT.DataNodeId = objDataNodeENS.DataNodeId; //数据结点Id
objDataNodeENT.DataNodeName = objDataNodeENS.DataNodeName; //数据结点名
objDataNodeENT.TabId = objDataNodeENS.TabId; //表ID
objDataNodeENT.FldId = objDataNodeENS.FldId; //字段Id
objDataNodeENT.KeyFldLst = objDataNodeENS.KeyFldLst; //关键字段Id列表
objDataNodeENT.VersionNo = objDataNodeENS.VersionNo; //版本号
objDataNodeENT.DataNodeTypeId = objDataNodeENS.DataNodeTypeId; //数据结点类型Id
objDataNodeENT.Depth = objDataNodeENS.Depth; //深度
objDataNodeENT.PrevDataNodeId = objDataNodeENS.PrevDataNodeId; //前置数据结点Id
objDataNodeENT.NextDataNodeId = objDataNodeENS.NextDataNodeId; //后继数据结点Id
objDataNodeENT.SubGraphName = objDataNodeENS.SubGraphName; //子图名
objDataNodeENT.ErrMsg = objDataNodeENS.ErrMsg; //错误信息
objDataNodeENT.PrjId = objDataNodeENS.PrjId; //工程Id
objDataNodeENT.PosX = objDataNodeENS.PosX; //位置X
objDataNodeENT.PosY = objDataNodeENS.PosY; //位置Y
objDataNodeENT.UsedTimes = objDataNodeENS.UsedTimes; //使用次数
objDataNodeENT.UpdDate = objDataNodeENS.UpdDate; //修改日期
objDataNodeENT.UpdUser = objDataNodeENS.UpdUser; //修改者
objDataNodeENT.Memo = objDataNodeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataNodeEN objDataNodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataNodeEN.DataNodeName, conDataNode.DataNodeName);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.TabId, conDataNode.TabId);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.FldId, conDataNode.FldId);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.VersionNo, conDataNode.VersionNo);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.DataNodeTypeId, conDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.PrjId, conDataNode.PrjId);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.UpdDate, conDataNode.UpdDate);
clsCheckSql.CheckFieldNotNull(objDataNodeEN.UpdUser, conDataNode.UpdUser);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeEN.DataNodeName, 100, conDataNode.DataNodeName);
clsCheckSql.CheckFieldLen(objDataNodeEN.TabId, 8, conDataNode.TabId);
clsCheckSql.CheckFieldLen(objDataNodeEN.FldId, 8, conDataNode.FldId);
clsCheckSql.CheckFieldLen(objDataNodeEN.KeyFldLst, 100, conDataNode.KeyFldLst);
clsCheckSql.CheckFieldLen(objDataNodeEN.DataNodeTypeId, 2, conDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldLen(objDataNodeEN.SubGraphName, 50, conDataNode.SubGraphName);
clsCheckSql.CheckFieldLen(objDataNodeEN.ErrMsg, 2000, conDataNode.ErrMsg);
clsCheckSql.CheckFieldLen(objDataNodeEN.PrjId, 4, conDataNode.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeEN.UpdDate, 20, conDataNode.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeEN.UpdUser, 20, conDataNode.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeEN.Memo, 1000, conDataNode.Memo);
//检查字段外键固定长度
 objDataNodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataNodeEN objDataNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeEN.DataNodeName, 100, conDataNode.DataNodeName);
clsCheckSql.CheckFieldLen(objDataNodeEN.TabId, 8, conDataNode.TabId);
clsCheckSql.CheckFieldLen(objDataNodeEN.FldId, 8, conDataNode.FldId);
clsCheckSql.CheckFieldLen(objDataNodeEN.KeyFldLst, 100, conDataNode.KeyFldLst);
clsCheckSql.CheckFieldLen(objDataNodeEN.DataNodeTypeId, 2, conDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldLen(objDataNodeEN.SubGraphName, 50, conDataNode.SubGraphName);
clsCheckSql.CheckFieldLen(objDataNodeEN.ErrMsg, 2000, conDataNode.ErrMsg);
clsCheckSql.CheckFieldLen(objDataNodeEN.PrjId, 4, conDataNode.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeEN.UpdDate, 20, conDataNode.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeEN.UpdUser, 20, conDataNode.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeEN.Memo, 1000, conDataNode.Memo);
//检查外键字段长度
 objDataNodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataNodeEN objDataNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeEN.DataNodeName, 100, conDataNode.DataNodeName);
clsCheckSql.CheckFieldLen(objDataNodeEN.TabId, 8, conDataNode.TabId);
clsCheckSql.CheckFieldLen(objDataNodeEN.FldId, 8, conDataNode.FldId);
clsCheckSql.CheckFieldLen(objDataNodeEN.KeyFldLst, 100, conDataNode.KeyFldLst);
clsCheckSql.CheckFieldLen(objDataNodeEN.DataNodeTypeId, 2, conDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldLen(objDataNodeEN.SubGraphName, 50, conDataNode.SubGraphName);
clsCheckSql.CheckFieldLen(objDataNodeEN.ErrMsg, 2000, conDataNode.ErrMsg);
clsCheckSql.CheckFieldLen(objDataNodeEN.PrjId, 4, conDataNode.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeEN.UpdDate, 20, conDataNode.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeEN.UpdUser, 20, conDataNode.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeEN.Memo, 1000, conDataNode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.DataNodeName, conDataNode.DataNodeName);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.TabId, conDataNode.TabId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.FldId, conDataNode.FldId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.KeyFldLst, conDataNode.KeyFldLst);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.DataNodeTypeId, conDataNode.DataNodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.SubGraphName, conDataNode.SubGraphName);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.ErrMsg, conDataNode.ErrMsg);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.PrjId, conDataNode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.UpdDate, conDataNode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.UpdUser, conDataNode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDataNodeEN.Memo, conDataNode.Memo);
//检查外键字段长度
 objDataNodeEN._IsCheckProperty = true;
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
string strSQL = "select DataNodeId, DataNodeName from DataNode ";
 clsSpecSQLforSql mySql = clsDataNodeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DataNode(数据结点),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataNodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDataNodeEN objDataNodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and TabId = '{0}'", objDataNodeEN.TabId);
 sbCondition.AppendFormat(" and FldId = '{0}'", objDataNodeEN.FldId);
 if (objDataNodeEN.KeyFldLst == null)
{
 sbCondition.AppendFormat(" and KeyFldLst is null");
}
else
{
 sbCondition.AppendFormat(" and KeyFldLst = '{0}'", objDataNodeEN.KeyFldLst);
}
 sbCondition.AppendFormat(" and VersionNo = '{0}'", objDataNodeEN.VersionNo);
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataNodeEN._CurrTabName);
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataNodeEN._CurrTabName, strCondition);
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}