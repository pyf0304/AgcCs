
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDataNodeDA
 表名:vDataNode(00050569)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:26:48
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
 /// vDataNode(vDataNode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDataNodeDA : clsCommBase4DA
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
 return clsvDataNodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDataNodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDataNodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDataNodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDataNodeEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDataNode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable_vDataNode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDataNode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDataNode.* " + 
$"from vDataNode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDataNode.DataNodeId not in " + 
$"(Select top {intTop_In} vDataNode.DataNodeId from vDataNode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNode where {1} and DataNodeId not in (Select top {2} DataNodeId from vDataNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNode where {1} and DataNodeId not in (Select top {3} DataNodeId from vDataNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDataNodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDataNode.* " + 
$"from vDataNode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDataNode.DataNodeId not in " + 
$"(Select top {intTop_In} vDataNode.DataNodeId from vDataNode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDataNode where {1} and DataNodeId not in (Select top {2} DataNodeId from vDataNode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDataNode where {1} and DataNodeId not in (Select top {3} DataNodeId from vDataNode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDataNodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDataNodeDA:GetObjLst)", objException.Message));
}
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = TransNullToInt(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = TransNullToInt(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataNodeDA: GetObjLst)", objException.Message));
}
objvDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataNodeEN);
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
public List<clsvDataNodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDataNodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDataNodeEN> arrObjLst = new List<clsvDataNodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = TransNullToInt(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = TransNullToInt(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDataNodeDA: GetObjLst)", objException.Message));
}
objvDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDataNodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDataNodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDataNode(ref clsvDataNodeEN objvDataNodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where DataNodeId = " + ""+ objvDataNodeEN.DataNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDataNodeEN.DataNodeId = TransNullToInt(objDT.Rows[0][convDataNode.DataNodeId].ToString().Trim()); //数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDataNodeEN.DataNodeName = objDT.Rows[0][convDataNode.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNodeEN.TabId = objDT.Rows[0][convDataNode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeEN.TabName = objDT.Rows[0][convDataNode.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvDataNodeEN.FldId = objDT.Rows[0][convDataNode.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeEN.FldName = objDT.Rows[0][convDataNode.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDataNodeEN.VersionNo = TransNullToInt(objDT.Rows[0][convDataNode.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvDataNodeEN.DataNodeTypeId = objDT.Rows[0][convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNodeEN.DataNodeTypeName = objDT.Rows[0][convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeEN.SubGraphName = objDT.Rows[0][convDataNode.SubGraphName].ToString().Trim(); //子图名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeEN.PrjId = objDT.Rows[0][convDataNode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataNodeEN.UpdDate = objDT.Rows[0][convDataNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeEN.UpdUser = objDT.Rows[0][convDataNode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeEN.Memo = objDT.Rows[0][convDataNode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDataNodeDA: GetvDataNode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngDataNodeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDataNodeEN GetObjByDataNodeId(long lngDataNodeId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where DataNodeId = " + ""+ lngDataNodeId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
 objvDataNodeEN.DataNodeId = Int32.Parse(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名(字段类型:varchar,字段长度:100,是否可空:True)
 objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id(字段类型:char,字段长度:8,是否可空:False)
 objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名(字段类型:varchar,字段长度:50,是否可空:False)
 objvDataNodeEN.VersionNo = Int32.Parse(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号(字段类型:int,字段长度:4,是否可空:True)
 objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id(字段类型:char,字段长度:2,是否可空:True)
 objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名(字段类型:varchar,字段长度:50,是否可空:True)
 objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDataNodeDA: GetObjByDataNodeId)", objException.Message));
}
return objvDataNodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDataNodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDataNodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
strSQL = "Select * from vDataNode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN()
{
DataNodeId = TransNullToInt(objRow[convDataNode.DataNodeId].ToString().Trim()), //数据结点Id
DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(), //数据结点名
TabId = objRow[convDataNode.TabId].ToString().Trim(), //表ID
TabName = objRow[convDataNode.TabName].ToString().Trim(), //表名
FldId = objRow[convDataNode.FldId].ToString().Trim(), //字段Id
FldName = objRow[convDataNode.FldName].ToString().Trim(), //字段名
VersionNo = TransNullToInt(objRow[convDataNode.VersionNo].ToString().Trim()), //版本号
DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(), //数据结点类型Id
DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(), //数据结点类型名
SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(), //子图名
PrjId = objRow[convDataNode.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim() //说明
};
objvDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDataNodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDataNodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = TransNullToInt(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = TransNullToInt(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDataNodeDA: GetObjByDataRowvDataNode)", objException.Message));
}
objvDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDataNodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDataNodeEN objvDataNodeEN = new clsvDataNodeEN();
try
{
objvDataNodeEN.DataNodeId = TransNullToInt(objRow[convDataNode.DataNodeId].ToString().Trim()); //数据结点Id
objvDataNodeEN.DataNodeName = objRow[convDataNode.DataNodeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeName].ToString().Trim(); //数据结点名
objvDataNodeEN.TabId = objRow[convDataNode.TabId].ToString().Trim(); //表ID
objvDataNodeEN.TabName = objRow[convDataNode.TabName].ToString().Trim(); //表名
objvDataNodeEN.FldId = objRow[convDataNode.FldId].ToString().Trim(); //字段Id
objvDataNodeEN.FldName = objRow[convDataNode.FldName].ToString().Trim(); //字段名
objvDataNodeEN.VersionNo = TransNullToInt(objRow[convDataNode.VersionNo].ToString().Trim()); //版本号
objvDataNodeEN.DataNodeTypeId = objRow[convDataNode.DataNodeTypeId] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeId].ToString().Trim(); //数据结点类型Id
objvDataNodeEN.DataNodeTypeName = objRow[convDataNode.DataNodeTypeName] == DBNull.Value ? null : objRow[convDataNode.DataNodeTypeName].ToString().Trim(); //数据结点类型名
objvDataNodeEN.SubGraphName = objRow[convDataNode.SubGraphName] == DBNull.Value ? null : objRow[convDataNode.SubGraphName].ToString().Trim(); //子图名
objvDataNodeEN.PrjId = objRow[convDataNode.PrjId].ToString().Trim(); //工程Id
objvDataNodeEN.UpdDate = objRow[convDataNode.UpdDate] == DBNull.Value ? null : objRow[convDataNode.UpdDate].ToString().Trim(); //修改日期
objvDataNodeEN.UpdUser = objRow[convDataNode.UpdUser] == DBNull.Value ? null : objRow[convDataNode.UpdUser].ToString().Trim(); //修改者
objvDataNodeEN.Memo = objRow[convDataNode.Memo] == DBNull.Value ? null : objRow[convDataNode.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDataNodeDA: GetObjByDataRow)", objException.Message));
}
objvDataNodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDataNodeEN;
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
objSQL = clsvDataNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataNodeEN._CurrTabName, convDataNode.DataNodeId, 8, "");
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
objSQL = clsvDataNodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDataNodeEN._CurrTabName, convDataNode.DataNodeId, 8, strPrefix);
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DataNodeId from vDataNode where " + strCondition;
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DataNodeId from vDataNode where " + strCondition;
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataNode", "DataNodeId = " + ""+ lngDataNodeId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDataNodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDataNode", strCondition))
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
objSQL = clsvDataNodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDataNode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDataNodeENS">源对象</param>
 /// <param name = "objvDataNodeENT">目标对象</param>
public void CopyTo(clsvDataNodeEN objvDataNodeENS, clsvDataNodeEN objvDataNodeENT)
{
objvDataNodeENT.DataNodeId = objvDataNodeENS.DataNodeId; //数据结点Id
objvDataNodeENT.DataNodeName = objvDataNodeENS.DataNodeName; //数据结点名
objvDataNodeENT.TabId = objvDataNodeENS.TabId; //表ID
objvDataNodeENT.TabName = objvDataNodeENS.TabName; //表名
objvDataNodeENT.FldId = objvDataNodeENS.FldId; //字段Id
objvDataNodeENT.FldName = objvDataNodeENS.FldName; //字段名
objvDataNodeENT.VersionNo = objvDataNodeENS.VersionNo; //版本号
objvDataNodeENT.DataNodeTypeId = objvDataNodeENS.DataNodeTypeId; //数据结点类型Id
objvDataNodeENT.DataNodeTypeName = objvDataNodeENS.DataNodeTypeName; //数据结点类型名
objvDataNodeENT.SubGraphName = objvDataNodeENS.SubGraphName; //子图名
objvDataNodeENT.PrjId = objvDataNodeENS.PrjId; //工程Id
objvDataNodeENT.UpdDate = objvDataNodeENS.UpdDate; //修改日期
objvDataNodeENT.UpdUser = objvDataNodeENS.UpdUser; //修改者
objvDataNodeENT.Memo = objvDataNodeENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDataNodeEN objvDataNodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDataNodeEN.DataNodeName, 100, convDataNode.DataNodeName);
clsCheckSql.CheckFieldLen(objvDataNodeEN.TabId, 8, convDataNode.TabId);
clsCheckSql.CheckFieldLen(objvDataNodeEN.TabName, 100, convDataNode.TabName);
clsCheckSql.CheckFieldLen(objvDataNodeEN.FldId, 8, convDataNode.FldId);
clsCheckSql.CheckFieldLen(objvDataNodeEN.FldName, 50, convDataNode.FldName);
clsCheckSql.CheckFieldLen(objvDataNodeEN.DataNodeTypeId, 2, convDataNode.DataNodeTypeId);
clsCheckSql.CheckFieldLen(objvDataNodeEN.DataNodeTypeName, 50, convDataNode.DataNodeTypeName);
clsCheckSql.CheckFieldLen(objvDataNodeEN.SubGraphName, 50, convDataNode.SubGraphName);
clsCheckSql.CheckFieldLen(objvDataNodeEN.PrjId, 4, convDataNode.PrjId);
clsCheckSql.CheckFieldLen(objvDataNodeEN.UpdDate, 20, convDataNode.UpdDate);
clsCheckSql.CheckFieldLen(objvDataNodeEN.UpdUser, 20, convDataNode.UpdUser);
clsCheckSql.CheckFieldLen(objvDataNodeEN.Memo, 1000, convDataNode.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.DataNodeName, convDataNode.DataNodeName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.TabId, convDataNode.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.TabName, convDataNode.TabName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.FldId, convDataNode.FldId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.FldName, convDataNode.FldName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.DataNodeTypeId, convDataNode.DataNodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.DataNodeTypeName, convDataNode.DataNodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.SubGraphName, convDataNode.SubGraphName);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.PrjId, convDataNode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.UpdDate, convDataNode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.UpdUser, convDataNode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvDataNodeEN.Memo, convDataNode.Memo);
//检查外键字段长度
 objvDataNodeEN._IsCheckProperty = true;
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
string strSQL = "select DataNodeId, DataNodeName from vDataNode ";
 clsSpecSQLforSql mySql = clsvDataNodeDA.GetSpecSQLObj();
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataNodeEN._CurrTabName);
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDataNodeEN._CurrTabName, strCondition);
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
 objSQL = clsvDataNodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}