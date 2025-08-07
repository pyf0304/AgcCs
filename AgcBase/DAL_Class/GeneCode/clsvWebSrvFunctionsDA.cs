
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvWebSrvFunctionsDA
 表名:vWebSrvFunctions(00050343)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:44:34
 生成者:pyf
 生成服务器IP:
 工程名称:AGC(0005)
 CM工程:AgcSpa后端(000014, 变量首字母不限定)-WebApi函数集
 相关数据库:103.116.76.183,8433AGC_CS12
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
 /// vWebSrv函数(vWebSrvFunctions)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvWebSrvFunctionsDA : clsCommBase4DA
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
 return clsvWebSrvFunctionsEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvWebSrvFunctionsEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvWebSrvFunctionsEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvWebSrvFunctionsEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvWebSrvFunctionsEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strWebSrvFunctionId)
{
strWebSrvFunctionId = strWebSrvFunctionId.Replace("'", "''");
if (strWebSrvFunctionId.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vWebSrvFunctions中,检查关键字,长度不正确!(clsvWebSrvFunctionsDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strWebSrvFunctionId)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vWebSrvFunctions中,关键字不能为空 或 null!(clsvWebSrvFunctionsDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strWebSrvFunctionId);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvWebSrvFunctionsDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vWebSrvFunctions(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable_vWebSrvFunctions)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvFunctions.* " + 
$"from vWebSrvFunctions " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvFunctions.WebSrvFunctionId not in " + 
$"(Select top {intTop_In} vWebSrvFunctions.WebSrvFunctionId from vWebSrvFunctions " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {2} WebSrvFunctionId from vWebSrvFunctions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {3} WebSrvFunctionId from vWebSrvFunctions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vWebSrvFunctions.* " + 
$"from vWebSrvFunctions " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vWebSrvFunctions.WebSrvFunctionId not in " + 
$"(Select top {intTop_In} vWebSrvFunctions.WebSrvFunctionId from vWebSrvFunctions " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {2} WebSrvFunctionId from vWebSrvFunctions where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vWebSrvFunctions where {1} and WebSrvFunctionId not in (Select top {3} WebSrvFunctionId from vWebSrvFunctions where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvWebSrvFunctionsEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA:GetObjLst)", objException.Message));
}
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetObjLst)", objException.Message));
}
objvWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvFunctionsEN);
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
public List<clsvWebSrvFunctionsEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA:GetObjLstByTabName)", objException.Message));
}
List<clsvWebSrvFunctionsEN> arrObjLst = new List<clsvWebSrvFunctionsEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetObjLst)", objException.Message));
}
objvWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvWebSrvFunctionsEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvWebSrvFunctions(ref clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where WebSrvFunctionId = " + "'"+ objvWebSrvFunctionsEN.WebSrvFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvWebSrvFunctionsEN.WebSrvFunctionId = objDT.Rows[0][convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFunctionsEN.WebSrvClassId = objDT.Rows[0][convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFunctionsEN.NameSpace = objDT.Rows[0][convWebSrvFunctions.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWebSrvFunctionsEN.WebSrvUrl = objDT.Rows[0][convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvWebSrvFunctionsEN.FuncModuleAgcId = objDT.Rows[0][convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFunctionsEN.PrjId = objDT.Rows[0][convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvFunctionsEN.FunctionName = objDT.Rows[0][convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objDT.Rows[0][convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objvWebSrvFunctionsEN.FunctionSignature = objDT.Rows[0][convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvWebSrvFunctionsEN.FuncTypeId = objDT.Rows[0][convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvWebSrvFunctionsEN.FuncTypeName = objDT.Rows[0][convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvWebSrvFunctionsEN.ReturnType = objDT.Rows[0][convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objvWebSrvFunctionsEN.ReturnTypeFullName = objDT.Rows[0][convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.IsKnownType = TransNullToBool(objDT.Rows[0][convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFunctionsEN.ReturnTypeId = objDT.Rows[0][convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvWebSrvFunctionsEN.DataTypeName = objDT.Rows[0][convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFunctionsEN.DataTypeAbbr = objDT.Rows[0][convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvWebSrvFunctionsEN.NetSysType = objDT.Rows[0][convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型(字段类型:varchar,字段长度:20,是否可空:False)
 objvWebSrvFunctionsEN.CsType = objDT.Rows[0][convWebSrvFunctions.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFunctionsEN.JavaType = objDT.Rows[0][convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFunctionsEN.JavaObjType = objDT.Rows[0][convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFunctionsEN.SwiftType = objDT.Rows[0][convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFunctionsEN.IsNeedQuote = TransNullToBool(objDT.Rows[0][convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFunctionsEN.SourceFunction = objDT.Rows[0][convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objDT.Rows[0][convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFunctionsEN.ReturnValueDescription = objDT.Rows[0][convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.FuncParaLst = objDT.Rows[0][convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.UpdDate = objDT.Rows[0][convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFunctionsEN.UpdUser = objDT.Rows[0][convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFunctionsEN.Memo = objDT.Rows[0][convWebSrvFunctions.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvFunctionsEN.ClsName = objDT.Rows[0][convWebSrvFunctions.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetvWebSrvFunctions)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strWebSrvFunctionId">表关键字</param>
 /// <returns>表对象</returns>
public clsvWebSrvFunctionsEN GetObjByWebSrvFunctionId(string strWebSrvFunctionId)
{
CheckPrimaryKey(strWebSrvFunctionId);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where WebSrvFunctionId = " + "'"+ strWebSrvFunctionId+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
 objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名(字段类型:varchar,字段长度:50,是否可空:True)
 objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址(字段类型:varchar,字段长度:300,是否可空:False)
 objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id(字段类型:char,字段长度:8,是否可空:False)
 objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称(字段类型:varchar,字段长度:200,是否可空:True)
 objvWebSrvFunctionsEN.GetCustomAttributes = Int32.Parse(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes(字段类型:int,字段长度:4,是否可空:False)
 objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.IsKnownType = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写(字段类型:varchar,字段长度:5,是否可空:False)
 objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型(字段类型:varchar,字段长度:20,是否可空:False)
 objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型(字段类型:varchar,字段长度:100,是否可空:False)
 objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType(字段类型:varchar,字段长度:100,是否可空:True)
 objvWebSrvFunctionsEN.IsNeedQuote = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号(字段类型:bit,字段长度:1,是否可空:False)
 objvWebSrvFunctionsEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.IsGeneCode = clsEntityBase2.TransNullToBool_S(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码(字段类型:bit,字段长度:1,是否可空:True)
 objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表(字段类型:varchar,字段长度:500,是否可空:True)
 objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetObjByWebSrvFunctionId)", objException.Message));
}
return objvWebSrvFunctionsEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvWebSrvFunctionsEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
strSQL = "Select * from vWebSrvFunctions where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN()
{
WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(), //函数Id
WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(), //类Id
NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(), //域名
WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(), //WebSrv地址
FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(), //功能模块Id
PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(), //工程Id
FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(), //功能名称
GetCustomAttributes = TransNullToInt(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()), //GetCustomAttributes
FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(), //函数签名
FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(), //函数类型Id
FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(), //函数类型名
ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(), //返回类型
ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(), //返回类型全名
IsKnownType = TransNullToBool(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()), //是否已知类型
ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(), //返回类型ID
DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(), //数据类型名称
DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(), //数据类型缩写
NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(), //NET系统类型
CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(), //CS类型
JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(), //JAVA类型
JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(), //JAVA对象类型
SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(), //SwiftType
IsNeedQuote = TransNullToBool(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()), //是否需要引号
IsAsyncFunc = TransNullToBool(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()), //是否异步函数
SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(), //来源函数
IsGeneCode = TransNullToBool(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()), //是否生成代码
ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(), //返回值说明
FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(), //函数参数列表
UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(), //说明
ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim() //类名
};
objvWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvFunctionsEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvWebSrvFunctionsEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetObjByDataRowvWebSrvFunctions)", objException.Message));
}
objvWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvFunctionsEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvWebSrvFunctionsEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvWebSrvFunctionsEN objvWebSrvFunctionsEN = new clsvWebSrvFunctionsEN();
try
{
objvWebSrvFunctionsEN.WebSrvFunctionId = objRow[convWebSrvFunctions.WebSrvFunctionId].ToString().Trim(); //函数Id
objvWebSrvFunctionsEN.WebSrvClassId = objRow[convWebSrvFunctions.WebSrvClassId].ToString().Trim(); //类Id
objvWebSrvFunctionsEN.NameSpace = objRow[convWebSrvFunctions.NameSpace] == DBNull.Value ? null : objRow[convWebSrvFunctions.NameSpace].ToString().Trim(); //域名
objvWebSrvFunctionsEN.WebSrvUrl = objRow[convWebSrvFunctions.WebSrvUrl] == DBNull.Value ? null : objRow[convWebSrvFunctions.WebSrvUrl].ToString().Trim(); //WebSrv地址
objvWebSrvFunctionsEN.FuncModuleAgcId = objRow[convWebSrvFunctions.FuncModuleAgcId] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncModuleAgcId].ToString().Trim(); //功能模块Id
objvWebSrvFunctionsEN.PrjId = objRow[convWebSrvFunctions.PrjId] == DBNull.Value ? null : objRow[convWebSrvFunctions.PrjId].ToString().Trim(); //工程Id
objvWebSrvFunctionsEN.FunctionName = objRow[convWebSrvFunctions.FunctionName] == DBNull.Value ? null : objRow[convWebSrvFunctions.FunctionName].ToString().Trim(); //功能名称
objvWebSrvFunctionsEN.GetCustomAttributes = TransNullToInt(objRow[convWebSrvFunctions.GetCustomAttributes].ToString().Trim()); //GetCustomAttributes
objvWebSrvFunctionsEN.FunctionSignature = objRow[convWebSrvFunctions.FunctionSignature].ToString().Trim(); //函数签名
objvWebSrvFunctionsEN.FuncTypeId = objRow[convWebSrvFunctions.FuncTypeId].ToString().Trim(); //函数类型Id
objvWebSrvFunctionsEN.FuncTypeName = objRow[convWebSrvFunctions.FuncTypeName].ToString().Trim(); //函数类型名
objvWebSrvFunctionsEN.ReturnType = objRow[convWebSrvFunctions.ReturnType].ToString().Trim(); //返回类型
objvWebSrvFunctionsEN.ReturnTypeFullName = objRow[convWebSrvFunctions.ReturnTypeFullName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeFullName].ToString().Trim(); //返回类型全名
objvWebSrvFunctionsEN.IsKnownType = TransNullToBool(objRow[convWebSrvFunctions.IsKnownType].ToString().Trim()); //是否已知类型
objvWebSrvFunctionsEN.ReturnTypeId = objRow[convWebSrvFunctions.ReturnTypeId] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnTypeId].ToString().Trim(); //返回类型ID
objvWebSrvFunctionsEN.DataTypeName = objRow[convWebSrvFunctions.DataTypeName] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeName].ToString().Trim(); //数据类型名称
objvWebSrvFunctionsEN.DataTypeAbbr = objRow[convWebSrvFunctions.DataTypeAbbr] == DBNull.Value ? null : objRow[convWebSrvFunctions.DataTypeAbbr].ToString().Trim(); //数据类型缩写
objvWebSrvFunctionsEN.NetSysType = objRow[convWebSrvFunctions.NetSysType] == DBNull.Value ? null : objRow[convWebSrvFunctions.NetSysType].ToString().Trim(); //NET系统类型
objvWebSrvFunctionsEN.CsType = objRow[convWebSrvFunctions.CsType] == DBNull.Value ? null : objRow[convWebSrvFunctions.CsType].ToString().Trim(); //CS类型
objvWebSrvFunctionsEN.JavaType = objRow[convWebSrvFunctions.JavaType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaType].ToString().Trim(); //JAVA类型
objvWebSrvFunctionsEN.JavaObjType = objRow[convWebSrvFunctions.JavaObjType] == DBNull.Value ? null : objRow[convWebSrvFunctions.JavaObjType].ToString().Trim(); //JAVA对象类型
objvWebSrvFunctionsEN.SwiftType = objRow[convWebSrvFunctions.SwiftType] == DBNull.Value ? null : objRow[convWebSrvFunctions.SwiftType].ToString().Trim(); //SwiftType
objvWebSrvFunctionsEN.IsNeedQuote = TransNullToBool(objRow[convWebSrvFunctions.IsNeedQuote].ToString().Trim()); //是否需要引号
objvWebSrvFunctionsEN.IsAsyncFunc = TransNullToBool(objRow[convWebSrvFunctions.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvWebSrvFunctionsEN.SourceFunction = objRow[convWebSrvFunctions.SourceFunction] == DBNull.Value ? null : objRow[convWebSrvFunctions.SourceFunction].ToString().Trim(); //来源函数
objvWebSrvFunctionsEN.IsGeneCode = TransNullToBool(objRow[convWebSrvFunctions.IsGeneCode].ToString().Trim()); //是否生成代码
objvWebSrvFunctionsEN.ReturnValueDescription = objRow[convWebSrvFunctions.ReturnValueDescription] == DBNull.Value ? null : objRow[convWebSrvFunctions.ReturnValueDescription].ToString().Trim(); //返回值说明
objvWebSrvFunctionsEN.FuncParaLst = objRow[convWebSrvFunctions.FuncParaLst] == DBNull.Value ? null : objRow[convWebSrvFunctions.FuncParaLst].ToString().Trim(); //函数参数列表
objvWebSrvFunctionsEN.UpdDate = objRow[convWebSrvFunctions.UpdDate] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdDate].ToString().Trim(); //修改日期
objvWebSrvFunctionsEN.UpdUser = objRow[convWebSrvFunctions.UpdUser] == DBNull.Value ? null : objRow[convWebSrvFunctions.UpdUser].ToString().Trim(); //修改者
objvWebSrvFunctionsEN.Memo = objRow[convWebSrvFunctions.Memo] == DBNull.Value ? null : objRow[convWebSrvFunctions.Memo].ToString().Trim(); //说明
objvWebSrvFunctionsEN.ClsName = objRow[convWebSrvFunctions.ClsName] == DBNull.Value ? null : objRow[convWebSrvFunctions.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvWebSrvFunctionsDA: GetObjByDataRow)", objException.Message));
}
objvWebSrvFunctionsEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvWebSrvFunctionsEN;
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
objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvFunctionsEN._CurrTabName, convWebSrvFunctions.WebSrvFunctionId, 8, "");
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
objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvWebSrvFunctionsEN._CurrTabName, convWebSrvFunctions.WebSrvFunctionId, 8, strPrefix);
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select WebSrvFunctionId from vWebSrvFunctions where " + strCondition;
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select WebSrvFunctionId from vWebSrvFunctions where " + strCondition;
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
 /// <param name = "strWebSrvFunctionId">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strWebSrvFunctionId)
{
CheckPrimaryKey(strWebSrvFunctionId);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvFunctions", "WebSrvFunctionId = " + "'"+ strWebSrvFunctionId+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvWebSrvFunctionsDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vWebSrvFunctions", strCondition))
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
objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vWebSrvFunctions");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvWebSrvFunctionsENS">源对象</param>
 /// <param name = "objvWebSrvFunctionsENT">目标对象</param>
public void CopyTo(clsvWebSrvFunctionsEN objvWebSrvFunctionsENS, clsvWebSrvFunctionsEN objvWebSrvFunctionsENT)
{
objvWebSrvFunctionsENT.WebSrvFunctionId = objvWebSrvFunctionsENS.WebSrvFunctionId; //函数Id
objvWebSrvFunctionsENT.WebSrvClassId = objvWebSrvFunctionsENS.WebSrvClassId; //类Id
objvWebSrvFunctionsENT.NameSpace = objvWebSrvFunctionsENS.NameSpace; //域名
objvWebSrvFunctionsENT.WebSrvUrl = objvWebSrvFunctionsENS.WebSrvUrl; //WebSrv地址
objvWebSrvFunctionsENT.FuncModuleAgcId = objvWebSrvFunctionsENS.FuncModuleAgcId; //功能模块Id
objvWebSrvFunctionsENT.PrjId = objvWebSrvFunctionsENS.PrjId; //工程Id
objvWebSrvFunctionsENT.FunctionName = objvWebSrvFunctionsENS.FunctionName; //功能名称
objvWebSrvFunctionsENT.GetCustomAttributes = objvWebSrvFunctionsENS.GetCustomAttributes; //GetCustomAttributes
objvWebSrvFunctionsENT.FunctionSignature = objvWebSrvFunctionsENS.FunctionSignature; //函数签名
objvWebSrvFunctionsENT.FuncTypeId = objvWebSrvFunctionsENS.FuncTypeId; //函数类型Id
objvWebSrvFunctionsENT.FuncTypeName = objvWebSrvFunctionsENS.FuncTypeName; //函数类型名
objvWebSrvFunctionsENT.ReturnType = objvWebSrvFunctionsENS.ReturnType; //返回类型
objvWebSrvFunctionsENT.ReturnTypeFullName = objvWebSrvFunctionsENS.ReturnTypeFullName; //返回类型全名
objvWebSrvFunctionsENT.IsKnownType = objvWebSrvFunctionsENS.IsKnownType; //是否已知类型
objvWebSrvFunctionsENT.ReturnTypeId = objvWebSrvFunctionsENS.ReturnTypeId; //返回类型ID
objvWebSrvFunctionsENT.DataTypeName = objvWebSrvFunctionsENS.DataTypeName; //数据类型名称
objvWebSrvFunctionsENT.DataTypeAbbr = objvWebSrvFunctionsENS.DataTypeAbbr; //数据类型缩写
objvWebSrvFunctionsENT.NetSysType = objvWebSrvFunctionsENS.NetSysType; //NET系统类型
objvWebSrvFunctionsENT.CsType = objvWebSrvFunctionsENS.CsType; //CS类型
objvWebSrvFunctionsENT.JavaType = objvWebSrvFunctionsENS.JavaType; //JAVA类型
objvWebSrvFunctionsENT.JavaObjType = objvWebSrvFunctionsENS.JavaObjType; //JAVA对象类型
objvWebSrvFunctionsENT.SwiftType = objvWebSrvFunctionsENS.SwiftType; //SwiftType
objvWebSrvFunctionsENT.IsNeedQuote = objvWebSrvFunctionsENS.IsNeedQuote; //是否需要引号
objvWebSrvFunctionsENT.IsAsyncFunc = objvWebSrvFunctionsENS.IsAsyncFunc; //是否异步函数
objvWebSrvFunctionsENT.SourceFunction = objvWebSrvFunctionsENS.SourceFunction; //来源函数
objvWebSrvFunctionsENT.IsGeneCode = objvWebSrvFunctionsENS.IsGeneCode; //是否生成代码
objvWebSrvFunctionsENT.ReturnValueDescription = objvWebSrvFunctionsENS.ReturnValueDescription; //返回值说明
objvWebSrvFunctionsENT.FuncParaLst = objvWebSrvFunctionsENS.FuncParaLst; //函数参数列表
objvWebSrvFunctionsENT.UpdDate = objvWebSrvFunctionsENS.UpdDate; //修改日期
objvWebSrvFunctionsENT.UpdUser = objvWebSrvFunctionsENS.UpdUser; //修改者
objvWebSrvFunctionsENT.Memo = objvWebSrvFunctionsENS.Memo; //说明
objvWebSrvFunctionsENT.ClsName = objvWebSrvFunctionsENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvWebSrvFunctionsEN objvWebSrvFunctionsEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.WebSrvFunctionId, 8, convWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.WebSrvClassId, 8, convWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.NameSpace, 50, convWebSrvFunctions.NameSpace);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.WebSrvUrl, 300, convWebSrvFunctions.WebSrvUrl);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.FuncModuleAgcId, 8, convWebSrvFunctions.FuncModuleAgcId);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.PrjId, 4, convWebSrvFunctions.PrjId);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.FunctionName, 200, convWebSrvFunctions.FunctionName);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.FunctionSignature, 500, convWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.FuncTypeId, 2, convWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.FuncTypeName, 20, convWebSrvFunctions.FuncTypeName);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.ReturnType, 500, convWebSrvFunctions.ReturnType);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.ReturnTypeFullName, 500, convWebSrvFunctions.ReturnTypeFullName);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.ReturnTypeId, 2, convWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.DataTypeName, 100, convWebSrvFunctions.DataTypeName);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.DataTypeAbbr, 5, convWebSrvFunctions.DataTypeAbbr);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.NetSysType, 20, convWebSrvFunctions.NetSysType);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.CsType, 100, convWebSrvFunctions.CsType);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.JavaType, 100, convWebSrvFunctions.JavaType);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.JavaObjType, 100, convWebSrvFunctions.JavaObjType);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.SwiftType, 100, convWebSrvFunctions.SwiftType);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.SourceFunction, 500, convWebSrvFunctions.SourceFunction);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.ReturnValueDescription, 500, convWebSrvFunctions.ReturnValueDescription);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.FuncParaLst, 500, convWebSrvFunctions.FuncParaLst);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.UpdDate, 20, convWebSrvFunctions.UpdDate);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.UpdUser, 20, convWebSrvFunctions.UpdUser);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.Memo, 1000, convWebSrvFunctions.Memo);
clsCheckSql.CheckFieldLen(objvWebSrvFunctionsEN.ClsName, 100, convWebSrvFunctions.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.WebSrvFunctionId, convWebSrvFunctions.WebSrvFunctionId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.WebSrvClassId, convWebSrvFunctions.WebSrvClassId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.NameSpace, convWebSrvFunctions.NameSpace);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.WebSrvUrl, convWebSrvFunctions.WebSrvUrl);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.FuncModuleAgcId, convWebSrvFunctions.FuncModuleAgcId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.PrjId, convWebSrvFunctions.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.FunctionName, convWebSrvFunctions.FunctionName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.FunctionSignature, convWebSrvFunctions.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.FuncTypeId, convWebSrvFunctions.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.FuncTypeName, convWebSrvFunctions.FuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.ReturnType, convWebSrvFunctions.ReturnType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.ReturnTypeFullName, convWebSrvFunctions.ReturnTypeFullName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.ReturnTypeId, convWebSrvFunctions.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.DataTypeName, convWebSrvFunctions.DataTypeName);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.DataTypeAbbr, convWebSrvFunctions.DataTypeAbbr);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.NetSysType, convWebSrvFunctions.NetSysType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.CsType, convWebSrvFunctions.CsType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.JavaType, convWebSrvFunctions.JavaType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.JavaObjType, convWebSrvFunctions.JavaObjType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.SwiftType, convWebSrvFunctions.SwiftType);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.SourceFunction, convWebSrvFunctions.SourceFunction);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.ReturnValueDescription, convWebSrvFunctions.ReturnValueDescription);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.FuncParaLst, convWebSrvFunctions.FuncParaLst);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.UpdDate, convWebSrvFunctions.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.UpdUser, convWebSrvFunctions.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.Memo, convWebSrvFunctions.Memo);
clsCheckSql.CheckSqlInjection4Field(objvWebSrvFunctionsEN.ClsName, convWebSrvFunctions.ClsName);
//检查外键字段长度
 objvWebSrvFunctionsEN._IsCheckProperty = true;
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvFunctionsEN._CurrTabName);
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvWebSrvFunctionsEN._CurrTabName, strCondition);
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
 objSQL = clsvWebSrvFunctionsDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}