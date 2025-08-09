
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCode_SimDA
 表名:vFunction4GeneCode_Sim(00050605)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:03:23
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:109.244.40.104,8433AGC_CS12
 PrjDataBaseId:0005
 模块中文名:函数管理(PrjFunction)
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
 /// v函数4GC_Sim(vFunction4GeneCode_Sim)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFunction4GeneCode_SimDA : clsCommBase4DA
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
 return clsvFunction4GeneCode_SimEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFunction4GeneCode_SimEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunction4GeneCode_SimEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFunction4GeneCode_SimEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFunction4GeneCode_SimEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncId4GC">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncId4GC)
{
strFuncId4GC = strFuncId4GC.Replace("'", "''");
if (strFuncId4GC.Length > 10)
{
throw new Exception("(errid:Data000001)在表:vFunction4GeneCode_Sim中,检查关键字,长度不正确!(clsvFunction4GeneCode_SimDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId4GC)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFunction4GeneCode_Sim中,关键字不能为空 或 null!(clsvFunction4GeneCode_SimDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4GC);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFunction4GeneCode_SimDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFunction4GeneCode_Sim(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable_vFunction4GeneCode_Sim)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunction4GeneCode_Sim.* " + 
$"from vFunction4GeneCode_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunction4GeneCode_Sim.FuncId4GC not in " + 
$"(Select top {intTop_In} vFunction4GeneCode_Sim.FuncId4GC from vFunction4GeneCode_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1} and FuncId4GC not in (Select top {2} FuncId4GC from vFunction4GeneCode_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1} and FuncId4GC not in (Select top {3} FuncId4GC from vFunction4GeneCode_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunction4GeneCode_Sim.* " + 
$"from vFunction4GeneCode_Sim " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunction4GeneCode_Sim.FuncId4GC not in " + 
$"(Select top {intTop_In} vFunction4GeneCode_Sim.FuncId4GC from vFunction4GeneCode_Sim " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1} and FuncId4GC not in (Select top {2} FuncId4GC from vFunction4GeneCode_Sim where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode_Sim where {1} and FuncId4GC not in (Select top {3} FuncId4GC from vFunction4GeneCode_Sim where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFunction4GeneCode_SimEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA:GetObjLst)", objException.Message));
}
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = TransNullToBool(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetObjLst)", objException.Message));
}
objvFunction4GeneCode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
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
public List<clsvFunction4GeneCode_SimEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFunction4GeneCode_SimEN> arrObjLst = new List<clsvFunction4GeneCode_SimEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = TransNullToBool(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetObjLst)", objException.Message));
}
objvFunction4GeneCode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunction4GeneCode_SimEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFunction4GeneCode_Sim(ref clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where FuncId4GC = " + "'"+ objvFunction4GeneCode_SimEN.FuncId4GC+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFunction4GeneCode_SimEN.FuncId4GC = objDT.Rows[0][convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFunction4GeneCode_SimEN.FuncName = objDT.Rows[0][convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCode_SimEN.FuncId4Code = objDT.Rows[0][convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4GeneCode_SimEN.SqlDsTypeId = objDT.Rows[0][convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCode_SimEN.FeatureId = objDT.Rows[0][convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCode_SimEN.InUse = TransNullToBool(objDT.Rows[0][convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4GeneCode_SimEN.FuncGCTypeId = objDT.Rows[0][convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCode_SimEN.TemplateNum = TransNullToInt(objDT.Rows[0][convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4GeneCode_SimEN.ProgLangTypeId = objDT.Rows[0][convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCode_SimEN.FuncCodeTypeId = objDT.Rows[0][convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCode_SimEN.UsedTimes = TransNullToInt(objDT.Rows[0][convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetvFunction4GeneCode_Sim)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public clsvFunction4GeneCode_SimEN GetObjByFuncId4GC(string strFuncId4GC)
{
CheckPrimaryKey(strFuncId4GC);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where FuncId4GC = " + "'"+ strFuncId4GC+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
 objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCode_SimEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetObjByFuncId4GC)", objException.Message));
}
return objvFunction4GeneCode_SimEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFunction4GeneCode_SimEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode_Sim where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN()
{
FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(), //函数ID
FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(), //函数名
FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(), //函数Id4Code
SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(), //数据源类型Id
FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(), //功能Id
InUse = TransNullToBool(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()), //是否在用
FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(), //函数生成代码类型Id
TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()), //TemplateNum
ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(), //函数代码类型Id
UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()) //使用次数
};
objvFunction4GeneCode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4GeneCode_SimEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFunction4GeneCode_SimEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = TransNullToBool(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetObjByDataRowvFunction4GeneCode_Sim)", objException.Message));
}
objvFunction4GeneCode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4GeneCode_SimEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFunction4GeneCode_SimEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN = new clsvFunction4GeneCode_SimEN();
try
{
objvFunction4GeneCode_SimEN.FuncId4GC = objRow[convFunction4GeneCode_Sim.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCode_SimEN.FuncName = objRow[convFunction4GeneCode_Sim.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCode_SimEN.FuncId4Code = objRow[convFunction4GeneCode_Sim.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCode_SimEN.SqlDsTypeId = objRow[convFunction4GeneCode_Sim.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCode_SimEN.FeatureId = objRow[convFunction4GeneCode_Sim.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCode_SimEN.InUse = TransNullToBool(objRow[convFunction4GeneCode_Sim.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCode_SimEN.FuncGCTypeId = objRow[convFunction4GeneCode_Sim.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCode_SimEN.TemplateNum = objRow[convFunction4GeneCode_Sim.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCode_SimEN.ProgLangTypeId = objRow[convFunction4GeneCode_Sim.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCode_SimEN.FuncCodeTypeId = objRow[convFunction4GeneCode_Sim.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode_Sim.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCode_SimEN.UsedTimes = objRow[convFunction4GeneCode_Sim.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode_Sim.UsedTimes].ToString().Trim()); //使用次数
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFunction4GeneCode_SimDA: GetObjByDataRow)", objException.Message));
}
objvFunction4GeneCode_SimEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4GeneCode_SimEN;
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
objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunction4GeneCode_SimEN._CurrTabName, convFunction4GeneCode_Sim.FuncId4GC, 10, "");
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
objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunction4GeneCode_SimEN._CurrTabName, convFunction4GeneCode_Sim.FuncId4GC, 10, strPrefix);
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId4GC from vFunction4GeneCode_Sim where " + strCondition;
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId4GC from vFunction4GeneCode_Sim where " + strCondition;
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
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncId4GC)
{
CheckPrimaryKey(strFuncId4GC);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunction4GeneCode_Sim", "FuncId4GC = " + "'"+ strFuncId4GC+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFunction4GeneCode_SimDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunction4GeneCode_Sim", strCondition))
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
objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFunction4GeneCode_Sim");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFunction4GeneCode_SimENS">源对象</param>
 /// <param name = "objvFunction4GeneCode_SimENT">目标对象</param>
public void CopyTo(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENS, clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimENT)
{
objvFunction4GeneCode_SimENT.FuncId4GC = objvFunction4GeneCode_SimENS.FuncId4GC; //函数ID
objvFunction4GeneCode_SimENT.FuncName = objvFunction4GeneCode_SimENS.FuncName; //函数名
objvFunction4GeneCode_SimENT.FuncId4Code = objvFunction4GeneCode_SimENS.FuncId4Code; //函数Id4Code
objvFunction4GeneCode_SimENT.SqlDsTypeId = objvFunction4GeneCode_SimENS.SqlDsTypeId; //数据源类型Id
objvFunction4GeneCode_SimENT.FeatureId = objvFunction4GeneCode_SimENS.FeatureId; //功能Id
objvFunction4GeneCode_SimENT.InUse = objvFunction4GeneCode_SimENS.InUse; //是否在用
objvFunction4GeneCode_SimENT.FuncGCTypeId = objvFunction4GeneCode_SimENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4GeneCode_SimENT.TemplateNum = objvFunction4GeneCode_SimENS.TemplateNum; //TemplateNum
objvFunction4GeneCode_SimENT.ProgLangTypeId = objvFunction4GeneCode_SimENS.ProgLangTypeId; //编程语言类型Id
objvFunction4GeneCode_SimENT.FuncCodeTypeId = objvFunction4GeneCode_SimENS.FuncCodeTypeId; //函数代码类型Id
objvFunction4GeneCode_SimENT.UsedTimes = objvFunction4GeneCode_SimENS.UsedTimes; //使用次数
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFunction4GeneCode_SimEN objvFunction4GeneCode_SimEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.FuncId4GC, 10, convFunction4GeneCode_Sim.FuncId4GC);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.FuncName, 100, convFunction4GeneCode_Sim.FuncName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.FuncId4Code, 8, convFunction4GeneCode_Sim.FuncId4Code);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.SqlDsTypeId, 2, convFunction4GeneCode_Sim.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.FeatureId, 4, convFunction4GeneCode_Sim.FeatureId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.FuncGCTypeId, 2, convFunction4GeneCode_Sim.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.ProgLangTypeId, 2, convFunction4GeneCode_Sim.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCode_SimEN.FuncCodeTypeId, 4, convFunction4GeneCode_Sim.FuncCodeTypeId);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.FuncId4GC, convFunction4GeneCode_Sim.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.FuncName, convFunction4GeneCode_Sim.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.FuncId4Code, convFunction4GeneCode_Sim.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.SqlDsTypeId, convFunction4GeneCode_Sim.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.FeatureId, convFunction4GeneCode_Sim.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.FuncGCTypeId, convFunction4GeneCode_Sim.FuncGCTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.ProgLangTypeId, convFunction4GeneCode_Sim.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCode_SimEN.FuncCodeTypeId, convFunction4GeneCode_Sim.FuncCodeTypeId);
//检查外键字段长度
 objvFunction4GeneCode_SimEN._IsCheckProperty = true;
}

 #endregion 检查对象属性

 #region 绑定下拉框

 /// <summary>
 /// 获取用于绑定下拉框的DataTable,获取两个字段:1、关键字；2、名称字段
 /// (AutoGCLib.clsGeneCodeBase4Tab:Gen_4DAL_GetDataTable4DdlBind)
 /// </summary>
 /// <returns>返回用于绑定下拉框的DataTable</returns>
public System.Data.DataTable GetFuncId4GC()
{
//获取某学院所有专业信息
string strSQL = "select FuncId4GC, FuncName from vFunction4GeneCode_Sim ";
 clsSpecSQLforSql mySql = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunction4GeneCode_SimEN._CurrTabName);
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunction4GeneCode_SimEN._CurrTabName, strCondition);
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
 objSQL = clsvFunction4GeneCode_SimDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}