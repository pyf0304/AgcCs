
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvDnFuncMap_SimDA
 表名:vDnFuncMap_Sim(00050625)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:08
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
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
 /// v结点函数映射_Sim(vDnFuncMap_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvDnFuncMap_SimDA : clsCommBase4DA
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
 return clsvDnFuncMap_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvDnFuncMap_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvDnFuncMap_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvDnFuncMap_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvDnFuncMap_SimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strDnFuncMapId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strDnFuncMapId)
{
strDnFuncMapId = strDnFuncMapId.Replace("'", "''");
if (strDnFuncMapId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vDnFuncMap_Sim中,检查关键字,长度不正确!(clsvDnFuncMap_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strDnFuncMapId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vDnFuncMap_Sim中,关键字不能为空 或 null!(clsvDnFuncMap_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strDnFuncMapId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvDnFuncMap_SimDA:CheckPrimaryKey)", objException.Message));
}
return true;
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vDnFuncMap_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable_vDnFuncMap_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDnFuncMap_Sim.* " + 
$"from vDnFuncMap_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDnFuncMap_Sim.DnFuncMapId not in " + 
$"(Select top {intTop_In} vDnFuncMap_Sim.DnFuncMapId from vDnFuncMap_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from vDnFuncMap_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from vDnFuncMap_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vDnFuncMap_Sim.* " + 
$"from vDnFuncMap_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vDnFuncMap_Sim.DnFuncMapId not in " + 
$"(Select top {intTop_In} vDnFuncMap_Sim.DnFuncMapId from vDnFuncMap_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1} and DnFuncMapId not in (Select top {2} DnFuncMapId from vDnFuncMap_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vDnFuncMap_Sim where {1} and DnFuncMapId not in (Select top {3} DnFuncMapId from vDnFuncMap_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvDnFuncMap_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA:GetObjLst)", objException.Message));
}
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetObjLst)", objException.Message));
}
objvDnFuncMap_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDnFuncMap_SimEN);
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
public List<clsvDnFuncMap_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvDnFuncMap_SimEN> arrObjLst = new List<clsvDnFuncMap_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetObjLst)", objException.Message));
}
objvDnFuncMap_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvDnFuncMap_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvDnFuncMap_Sim(ref clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where DnFuncMapId = " + "'"+ objvDnFuncMap_SimEN.DnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvDnFuncMap_SimEN.DnFuncMapId = objDT.Rows[0][convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMap_SimEN.InDataNodeId = TransNullToInt(objDT.Rows[0][convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMap_SimEN.OutDataNodeId = TransNullToInt(objDT.Rows[0][convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMap_SimEN.AssociationMappingId = objDT.Rows[0][convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMap_SimEN.FuncMapModeId = objDT.Rows[0][convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMap_SimEN.TabId = objDT.Rows[0][convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMap_SimEN.DnFunctionId = objDT.Rows[0][convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDnFuncMap_SimEN.PrjId = objDT.Rows[0][convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDnFuncMap_SimEN.UsedTimes = TransNullToInt(objDT.Rows[0][convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetvDnFuncMap_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strDnFuncMapId">表关键字</param>
 /// <returns>表对象</returns>
public clsvDnFuncMap_SimEN GetObjByDnFuncMapId(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where DnFuncMapId = " + "'"+ strDnFuncMapId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
 objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id(字段类型:bigint,字段长度:8,是否可空:True)
 objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id(字段类型:char,字段长度:2,是否可空:True)
 objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetObjByDnFuncMapId)", objException.Message));
}
return objvDnFuncMap_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvDnFuncMap_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
strSQL = "Select * from vDnFuncMap_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN()
{
DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(), //函数映射Id
InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()), //In数据结点Id
OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()), //Out数据结点Id
AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(), //关联关系映射Id
FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(), //函数映射模式Id
TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(), //表ID
DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(), //DN函数Id
PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(), //工程Id
UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()) //使用次数
};
objvDnFuncMap_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFuncMap_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvDnFuncMap_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetObjByDataRowvDnFuncMap_Sim)", objException.Message));
}
objvDnFuncMap_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFuncMap_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvDnFuncMap_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvDnFuncMap_SimEN objvDnFuncMap_SimEN = new clsvDnFuncMap_SimEN();
try
{
objvDnFuncMap_SimEN.DnFuncMapId = objRow[convDnFuncMap_Sim.DnFuncMapId].ToString().Trim(); //函数映射Id
objvDnFuncMap_SimEN.InDataNodeId = objRow[convDnFuncMap_Sim.InDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.InDataNodeId].ToString().Trim()); //In数据结点Id
objvDnFuncMap_SimEN.OutDataNodeId = objRow[convDnFuncMap_Sim.OutDataNodeId] == DBNull.Value ? (long?)null : TransNullToInt(objRow[convDnFuncMap_Sim.OutDataNodeId].ToString().Trim()); //Out数据结点Id
objvDnFuncMap_SimEN.AssociationMappingId = objRow[convDnFuncMap_Sim.AssociationMappingId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.AssociationMappingId].ToString().Trim(); //关联关系映射Id
objvDnFuncMap_SimEN.FuncMapModeId = objRow[convDnFuncMap_Sim.FuncMapModeId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.FuncMapModeId].ToString().Trim(); //函数映射模式Id
objvDnFuncMap_SimEN.TabId = objRow[convDnFuncMap_Sim.TabId].ToString().Trim(); //表ID
objvDnFuncMap_SimEN.DnFunctionId = objRow[convDnFuncMap_Sim.DnFunctionId] == DBNull.Value ? null : objRow[convDnFuncMap_Sim.DnFunctionId].ToString().Trim(); //DN函数Id
objvDnFuncMap_SimEN.PrjId = objRow[convDnFuncMap_Sim.PrjId].ToString().Trim(); //工程Id
objvDnFuncMap_SimEN.UsedTimes = objRow[convDnFuncMap_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convDnFuncMap_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvDnFuncMap_SimDA: GetObjByDataRow)", objException.Message));
}
objvDnFuncMap_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvDnFuncMap_SimEN;
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
objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDnFuncMap_SimEN._CurrTabName, convDnFuncMap_Sim.DnFuncMapId, 8, "");
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
objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvDnFuncMap_SimEN._CurrTabName, convDnFuncMap_Sim.DnFuncMapId, 8, strPrefix);
return strMaxValue;
}

 /// <summary>
 /// 获取当前表满足条件的第一条记录的关键字值
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstID)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回的第一条记录的关键字值</returns>
public string GetFirstID(string strCondition) 
{
string strSQL ;
 System.Data.DataTable objDT ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select DnFuncMapId from vDnFuncMap_Sim where " + strCondition;
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
return "";
}
strKeyValue = objDT.Rows[0][0].ToString();
return strKeyValue;
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
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select DnFuncMapId from vDnFuncMap_Sim where " + strCondition;
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
 /// <param name = "strDnFuncMapId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strDnFuncMapId)
{
CheckPrimaryKey(strDnFuncMapId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDnFuncMap_Sim", "DnFuncMapId = " + "'"+ strDnFuncMapId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvDnFuncMap_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vDnFuncMap_Sim", strCondition))
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
objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vDnFuncMap_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvDnFuncMap_SimENS">源对象</param>
 /// <param name = "objvDnFuncMap_SimENT">目标对象</param>
public void CopyTo(clsvDnFuncMap_SimEN objvDnFuncMap_SimENS, clsvDnFuncMap_SimEN objvDnFuncMap_SimENT)
{
objvDnFuncMap_SimENT.DnFuncMapId = objvDnFuncMap_SimENS.DnFuncMapId; //函数映射Id
objvDnFuncMap_SimENT.InDataNodeId = objvDnFuncMap_SimENS.InDataNodeId; //In数据结点Id
objvDnFuncMap_SimENT.OutDataNodeId = objvDnFuncMap_SimENS.OutDataNodeId; //Out数据结点Id
objvDnFuncMap_SimENT.AssociationMappingId = objvDnFuncMap_SimENS.AssociationMappingId; //关联关系映射Id
objvDnFuncMap_SimENT.FuncMapModeId = objvDnFuncMap_SimENS.FuncMapModeId; //函数映射模式Id
objvDnFuncMap_SimENT.TabId = objvDnFuncMap_SimENS.TabId; //表ID
objvDnFuncMap_SimENT.DnFunctionId = objvDnFuncMap_SimENS.DnFunctionId; //DN函数Id
objvDnFuncMap_SimENT.PrjId = objvDnFuncMap_SimENS.PrjId; //工程Id
objvDnFuncMap_SimENT.UsedTimes = objvDnFuncMap_SimENS.UsedTimes; //使用次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvDnFuncMap_SimEN objvDnFuncMap_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvDnFuncMap_SimEN.DnFuncMapId, 8, convDnFuncMap_Sim.DnFuncMapId);
clsCheckSql.CheckFieldLen(objvDnFuncMap_SimEN.AssociationMappingId, 2, convDnFuncMap_Sim.AssociationMappingId);
clsCheckSql.CheckFieldLen(objvDnFuncMap_SimEN.FuncMapModeId, 2, convDnFuncMap_Sim.FuncMapModeId);
clsCheckSql.CheckFieldLen(objvDnFuncMap_SimEN.TabId, 8, convDnFuncMap_Sim.TabId);
clsCheckSql.CheckFieldLen(objvDnFuncMap_SimEN.DnFunctionId, 8, convDnFuncMap_Sim.DnFunctionId);
clsCheckSql.CheckFieldLen(objvDnFuncMap_SimEN.PrjId, 4, convDnFuncMap_Sim.PrjId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMap_SimEN.DnFuncMapId, convDnFuncMap_Sim.DnFuncMapId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMap_SimEN.AssociationMappingId, convDnFuncMap_Sim.AssociationMappingId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMap_SimEN.FuncMapModeId, convDnFuncMap_Sim.FuncMapModeId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMap_SimEN.TabId, convDnFuncMap_Sim.TabId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMap_SimEN.DnFunctionId, convDnFuncMap_Sim.DnFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvDnFuncMap_SimEN.PrjId, convDnFuncMap_Sim.PrjId);
//检查外键字段长度
 objvDnFuncMap_SimEN._IsCheckProperty = true;
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
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
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
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
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
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDnFuncMap_SimEN._CurrTabName);
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
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvDnFuncMap_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvDnFuncMap_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}