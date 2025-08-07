
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsFunction4GeneCodeDA
 表名:Function4GeneCode(00050311)
 * 版本:2025.07.25.1(服务器:PYF-AI)
 日期:2025/07/28 00:26:44
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// 函数4GeneCode(Function4GeneCode)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsFunction4GeneCodeDA : clsCommBase4DA
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
 return clsFunction4GeneCodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsFunction4GeneCodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsFunction4GeneCodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsFunction4GeneCodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsFunction4GeneCodeEN._ConnectString);
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
throw new Exception("(errid:Data000001)在表:Function4GeneCode中,检查关键字,长度不正确!(clsFunction4GeneCodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId4GC)  ==  true)
{
throw new Exception("(errid:Data000002)在表:Function4GeneCode中,关键字不能为空 或 null!(clsFunction4GeneCodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4GC);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsFunction4GeneCodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_Function4GeneCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable_Function4GeneCode)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Function4GeneCode.* " + 
$"from Function4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Function4GeneCode.FuncId4GC not in " + 
$"(Select top {intTop_In} Function4GeneCode.FuncId4GC from Function4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1} and FuncId4GC not in (Select top {2} FuncId4GC from Function4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1} and FuncId4GC not in (Select top {3} FuncId4GC from Function4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} Function4GeneCode.* " + 
$"from Function4GeneCode " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and Function4GeneCode.FuncId4GC not in " + 
$"(Select top {intTop_In} Function4GeneCode.FuncId4GC from Function4GeneCode " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1} and FuncId4GC not in (Select top {2} FuncId4GC from Function4GeneCode where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from Function4GeneCode where {1} and FuncId4GC not in (Select top {3} FuncId4GC from Function4GeneCode where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsFunction4GeneCodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA:GetObjLst)", objException.Message));
}
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = TransNullToBool(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetObjLst)", objException.Message));
}
objFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunction4GeneCodeEN);
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
public List<clsFunction4GeneCodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsFunction4GeneCodeEN> arrObjLst = new List<clsFunction4GeneCodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = TransNullToBool(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetObjLst)", objException.Message));
}
objFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objFunction4GeneCodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetFunction4GeneCode(ref clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where FuncId4GC = " + "'"+ objFunction4GeneCodeEN.FuncId4GC+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objFunction4GeneCodeEN.FuncId4GC = objDT.Rows[0][conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objFunction4GeneCodeEN.FuncName = objDT.Rows[0][conFunction4GeneCode.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4GeneCodeEN.FuncId4Code = objDT.Rows[0][conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objFunction4GeneCodeEN.FuncName4GC = objDT.Rows[0][conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4GeneCodeEN.FuncCHName4GC = objDT.Rows[0][conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4GeneCodeEN.FeatureId = objDT.Rows[0][conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.ProgLangTypeId = objDT.Rows[0][conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.FuncCodeTypeId = objDT.Rows[0][conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.SqlDsTypeId = objDT.Rows[0][conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.FuncGCTypeId = objDT.Rows[0][conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.PrjId = objDT.Rows[0][conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.ReturnTypeId = objDT.Rows[0][conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objFunction4GeneCodeEN.FuncTypeId = objDT.Rows[0][conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.IsTemplate = TransNullToBool(objDT.Rows[0][conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objFunction4GeneCodeEN.FunctionSignature = objDT.Rows[0][conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4GeneCodeEN.FuncCode = objDT.Rows[0][conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objFunction4GeneCodeEN.UserId = objDT.Rows[0][conFunction4GeneCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objFunction4GeneCodeEN.OrderNum = TransNullToInt(objDT.Rows[0][conFunction4GeneCode.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.InUse = TransNullToBool(objDT.Rows[0][conFunction4GeneCode.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFunction4GeneCodeEN.PrimaryTypeIds = objDT.Rows[0][conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4GeneCodeEN.CodeText = objDT.Rows[0][conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objFunction4GeneCodeEN.UsedTimes = TransNullToInt(objDT.Rows[0][conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
 objFunction4GeneCodeEN.UpdDate = objDT.Rows[0][conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4GeneCodeEN.UpdUser = objDT.Rows[0][conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4GeneCodeEN.Memo = objDT.Rows[0][conFunction4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objFunction4GeneCodeEN.ParsedWords = objDT.Rows[0][conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4GeneCodeEN.ParsedWordsExcluded = objDT.Rows[0][conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4GeneCodeEN.WordVector = objDT.Rows[0][conFunction4GeneCode.WordVector].ToString().Trim(); //词向量(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objDT.Rows[0][conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetFunction4GeneCode)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4GC">表关键字</param>
 /// <returns>表对象</returns>
public clsFunction4GeneCodeEN GetObjByFuncId4GC(string strFuncId4GC)
{
CheckPrimaryKey(strFuncId4GC);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where FuncId4GC = " + "'"+ strFuncId4GC+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
 objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID(字段类型:char,字段长度:10,是否可空:False)
 objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名(字段类型:varchar,字段长度:100,是否可空:False)
 objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objFunction4GeneCodeEN.IsTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板(字段类型:bit,字段长度:1,是否可空:False)
 objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码(字段类型:text,字段长度:2147483647,是否可空:True)
 objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id(字段类型:varchar,字段长度:18,是否可空:True)
 objFunction4GeneCodeEN.OrderNum = Int32.Parse(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objFunction4GeneCodeEN.InUse = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用(字段类型:bit,字段长度:1,是否可空:True)
 objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s(字段类型:varchar,字段长度:50,是否可空:True)
 objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本(字段类型:varchar,字段长度:8000,是否可空:True)
 objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数(字段类型:int,字段长度:4,是否可空:True)
 objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量(字段类型:varchar,字段长度:500,是否可空:True)
 objFunction4GeneCodeEN.IsFuncTemplate = clsEntityBase2.TransNullToBool_S(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板(字段类型:bit,字段长度:1,是否可空:True)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetObjByFuncId4GC)", objException.Message));
}
return objFunction4GeneCodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsFunction4GeneCodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN()
{
FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(), //函数ID
FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(), //函数名
FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(), //函数名4生成代码
FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(), //函数中文名4生成代码
FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(), //功能Id
ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(), //函数代码类型Id
SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(), //数据源类型Id
FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(), //函数生成代码类型Id
PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(), //工程Id
ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(), //返回类型ID
FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(), //函数类型Id
IsTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()), //是否模板
FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(), //函数签名
FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(), //函数代码
UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(), //用户Id
OrderNum = TransNullToInt(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()), //序号
InUse = TransNullToBool(objRow[conFunction4GeneCode.InUse].ToString().Trim()), //是否在用
PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(), //主键类型s
CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(), //代码文本
UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()), //使用次数
UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(), //修改者
Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(), //说明
ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(), //分析的词
ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(), //剔除后的词组
WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(), //词向量
IsFuncTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()) //是否函数模板
};
objFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunction4GeneCodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsFunction4GeneCodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = TransNullToBool(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetObjByDataRowFunction4GeneCode)", objException.Message));
}
objFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunction4GeneCodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsFunction4GeneCodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsFunction4GeneCodeEN objFunction4GeneCodeEN = new clsFunction4GeneCodeEN();
try
{
objFunction4GeneCodeEN.FuncId4GC = objRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objFunction4GeneCodeEN.FuncName = objRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objFunction4GeneCodeEN.FuncId4Code = objRow[conFunction4GeneCode.FuncId4Code] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objFunction4GeneCodeEN.FuncName4GC = objRow[conFunction4GeneCode.FuncName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objFunction4GeneCodeEN.FuncCHName4GC = objRow[conFunction4GeneCode.FuncCHName4GC] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objFunction4GeneCodeEN.FeatureId = objRow[conFunction4GeneCode.FeatureId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objFunction4GeneCodeEN.ProgLangTypeId = objRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objFunction4GeneCodeEN.FuncCodeTypeId = objRow[conFunction4GeneCode.FuncCodeTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objFunction4GeneCodeEN.SqlDsTypeId = objRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objFunction4GeneCodeEN.FuncGCTypeId = objRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objFunction4GeneCodeEN.PrjId = objRow[conFunction4GeneCode.PrjId] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objFunction4GeneCodeEN.ReturnTypeId = objRow[conFunction4GeneCode.ReturnTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objFunction4GeneCodeEN.FuncTypeId = objRow[conFunction4GeneCode.FuncTypeId] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objFunction4GeneCodeEN.IsTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsTemplate].ToString().Trim()); //是否模板
objFunction4GeneCodeEN.FunctionSignature = objRow[conFunction4GeneCode.FunctionSignature] == DBNull.Value ? null : objRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objFunction4GeneCodeEN.FuncCode = objRow[conFunction4GeneCode.FuncCode] == DBNull.Value ? null : objRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objFunction4GeneCodeEN.UserId = objRow[conFunction4GeneCode.UserId] == DBNull.Value ? null : objRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objFunction4GeneCodeEN.OrderNum = TransNullToInt(objRow[conFunction4GeneCode.OrderNum].ToString().Trim()); //序号
objFunction4GeneCodeEN.InUse = TransNullToBool(objRow[conFunction4GeneCode.InUse].ToString().Trim()); //是否在用
objFunction4GeneCodeEN.PrimaryTypeIds = objRow[conFunction4GeneCode.PrimaryTypeIds] == DBNull.Value ? null : objRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objFunction4GeneCodeEN.CodeText = objRow[conFunction4GeneCode.CodeText] == DBNull.Value ? null : objRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objFunction4GeneCodeEN.UsedTimes = objRow[conFunction4GeneCode.UsedTimes] == DBNull.Value ? (int?)null : TransNullToInt(objRow[conFunction4GeneCode.UsedTimes].ToString().Trim()); //使用次数
objFunction4GeneCodeEN.UpdDate = objRow[conFunction4GeneCode.UpdDate] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objFunction4GeneCodeEN.UpdUser = objRow[conFunction4GeneCode.UpdUser] == DBNull.Value ? null : objRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objFunction4GeneCodeEN.Memo = objRow[conFunction4GeneCode.Memo] == DBNull.Value ? null : objRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objFunction4GeneCodeEN.ParsedWords = objRow[conFunction4GeneCode.ParsedWords] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objFunction4GeneCodeEN.ParsedWordsExcluded = objRow[conFunction4GeneCode.ParsedWordsExcluded] == DBNull.Value ? null : objRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objFunction4GeneCodeEN.WordVector = objRow[conFunction4GeneCode.WordVector] == DBNull.Value ? null : objRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objFunction4GeneCodeEN.IsFuncTemplate = TransNullToBool(objRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim()); //是否函数模板
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsFunction4GeneCodeDA: GetObjByDataRow)", objException.Message));
}
objFunction4GeneCodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objFunction4GeneCodeEN;
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
objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunction4GeneCodeEN._CurrTabName, conFunction4GeneCode.FuncId4GC, 10, "");
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
objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsFunction4GeneCodeEN._CurrTabName, conFunction4GeneCode.FuncId4GC, 10, strPrefix);
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId4GC from Function4GeneCode where " + strCondition;
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId4GC from Function4GeneCode where " + strCondition;
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Function4GeneCode", "FuncId4GC = " + "'"+ strFuncId4GC+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("Function4GeneCode", strCondition))
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
objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("Function4GeneCode");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 添加记录

 /// <summary>
 /// 添加新记录
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecord)
 /// </summary>
 /// <returns>添加是否成功?</returns>
 public bool AddNewRecord(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
 {
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4GeneCodeEN);
 }
string strSQL; 
System.Data.SqlClient.SqlDataAdapter objDA ; 
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB ; 
System.Data.DataRow objRow; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where 1 = 2";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Function4GeneCode");
objRow = objDS.Tables["Function4GeneCode"].NewRow();
objRow[conFunction4GeneCode.FuncId4GC] = objFunction4GeneCodeEN.FuncId4GC; //函数ID
objRow[conFunction4GeneCode.FuncName] = objFunction4GeneCodeEN.FuncName; //函数名
 if (objFunction4GeneCodeEN.FuncId4Code !=  "")
 {
objRow[conFunction4GeneCode.FuncId4Code] = objFunction4GeneCodeEN.FuncId4Code; //函数Id4Code
 }
 if (objFunction4GeneCodeEN.FuncName4GC !=  "")
 {
objRow[conFunction4GeneCode.FuncName4GC] = objFunction4GeneCodeEN.FuncName4GC; //函数名4生成代码
 }
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  "")
 {
objRow[conFunction4GeneCode.FuncCHName4GC] = objFunction4GeneCodeEN.FuncCHName4GC; //函数中文名4生成代码
 }
 if (objFunction4GeneCodeEN.FeatureId !=  "")
 {
objRow[conFunction4GeneCode.FeatureId] = objFunction4GeneCodeEN.FeatureId; //功能Id
 }
objRow[conFunction4GeneCode.ProgLangTypeId] = objFunction4GeneCodeEN.ProgLangTypeId; //编程语言类型Id
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  "")
 {
objRow[conFunction4GeneCode.FuncCodeTypeId] = objFunction4GeneCodeEN.FuncCodeTypeId; //函数代码类型Id
 }
objRow[conFunction4GeneCode.SqlDsTypeId] = objFunction4GeneCodeEN.SqlDsTypeId; //数据源类型Id
objRow[conFunction4GeneCode.FuncGCTypeId] = objFunction4GeneCodeEN.FuncGCTypeId; //函数生成代码类型Id
 if (objFunction4GeneCodeEN.PrjId !=  "")
 {
objRow[conFunction4GeneCode.PrjId] = objFunction4GeneCodeEN.PrjId; //工程Id
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  "")
 {
objRow[conFunction4GeneCode.ReturnTypeId] = objFunction4GeneCodeEN.ReturnTypeId; //返回类型ID
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  "")
 {
objRow[conFunction4GeneCode.FuncTypeId] = objFunction4GeneCodeEN.FuncTypeId; //函数类型Id
 }
objRow[conFunction4GeneCode.IsTemplate] = objFunction4GeneCodeEN.IsTemplate; //是否模板
 if (objFunction4GeneCodeEN.FunctionSignature !=  "")
 {
objRow[conFunction4GeneCode.FunctionSignature] = objFunction4GeneCodeEN.FunctionSignature; //函数签名
 }
 if (objFunction4GeneCodeEN.FuncCode !=  "")
 {
objRow[conFunction4GeneCode.FuncCode] = objFunction4GeneCodeEN.FuncCode; //函数代码
 }
 if (objFunction4GeneCodeEN.UserId !=  "")
 {
objRow[conFunction4GeneCode.UserId] = objFunction4GeneCodeEN.UserId; //用户Id
 }
objRow[conFunction4GeneCode.OrderNum] = objFunction4GeneCodeEN.OrderNum; //序号
objRow[conFunction4GeneCode.InUse] = objFunction4GeneCodeEN.InUse; //是否在用
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  "")
 {
objRow[conFunction4GeneCode.PrimaryTypeIds] = objFunction4GeneCodeEN.PrimaryTypeIds; //主键类型s
 }
 if (objFunction4GeneCodeEN.CodeText !=  "")
 {
objRow[conFunction4GeneCode.CodeText] = objFunction4GeneCodeEN.CodeText; //代码文本
 }
objRow[conFunction4GeneCode.UsedTimes] = objFunction4GeneCodeEN.UsedTimes; //使用次数
 if (objFunction4GeneCodeEN.UpdDate !=  "")
 {
objRow[conFunction4GeneCode.UpdDate] = objFunction4GeneCodeEN.UpdDate; //修改日期
 }
 if (objFunction4GeneCodeEN.UpdUser !=  "")
 {
objRow[conFunction4GeneCode.UpdUser] = objFunction4GeneCodeEN.UpdUser; //修改者
 }
 if (objFunction4GeneCodeEN.Memo !=  "")
 {
objRow[conFunction4GeneCode.Memo] = objFunction4GeneCodeEN.Memo; //说明
 }
 if (objFunction4GeneCodeEN.ParsedWords !=  "")
 {
objRow[conFunction4GeneCode.ParsedWords] = objFunction4GeneCodeEN.ParsedWords; //分析的词
 }
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  "")
 {
objRow[conFunction4GeneCode.ParsedWordsExcluded] = objFunction4GeneCodeEN.ParsedWordsExcluded; //剔除后的词组
 }
 if (objFunction4GeneCodeEN.WordVector !=  "")
 {
objRow[conFunction4GeneCode.WordVector] = objFunction4GeneCodeEN.WordVector; //词向量
 }
objRow[conFunction4GeneCode.IsFuncTemplate] = objFunction4GeneCodeEN.IsFuncTemplate; //是否函数模板
objDS.Tables[clsFunction4GeneCodeEN._CurrTabName].Rows.Add(objRow);
try
{
objDA.Update(objDS, clsFunction4GeneCodeEN._CurrTabName);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4GeneCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4GeneCodeEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4GC);
 var strFuncId4GC = objFunction4GeneCodeEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName);
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4Code);
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName4GC);
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCHName4GC);
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FeatureId);
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ProgLangTypeId);
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCodeTypeId);
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCodeTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.SqlDsTypeId);
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrjId);
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ReturnTypeId);
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncTypeId);
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FunctionSignature);
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCode);
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UserId);
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.OrderNum);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conFunction4GeneCode.InUse);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrimaryTypeIds);
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeIds + "'");
 }
 
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.CodeText);
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeText + "'");
 }
 
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UsedTimes);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.UsedTimes.ToString());
 }
 
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdDate);
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdUser);
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.Memo);
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWords);
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWords + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWordsExcluded);
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWordsExcluded + "'");
 }
 
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.WordVector);
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordVector + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsFuncTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsFuncTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4GeneCode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString());
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKey)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4GeneCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4GeneCodeEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4GC);
 var strFuncId4GC = objFunction4GeneCodeEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName);
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4Code);
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName4GC);
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCHName4GC);
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FeatureId);
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ProgLangTypeId);
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCodeTypeId);
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCodeTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.SqlDsTypeId);
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrjId);
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ReturnTypeId);
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncTypeId);
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FunctionSignature);
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCode);
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UserId);
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.OrderNum);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conFunction4GeneCode.InUse);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrimaryTypeIds);
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeIds + "'");
 }
 
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.CodeText);
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeText + "'");
 }
 
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UsedTimes);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.UsedTimes.ToString());
 }
 
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdDate);
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdUser);
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.Memo);
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWords);
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWords + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWordsExcluded);
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWordsExcluded + "'");
 }
 
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.WordVector);
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordVector + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsFuncTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsFuncTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4GeneCode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
 objSQL.ExecSql(strSQL.ToString());
return objFunction4GeneCodeEN.FuncId4GC;
}



 /// <summary>
 /// /// 功能:通过SQL命令来插入记录,该方式是优化方式,同时返回新插入记录的关键字的值.(带事务处理)(针对Identity关键字)
 /// /// 优点:1、能够处理字段中的单撇问题；2、能够使字段值为NULL的字段无需插入；3、返回新插入记录的关键字的值
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQL2WithReturnKeyAndTransaction)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回新插入记录的关键字的值,否则就报错</returns>
public string AddNewRecordBySQL2WithReturnKey(clsFunction4GeneCodeEN objFunction4GeneCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4GeneCodeEN);
 }
StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4GeneCodeEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4GC);
 var strFuncId4GC = objFunction4GeneCodeEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName);
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4Code);
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName4GC);
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCHName4GC);
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FeatureId);
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ProgLangTypeId);
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCodeTypeId);
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCodeTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.SqlDsTypeId);
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrjId);
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ReturnTypeId);
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncTypeId);
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FunctionSignature);
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCode);
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UserId);
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.OrderNum);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conFunction4GeneCode.InUse);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrimaryTypeIds);
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeIds + "'");
 }
 
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.CodeText);
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeText + "'");
 }
 
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UsedTimes);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.UsedTimes.ToString());
 }
 
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdDate);
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdUser);
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.Memo);
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWords);
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWords + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWordsExcluded);
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWordsExcluded + "'");
 }
 
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.WordVector);
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordVector + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsFuncTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsFuncTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4GeneCode");
 strSQL.AppendFormat(" ({0}) values ({1}); ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
    objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
return objFunction4GeneCodeEN.FuncId4GC;
}



 /// <summary>
 /// 功能:通过SQL命令来插入记录
 /// 主要用于上传文件时。
 /// (AutoGCLib.DALCode4CSharp:GenAddNewRecordBySQLWithTransaction2)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果插入成功则返回TRUE,否则为FALSE</returns>
public bool AddNewRecordBySQL2(clsFunction4GeneCodeEN objFunction4GeneCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckPropertyNew(objFunction4GeneCodeEN);
 }
 StringBuilder strSQL = new StringBuilder();
 //需要插入表的字段列表
 ArrayList arrFieldListForInsert = new ArrayList();
 //需要插入表的值列表
 ArrayList arrValueListForInsert = new ArrayList();
 
 if (objFunction4GeneCodeEN.FuncId4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4GC);
 var strFuncId4GC = objFunction4GeneCodeEN.FuncId4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName);
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncId4Code);
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncId4Code + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncName4GC);
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCHName4GC);
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCHName4GC + "'");
 }
 
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FeatureId);
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFeatureId + "'");
 }
 
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ProgLangTypeId);
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strProgLangTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCodeTypeId);
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCodeTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.SqlDsTypeId);
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strSqlDsTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncGCTypeId);
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncGCTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrjId);
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrjId + "'");
 }
 
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ReturnTypeId);
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strReturnTypeId + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncTypeId);
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncTypeId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsTemplate  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FunctionSignature);
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFunctionSignature + "'");
 }
 
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.FuncCode);
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strFuncCode + "'");
 }
 
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UserId);
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUserId + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.OrderNum);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.OrderNum.ToString());
 
 arrFieldListForInsert.Add(conFunction4GeneCode.InUse);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.InUse  ==  false ? "0" : "1") + "'");
 
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.PrimaryTypeIds);
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strPrimaryTypeIds + "'");
 }
 
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.CodeText);
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strCodeText + "'");
 }
 
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UsedTimes);
 arrValueListForInsert.Add(objFunction4GeneCodeEN.UsedTimes.ToString());
 }
 
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdDate);
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdDate + "'");
 }
 
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.UpdUser);
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strUpdUser + "'");
 }
 
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.Memo);
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strMemo + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWords);
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWords + "'");
 }
 
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.ParsedWordsExcluded);
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strParsedWordsExcluded + "'");
 }
 
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 arrFieldListForInsert.Add(conFunction4GeneCode.WordVector);
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 arrValueListForInsert.Add("'" + strWordVector + "'");
 }
 
 arrFieldListForInsert.Add(conFunction4GeneCode.IsFuncTemplate);
 arrValueListForInsert.Add("'" + (objFunction4GeneCodeEN.IsFuncTemplate  ==  false ? "0" : "1") + "'");
 //组织插入记录SQL串
 string[] sstrFieldCode = (string[])(arrFieldListForInsert.ToArray(System.Type.GetType("System.String")));
 string strFieldListCode = string.Join(",", sstrFieldCode);
 string[] sstrValuesCode = (string[])(arrValueListForInsert.ToArray(System.Type.GetType("System.String")));
 string strValuesListCode = string.Join(",", sstrValuesCode);
 strSQL.Append("Insert into Function4GeneCode");
 strSQL.AppendFormat(" ({0}) values ({1}) ", strFieldListCode, strValuesListCode);
 clsCheckSql.CheckSqlInjection4Insert(strSQL.ToString());
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
return objSQL.ExecSql(strSQL.ToString(), objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 把多条记录同时插入到表中!
 /// (AutoGCLib.DALCode4CSharp:GenAddnewMultiRec)
 /// </summary>
 /// <param name = "oDT"></param>
 /// <returns></returns>
public bool AddnewFunction4GeneCodes(System.Data.DataTable oDT) 
{
string strSQL;
System.Data.SqlClient.SqlDataAdapter objDA;
System.Data.DataSet objDS = new System.Data.DataSet();
System.Data.SqlClient.SqlCommandBuilder objCB; 
System.Data.DataRow objRow;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where FuncId4GC = '111'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, "Function4GeneCode");
//检查关键字的唯一性
foreach(System.Data.DataRow oRow in oDT.Rows)
{
string strFuncId4GC = oRow[conFunction4GeneCode.FuncId4GC].ToString().Trim();
if (IsExist(strFuncId4GC))
{
 string strResult = "关键字变量值为:" + string.Format("FuncId4GC = {0}", strFuncId4GC) + "的记录已存在,不能重复插入!" ;
 throw new Exception(strResult);
}
}
//把多条记录插入到表中
foreach(System.Data.DataRow oRow in oDT.Rows)
{
objRow = objDS.Tables[clsFunction4GeneCodeEN._CurrTabName ].NewRow();
objRow[conFunction4GeneCode.FuncId4GC] = oRow[conFunction4GeneCode.FuncId4GC].ToString().Trim(); //函数ID
objRow[conFunction4GeneCode.FuncName] = oRow[conFunction4GeneCode.FuncName].ToString().Trim(); //函数名
objRow[conFunction4GeneCode.FuncId4Code] = oRow[conFunction4GeneCode.FuncId4Code].ToString().Trim(); //函数Id4Code
objRow[conFunction4GeneCode.FuncName4GC] = oRow[conFunction4GeneCode.FuncName4GC].ToString().Trim(); //函数名4生成代码
objRow[conFunction4GeneCode.FuncCHName4GC] = oRow[conFunction4GeneCode.FuncCHName4GC].ToString().Trim(); //函数中文名4生成代码
objRow[conFunction4GeneCode.FeatureId] = oRow[conFunction4GeneCode.FeatureId].ToString().Trim(); //功能Id
objRow[conFunction4GeneCode.ProgLangTypeId] = oRow[conFunction4GeneCode.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objRow[conFunction4GeneCode.FuncCodeTypeId] = oRow[conFunction4GeneCode.FuncCodeTypeId].ToString().Trim(); //函数代码类型Id
objRow[conFunction4GeneCode.SqlDsTypeId] = oRow[conFunction4GeneCode.SqlDsTypeId].ToString().Trim(); //数据源类型Id
objRow[conFunction4GeneCode.FuncGCTypeId] = oRow[conFunction4GeneCode.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objRow[conFunction4GeneCode.PrjId] = oRow[conFunction4GeneCode.PrjId].ToString().Trim(); //工程Id
objRow[conFunction4GeneCode.ReturnTypeId] = oRow[conFunction4GeneCode.ReturnTypeId].ToString().Trim(); //返回类型ID
objRow[conFunction4GeneCode.FuncTypeId] = oRow[conFunction4GeneCode.FuncTypeId].ToString().Trim(); //函数类型Id
objRow[conFunction4GeneCode.IsTemplate] = oRow[conFunction4GeneCode.IsTemplate].ToString().Trim(); //是否模板
objRow[conFunction4GeneCode.FunctionSignature] = oRow[conFunction4GeneCode.FunctionSignature].ToString().Trim(); //函数签名
objRow[conFunction4GeneCode.FuncCode] = oRow[conFunction4GeneCode.FuncCode].ToString().Trim(); //函数代码
objRow[conFunction4GeneCode.UserId] = oRow[conFunction4GeneCode.UserId].ToString().Trim(); //用户Id
objRow[conFunction4GeneCode.OrderNum] = oRow[conFunction4GeneCode.OrderNum].ToString().Trim(); //序号
objRow[conFunction4GeneCode.InUse] = oRow[conFunction4GeneCode.InUse].ToString().Trim(); //是否在用
objRow[conFunction4GeneCode.PrimaryTypeIds] = oRow[conFunction4GeneCode.PrimaryTypeIds].ToString().Trim(); //主键类型s
objRow[conFunction4GeneCode.CodeText] = oRow[conFunction4GeneCode.CodeText].ToString().Trim(); //代码文本
objRow[conFunction4GeneCode.UsedTimes] = oRow[conFunction4GeneCode.UsedTimes].ToString().Trim(); //使用次数
objRow[conFunction4GeneCode.UpdDate] = oRow[conFunction4GeneCode.UpdDate].ToString().Trim(); //修改日期
objRow[conFunction4GeneCode.UpdUser] = oRow[conFunction4GeneCode.UpdUser].ToString().Trim(); //修改者
objRow[conFunction4GeneCode.Memo] = oRow[conFunction4GeneCode.Memo].ToString().Trim(); //说明
objRow[conFunction4GeneCode.ParsedWords] = oRow[conFunction4GeneCode.ParsedWords].ToString().Trim(); //分析的词
objRow[conFunction4GeneCode.ParsedWordsExcluded] = oRow[conFunction4GeneCode.ParsedWordsExcluded].ToString().Trim(); //剔除后的词组
objRow[conFunction4GeneCode.WordVector] = oRow[conFunction4GeneCode.WordVector].ToString().Trim(); //词向量
objRow[conFunction4GeneCode.IsFuncTemplate] = oRow[conFunction4GeneCode.IsFuncTemplate].ToString().Trim(); //是否函数模板
 objDS.Tables[clsFunction4GeneCodeEN._CurrTabName].Rows.Add(objRow);
}
try
{
objDA.Update(objDS, clsFunction4GeneCodeEN._CurrTabName);
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
 /// <param name = "objFunction4GeneCodeEN">需要修改到数据库中的对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool Update(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4GeneCodeEN);
 }
string strSQL ;
System.Data.SqlClient.SqlDataAdapter objDA ;
System.Data.DataSet objDS = new System.Data.DataSet();
 System.Data.SqlClient.SqlCommandBuilder objCB ;
System.Data.DataRow objRow ;
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
strSQL = "Select * from Function4GeneCode where FuncId4GC = " + "'"+ objFunction4GeneCodeEN.FuncId4GC+"'";
objDA = new System.Data.SqlClient.SqlDataAdapter(strSQL, objSQL.SQLConnect);
objCB = new System.Data.SqlClient.SqlCommandBuilder(objDA);
objDA.Fill(objDS, clsFunction4GeneCodeEN._CurrTabName);
if (objDS.Tables[clsFunction4GeneCodeEN._CurrTabName].Rows.Count  ==  0)
{
//MsgBox("没有相应的ID号:FuncId4GC = " + "'"+ objFunction4GeneCodeEN.FuncId4GC+"'");
return false;
}
objRow = objDS.Tables[clsFunction4GeneCodeEN._CurrTabName].Rows[0];
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncId4GC))
 {
objRow[conFunction4GeneCode.FuncId4GC] = objFunction4GeneCodeEN.FuncId4GC; //函数ID
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName))
 {
objRow[conFunction4GeneCode.FuncName] = objFunction4GeneCodeEN.FuncName; //函数名
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncId4Code))
 {
objRow[conFunction4GeneCode.FuncId4Code] = objFunction4GeneCodeEN.FuncId4Code; //函数Id4Code
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName4GC))
 {
objRow[conFunction4GeneCode.FuncName4GC] = objFunction4GeneCodeEN.FuncName4GC; //函数名4生成代码
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCHName4GC))
 {
objRow[conFunction4GeneCode.FuncCHName4GC] = objFunction4GeneCodeEN.FuncCHName4GC; //函数中文名4生成代码
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FeatureId))
 {
objRow[conFunction4GeneCode.FeatureId] = objFunction4GeneCodeEN.FeatureId; //功能Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ProgLangTypeId))
 {
objRow[conFunction4GeneCode.ProgLangTypeId] = objFunction4GeneCodeEN.ProgLangTypeId; //编程语言类型Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCodeTypeId))
 {
objRow[conFunction4GeneCode.FuncCodeTypeId] = objFunction4GeneCodeEN.FuncCodeTypeId; //函数代码类型Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.SqlDsTypeId))
 {
objRow[conFunction4GeneCode.SqlDsTypeId] = objFunction4GeneCodeEN.SqlDsTypeId; //数据源类型Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncGCTypeId))
 {
objRow[conFunction4GeneCode.FuncGCTypeId] = objFunction4GeneCodeEN.FuncGCTypeId; //函数生成代码类型Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrjId))
 {
objRow[conFunction4GeneCode.PrjId] = objFunction4GeneCodeEN.PrjId; //工程Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ReturnTypeId))
 {
objRow[conFunction4GeneCode.ReturnTypeId] = objFunction4GeneCodeEN.ReturnTypeId; //返回类型ID
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncTypeId))
 {
objRow[conFunction4GeneCode.FuncTypeId] = objFunction4GeneCodeEN.FuncTypeId; //函数类型Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsTemplate))
 {
objRow[conFunction4GeneCode.IsTemplate] = objFunction4GeneCodeEN.IsTemplate; //是否模板
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FunctionSignature))
 {
objRow[conFunction4GeneCode.FunctionSignature] = objFunction4GeneCodeEN.FunctionSignature; //函数签名
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCode))
 {
objRow[conFunction4GeneCode.FuncCode] = objFunction4GeneCodeEN.FuncCode; //函数代码
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UserId))
 {
objRow[conFunction4GeneCode.UserId] = objFunction4GeneCodeEN.UserId; //用户Id
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.OrderNum))
 {
objRow[conFunction4GeneCode.OrderNum] = objFunction4GeneCodeEN.OrderNum; //序号
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.InUse))
 {
objRow[conFunction4GeneCode.InUse] = objFunction4GeneCodeEN.InUse; //是否在用
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrimaryTypeIds))
 {
objRow[conFunction4GeneCode.PrimaryTypeIds] = objFunction4GeneCodeEN.PrimaryTypeIds; //主键类型s
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.CodeText))
 {
objRow[conFunction4GeneCode.CodeText] = objFunction4GeneCodeEN.CodeText; //代码文本
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UsedTimes))
 {
objRow[conFunction4GeneCode.UsedTimes] = objFunction4GeneCodeEN.UsedTimes; //使用次数
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdDate))
 {
objRow[conFunction4GeneCode.UpdDate] = objFunction4GeneCodeEN.UpdDate; //修改日期
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdUser))
 {
objRow[conFunction4GeneCode.UpdUser] = objFunction4GeneCodeEN.UpdUser; //修改者
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.Memo))
 {
objRow[conFunction4GeneCode.Memo] = objFunction4GeneCodeEN.Memo; //说明
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWords))
 {
objRow[conFunction4GeneCode.ParsedWords] = objFunction4GeneCodeEN.ParsedWords; //分析的词
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded))
 {
objRow[conFunction4GeneCode.ParsedWordsExcluded] = objFunction4GeneCodeEN.ParsedWordsExcluded; //剔除后的词组
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.WordVector))
 {
objRow[conFunction4GeneCode.WordVector] = objFunction4GeneCodeEN.WordVector; //词向量
 }
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsFuncTemplate))
 {
objRow[conFunction4GeneCode.IsFuncTemplate] = objFunction4GeneCodeEN.IsFuncTemplate; //是否函数模板
 }
try
{
objDA.Update(objDS, clsFunction4GeneCodeEN._CurrTabName);
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4GeneCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
try
{
sbSQL.AppendFormat("Update Function4GeneCode Set ");
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName))
 {
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conFunction4GeneCode.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncName); //函数名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncId4Code))
 {
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncId4Code, conFunction4GeneCode.FuncId4Code); //函数Id4Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncId4Code); //函数Id4Code
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName4GC))
 {
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName4GC, conFunction4GeneCode.FuncName4GC); //函数名4生成代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncName4GC); //函数名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCHName4GC))
 {
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCHName4GC, conFunction4GeneCode.FuncCHName4GC); //函数中文名4生成代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncCHName4GC); //函数中文名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FeatureId))
 {
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conFunction4GeneCode.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FeatureId); //功能Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ProgLangTypeId))
 {
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conFunction4GeneCode.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCodeTypeId))
 {
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCodeTypeId, conFunction4GeneCode.FuncCodeTypeId); //函数代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncCodeTypeId); //函数代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.SqlDsTypeId))
 {
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsTypeId, conFunction4GeneCode.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.SqlDsTypeId); //数据源类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncGCTypeId))
 {
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncGCTypeId, conFunction4GeneCode.FuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncGCTypeId); //函数生成代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrjId))
 {
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFunction4GeneCode.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.PrjId); //工程Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ReturnTypeId))
 {
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conFunction4GeneCode.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncTypeId))
 {
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conFunction4GeneCode.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncTypeId); //函数类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4GeneCodeEN.IsTemplate == true?"1":"0", conFunction4GeneCode.IsTemplate); //是否模板
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FunctionSignature))
 {
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conFunction4GeneCode.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FunctionSignature); //函数签名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCode))
 {
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCode, conFunction4GeneCode.FuncCode); //函数代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncCode); //函数代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UserId))
 {
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conFunction4GeneCode.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UserId); //用户Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4GeneCodeEN.OrderNum, conFunction4GeneCode.OrderNum); //序号
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4GeneCodeEN.InUse == true?"1":"0", conFunction4GeneCode.InUse); //是否在用
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrimaryTypeIds))
 {
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeIds, conFunction4GeneCode.PrimaryTypeIds); //主键类型s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.PrimaryTypeIds); //主键类型s
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.CodeText))
 {
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeText, conFunction4GeneCode.CodeText); //代码文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.CodeText); //代码文本
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UsedTimes))
 {
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4GeneCodeEN.UsedTimes, conFunction4GeneCode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UsedTimes); //使用次数
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdDate))
 {
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunction4GeneCode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UpdDate); //修改日期
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdUser))
 {
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunction4GeneCode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UpdUser); //修改者
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.Memo))
 {
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunction4GeneCode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.Memo); //说明
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWords))
 {
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParsedWords, conFunction4GeneCode.ParsedWords); //分析的词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ParsedWords); //分析的词
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded))
 {
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParsedWordsExcluded, conFunction4GeneCode.ParsedWordsExcluded); //剔除后的词组
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ParsedWordsExcluded); //剔除后的词组
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.WordVector))
 {
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordVector, conFunction4GeneCode.WordVector); //词向量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.WordVector); //词向量
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsFuncTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4GeneCodeEN.IsFuncTemplate == true?"1":"0", conFunction4GeneCode.IsFuncTemplate); //是否函数模板
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncId4GC = '{0}'", objFunction4GeneCodeEN.FuncId4GC); 
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
 /// <param name = "objFunction4GeneCodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithCondition(clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strCondition)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4GeneCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Function4GeneCode Set ");
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName))
 {
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncId4Code))
 {
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId4Code = '{0}',", strFuncId4Code); //函数Id4Code
 }
 else
 {
 sbSQL.Append(" FuncId4Code = null,"); //函数Id4Code
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName4GC))
 {
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName4GC = '{0}',", strFuncName4GC); //函数名4生成代码
 }
 else
 {
 sbSQL.Append(" FuncName4GC = null,"); //函数名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCHName4GC))
 {
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCHName4GC = '{0}',", strFuncCHName4GC); //函数中文名4生成代码
 }
 else
 {
 sbSQL.Append(" FuncCHName4GC = null,"); //函数中文名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FeatureId))
 {
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ProgLangTypeId))
 {
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCodeTypeId))
 {
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCodeTypeId = '{0}',", strFuncCodeTypeId); //函数代码类型Id
 }
 else
 {
 sbSQL.Append(" FuncCodeTypeId = null,"); //函数代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.SqlDsTypeId))
 {
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", strSqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncGCTypeId))
 {
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncGCTypeId = '{0}',", strFuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.Append(" FuncGCTypeId = null,"); //函数生成代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrjId))
 {
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ReturnTypeId))
 {
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncTypeId))
 {
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFunction4GeneCodeEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FunctionSignature))
 {
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCode))
 {
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCode = '{0}',", strFuncCode); //函数代码
 }
 else
 {
 sbSQL.Append(" FuncCode = null,"); //函数代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UserId))
 {
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objFunction4GeneCodeEN.OrderNum); //序号
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFunction4GeneCodeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrimaryTypeIds))
 {
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeIds = '{0}',", strPrimaryTypeIds); //主键类型s
 }
 else
 {
 sbSQL.Append(" PrimaryTypeIds = null,"); //主键类型s
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.CodeText))
 {
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeText = '{0}',", strCodeText); //代码文本
 }
 else
 {
 sbSQL.Append(" CodeText = null,"); //代码文本
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UsedTimes))
 {
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4GeneCodeEN.UsedTimes, conFunction4GeneCode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UsedTimes); //使用次数
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdDate))
 {
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdUser))
 {
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.Memo))
 {
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWords))
 {
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParsedWords = '{0}',", strParsedWords); //分析的词
 }
 else
 {
 sbSQL.Append(" ParsedWords = null,"); //分析的词
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded))
 {
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParsedWordsExcluded = '{0}',", strParsedWordsExcluded); //剔除后的词组
 }
 else
 {
 sbSQL.Append(" ParsedWordsExcluded = null,"); //剔除后的词组
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.WordVector))
 {
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordVector = '{0}',", strWordVector); //词向量
 }
 else
 {
 sbSQL.Append(" WordVector = null,"); //词向量
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsFuncTemplate))
 {
 sbSQL.AppendFormat(" IsFuncTemplate = '{0}',", objFunction4GeneCodeEN.IsFuncTemplate == true?"1":"0"); //是否函数模板
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
 /// <param name = "objFunction4GeneCodeEN">需要修改的对象</param>
 /// <param name = "strCondition">修改记录时的条件</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySqlWithConditionTransaction(clsFunction4GeneCodeEN objFunction4GeneCodeEN, string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4GeneCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Function4GeneCode Set ");
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName))
 {
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName = '{0}',", strFuncName); //函数名
 }
 else
 {
 sbSQL.Append(" FuncName = null,"); //函数名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncId4Code))
 {
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncId4Code = '{0}',", strFuncId4Code); //函数Id4Code
 }
 else
 {
 sbSQL.Append(" FuncId4Code = null,"); //函数Id4Code
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName4GC))
 {
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncName4GC = '{0}',", strFuncName4GC); //函数名4生成代码
 }
 else
 {
 sbSQL.Append(" FuncName4GC = null,"); //函数名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCHName4GC))
 {
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCHName4GC = '{0}',", strFuncCHName4GC); //函数中文名4生成代码
 }
 else
 {
 sbSQL.Append(" FuncCHName4GC = null,"); //函数中文名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FeatureId))
 {
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FeatureId = '{0}',", strFeatureId); //功能Id
 }
 else
 {
 sbSQL.Append(" FeatureId = null,"); //功能Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ProgLangTypeId))
 {
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ProgLangTypeId = '{0}',", strProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.Append(" ProgLangTypeId = null,"); //编程语言类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCodeTypeId))
 {
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCodeTypeId = '{0}',", strFuncCodeTypeId); //函数代码类型Id
 }
 else
 {
 sbSQL.Append(" FuncCodeTypeId = null,"); //函数代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.SqlDsTypeId))
 {
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" SqlDsTypeId = '{0}',", strSqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.Append(" SqlDsTypeId = null,"); //数据源类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncGCTypeId))
 {
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncGCTypeId = '{0}',", strFuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.Append(" FuncGCTypeId = null,"); //函数生成代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrjId))
 {
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrjId = '{0}',", strPrjId); //工程Id
 }
 else
 {
 sbSQL.Append(" PrjId = null,"); //工程Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ReturnTypeId))
 {
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ReturnTypeId = '{0}',", strReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.Append(" ReturnTypeId = null,"); //返回类型ID
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncTypeId))
 {
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncTypeId = '{0}',", strFuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.Append(" FuncTypeId = null,"); //函数类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsTemplate))
 {
 sbSQL.AppendFormat(" IsTemplate = '{0}',", objFunction4GeneCodeEN.IsTemplate == true?"1":"0"); //是否模板
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FunctionSignature))
 {
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FunctionSignature = '{0}',", strFunctionSignature); //函数签名
 }
 else
 {
 sbSQL.Append(" FunctionSignature = null,"); //函数签名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCode))
 {
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" FuncCode = '{0}',", strFuncCode); //函数代码
 }
 else
 {
 sbSQL.Append(" FuncCode = null,"); //函数代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UserId))
 {
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UserId = '{0}',", strUserId); //用户Id
 }
 else
 {
 sbSQL.Append(" UserId = null,"); //用户Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.OrderNum))
 {
 sbSQL.AppendFormat(" OrderNum = {0},", objFunction4GeneCodeEN.OrderNum); //序号
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.InUse))
 {
 sbSQL.AppendFormat(" InUse = '{0}',", objFunction4GeneCodeEN.InUse == true?"1":"0"); //是否在用
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrimaryTypeIds))
 {
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" PrimaryTypeIds = '{0}',", strPrimaryTypeIds); //主键类型s
 }
 else
 {
 sbSQL.Append(" PrimaryTypeIds = null,"); //主键类型s
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.CodeText))
 {
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" CodeText = '{0}',", strCodeText); //代码文本
 }
 else
 {
 sbSQL.Append(" CodeText = null,"); //代码文本
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UsedTimes))
 {
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4GeneCodeEN.UsedTimes, conFunction4GeneCode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UsedTimes); //使用次数
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdDate))
 {
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdDate = '{0}',", strUpdDate); //修改日期
 }
 else
 {
 sbSQL.Append(" UpdDate = null,"); //修改日期
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdUser))
 {
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" UpdUser = '{0}',", strUpdUser); //修改者
 }
 else
 {
 sbSQL.Append(" UpdUser = null,"); //修改者
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.Memo))
 {
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" Memo = '{0}',", strMemo); //说明
 }
 else
 {
 sbSQL.Append(" Memo = null,"); //说明
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWords))
 {
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParsedWords = '{0}',", strParsedWords); //分析的词
 }
 else
 {
 sbSQL.Append(" ParsedWords = null,"); //分析的词
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded))
 {
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" ParsedWordsExcluded = '{0}',", strParsedWordsExcluded); //剔除后的词组
 }
 else
 {
 sbSQL.Append(" ParsedWordsExcluded = null,"); //剔除后的词组
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.WordVector))
 {
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat(" WordVector = '{0}',", strWordVector); //词向量
 }
 else
 {
 sbSQL.Append(" WordVector = null,"); //词向量
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsFuncTemplate))
 {
 sbSQL.AppendFormat(" IsFuncTemplate = '{0}',", objFunction4GeneCodeEN.IsFuncTemplate == true?"1":"0"); //是否函数模板
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
 /// <param name = "objFunction4GeneCodeEN">需要添加的实体对象</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>如果修改成功则返回TRUE,否则为FALSE</returns>
public bool UpdateBySql2(clsFunction4GeneCodeEN objFunction4GeneCodeEN, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
 objFunction4GeneCodeEN.UpdDate = clsDateTime.getTodayDateTimeStr(1);
 if (objFunction4GeneCodeEN._IsCheckProperty  ==  false)
 {
 CheckProperty4Update(objFunction4GeneCodeEN);
 }
StringBuilder sbSQL = new StringBuilder();
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
sbSQL.AppendFormat("Update Function4GeneCode Set ");
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName))
 {
 if (objFunction4GeneCodeEN.FuncName !=  null)
 {
 var strFuncName = objFunction4GeneCodeEN.FuncName.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName, conFunction4GeneCode.FuncName); //函数名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncName); //函数名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncId4Code))
 {
 if (objFunction4GeneCodeEN.FuncId4Code !=  null)
 {
 var strFuncId4Code = objFunction4GeneCodeEN.FuncId4Code.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncId4Code, conFunction4GeneCode.FuncId4Code); //函数Id4Code
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncId4Code); //函数Id4Code
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncName4GC))
 {
 if (objFunction4GeneCodeEN.FuncName4GC !=  null)
 {
 var strFuncName4GC = objFunction4GeneCodeEN.FuncName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncName4GC, conFunction4GeneCode.FuncName4GC); //函数名4生成代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncName4GC); //函数名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCHName4GC))
 {
 if (objFunction4GeneCodeEN.FuncCHName4GC !=  null)
 {
 var strFuncCHName4GC = objFunction4GeneCodeEN.FuncCHName4GC.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCHName4GC, conFunction4GeneCode.FuncCHName4GC); //函数中文名4生成代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncCHName4GC); //函数中文名4生成代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FeatureId))
 {
 if (objFunction4GeneCodeEN.FeatureId !=  null)
 {
 var strFeatureId = objFunction4GeneCodeEN.FeatureId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFeatureId, conFunction4GeneCode.FeatureId); //功能Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FeatureId); //功能Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ProgLangTypeId))
 {
 if (objFunction4GeneCodeEN.ProgLangTypeId !=  null)
 {
 var strProgLangTypeId = objFunction4GeneCodeEN.ProgLangTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strProgLangTypeId, conFunction4GeneCode.ProgLangTypeId); //编程语言类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ProgLangTypeId); //编程语言类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCodeTypeId))
 {
 if (objFunction4GeneCodeEN.FuncCodeTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncCodeTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncCodeTypeId !=  null)
 {
 var strFuncCodeTypeId = objFunction4GeneCodeEN.FuncCodeTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCodeTypeId, conFunction4GeneCode.FuncCodeTypeId); //函数代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncCodeTypeId); //函数代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.SqlDsTypeId))
 {
 if (objFunction4GeneCodeEN.SqlDsTypeId !=  null)
 {
 var strSqlDsTypeId = objFunction4GeneCodeEN.SqlDsTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strSqlDsTypeId, conFunction4GeneCode.SqlDsTypeId); //数据源类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.SqlDsTypeId); //数据源类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncGCTypeId))
 {
 if (objFunction4GeneCodeEN.FuncGCTypeId !=  null)
 {
 var strFuncGCTypeId = objFunction4GeneCodeEN.FuncGCTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncGCTypeId, conFunction4GeneCode.FuncGCTypeId); //函数生成代码类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncGCTypeId); //函数生成代码类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrjId))
 {
 if (objFunction4GeneCodeEN.PrjId  ==  "")
 {
 objFunction4GeneCodeEN.PrjId = null;
 }
 if (objFunction4GeneCodeEN.PrjId !=  null)
 {
 var strPrjId = objFunction4GeneCodeEN.PrjId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrjId, conFunction4GeneCode.PrjId); //工程Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.PrjId); //工程Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ReturnTypeId))
 {
 if (objFunction4GeneCodeEN.ReturnTypeId  ==  "")
 {
 objFunction4GeneCodeEN.ReturnTypeId = null;
 }
 if (objFunction4GeneCodeEN.ReturnTypeId !=  null)
 {
 var strReturnTypeId = objFunction4GeneCodeEN.ReturnTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strReturnTypeId, conFunction4GeneCode.ReturnTypeId); //返回类型ID
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ReturnTypeId); //返回类型ID
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncTypeId))
 {
 if (objFunction4GeneCodeEN.FuncTypeId  ==  "")
 {
 objFunction4GeneCodeEN.FuncTypeId = null;
 }
 if (objFunction4GeneCodeEN.FuncTypeId !=  null)
 {
 var strFuncTypeId = objFunction4GeneCodeEN.FuncTypeId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncTypeId, conFunction4GeneCode.FuncTypeId); //函数类型Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncTypeId); //函数类型Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4GeneCodeEN.IsTemplate == true?"1":"0", conFunction4GeneCode.IsTemplate); //是否模板
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FunctionSignature))
 {
 if (objFunction4GeneCodeEN.FunctionSignature !=  null)
 {
 var strFunctionSignature = objFunction4GeneCodeEN.FunctionSignature.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFunctionSignature, conFunction4GeneCode.FunctionSignature); //函数签名
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FunctionSignature); //函数签名
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.FuncCode))
 {
 if (objFunction4GeneCodeEN.FuncCode !=  null)
 {
 var strFuncCode = objFunction4GeneCodeEN.FuncCode.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strFuncCode, conFunction4GeneCode.FuncCode); //函数代码
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.FuncCode); //函数代码
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UserId))
 {
 if (objFunction4GeneCodeEN.UserId !=  null)
 {
 var strUserId = objFunction4GeneCodeEN.UserId.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUserId, conFunction4GeneCode.UserId); //用户Id
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UserId); //用户Id
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.OrderNum))
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4GeneCodeEN.OrderNum, conFunction4GeneCode.OrderNum); //序号
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.InUse))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4GeneCodeEN.InUse == true?"1":"0", conFunction4GeneCode.InUse); //是否在用
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.PrimaryTypeIds))
 {
 if (objFunction4GeneCodeEN.PrimaryTypeIds !=  null)
 {
 var strPrimaryTypeIds = objFunction4GeneCodeEN.PrimaryTypeIds.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strPrimaryTypeIds, conFunction4GeneCode.PrimaryTypeIds); //主键类型s
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.PrimaryTypeIds); //主键类型s
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.CodeText))
 {
 if (objFunction4GeneCodeEN.CodeText !=  null)
 {
 var strCodeText = objFunction4GeneCodeEN.CodeText.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strCodeText, conFunction4GeneCode.CodeText); //代码文本
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.CodeText); //代码文本
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UsedTimes))
 {
 if (objFunction4GeneCodeEN.UsedTimes !=  null)
 {
 sbSQL.AppendFormat("{1} = {0},",objFunction4GeneCodeEN.UsedTimes, conFunction4GeneCode.UsedTimes); //使用次数
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UsedTimes); //使用次数
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdDate))
 {
 if (objFunction4GeneCodeEN.UpdDate !=  null)
 {
 var strUpdDate = objFunction4GeneCodeEN.UpdDate.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdDate, conFunction4GeneCode.UpdDate); //修改日期
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UpdDate); //修改日期
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.UpdUser))
 {
 if (objFunction4GeneCodeEN.UpdUser !=  null)
 {
 var strUpdUser = objFunction4GeneCodeEN.UpdUser.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strUpdUser, conFunction4GeneCode.UpdUser); //修改者
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.UpdUser); //修改者
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.Memo))
 {
 if (objFunction4GeneCodeEN.Memo !=  null)
 {
 var strMemo = objFunction4GeneCodeEN.Memo.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strMemo, conFunction4GeneCode.Memo); //说明
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.Memo); //说明
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWords))
 {
 if (objFunction4GeneCodeEN.ParsedWords !=  null)
 {
 var strParsedWords = objFunction4GeneCodeEN.ParsedWords.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParsedWords, conFunction4GeneCode.ParsedWords); //分析的词
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ParsedWords); //分析的词
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.ParsedWordsExcluded))
 {
 if (objFunction4GeneCodeEN.ParsedWordsExcluded !=  null)
 {
 var strParsedWordsExcluded = objFunction4GeneCodeEN.ParsedWordsExcluded.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strParsedWordsExcluded, conFunction4GeneCode.ParsedWordsExcluded); //剔除后的词组
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.ParsedWordsExcluded); //剔除后的词组
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.WordVector))
 {
 if (objFunction4GeneCodeEN.WordVector !=  null)
 {
 var strWordVector = objFunction4GeneCodeEN.WordVector.Replace("'", "''"); //转换值串中的单撇"'",使之成为双撇"''"
 sbSQL.AppendFormat("{1} = '{0}',", strWordVector, conFunction4GeneCode.WordVector); //词向量
 }
 else
 {
 sbSQL.AppendFormat("{0} = null,",conFunction4GeneCode.WordVector); //词向量
 }
 }
 
 if (objFunction4GeneCodeEN.IsUpdated(conFunction4GeneCode.IsFuncTemplate))
 {
 sbSQL.AppendFormat(" {1} = '{0}',", objFunction4GeneCodeEN.IsFuncTemplate == true?"1":"0", conFunction4GeneCode.IsFuncTemplate); //是否函数模板
 }
 sbSQL.Remove(sbSQL.Length - 1, 1);
 sbSQL.AppendFormat(" Where FuncId4GC = '{0}'", objFunction4GeneCodeEN.FuncId4GC); 
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
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>如果删除成功则返回TRUE,否则为FALSE</returns>
public bool DelRecordBySP(string strFuncId4GC) 
{
CheckPrimaryKey(strFuncId4GC);
//通过存储过程来
//直接使用
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
objSQL.SPConfigXMLFile = clsSysParaEN.strXmlSpParaFileName;
//			 gobjSQL.SPConfigXMLFile = "..\\Parameter.xml"
ArrayList values = new ArrayList()
{
 strFuncId4GC,
};
 objSQL.ExecSP("Function4GeneCode_Delete", values);
return true;
}

 /// <summary>
 /// 功能:删除关键字所指的记录,使用事务
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelRecordWithTransaction)
 /// </summary>
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <param name = "objSqlConnection">Sql连接对象</param>
 /// <param name = "objSqlTransaction">Sql事务对象</param>
 /// <returns>返回删除是否成功?。</returns>
public bool DelRecord(string strFuncId4GC, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction) 
{
CheckPrimaryKey(strFuncId4GC);
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
//删除Function4GeneCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Function4GeneCode where FuncId4GC = " + "'"+ strFuncId4GC+"'";
return objSQL.ExecSql(strSQL, objSqlConnection, objSqlTransaction);
}


 /// <summary>
 /// 功能:同时删除多条记录,删除给定关键字列表的记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelMultiRec)
 /// </summary>
 /// <param name = "lstKey">给定的关键字值列表</param>
 /// <returns>返回删除是否成功?</returns>
public int DelFunction4GeneCode(List<string> lstKey)
{
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
string strSQL;
string strKeyList;
if (lstKey.Count  == 0) return 0;
strKeyList = "";
for (int i = 0; i<lstKey.Count; i++)
{
if (i == 0) strKeyList = strKeyList + "'" + lstKey[i].ToString() + "'";
else strKeyList +=  "," + "'" + lstKey[i].ToString() + "'";
}
strSQL = "";
//删除Function4GeneCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Function4GeneCode where FuncId4GC in (" + strKeyList + ")";
return objSQL.ExecSql2(strSQL);
}

 /// <summary>
 /// 功能:删除关键字所指定的记录
 /// (AutoGCLib.DALCode4CSharp:GenDelRecord)
 /// </summary>
 /// <param name = "strFuncId4GC">给定的关键字值</param>
 /// <returns>返回删除的记录数</returns>
public int DelRecord(string strFuncId4GC) 
{
CheckPrimaryKey(strFuncId4GC);
//删除单条记录
string strSQL = "";
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
//删除Function4GeneCode本表中与当前对象有关的记录
strSQL = strSQL + "Delete from Function4GeneCode where FuncId4GC = " + "'"+ strFuncId4GC+"'";
 return objSQL.ExecSql2(strSQL);
}


 /// <summary>
 /// 功能:删除满足条件的多条记录
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenDelCondRec)
 /// </summary>
 /// <param name = "strCondition">需要删除的记录条件</param>
 /// <returns>返回删除的记录数。</returns>
public int DelFunction4GeneCode(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000042)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: DelFunction4GeneCode)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return 0;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Function4GeneCode where " + strCondition ;
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
public bool DelFunction4GeneCodeWithTransaction_S(string strCondition, SqlConnection objSqlConnection, SqlTransaction objSqlTransaction)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000043)在输入条件中含有{0},请检查!(clsFunction4GeneCodeDA: DelFunction4GeneCodeWithTransaction_S)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
string strSQL;
if (strCondition  ==  "")
{
return false;	//表示删除0条记录,实际上是不能该表的所有记录
}
else
{
strSQL = "Delete from Function4GeneCode where " + strCondition ;
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
 /// <param name = "objFunction4GeneCodeENS">源对象</param>
 /// <param name = "objFunction4GeneCodeENT">目标对象</param>
public void CopyTo(clsFunction4GeneCodeEN objFunction4GeneCodeENS, clsFunction4GeneCodeEN objFunction4GeneCodeENT)
{
objFunction4GeneCodeENT.FuncId4GC = objFunction4GeneCodeENS.FuncId4GC; //函数ID
objFunction4GeneCodeENT.FuncName = objFunction4GeneCodeENS.FuncName; //函数名
objFunction4GeneCodeENT.FuncId4Code = objFunction4GeneCodeENS.FuncId4Code; //函数Id4Code
objFunction4GeneCodeENT.FuncName4GC = objFunction4GeneCodeENS.FuncName4GC; //函数名4生成代码
objFunction4GeneCodeENT.FuncCHName4GC = objFunction4GeneCodeENS.FuncCHName4GC; //函数中文名4生成代码
objFunction4GeneCodeENT.FeatureId = objFunction4GeneCodeENS.FeatureId; //功能Id
objFunction4GeneCodeENT.ProgLangTypeId = objFunction4GeneCodeENS.ProgLangTypeId; //编程语言类型Id
objFunction4GeneCodeENT.FuncCodeTypeId = objFunction4GeneCodeENS.FuncCodeTypeId; //函数代码类型Id
objFunction4GeneCodeENT.SqlDsTypeId = objFunction4GeneCodeENS.SqlDsTypeId; //数据源类型Id
objFunction4GeneCodeENT.FuncGCTypeId = objFunction4GeneCodeENS.FuncGCTypeId; //函数生成代码类型Id
objFunction4GeneCodeENT.PrjId = objFunction4GeneCodeENS.PrjId; //工程Id
objFunction4GeneCodeENT.ReturnTypeId = objFunction4GeneCodeENS.ReturnTypeId; //返回类型ID
objFunction4GeneCodeENT.FuncTypeId = objFunction4GeneCodeENS.FuncTypeId; //函数类型Id
objFunction4GeneCodeENT.IsTemplate = objFunction4GeneCodeENS.IsTemplate; //是否模板
objFunction4GeneCodeENT.FunctionSignature = objFunction4GeneCodeENS.FunctionSignature; //函数签名
objFunction4GeneCodeENT.FuncCode = objFunction4GeneCodeENS.FuncCode; //函数代码
objFunction4GeneCodeENT.UserId = objFunction4GeneCodeENS.UserId; //用户Id
objFunction4GeneCodeENT.OrderNum = objFunction4GeneCodeENS.OrderNum; //序号
objFunction4GeneCodeENT.InUse = objFunction4GeneCodeENS.InUse; //是否在用
objFunction4GeneCodeENT.PrimaryTypeIds = objFunction4GeneCodeENS.PrimaryTypeIds; //主键类型s
objFunction4GeneCodeENT.CodeText = objFunction4GeneCodeENS.CodeText; //代码文本
objFunction4GeneCodeENT.UsedTimes = objFunction4GeneCodeENS.UsedTimes; //使用次数
objFunction4GeneCodeENT.UpdDate = objFunction4GeneCodeENS.UpdDate; //修改日期
objFunction4GeneCodeENT.UpdUser = objFunction4GeneCodeENS.UpdUser; //修改者
objFunction4GeneCodeENT.Memo = objFunction4GeneCodeENS.Memo; //说明
objFunction4GeneCodeENT.ParsedWords = objFunction4GeneCodeENS.ParsedWords; //分析的词
objFunction4GeneCodeENT.ParsedWordsExcluded = objFunction4GeneCodeENS.ParsedWordsExcluded; //剔除后的词组
objFunction4GeneCodeENT.WordVector = objFunction4GeneCodeENS.WordVector; //词向量
objFunction4GeneCodeENT.IsFuncTemplate = objFunction4GeneCodeENS.IsFuncTemplate; //是否函数模板
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckPropertyNew(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检查字段不能为空(NULL)
clsCheckSql.CheckFieldNotNull(objFunction4GeneCodeEN.FuncName, conFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldNotNull(objFunction4GeneCodeEN.ProgLangTypeId, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldNotNull(objFunction4GeneCodeEN.SqlDsTypeId, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldNotNull(objFunction4GeneCodeEN.FuncGCTypeId, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldNotNull(objFunction4GeneCodeEN.OrderNum, conFunction4GeneCode.OrderNum);
//检查字段长度
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncId4GC, 10, conFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncName, 100, conFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncName4GC, 50, conFunction4GeneCode.FuncName4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncCHName4GC, 50, conFunction4GeneCode.FuncCHName4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FeatureId, 4, conFunction4GeneCode.FeatureId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.SqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.PrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FunctionSignature, 500, conFunction4GeneCode.FunctionSignature);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UserId, 18, conFunction4GeneCode.UserId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.PrimaryTypeIds, 50, conFunction4GeneCode.PrimaryTypeIds);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.CodeText, 8000, conFunction4GeneCode.CodeText);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UpdDate, 20, conFunction4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UpdUser, 20, conFunction4GeneCode.UpdUser);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.Memo, 1000, conFunction4GeneCode.Memo);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ParsedWords, 500, conFunction4GeneCode.ParsedWords);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ParsedWordsExcluded, 500, conFunction4GeneCode.ParsedWordsExcluded);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.WordVector, 500, conFunction4GeneCode.WordVector);
//检查字段外键固定长度
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.FuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.PrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.ReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.FuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
 objFunction4GeneCodeEN._IsCheckProperty = true;
}
 /// <summary>
 /// 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPropertyNew)
 /// </summary>
public void CheckProperty4Update(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncName, 100, conFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncName4GC, 50, conFunction4GeneCode.FuncName4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncCHName4GC, 50, conFunction4GeneCode.FuncCHName4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FeatureId, 4, conFunction4GeneCode.FeatureId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.SqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.PrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FunctionSignature, 500, conFunction4GeneCode.FunctionSignature);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UserId, 18, conFunction4GeneCode.UserId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.PrimaryTypeIds, 50, conFunction4GeneCode.PrimaryTypeIds);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.CodeText, 8000, conFunction4GeneCode.CodeText);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UpdDate, 20, conFunction4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UpdUser, 20, conFunction4GeneCode.UpdUser);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.Memo, 1000, conFunction4GeneCode.Memo);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ParsedWords, 500, conFunction4GeneCode.ParsedWords);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ParsedWordsExcluded, 500, conFunction4GeneCode.ParsedWordsExcluded);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.WordVector, 500, conFunction4GeneCode.WordVector);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.FuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.PrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.ReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.FuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
 objFunction4GeneCodeEN._IsCheckProperty = true;
}

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncId4GC, 10, conFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncName, 100, conFunction4GeneCode.FuncName);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncId4Code, 8, conFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncName4GC, 50, conFunction4GeneCode.FuncName4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncCHName4GC, 50, conFunction4GeneCode.FuncCHName4GC);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FeatureId, 4, conFunction4GeneCode.FeatureId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ProgLangTypeId, 2, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.SqlDsTypeId, 2, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncGCTypeId, 2, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.PrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.FunctionSignature, 500, conFunction4GeneCode.FunctionSignature);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UserId, 18, conFunction4GeneCode.UserId);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.PrimaryTypeIds, 50, conFunction4GeneCode.PrimaryTypeIds);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.CodeText, 8000, conFunction4GeneCode.CodeText);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UpdDate, 20, conFunction4GeneCode.UpdDate);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.UpdUser, 20, conFunction4GeneCode.UpdUser);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.Memo, 1000, conFunction4GeneCode.Memo);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ParsedWords, 500, conFunction4GeneCode.ParsedWords);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.ParsedWordsExcluded, 500, conFunction4GeneCode.ParsedWordsExcluded);
clsCheckSql.CheckFieldLen(objFunction4GeneCodeEN.WordVector, 500, conFunction4GeneCode.WordVector);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncId4GC, conFunction4GeneCode.FuncId4GC);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncName, conFunction4GeneCode.FuncName);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncId4Code, conFunction4GeneCode.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncName4GC, conFunction4GeneCode.FuncName4GC);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncCHName4GC, conFunction4GeneCode.FuncCHName4GC);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FeatureId, conFunction4GeneCode.FeatureId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.ProgLangTypeId, conFunction4GeneCode.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncCodeTypeId, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.SqlDsTypeId, conFunction4GeneCode.SqlDsTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncGCTypeId, conFunction4GeneCode.FuncGCTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.PrjId, conFunction4GeneCode.PrjId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.ReturnTypeId, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FuncTypeId, conFunction4GeneCode.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.FunctionSignature, conFunction4GeneCode.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.UserId, conFunction4GeneCode.UserId);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.PrimaryTypeIds, conFunction4GeneCode.PrimaryTypeIds);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.CodeText, conFunction4GeneCode.CodeText);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.UpdDate, conFunction4GeneCode.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.UpdUser, conFunction4GeneCode.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.Memo, conFunction4GeneCode.Memo);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.ParsedWords, conFunction4GeneCode.ParsedWords);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.ParsedWordsExcluded, conFunction4GeneCode.ParsedWordsExcluded);
clsCheckSql.CheckSqlInjection4Field(objFunction4GeneCodeEN.WordVector, conFunction4GeneCode.WordVector);
//检查外键字段长度
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.FuncCodeTypeId, 4, conFunction4GeneCode.FuncCodeTypeId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.PrjId, 4, conFunction4GeneCode.PrjId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.ReturnTypeId, 2, conFunction4GeneCode.ReturnTypeId);
clsCheckSql.CheckFieldForeignKey(objFunction4GeneCodeEN.FuncTypeId, 2, conFunction4GeneCode.FuncTypeId);
 objFunction4GeneCodeEN._IsCheckProperty = true;
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
string strSQL = "select FuncId4GC, FuncName from Function4GeneCode ";
 clsSpecSQLforSql mySql = clsFunction4GeneCodeDA.GetSpecSQLObj();
System.Data.DataTable objDT = mySql.GetDataTable(strSQL);
return objDT;
}

 #endregion 绑定下拉框

 #region 检查唯一性

 /// <summary>
 /// 获取唯一性条件串(Uniqueness)--Function4GeneCode(函数4GeneCode),根据唯一约束条件来生成
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetUniquenessConditionString)
 /// </summary>
 /// <param name = "objFunction4GeneCodeEN">表对象</param>
 /// <returns>返回唯一性条件串</returns>
public string GetUniCondStr(clsFunction4GeneCodeEN objFunction4GeneCodeEN)
{
StringBuilder sbCondition = new StringBuilder();
sbCondition.AppendFormat("1 = 1");
 sbCondition.AppendFormat(" and FuncName = '{0}'", objFunction4GeneCodeEN.FuncName);
 if (objFunction4GeneCodeEN.FuncCodeTypeId == null)
{
 sbCondition.AppendFormat(" and FuncCodeTypeId is null");
}
else
{
 sbCondition.AppendFormat(" and FuncCodeTypeId = '{0}'", objFunction4GeneCodeEN.FuncCodeTypeId);
}
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunction4GeneCodeEN._CurrTabName);
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsFunction4GeneCodeEN._CurrTabName, strCondition);
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
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
 objSQL = clsFunction4GeneCodeDA.GetSpecSQLObj();
int intRecCount = objSQL.SetFldDataOfTable(strTabName, strFldName, varValue, strCondition);
return intRecCount;
}

 #endregion 表操作常用函数
}
}