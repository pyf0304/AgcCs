
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsDataNodeDirectMapDA
 表名:DataNodeDirectMap(00050570)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:32:25
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
 /// 数据结点直接映射(DataNodeDirectMap)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsDataNodeDirectMapDA : clsCommBase4DA
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
 return clsDataNodeDirectMapEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsDataNodeDirectMapEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsDataNodeDirectMapEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsDataNodeDirectMapEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsDataNodeDirectMapEN._ConnectString);
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_DataNodeDirectMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable_DataNodeDirectMap)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataNodeDirectMap.* " + 
$"from DataNodeDirectMap " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataNodeDirectMap.mId not in " + 
$"(Select top {intTop_In} DataNodeDirectMap.mId from DataNodeDirectMap " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1} and mId not in (Select top {2} mId from DataNodeDirectMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1} and mId not in (Select top {3} mId from DataNodeDirectMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} DataNodeDirectMap.* " + 
$"from DataNodeDirectMap " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and DataNodeDirectMap.mId not in " + 
$"(Select top {intTop_In} DataNodeDirectMap.mId from DataNodeDirectMap " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1} and mId not in (Select top {2} mId from DataNodeDirectMap where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from DataNodeDirectMap where {1} and mId not in (Select top {3} mId from DataNodeDirectMap where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsDataNodeDirectMapEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA:GetObjLst)", objException.Message));
}
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = TransNullToInt(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetObjLst)", objException.Message));
}
objDataNodeDirectMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataNodeDirectMapEN);
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
public List<clsDataNodeDirectMapEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA:GetObjLstByTabName)", objException.Message));
}
List<clsDataNodeDirectMapEN> arrObjLst = new List<clsDataNodeDirectMapEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = TransNullToInt(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetObjLst)", objException.Message));
}
objDataNodeDirectMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objDataNodeDirectMapEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetDataNodeDirectMap(ref clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where mId = " + ""+ objDataNodeDirectMapEN.mId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objDataNodeDirectMapEN.mId = TransNullToInt(objDT.Rows[0][conDataNodeDirectMap.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDataNodeDirectMapEN.InDataNodeId = TransNullToInt(objDT.Rows[0][conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeDirectMapEN.OutDataNodeId = TransNullToInt(objDT.Rows[0][conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeDirectMapEN.AssociationMappingId = objDT.Rows[0][conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeDirectMapEN.FuncMapModeId = objDT.Rows[0][conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeDirectMapEN.TabId = objDT.Rows[0][conDataNodeDirectMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeDirectMapEN.DnFunctionId = objDT.Rows[0][conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeDirectMapEN.PrjId = objDT.Rows[0][conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDataNodeDirectMapEN.UpdDate = objDT.Rows[0][conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeDirectMapEN.UpdUser = objDT.Rows[0][conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeDirectMapEN.Memo = objDT.Rows[0][conDataNodeDirectMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetDataNodeDirectMap)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "lngmId">表关键字</param>
 /// <returns>表对象</returns>
public clsDataNodeDirectMapEN GetObjBymId(long lngmId)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where mId = " + ""+ lngmId+"";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
 objDataNodeDirectMapEN.mId = Int32.Parse(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId(字段类型:bigint,字段长度:8,是否可空:False)
 objDataNodeDirectMapEN.InDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeDirectMapEN.OutDataNodeId = Int32.Parse(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetObjBymId)", objException.Message));
}
return objDataNodeDirectMapEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsDataNodeDirectMapEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN()
{
mId = TransNullToInt(objRow[conDataNodeDirectMap.mId].ToString().Trim()), //mId
InDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()), //In数据结点Id
OutDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()), //Out数据结点Id
AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(), //关联关系映射Id
FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(), //函数映射模式Id
TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(), //表ID
DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(), //DN函数Id
PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim() //说明
};
objDataNodeDirectMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeDirectMapEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsDataNodeDirectMapEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = TransNullToInt(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetObjByDataRowDataNodeDirectMap)", objException.Message));
}
objDataNodeDirectMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeDirectMapEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsDataNodeDirectMapEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsDataNodeDirectMapEN objDataNodeDirectMapEN = new clsDataNodeDirectMapEN();
try
{
objDataNodeDirectMapEN.mId = TransNullToInt(objRow[conDataNodeDirectMap.mId].ToString().Trim()); //mId
objDataNodeDirectMapEN.InDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim()); //In数据结点Id
objDataNodeDirectMapEN.OutDataNodeId = TransNullToInt(objRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objDataNodeDirectMapEN.AssociationMappingId = objRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objDataNodeDirectMapEN.FuncMapModeId = objRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objDataNodeDirectMapEN.TabId = objRow[conDataNodeDirectMap.TabId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objDataNodeDirectMapEN.DnFunctionId = objRow[conDataNodeDirectMap.DnFunctionId] == DBNull.Value ? null : objRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objDataNodeDirectMapEN.PrjId = objRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objDataNodeDirectMapEN.UpdDate = objRow[conDataNodeDirectMap.UpdDate] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objDataNodeDirectMapEN.UpdUser = objRow[conDataNodeDirectMap.UpdUser] == DBNull.Value ? null : objRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objDataNodeDirectMapEN.Memo = objRow[conDataNodeDirectMap.Memo] == DBNull.Value ? null : objRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsDataNodeDirectMapDA: GetObjByDataRow)", objException.Message));
}
objDataNodeDirectMapEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objDataNodeDirectMapEN;
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
objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataNodeDirectMapEN._CurrTabName, conDataNodeDirectMap.mId, 8, "");
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
objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsDataNodeDirectMapEN._CurrTabName, conDataNodeDirectMap.mId, 8, strPrefix);
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select mId from DataNodeDirectMap where " + strCondition;
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select mId from DataNodeDirectMap where " + strCondition;
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataNodeDirectMap", "mId = " + ""+ lngmId+""))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("DataNodeDirectMap", strCondition))
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
objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("DataNodeDirectMap");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
 {
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeDirectMapEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataNodeDirectMap");
objRow = objDS.Tables["DataNodeDirectMap"].NewRow();
objRow[conDataNodeDirectMap.InDataNodeId] = objDataNodeDirectMapEN.InDataNodeId; //In数据结点Id
objRow[conDataNodeDirectMap.OutDataNodeId] = objDataNodeDirectMapEN.OutDataNodeId; //Out数据结点Id
objRow[conDataNodeDirectMap.AssociationMappingId] = objDataNodeDirectMapEN.AssociationMappingId; //关联关系映射Id
objRow[conDataNodeDirectMap.FuncMapModeId] = objDataNodeDirectMapEN.FuncMapModeId; //函数映射模式Id
 if (objDataNodeDirectMapEN.TabId !=  "")
 {
objRow[conDataNodeDirectMap.TabId] = objDataNodeDirectMapEN.TabId; //表ID
 }
 if (objDataNodeDirectMapEN.DnFunctionId !=  "")
 {
objRow[conDataNodeDirectMap.DnFunctionId] = objDataNodeDirectMapEN.DnFunctionId; //DN函数Id
 }
objRow[conDataNodeDirectMap.PrjId] = objDataNodeDirectMapEN.PrjId; //工程Id
 if (objDataNodeDirectMapEN.UpdDate !=  "")
 {
objRow[conDataNodeDirectMap.UpdDate] = objDataNodeDirectMapEN.UpdDate; //修改日期
 }
 if (objDataNodeDirectMapEN.UpdUser !=  "")
 {
objRow[conDataNodeDirectMap.UpdUser] = objDataNodeDirectMapEN.UpdUser; //修改者
 }
 if (objDataNodeDirectMapEN.Memo !=  "")
 {
objRow[conDataNodeDirectMap.Memo] = objDataNodeDirectMapEN.Memo; //说明
 }
objDS.Tables[clsDataNodeDirectMapEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsDataNodeDirectMapEN._CurrTabName);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeDirectMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.InDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.OutDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.OutDataNodeId.ToString());
 
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.AssociationMappingId);
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.FuncMapModeId);
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.TabId);
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.DnFunctionId);
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.PrjId);
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdDate);
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdUser);
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.Memo);
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeDirectMap");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeDirectMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.InDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.OutDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.OutDataNodeId.ToString());
 
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.AssociationMappingId);
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.FuncMapModeId);
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.TabId);
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.DnFunctionId);
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.PrjId);
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdDate);
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdUser);
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.Memo);
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeDirectMap");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString()).Rows[0][0].ToString();
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsDataNodeDirectMapEN objDataNodeDirectMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeDirectMapEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.InDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.OutDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.OutDataNodeId.ToString());
 
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.AssociationMappingId);
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.FuncMapModeId);
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.TabId);
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.DnFunctionId);
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.PrjId);
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdDate);
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdUser);
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.Memo);
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeDirectMap");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 strSQL.Append(" select @@identity;");
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
return objSQL.GetDataTable(strSQL.ToString(), objSqlConnection, objSqlTransaction).Rows[0][0].ToString();
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsDataNodeDirectMapEN objDataNodeDirectMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objDataNodeDirectMapEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.InDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.InDataNodeId.ToString());
 
 arrFieldListForInsert.Add(conDataNodeDirectMap.OutDataNodeId);
 arrValueListForInsert.Add(objDataNodeDirectMapEN.OutDataNodeId.ToString());
 
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.AssociationMappingId);
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strAssociationMappingId + "'");
 }
 
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.FuncMapModeId);
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncMapModeId + "'");
 }
 
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.TabId);
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strTabId + "'");
 }
 
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.DnFunctionId);
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strDnFunctionId + "'");
 }
 
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.PrjId);
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdDate);
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.UpdUser);
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conDataNodeDirectMap.Memo);
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into DataNodeDirectMap");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewDataNodeDirectMaps(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where mId = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "DataNodeDirectMap");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
long lngmId = TransNullToInt(oRow[conDataNodeDirectMap.mId].ToString().Trim());
if (IsExist(lngmId))
{
 string strResult = "关键字变量值为:" + string.Format("mId = {0}", lngmId) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsDataNodeDirectMapEN._CurrTabName ].NewRow();
objRow[conDataNodeDirectMap.InDataNodeId] = oRow[conDataNodeDirectMap.InDataNodeId].ToString().Trim(); //In数据结点Id
objRow[conDataNodeDirectMap.OutDataNodeId] = oRow[conDataNodeDirectMap.OutDataNodeId].ToString().Trim(); //Out数据结点Id
objRow[conDataNodeDirectMap.AssociationMappingId] = oRow[conDataNodeDirectMap.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objRow[conDataNodeDirectMap.FuncMapModeId] = oRow[conDataNodeDirectMap.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objRow[conDataNodeDirectMap.TabId] = oRow[conDataNodeDirectMap.TabId].ToString().Trim(); //表ID
objRow[conDataNodeDirectMap.DnFunctionId] = oRow[conDataNodeDirectMap.DnFunctionId].ToString().Trim(); //DN函数Id
objRow[conDataNodeDirectMap.PrjId] = oRow[conDataNodeDirectMap.PrjId].ToString().Trim(); //工程Id
objRow[conDataNodeDirectMap.UpdDate] = oRow[conDataNodeDirectMap.UpdDate].ToString().Trim(); //修改日期
objRow[conDataNodeDirectMap.UpdUser] = oRow[conDataNodeDirectMap.UpdUser].ToString().Trim(); //修改者
objRow[conDataNodeDirectMap.Memo] = oRow[conDataNodeDirectMap.Memo].ToString().Trim(); //说明
 objDS.Tables[clsDataNodeDirectMapEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsDataNodeDirectMapEN._CurrTabName);
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
 /// <param name = "objDataNodeDirectMapEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeDirectMapEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
strSQL = "Select * from DataNodeDirectMap where mId = " + ""+ objDataNodeDirectMapEN.mId+"";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsDataNodeDirectMapEN._CurrTabName);
if (objDS.Tables[clsDataNodeDirectMapEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:mId = " + ""+ objDataNodeDirectMapEN.mId+"");
return false;
}
objRow = objDS.Tables[clsDataNodeDirectMapEN._CurrTabName].Rows[0];
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.InDataNodeId))
 {
objRow[conDataNodeDirectMap.InDataNodeId] = objDataNodeDirectMapEN.InDataNodeId; //In数据结点Id
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.OutDataNodeId))
 {
objRow[conDataNodeDirectMap.OutDataNodeId] = objDataNodeDirectMapEN.OutDataNodeId; //Out数据结点Id
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.AssociationMappingId))
 {
objRow[conDataNodeDirectMap.AssociationMappingId] = objDataNodeDirectMapEN.AssociationMappingId; //关联关系映射Id
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.FuncMapModeId))
 {
objRow[conDataNodeDirectMap.FuncMapModeId] = objDataNodeDirectMapEN.FuncMapModeId; //函数映射模式Id
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.TabId))
 {
objRow[conDataNodeDirectMap.TabId] = objDataNodeDirectMapEN.TabId; //表ID
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.DnFunctionId))
 {
objRow[conDataNodeDirectMap.DnFunctionId] = objDataNodeDirectMapEN.DnFunctionId; //DN函数Id
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.PrjId))
 {
objRow[conDataNodeDirectMap.PrjId] = objDataNodeDirectMapEN.PrjId; //工程Id
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdDate))
 {
objRow[conDataNodeDirectMap.UpdDate] = objDataNodeDirectMapEN.UpdDate; //修改日期
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdUser))
 {
objRow[conDataNodeDirectMap.UpdUser] = objDataNodeDirectMapEN.UpdUser; //修改者
 }
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.Memo))
 {
objRow[conDataNodeDirectMap.Memo] = objDataNodeDirectMapEN.Memo; //说明
 }
try
{
objDA.Update(objDS, clsDataNodeDirectMapEN._CurrTabName);
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeDirectMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update DataNodeDirectMap Set ");
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.InDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeDirectMapEN.InDataNodeId, conDataNodeDirectMap.InDataNodeId); //In数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.OutDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeDirectMapEN.OutDataNodeId, conDataNodeDirectMap.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.AssociationMappingId))
 {
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDataNodeDirectMap.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.FuncMapModeId))
 {
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeId, conDataNodeDirectMap.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.FuncMapModeId); //函数映射模式Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.TabId))
 {
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conDataNodeDirectMap.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.TabId); //表ID
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.DnFunctionId))
 {
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnFunctionId, conDataNodeDirectMap.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.DnFunctionId); //DN函数Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.PrjId))
 {
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDataNodeDirectMap.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.PrjId); //工程Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdDate))
 {
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDataNodeDirectMap.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.UpdDate); //修改日期
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdUser))
 {
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDataNodeDirectMap.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.UpdUser); //修改者
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.Memo))
 {
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDataNodeDirectMap.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDataNodeDirectMapEN.mId); 
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
 /// <param name = "objDataNodeDirectMapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strCondition)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeDirectMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNodeDirectMap Set ");
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.InDataNodeId))
 {
 sbSQL.AppendFormat(" InDataNodeId = {0},", objDataNodeDirectMapEN.InDataNodeId); //In数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.OutDataNodeId))
 {
 sbSQL.AppendFormat(" OutDataNodeId = {0},", objDataNodeDirectMapEN.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.AssociationMappingId))
 {
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.FuncMapModeId))
 {
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeId = '{0}',", strFuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.Append(" FuncMapModeId = null,"); //函数映射模式Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.TabId))
 {
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.DnFunctionId))
 {
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionId = '{0}',", strDnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.Append(" DnFunctionId = null,"); //DN函数Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.PrjId))
 {
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdDate))
 {
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdUser))
 {
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.Memo))
 {
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDataNodeDirectMapEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsDataNodeDirectMapEN objDataNodeDirectMapEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeDirectMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNodeDirectMap Set ");
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.InDataNodeId))
 {
 sbSQL.AppendFormat(" InDataNodeId = {0},", objDataNodeDirectMapEN.InDataNodeId); //In数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.OutDataNodeId))
 {
 sbSQL.AppendFormat(" OutDataNodeId = {0},", objDataNodeDirectMapEN.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.AssociationMappingId))
 {
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" AssociationMappingId = '{0}',", strAssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.Append(" AssociationMappingId = null,"); //关联关系映射Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.FuncMapModeId))
 {
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncMapModeId = '{0}',", strFuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.Append(" FuncMapModeId = null,"); //函数映射模式Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.TabId))
 {
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" TabId = '{0}',", strTabId); //表ID
 }
 else
 {
 sbSQL.Append(" TabId = null,"); //表ID
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.DnFunctionId))
 {
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" DnFunctionId = '{0}',", strDnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.Append(" DnFunctionId = null,"); //DN函数Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.PrjId))
 {
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdDate))
 {
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdUser))
 {
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.Memo))
 {
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
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
 /// <param name = "objDataNodeDirectMapEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsDataNodeDirectMapEN objDataNodeDirectMapEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objDataNodeDirectMapEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objDataNodeDirectMapEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objDataNodeDirectMapEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update DataNodeDirectMap Set ");
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.InDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeDirectMapEN.InDataNodeId, conDataNodeDirectMap.InDataNodeId); //In数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.OutDataNodeId))
 {
 sbSQL.AppendFormat("{1} = {0},",objDataNodeDirectMapEN.OutDataNodeId, conDataNodeDirectMap.OutDataNodeId); //Out数据结点Id
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.AssociationMappingId))
 {
 if (objDataNodeDirectMapEN.AssociationMappingId !=  null)
 {
 var strAssociationMappingId = objDataNodeDirectMapEN.AssociationMappingId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strAssociationMappingId, conDataNodeDirectMap.AssociationMappingId); //关联关系映射Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.AssociationMappingId); //关联关系映射Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.FuncMapModeId))
 {
 if (objDataNodeDirectMapEN.FuncMapModeId !=  null)
 {
 var strFuncMapModeId = objDataNodeDirectMapEN.FuncMapModeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncMapModeId, conDataNodeDirectMap.FuncMapModeId); //函数映射模式Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.FuncMapModeId); //函数映射模式Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.TabId))
 {
 if (objDataNodeDirectMapEN.TabId !=  null)
 {
 var strTabId = objDataNodeDirectMapEN.TabId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strTabId, conDataNodeDirectMap.TabId); //表ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.TabId); //表ID
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.DnFunctionId))
 {
 if (objDataNodeDirectMapEN.DnFunctionId !=  null)
 {
 var strDnFunctionId = objDataNodeDirectMapEN.DnFunctionId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strDnFunctionId, conDataNodeDirectMap.DnFunctionId); //DN函数Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.DnFunctionId); //DN函数Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.PrjId))
 {
 if (objDataNodeDirectMapEN.PrjId !=  null)
 {
 var strPrjId = objDataNodeDirectMapEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conDataNodeDirectMap.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.PrjId); //工程Id
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdDate))
 {
 if (objDataNodeDirectMapEN.UpdDate !=  null)
 {
 var strUpdDate = objDataNodeDirectMapEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conDataNodeDirectMap.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.UpdDate); //修改日期
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.UpdUser))
 {
 if (objDataNodeDirectMapEN.UpdUser !=  null)
 {
 var strUpdUser = objDataNodeDirectMapEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conDataNodeDirectMap.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.UpdUser); //修改者
 }
 }
 
 if (objDataNodeDirectMapEN.IsUpdated(conDataNodeDirectMap.Memo))
 {
 if (objDataNodeDirectMapEN.Memo !=  null)
 {
 var strMemo = objDataNodeDirectMapEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conDataNodeDirectMap.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conDataNodeDirectMap.Memo); //说明
 }
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where mId = {0}", objDataNodeDirectMapEN.mId); 
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 lngmId,
};
 objSQL.ExecSP("DataNodeDirectMap_Delete", values);
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
//删除DataNodeDirectMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNodeDirectMap where mId = " + ""+ lngmId+"";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelDataNodeDirectMap(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
//删除DataNodeDirectMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNodeDirectMap where mId in (" + strKeyList + ")";
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
//删除DataNodeDirectMap本表中与当前对象有关的记录
strSQL = strSQL + "Delete from DataNodeDirectMap where mId = " + ""+ lngmId+"";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelDataNodeDirectMap(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: DelDataNodeDirectMap)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataNodeDirectMap where " + strCondition ;
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
public bool DelDataNodeDirectMapWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsDataNodeDirectMapDA: DelDataNodeDirectMapWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from DataNodeDirectMap where " + strCondition ;
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
 /// <param name = "objDataNodeDirectMapENS">源对象</param>
 /// <param name = "objDataNodeDirectMapENT">目标对象</param>
public void CopyTo(clsDataNodeDirectMapEN objDataNodeDirectMapENS, clsDataNodeDirectMapEN objDataNodeDirectMapENT)
{
objDataNodeDirectMapENT.mId = objDataNodeDirectMapENS.mId; //mId
objDataNodeDirectMapENT.InDataNodeId = objDataNodeDirectMapENS.InDataNodeId; //In数据结点Id
objDataNodeDirectMapENT.OutDataNodeId = objDataNodeDirectMapENS.OutDataNodeId; //Out数据结点Id
objDataNodeDirectMapENT.AssociationMappingId = objDataNodeDirectMapENS.AssociationMappingId; //关联关系映射Id
objDataNodeDirectMapENT.FuncMapModeId = objDataNodeDirectMapENS.FuncMapModeId; //函数映射模式Id
objDataNodeDirectMapENT.TabId = objDataNodeDirectMapENS.TabId; //表ID
objDataNodeDirectMapENT.DnFunctionId = objDataNodeDirectMapENS.DnFunctionId; //DN函数Id
objDataNodeDirectMapENT.PrjId = objDataNodeDirectMapENS.PrjId; //工程Id
objDataNodeDirectMapENT.UpdDate = objDataNodeDirectMapENS.UpdDate; //修改日期
objDataNodeDirectMapENT.UpdUser = objDataNodeDirectMapENS.UpdUser; //修改者
objDataNodeDirectMapENT.Memo = objDataNodeDirectMapENS.Memo; //说明
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objDataNodeDirectMapEN.InDataNodeId, conDataNodeDirectMap.InDataNodeId);
clsCheckSql.CheckFieldNotNull(objDataNodeDirectMapEN.OutDataNodeId, conDataNodeDirectMap.OutDataNodeId);
clsCheckSql.CheckFieldNotNull(objDataNodeDirectMapEN.AssociationMappingId, conDataNodeDirectMap.AssociationMappingId);
clsCheckSql.CheckFieldNotNull(objDataNodeDirectMapEN.FuncMapModeId, conDataNodeDirectMap.FuncMapModeId);
clsCheckSql.CheckFieldNotNull(objDataNodeDirectMapEN.PrjId, conDataNodeDirectMap.PrjId);
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.AssociationMappingId, 2, conDataNodeDirectMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.FuncMapModeId, 2, conDataNodeDirectMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.TabId, 8, conDataNodeDirectMap.TabId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.DnFunctionId, 8, conDataNodeDirectMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.PrjId, 4, conDataNodeDirectMap.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.UpdDate, 20, conDataNodeDirectMap.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.UpdUser, 20, conDataNodeDirectMap.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.Memo, 1000, conDataNodeDirectMap.Memo);
//检查字段外键固定长度
 objDataNodeDirectMapEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.AssociationMappingId, 2, conDataNodeDirectMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.FuncMapModeId, 2, conDataNodeDirectMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.TabId, 8, conDataNodeDirectMap.TabId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.DnFunctionId, 8, conDataNodeDirectMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.PrjId, 4, conDataNodeDirectMap.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.UpdDate, 20, conDataNodeDirectMap.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.UpdUser, 20, conDataNodeDirectMap.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.Memo, 1000, conDataNodeDirectMap.Memo);
//检查外键字段长度
 objDataNodeDirectMapEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.AssociationMappingId, 2, conDataNodeDirectMap.AssociationMappingId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.FuncMapModeId, 2, conDataNodeDirectMap.FuncMapModeId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.TabId, 8, conDataNodeDirectMap.TabId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.DnFunctionId, 8, conDataNodeDirectMap.DnFunctionId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.PrjId, 4, conDataNodeDirectMap.PrjId);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.UpdDate, 20, conDataNodeDirectMap.UpdDate);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.UpdUser, 20, conDataNodeDirectMap.UpdUser);
clsCheckSql.CheckFieldLen(objDataNodeDirectMapEN.Memo, 1000, conDataNodeDirectMap.Memo);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.AssociationMappingId, conDataNodeDirectMap.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.FuncMapModeId, conDataNodeDirectMap.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.TabId, conDataNodeDirectMap.TabId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.DnFunctionId, conDataNodeDirectMap.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.PrjId, conDataNodeDirectMap.PrjId);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.UpdDate, conDataNodeDirectMap.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.UpdUser, conDataNodeDirectMap.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objDataNodeDirectMapEN.Memo, conDataNodeDirectMap.Memo);
//检查外键字段长度
 objDataNodeDirectMapEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--DataNodeDirectMap(数据结点直接映射),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objDataNodeDirectMapEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsDataNodeDirectMapEN objDataNodeDirectMapEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and InDataNodeId = '{0}'", objDataNodeDirectMapEN.InDataNodeId);
 sbCondition.AppendFormat(" and OutDataNodeId = '{0}'", objDataNodeDirectMapEN.OutDataNodeId);
 sbCondition.AppendFormat(" and PrjId = '{0}'", objDataNodeDirectMapEN.PrjId);
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataNodeDirectMapEN._CurrTabName);
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsDataNodeDirectMapEN._CurrTabName, strCondition);
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
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
 objSQL = clsDataNodeDirectMapDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}