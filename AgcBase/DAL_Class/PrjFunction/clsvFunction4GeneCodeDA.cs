
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4GeneCodeDA
 表名:vFunction4GeneCode(00050315)
 * 版本:2025.08.02.1(服务器:PYF-THINKPAD)
 日期:2025/08/09 20:04:34
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
 /// v函数4GeneCode(vFunction4GeneCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFunction4GeneCodeDA : clsCommBase4DA
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
 return clsvFunction4GeneCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFunction4GeneCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunction4GeneCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFunction4GeneCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFunction4GeneCodeEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:vFunction4GeneCode中,检查关键字,长度不正确!(clsvFunction4GeneCodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId4GC)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFunction4GeneCode中,关键字不能为空 或 null!(clsvFunction4GeneCodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4GC);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFunction4GeneCodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFunction4GeneCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable_vFunction4GeneCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunction4GeneCode.* " + 
$"from vFunction4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunction4GeneCode.FuncId4GC not in " + 
$"(Select top {intTop_In} vFunction4GeneCode.FuncId4GC from vFunction4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1} and FuncId4GC not in (Select top {2} FuncId4GC from vFunction4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1} and FuncId4GC not in (Select top {3} FuncId4GC from vFunction4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunction4GeneCode.* " + 
$"from vFunction4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunction4GeneCode.FuncId4GC not in " + 
$"(Select top {intTop_In} vFunction4GeneCode.FuncId4GC from vFunction4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1} and FuncId4GC not in (Select top {2} FuncId4GC from vFunction4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4GeneCode where {1} and FuncId4GC not in (Select top {3} FuncId4GC from vFunction4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFunction4GeneCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA:GetObjLst)", objException.Message));
}
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = TransNullToBool(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetObjLst)", objException.Message));
}
objvFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunction4GeneCodeEN);
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
public List<clsvFunction4GeneCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFunction4GeneCodeEN> arrObjLst = new List<clsvFunction4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = TransNullToBool(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetObjLst)", objException.Message));
}
objvFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunction4GeneCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFunction4GeneCode(ref clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where FuncId4GC = " + "'"+ objvFunction4GeneCodeEN.FuncId4GC+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFunction4GeneCodeEN.FuncId4GC = objDT.Rows[0][convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFunction4GeneCodeEN.FuncName = objDT.Rows[0][convFunction4GeneCode.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCodeEN.FuncId4Code = objDT.Rows[0][convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4GeneCodeEN.FuncName4Code = objDT.Rows[0][convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCodeEN.FuncCHName4Code = objDT.Rows[0][convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvFunction4GeneCodeEN.FunctionSignatureSim = objDT.Rows[0][convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4GeneCodeEN.FeatureId = objDT.Rows[0][convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.FeatureName = objDT.Rows[0][convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCodeEN.FeatureDescription = objDT.Rows[0][convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFunction4GeneCodeEN.FeatureTypeName = objDT.Rows[0][convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunction4GeneCodeEN.ProgLangTypeId = objDT.Rows[0][convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.ProgLangTypeName = objDT.Rows[0][convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunction4GeneCodeEN.SqlDsTypeId = objDT.Rows[0][convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.SqlDsTypeName = objDT.Rows[0][convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4GeneCodeEN.FuncGCTypeId = objDT.Rows[0][convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.FuncGCTypeName = objDT.Rows[0][convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.FuncGCTypeENName = objDT.Rows[0][convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.PrjId = objDT.Rows[0][convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.ReturnTypeId = objDT.Rows[0][convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvFunction4GeneCodeEN.FuncTypeId = objDT.Rows[0][convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.FuncTypeName = objDT.Rows[0][convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4GeneCodeEN.IsTemplate = TransNullToBool(objDT.Rows[0][convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvFunction4GeneCodeEN.FunctionSignature = objDT.Rows[0][convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4GeneCodeEN.FuncCode = objDT.Rows[0][convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objvFunction4GeneCodeEN.UserId = objDT.Rows[0][convFunction4GeneCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvFunction4GeneCodeEN.OrderNum = TransNullToInt(objDT.Rows[0][convFunction4GeneCode.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.InUse = TransNullToBool(objDT.Rows[0][convFunction4GeneCode.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4GeneCodeEN.CodeText = objDT.Rows[0][convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvFunction4GeneCodeEN.UpdDate = objDT.Rows[0][convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4GeneCodeEN.UpdUser = objDT.Rows[0][convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4GeneCodeEN.Memo = objDT.Rows[0][convFunction4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunction4GeneCodeEN.ParsedWords = objDT.Rows[0][convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词(字段类型:varchar,字段长度:500,是否可空:True)
 objvFunction4GeneCodeEN.ParsedWordsExcluded = objDT.Rows[0][convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组(字段类型:varchar,字段长度:500,是否可空:True)
 objvFunction4GeneCodeEN.WordVector = objDT.Rows[0][convFunction4GeneCode.WordVector].ToString().Trim(); //词向量(字段类型:varchar,字段长度:500,是否可空:True)
 objvFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objDT.Rows[0][convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4GeneCodeEN.ReturnTypeName = objDT.Rows[0][convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunction4GeneCodeEN.TemplateNum = TransNullToInt(objDT.Rows[0][convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4GeneCodeEN.Order4FeatureNum = TransNullToInt(objDT.Rows[0][convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4GeneCodeEN.FuncCodeTypeENName = objDT.Rows[0][convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.FuncCodeTypeId = objDT.Rows[0][convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.FuncCodeTypeName = objDT.Rows[0][convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objDT.Rows[0][convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetvFunction4GeneCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public clsvFunction4GeneCodeEN GetObjByFuncId4GC(string strFuncId4GC)
{
CheckPrimaryKey(strFuncId4GC);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where FuncId4GC = " + "'"+ strFuncId4GC+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
 objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明(字段类型:varchar,字段长度:4000,是否可空:True)
 objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objvFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词(字段类型:varchar,字段长度:500,是否可空:True)
 objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组(字段类型:varchar,字段长度:500,是否可空:True)
 objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量(字段类型:varchar,字段长度:500,是否可空:True)
 objvFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType(字段类型:char,字段长度:2,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetObjByFuncId4GC)", objException.Message));
}
return objvFunction4GeneCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFunction4GeneCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN()
{
FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(), //函数ID
FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(), //函数名
FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(), //函数名4Code
FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(), //函数中文名4Code
FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(), //函数签名_Sim
FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(), //功能Id
FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(), //功能名称
FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(), //功能说明
FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(), //功能类型名称
ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(), //编程语言类型名
SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(), //数据源类型Id
SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(), //Sql数据源名
FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(), //函数生成代码类型Id
FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(), //函数生成代码类型名
FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(), //函数生成代码类型英文名
PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(), //工程Id
ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(), //返回类型ID
FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(), //函数类型Id
FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(), //函数类型名
IsTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()), //是否模板
FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(), //函数签名
FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(), //函数代码
UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(), //用户Id
OrderNum = TransNullToInt(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[convFunction4GeneCode.InUse].ToString().Trim()), //是否在用
CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(), //代码文本
UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(), //说明
ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(), //分析的词
ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(), //剔除后的词组
WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(), //词向量
IsFuncTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()), //是否函数模板
ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(), //返回类型名
TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()), //TemplateNum
Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()), //Order4FeatureNum
FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(), //FuncCodeTypeENName
FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(), //函数代码类型Id
FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(), //FuncCodeTypeName
ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim() //ProgLangTypeId4FuncCodeType
};
objvFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4GeneCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFunction4GeneCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = TransNullToBool(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetObjByDataRowvFunction4GeneCode)", objException.Message));
}
objvFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4GeneCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFunction4GeneCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunction4GeneCodeEN objvFunction4GeneCodeEN = new clsvFunction4GeneCodeEN();
try
{
objvFunction4GeneCodeEN.FuncId4GC = objRow[convFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objvFunction4GeneCodeEN.FuncName = objRow[convFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objvFunction4GeneCodeEN.FuncId4Code = objRow[convFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4GeneCodeEN.FuncName4Code = objRow[convFunction4GeneCode.FuncName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4GeneCodeEN.FuncCHName4Code = objRow[convFunction4GeneCode.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4GeneCodeEN.FunctionSignatureSim = objRow[convFunction4GeneCode.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4GeneCodeEN.FeatureId = objRow[convFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objvFunction4GeneCodeEN.FeatureName = objRow[convFunction4GeneCode.FeatureName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureName].ToString().Trim(); //功能名称
objvFunction4GeneCodeEN.FeatureDescription = objRow[convFunction4GeneCode.FeatureDescription] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureDescription].ToString().Trim(); //功能说明
objvFunction4GeneCodeEN.FeatureTypeName = objRow[convFunction4GeneCode.FeatureTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FeatureTypeName].ToString().Trim(); //功能类型名称
objvFunction4GeneCodeEN.ProgLangTypeId = objRow[convFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4GeneCodeEN.ProgLangTypeName = objRow[convFunction4GeneCode.ProgLangTypeName].ToString().Trim(); //编程语言类型名
objvFunction4GeneCodeEN.SqlDsTypeId = objRow[convFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objvFunction4GeneCodeEN.SqlDsTypeName = objRow[convFunction4GeneCode.SqlDsTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.SqlDsTypeName].ToString().Trim(); //Sql数据源名
objvFunction4GeneCodeEN.FuncGCTypeId = objRow[convFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4GeneCodeEN.FuncGCTypeName = objRow[convFunction4GeneCode.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4GeneCodeEN.FuncGCTypeENName = objRow[convFunction4GeneCode.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4GeneCodeEN.PrjId = objRow[convFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[convFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objvFunction4GeneCodeEN.ReturnTypeId = objRow[convFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4GeneCodeEN.FuncTypeId = objRow[convFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4GeneCodeEN.FuncTypeName = objRow[convFunction4GeneCode.FuncTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objvFunction4GeneCodeEN.FunctionSignature = objRow[convFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[convFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4GeneCodeEN.FuncCode = objRow[convFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objvFunction4GeneCodeEN.UserId = objRow[convFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[convFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objvFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[convFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objvFunction4GeneCodeEN.InUse = TransNullToBool(objRow[convFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objvFunction4GeneCodeEN.CodeText = objRow[convFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[convFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objvFunction4GeneCodeEN.UpdDate = objRow[convFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objvFunction4GeneCodeEN.UpdUser = objRow[convFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[convFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objvFunction4GeneCodeEN.Memo = objRow[convFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[convFunction4GeneCode.Memo].ToString().Trim(); //说明
objvFunction4GeneCodeEN.ParsedWords = objRow[convFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objvFunction4GeneCodeEN.ParsedWordsExcluded = objRow[convFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[convFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objvFunction4GeneCodeEN.WordVector = objRow[convFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[convFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objvFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[convFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
objvFunction4GeneCodeEN.ReturnTypeName = objRow[convFunction4GeneCode.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4GeneCodeEN.TemplateNum = objRow[convFunction4GeneCode.TemplateNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.TemplateNum].ToString().Trim()); //TemplateNum
objvFunction4GeneCodeEN.Order4FeatureNum = objRow[convFunction4GeneCode.Order4FeatureNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4GeneCode.Order4FeatureNum].ToString().Trim()); //Order4FeatureNum
objvFunction4GeneCodeEN.FuncCodeTypeENName = objRow[convFunction4GeneCode.FuncCodeTypeENName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeENName].ToString().Trim(); //FuncCodeTypeENName
objvFunction4GeneCodeEN.FuncCodeTypeId = objRow[convFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objvFunction4GeneCodeEN.FuncCodeTypeName = objRow[convFunction4GeneCode.FuncCodeTypeName] == DBNull.Value ? null : objRow[convFunction4GeneCode.FuncCodeTypeName].ToString().Trim(); //FuncCodeTypeName
objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType = objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType] == DBNull.Value ? null : objRow[convFunction4GeneCode.ProgLangTypeId4FuncCodeType].ToString().Trim(); //ProgLangTypeId4FuncCodeType
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFunction4GeneCodeDA: GetObjByDataRow)", objException.Message));
}
objvFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4GeneCodeEN;
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
objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunction4GeneCodeEN._CurrTabName, convFunction4GeneCode.FuncId4GC, 10, "");
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
objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunction4GeneCodeEN._CurrTabName, convFunction4GeneCode.FuncId4GC, 10, strPrefix);
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId4GC from vFunction4GeneCode where " + strCondition;
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId4GC from vFunction4GeneCode where " + strCondition;
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunction4GeneCode", "FuncId4GC = " + "'"+ strFuncId4GC+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFunction4GeneCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunction4GeneCode", strCondition))
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
objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFunction4GeneCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFunction4GeneCodeENS">源对象</param>
 /// <param name = "objvFunction4GeneCodeENT">目标对象</param>
public void CopyTo(clsvFunction4GeneCodeEN objvFunction4GeneCodeENS, clsvFunction4GeneCodeEN objvFunction4GeneCodeENT)
{
objvFunction4GeneCodeENT.FuncId4GC = objvFunction4GeneCodeENS.FuncId4GC; //函数ID
objvFunction4GeneCodeENT.FuncName = objvFunction4GeneCodeENS.FuncName; //函数名
objvFunction4GeneCodeENT.FuncId4Code = objvFunction4GeneCodeENS.FuncId4Code; //函数Id4Code
objvFunction4GeneCodeENT.FuncName4Code = objvFunction4GeneCodeENS.FuncName4Code; //函数名4Code
objvFunction4GeneCodeENT.FuncCHName4Code = objvFunction4GeneCodeENS.FuncCHName4Code; //函数中文名4Code
objvFunction4GeneCodeENT.FunctionSignatureSim = objvFunction4GeneCodeENS.FunctionSignatureSim; //函数签名_Sim
objvFunction4GeneCodeENT.FeatureId = objvFunction4GeneCodeENS.FeatureId; //功能Id
objvFunction4GeneCodeENT.FeatureName = objvFunction4GeneCodeENS.FeatureName; //功能名称
objvFunction4GeneCodeENT.FeatureDescription = objvFunction4GeneCodeENS.FeatureDescription; //功能说明
objvFunction4GeneCodeENT.FeatureTypeName = objvFunction4GeneCodeENS.FeatureTypeName; //功能类型名称
objvFunction4GeneCodeENT.ProgLangTypeId = objvFunction4GeneCodeENS.ProgLangTypeId; //编程语言类型Id
objvFunction4GeneCodeENT.ProgLangTypeName = objvFunction4GeneCodeENS.ProgLangTypeName; //编程语言类型名
objvFunction4GeneCodeENT.SqlDsTypeId = objvFunction4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objvFunction4GeneCodeENT.SqlDsTypeName = objvFunction4GeneCodeENS.SqlDsTypeName; //Sql数据源名
objvFunction4GeneCodeENT.FuncGCTypeId = objvFunction4GeneCodeENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4GeneCodeENT.FuncGCTypeName = objvFunction4GeneCodeENS.FuncGCTypeName; //函数生成代码类型名
objvFunction4GeneCodeENT.FuncGCTypeENName = objvFunction4GeneCodeENS.FuncGCTypeENName; //函数生成代码类型英文名
objvFunction4GeneCodeENT.PrjId = objvFunction4GeneCodeENS.PrjId; //工程Id
objvFunction4GeneCodeENT.ReturnTypeId = objvFunction4GeneCodeENS.ReturnTypeId; //返回类型ID
objvFunction4GeneCodeENT.FuncTypeId = objvFunction4GeneCodeENS.FuncTypeId; //函数类型Id
objvFunction4GeneCodeENT.FuncTypeName = objvFunction4GeneCodeENS.FuncTypeName; //函数类型名
objvFunction4GeneCodeENT.IsTemplate = objvFunction4GeneCodeENS.IsTemplate; //是否模板
objvFunction4GeneCodeENT.FunctionSignature = objvFunction4GeneCodeENS.FunctionSignature; //函数签名
objvFunction4GeneCodeENT.FuncCode = objvFunction4GeneCodeENS.FuncCode; //函数代码
objvFunction4GeneCodeENT.UserId = objvFunction4GeneCodeENS.UserId; //用户Id
objvFunction4GeneCodeENT.OrderNum = objvFunction4GeneCodeENS.OrderNum; //序号
objvFunction4GeneCodeENT.InUse = objvFunction4GeneCodeENS.InUse; //是否在用
objvFunction4GeneCodeENT.CodeText = objvFunction4GeneCodeENS.CodeText; //代码文本
objvFunction4GeneCodeENT.UpdDate = objvFunction4GeneCodeENS.UpdDate; //修改日期
objvFunction4GeneCodeENT.UpdUser = objvFunction4GeneCodeENS.UpdUser; //修改者
objvFunction4GeneCodeENT.Memo = objvFunction4GeneCodeENS.Memo; //说明
objvFunction4GeneCodeENT.ParsedWords = objvFunction4GeneCodeENS.ParsedWords; //分析的词
objvFunction4GeneCodeENT.ParsedWordsExcluded = objvFunction4GeneCodeENS.ParsedWordsExcluded; //剔除后的词组
objvFunction4GeneCodeENT.WordVector = objvFunction4GeneCodeENS.WordVector; //词向量
objvFunction4GeneCodeENT.IsFuncTemplate = objvFunction4GeneCodeENS.IsFuncTemplate; //是否函数模板
objvFunction4GeneCodeENT.ReturnTypeName = objvFunction4GeneCodeENS.ReturnTypeName; //返回类型名
objvFunction4GeneCodeENT.TemplateNum = objvFunction4GeneCodeENS.TemplateNum; //TemplateNum
objvFunction4GeneCodeENT.Order4FeatureNum = objvFunction4GeneCodeENS.Order4FeatureNum; //Order4FeatureNum
objvFunction4GeneCodeENT.FuncCodeTypeENName = objvFunction4GeneCodeENS.FuncCodeTypeENName; //FuncCodeTypeENName
objvFunction4GeneCodeENT.FuncCodeTypeId = objvFunction4GeneCodeENS.FuncCodeTypeId; //函数代码类型Id
objvFunction4GeneCodeENT.FuncCodeTypeName = objvFunction4GeneCodeENS.FuncCodeTypeName; //FuncCodeTypeName
objvFunction4GeneCodeENT.ProgLangTypeId4FuncCodeType = objvFunction4GeneCodeENS.ProgLangTypeId4FuncCodeType; //ProgLangTypeId4FuncCodeType
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFunction4GeneCodeEN objvFunction4GeneCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncId4GC, 10, convFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncName, 100, convFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncId4Code, 8, convFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncName4Code, 100, convFunction4GeneCode.FuncName4Code);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncCHName4Code, 200, convFunction4GeneCode.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FunctionSignatureSim, 500, convFunction4GeneCode.FunctionSignatureSim);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FeatureId, 4, convFunction4GeneCode.FeatureId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FeatureName, 100, convFunction4GeneCode.FeatureName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FeatureDescription, 4000, convFunction4GeneCode.FeatureDescription);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FeatureTypeName, 30, convFunction4GeneCode.FeatureTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ProgLangTypeId, 2, convFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ProgLangTypeName, 30, convFunction4GeneCode.ProgLangTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.SqlDsTypeId, 2, convFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.SqlDsTypeName, 20, convFunction4GeneCode.SqlDsTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncGCTypeId, 2, convFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncGCTypeName, 50, convFunction4GeneCode.FuncGCTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncGCTypeENName, 50, convFunction4GeneCode.FuncGCTypeENName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.PrjId, 4, convFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ReturnTypeId, 2, convFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncTypeId, 2, convFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncTypeName, 20, convFunction4GeneCode.FuncTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FunctionSignature, 500, convFunction4GeneCode.FunctionSignature);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.UserId, 18, convFunction4GeneCode.UserId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.CodeText, 8000, convFunction4GeneCode.CodeText);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.UpdDate, 20, convFunction4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.UpdUser, 20, convFunction4GeneCode.UpdUser);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.Memo, 1000, convFunction4GeneCode.Memo);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ParsedWords, 500, convFunction4GeneCode.ParsedWords);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ParsedWordsExcluded, 500, convFunction4GeneCode.ParsedWordsExcluded);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.WordVector, 500, convFunction4GeneCode.WordVector);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ReturnTypeName, 100, convFunction4GeneCode.ReturnTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncCodeTypeENName, 50, convFunction4GeneCode.FuncCodeTypeENName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncCodeTypeId, 4, convFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.FuncCodeTypeName, 50, convFunction4GeneCode.FuncCodeTypeName);
clsCheckSql.CheckFieldLen(objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType, 2, convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncId4GC, convFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncName, convFunction4GeneCode.FuncName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncId4Code, convFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncName4Code, convFunction4GeneCode.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncCHName4Code, convFunction4GeneCode.FuncCHName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FunctionSignatureSim, convFunction4GeneCode.FunctionSignatureSim);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FeatureId, convFunction4GeneCode.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FeatureName, convFunction4GeneCode.FeatureName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FeatureDescription, convFunction4GeneCode.FeatureDescription);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FeatureTypeName, convFunction4GeneCode.FeatureTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ProgLangTypeId, convFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ProgLangTypeName, convFunction4GeneCode.ProgLangTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.SqlDsTypeId, convFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.SqlDsTypeName, convFunction4GeneCode.SqlDsTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncGCTypeId, convFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncGCTypeName, convFunction4GeneCode.FuncGCTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncGCTypeENName, convFunction4GeneCode.FuncGCTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.PrjId, convFunction4GeneCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ReturnTypeId, convFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncTypeId, convFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncTypeName, convFunction4GeneCode.FuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FunctionSignature, convFunction4GeneCode.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.UserId, convFunction4GeneCode.UserId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.CodeText, convFunction4GeneCode.CodeText);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.UpdDate, convFunction4GeneCode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.UpdUser, convFunction4GeneCode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.Memo, convFunction4GeneCode.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ParsedWords, convFunction4GeneCode.ParsedWords);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ParsedWordsExcluded, convFunction4GeneCode.ParsedWordsExcluded);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.WordVector, convFunction4GeneCode.WordVector);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ReturnTypeName, convFunction4GeneCode.ReturnTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncCodeTypeENName, convFunction4GeneCode.FuncCodeTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncCodeTypeId, convFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.FuncCodeTypeName, convFunction4GeneCode.FuncCodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4GeneCodeEN.ProgLangTypeId4FuncCodeType, convFunction4GeneCode.ProgLangTypeId4FuncCodeType);
//检查外键字段长度
 objvFunction4GeneCodeEN._IsCheckProperty = true;
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunction4GeneCodeEN._CurrTabName);
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunction4GeneCodeEN._CurrTabName, strCondition);
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
 objSQL = clsvFunction4GeneCodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}