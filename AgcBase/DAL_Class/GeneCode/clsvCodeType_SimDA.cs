
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvCodeType_SimDA
 表名:vCodeType_Sim(00050623)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:生成代码(GeneCode)
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
 /// vCodeType_Sim(vCodeType_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvCodeType_SimDA : clsCommBase4DA
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
 return clsvCodeType_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvCodeType_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvCodeType_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvCodeType_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvCodeType_SimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strCodeTypeId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strCodeTypeId)
{
strCodeTypeId = strCodeTypeId.Replace("'", "''");
if (strCodeTypeId.Length > 4)
{
throw new Exception("(errid:Data000001)在表:vCodeType_Sim中,检查关键字,长度不正确!(clsvCodeType_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strCodeTypeId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vCodeType_Sim中,关键字不能为空 或 null!(clsvCodeType_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strCodeTypeId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvCodeType_SimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vCodeType_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable_vCodeType_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCodeType_Sim.* " + 
$"from vCodeType_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCodeType_Sim.CodeTypeId not in " + 
$"(Select top {intTop_In} vCodeType_Sim.CodeTypeId from vCodeType_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1} and CodeTypeId not in (Select top {2} CodeTypeId from vCodeType_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1} and CodeTypeId not in (Select top {3} CodeTypeId from vCodeType_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vCodeType_Sim.* " + 
$"from vCodeType_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vCodeType_Sim.CodeTypeId not in " + 
$"(Select top {intTop_In} vCodeType_Sim.CodeTypeId from vCodeType_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1} and CodeTypeId not in (Select top {2} CodeTypeId from vCodeType_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vCodeType_Sim where {1} and CodeTypeId not in (Select top {3} CodeTypeId from vCodeType_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvCodeType_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvCodeType_SimDA:GetObjLst)", objException.Message));
}
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = TransNullToBool(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = TransNullToBool(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = TransNullToBool(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCodeType_SimDA: GetObjLst)", objException.Message));
}
objvCodeType_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCodeType_SimEN);
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
public List<clsvCodeType_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvCodeType_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvCodeType_SimEN> arrObjLst = new List<clsvCodeType_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = TransNullToBool(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = TransNullToBool(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = TransNullToBool(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvCodeType_SimDA: GetObjLst)", objException.Message));
}
objvCodeType_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvCodeType_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvCodeType_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvCodeType_Sim(ref clsvCodeType_SimEN objvCodeType_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where CodeTypeId = " + "'"+ objvCodeType_SimEN.CodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvCodeType_SimEN.CodeTypeId = objDT.Rows[0][convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeType_SimEN.CodeTypeName = objDT.Rows[0][convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeType_SimEN.CodeTypeENName = objDT.Rows[0][convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.GroupName = objDT.Rows[0][convCodeType_Sim.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeType_SimEN.DependsOn = objDT.Rows[0][convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.FrontOrBack = objDT.Rows[0][convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.OrderNum = TransNullToInt(objDT.Rows[0][convCodeType_Sim.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCodeType_SimEN.ProgLangTypeId = objDT.Rows[0][convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeType_SimEN.Prefix = objDT.Rows[0][convCodeType_Sim.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvCodeType_SimEN.AppCount = TransNullToInt(objDT.Rows[0][convCodeType_Sim.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
 objvCodeType_SimEN.FuncCount = TransNullToInt(objDT.Rows[0][convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objvCodeType_SimEN.ClassNameFormat = objDT.Rows[0][convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.CodeTypeSimName = objDT.Rows[0][convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeType_SimEN.RegionTypeId = objDT.Rows[0][convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeType_SimEN.InUse = TransNullToBool(objDT.Rows[0][convCodeType_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeType_SimEN.SqlDsTypeId = objDT.Rows[0][convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeType_SimEN.IsDefaultOverride = TransNullToBool(objDT.Rows[0][convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖(字段类型:bit,字段长度:1,是否可空:False)
 objvCodeType_SimEN.IsExtend = TransNullToBool(objDT.Rows[0][convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeType_SimEN.IsAutoParseFile = TransNullToBool(objDT.Rows[0][convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeType_SimEN.FileNameFormat = objDT.Rows[0][convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvCodeType_SimDA: GetvCodeType_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strCodeTypeId">表关键字</param>
 /// <returns>表对象</returns>
public clsvCodeType_SimEN GetObjByCodeTypeId(string strCodeTypeId)
{
CheckPrimaryKey(strCodeTypeId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where CodeTypeId = " + "'"+ strCodeTypeId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
 objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名(字段类型:varchar,字段长度:30,是否可空:False)
 objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀(字段类型:varchar,字段长度:10,是否可空:True)
 objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数(字段类型:int,字段长度:4,是否可空:True)
 objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目(字段类型:int,字段长度:4,是否可空:True)
 objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式(字段类型:varchar,字段长度:50,是否可空:True)
 objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称(字段类型:varchar,字段长度:50,是否可空:False)
 objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvCodeType_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvCodeType_SimEN.IsDefaultOverride = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖(字段类型:bit,字段长度:1,是否可空:False)
 objvCodeType_SimEN.IsExtend = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeType_SimEN.IsAutoParseFile = clsEntityBase2.TransNullToBool_S(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件(字段类型:bit,字段长度:1,是否可空:True)
 objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式(字段类型:varchar,字段长度:50,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvCodeType_SimDA: GetObjByCodeTypeId)", objException.Message));
}
return objvCodeType_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvCodeType_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvCodeType_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
strSQL = "Select * from vCodeType_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN()
{
CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(), //代码类型名
CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(), //代码类型英文名
GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(), //组名
DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(), //依赖于
FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(), //前台Or后台
OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.OrderNum].ToString().Trim()), //序号
ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(), //前缀
AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.AppCount].ToString().Trim()), //应用数
FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.FuncCount].ToString().Trim()), //函数数目
ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(), //类名格式
CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(), //简称
RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(), //区域类型Id
InUse = TransNullToBool(objRow[convCodeType_Sim.InUse].ToString().Trim()), //是否在用
SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(), //数据源类型Id
IsDefaultOverride = TransNullToBool(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()), //是否默认覆盖
IsExtend = TransNullToBool(objRow[convCodeType_Sim.IsExtend].ToString().Trim()), //是否扩展类
IsAutoParseFile = TransNullToBool(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()), //是否自动分析文件
FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim() //文件名格式
};
objvCodeType_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCodeType_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvCodeType_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvCodeType_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = TransNullToBool(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = TransNullToBool(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = TransNullToBool(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvCodeType_SimDA: GetObjByDataRowvCodeType_Sim)", objException.Message));
}
objvCodeType_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCodeType_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvCodeType_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvCodeType_SimEN objvCodeType_SimEN = new clsvCodeType_SimEN();
try
{
objvCodeType_SimEN.CodeTypeId = objRow[convCodeType_Sim.CodeTypeId].ToString().Trim(); //代码类型Id
objvCodeType_SimEN.CodeTypeName = objRow[convCodeType_Sim.CodeTypeName].ToString().Trim(); //代码类型名
objvCodeType_SimEN.CodeTypeENName = objRow[convCodeType_Sim.CodeTypeENName] == DBNull.Value ? null : objRow[convCodeType_Sim.CodeTypeENName].ToString().Trim(); //代码类型英文名
objvCodeType_SimEN.GroupName = objRow[convCodeType_Sim.GroupName].ToString().Trim(); //组名
objvCodeType_SimEN.DependsOn = objRow[convCodeType_Sim.DependsOn] == DBNull.Value ? null : objRow[convCodeType_Sim.DependsOn].ToString().Trim(); //依赖于
objvCodeType_SimEN.FrontOrBack = objRow[convCodeType_Sim.FrontOrBack] == DBNull.Value ? null : objRow[convCodeType_Sim.FrontOrBack].ToString().Trim(); //前台Or后台
objvCodeType_SimEN.OrderNum = objRow[convCodeType_Sim.OrderNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.OrderNum].ToString().Trim()); //序号
objvCodeType_SimEN.ProgLangTypeId = objRow[convCodeType_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvCodeType_SimEN.Prefix = objRow[convCodeType_Sim.Prefix] == DBNull.Value ? null : objRow[convCodeType_Sim.Prefix].ToString().Trim(); //前缀
objvCodeType_SimEN.AppCount = objRow[convCodeType_Sim.AppCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.AppCount].ToString().Trim()); //应用数
objvCodeType_SimEN.FuncCount = objRow[convCodeType_Sim.FuncCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convCodeType_Sim.FuncCount].ToString().Trim()); //函数数目
objvCodeType_SimEN.ClassNameFormat = objRow[convCodeType_Sim.ClassNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.ClassNameFormat].ToString().Trim(); //类名格式
objvCodeType_SimEN.CodeTypeSimName = objRow[convCodeType_Sim.CodeTypeSimName].ToString().Trim(); //简称
objvCodeType_SimEN.RegionTypeId = objRow[convCodeType_Sim.RegionTypeId].ToString().Trim(); //区域类型Id
objvCodeType_SimEN.InUse = TransNullToBool(objRow[convCodeType_Sim.InUse].ToString().Trim()); //是否在用
objvCodeType_SimEN.SqlDsTypeId = objRow[convCodeType_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvCodeType_SimEN.IsDefaultOverride = TransNullToBool(objRow[convCodeType_Sim.IsDefaultOverride].ToString().Trim()); //是否默认覆盖
objvCodeType_SimEN.IsExtend = TransNullToBool(objRow[convCodeType_Sim.IsExtend].ToString().Trim()); //是否扩展类
objvCodeType_SimEN.IsAutoParseFile = TransNullToBool(objRow[convCodeType_Sim.IsAutoParseFile].ToString().Trim()); //是否自动分析文件
objvCodeType_SimEN.FileNameFormat = objRow[convCodeType_Sim.FileNameFormat] == DBNull.Value ? null : objRow[convCodeType_Sim.FileNameFormat].ToString().Trim(); //文件名格式
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvCodeType_SimDA: GetObjByDataRow)", objException.Message));
}
objvCodeType_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvCodeType_SimEN;
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
objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCodeType_SimEN._CurrTabName, convCodeType_Sim.CodeTypeId, 4, "");
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
objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvCodeType_SimEN._CurrTabName, convCodeType_Sim.CodeTypeId, 4, strPrefix);
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select CodeTypeId from vCodeType_Sim where " + strCondition;
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select CodeTypeId from vCodeType_Sim where " + strCondition;
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
 /// <param name = "strCodeTypeId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strCodeTypeId)
{
CheckPrimaryKey(strCodeTypeId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCodeType_Sim", "CodeTypeId = " + "'"+ strCodeTypeId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvCodeType_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vCodeType_Sim", strCondition))
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
objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vCodeType_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvCodeType_SimENS">源对象</param>
 /// <param name = "objvCodeType_SimENT">目标对象</param>
public void CopyTo(clsvCodeType_SimEN objvCodeType_SimENS, clsvCodeType_SimEN objvCodeType_SimENT)
{
objvCodeType_SimENT.CodeTypeId = objvCodeType_SimENS.CodeTypeId; //代码类型Id
objvCodeType_SimENT.CodeTypeName = objvCodeType_SimENS.CodeTypeName; //代码类型名
objvCodeType_SimENT.CodeTypeENName = objvCodeType_SimENS.CodeTypeENName; //代码类型英文名
objvCodeType_SimENT.GroupName = objvCodeType_SimENS.GroupName; //组名
objvCodeType_SimENT.DependsOn = objvCodeType_SimENS.DependsOn; //依赖于
objvCodeType_SimENT.FrontOrBack = objvCodeType_SimENS.FrontOrBack; //前台Or后台
objvCodeType_SimENT.OrderNum = objvCodeType_SimENS.OrderNum; //序号
objvCodeType_SimENT.ProgLangTypeId = objvCodeType_SimENS.ProgLangTypeId; //编程语言类型Id
objvCodeType_SimENT.Prefix = objvCodeType_SimENS.Prefix; //前缀
objvCodeType_SimENT.AppCount = objvCodeType_SimENS.AppCount; //应用数
objvCodeType_SimENT.FuncCount = objvCodeType_SimENS.FuncCount; //函数数目
objvCodeType_SimENT.ClassNameFormat = objvCodeType_SimENS.ClassNameFormat; //类名格式
objvCodeType_SimENT.CodeTypeSimName = objvCodeType_SimENS.CodeTypeSimName; //简称
objvCodeType_SimENT.RegionTypeId = objvCodeType_SimENS.RegionTypeId; //区域类型Id
objvCodeType_SimENT.InUse = objvCodeType_SimENS.InUse; //是否在用
objvCodeType_SimENT.SqlDsTypeId = objvCodeType_SimENS.SqlDsTypeId; //数据源类型Id
objvCodeType_SimENT.IsDefaultOverride = objvCodeType_SimENS.IsDefaultOverride; //是否默认覆盖
objvCodeType_SimENT.IsExtend = objvCodeType_SimENS.IsExtend; //是否扩展类
objvCodeType_SimENT.IsAutoParseFile = objvCodeType_SimENS.IsAutoParseFile; //是否自动分析文件
objvCodeType_SimENT.FileNameFormat = objvCodeType_SimENS.FileNameFormat; //文件名格式
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvCodeType_SimEN objvCodeType_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.CodeTypeId, 4, convCodeType_Sim.CodeTypeId);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.CodeTypeName, 50, convCodeType_Sim.CodeTypeName);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.CodeTypeENName, 50, convCodeType_Sim.CodeTypeENName);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.GroupName, 30, convCodeType_Sim.GroupName);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.DependsOn, 50, convCodeType_Sim.DependsOn);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.FrontOrBack, 50, convCodeType_Sim.FrontOrBack);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.ProgLangTypeId, 2, convCodeType_Sim.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.Prefix, 10, convCodeType_Sim.Prefix);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.ClassNameFormat, 50, convCodeType_Sim.ClassNameFormat);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.CodeTypeSimName, 50, convCodeType_Sim.CodeTypeSimName);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.RegionTypeId, 4, convCodeType_Sim.RegionTypeId);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.SqlDsTypeId, 2, convCodeType_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvCodeType_SimEN.FileNameFormat, 50, convCodeType_Sim.FileNameFormat);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.CodeTypeId, convCodeType_Sim.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.CodeTypeName, convCodeType_Sim.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.CodeTypeENName, convCodeType_Sim.CodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.GroupName, convCodeType_Sim.GroupName);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.DependsOn, convCodeType_Sim.DependsOn);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.FrontOrBack, convCodeType_Sim.FrontOrBack);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.ProgLangTypeId, convCodeType_Sim.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.Prefix, convCodeType_Sim.Prefix);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.ClassNameFormat, convCodeType_Sim.ClassNameFormat);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.CodeTypeSimName, convCodeType_Sim.CodeTypeSimName);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.RegionTypeId, convCodeType_Sim.RegionTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.SqlDsTypeId, convCodeType_Sim.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvCodeType_SimEN.FileNameFormat, convCodeType_Sim.FileNameFormat);
//检查外键字段长度
 objvCodeType_SimEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetCodeTypeId()
{
//获取某学院所有专业信息
string strSQL = "select CodeTypeId, CodeTypeName from vCodeType_Sim ";
 clsSpecSQLforSql mySql = clsvCodeType_SimDA.GetSpecSQLObj();
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCodeType_SimEN._CurrTabName);
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvCodeType_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvCodeType_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}