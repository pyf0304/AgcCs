
 /*-- -- -- -- -- -- -- -- -- -- --
 类名:clsvFunction4CodeDA
 表名:vFunction4Code(00050387)
 * 版本:2025.07.25.1(服务器:WIN-SRV103-116)
 日期:2025/07/28 01:45:27
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
 /// v函数4Code(vFunction4Code)
 /// (AutoGCLib.DALCode4CSharp:GeneCode)
 /// </summary>
public class  clsvFunction4CodeDA : clsCommBase4DA
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
 return clsvFunction4CodeEN._CurrTabName;
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
if (string.IsNullOrEmpty(clsvFunction4CodeEN._ConnectString)  ==  true)
{
objSQL = new clsSpecSQLforSql();
}
else
{
objSQL = new clsSpecSQLforSql(clsvFunction4CodeEN._ConnectString);
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
 if (string.IsNullOrEmpty(clsvFunction4CodeEN._ConnectString)  ==  true)
 {
 objSQL = new clsSpecSQLforSql();
 }
 else
 {
 objSQL = new clsSpecSQLforSql(clsvFunction4CodeEN._ConnectString);
 }
 return objSQL;
 }


 /// <summary>
 /// 检查表关键字是否合法,是否含有SQL注入
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckPrimaryKey)
 /// </summary>
 /// <param name = "strFuncId4Code">关键字</param>
 /// <returns>是否检查成功</returns>
public bool CheckPrimaryKey(string strFuncId4Code)
{
strFuncId4Code = strFuncId4Code.Replace("'", "''");
if (strFuncId4Code.Length > 8)
{
throw new Exception("(errid:Data000001)在表:vFunction4Code中,检查关键字,长度不正确!(clsvFunction4CodeDA:CheckPrimaryKey)");
}
if (string.IsNullOrEmpty(strFuncId4Code)  ==  true)
{
throw new Exception("(errid:Data000002)在表:vFunction4Code中,关键字不能为空 或 null!(clsvFunction4CodeDA:CheckPrimaryKey)");
}
try
{
clsCheckSql.CheckStrSQL_Weak(strFuncId4Code);
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000003)在关键字中含有{0},非法,请检查!(clsvFunction4CodeDA:CheckPrimaryKey)", objException.Message));
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
throw new Exception(string.Format("(errid:Data000017)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
return objDT;
}
 /// <summary>
 /// 根据条件获取数据表,用DataTable表示,同时检查是否含有SQL攻击-弱检查
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetDataTable)
 /// </summary>
 /// <param name = "strCondition">条件串</param>
 /// <returns>返回数据表DataTable</returns>
public System.Data.DataTable GetDataTable_vFunction4Code(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000018)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable_vFunction4Code)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000075)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000019)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where " + strCondition;
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
throw new Exception(string.Format("(errid:Data000076)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
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
throw new Exception(string.Format("(errid:Data000021)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1}", intTopSize, strCondition);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1} order by {2}", intTopSize, strCondition, strOrderBy);
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
throw new Exception(string.Format("(errid:Data000022)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTable_Top)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1}", intTopSize, strCondition);
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
throw new Exception(string.Format("(errid:Data000024)在分页查询中输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunction4Code.* " + 
$"from vFunction4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunction4Code.FuncId4Code not in " + 
$"(Select top {intTop_In} vFunction4Code.FuncId4Code from vFunction4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1} and FuncId4Code not in (Select top {2} FuncId4Code from vFunction4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1} and FuncId4Code not in (Select top {3} FuncId4Code from vFunction4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
throw new Exception(string.Format("(errid:Data000025)在分页查询中输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetDataTableByPager)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
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
strSQL = $"Select Top {intPageSize} vFunction4Code.* " + 
$"from vFunction4Code " + 
$"{strLeftLinkStr} " + 
$"where {strCondition} and vFunction4Code.FuncId4Code not in " + 
$"(Select top {intTop_In} vFunction4Code.FuncId4Code from vFunction4Code " + 
$"{strLeftLinkStr} " +
$" where {strCondition} " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection}) " + 
$"order by {sortInfo.SortField} {sortInfo.SortDirection} ";
}
else
{
 if (string.IsNullOrEmpty(strOrderBy) == true)
 {
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1} and FuncId4Code not in (Select top {2} FuncId4Code from vFunction4Code where {1}) ", intPageSize, strCondition, intTop_In);
 }
 else
 {
 strSQL = string.Format("Select Top {0} * from vFunction4Code where {1} and FuncId4Code not in (Select top {3} FuncId4Code from vFunction4Code where {1} order by {2}) order by {2} ", intPageSize, strCondition, strOrderBy, intTop_In);
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
public List<clsvFunction4CodeEN> GetObjLst(string strCondition)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000037)在输入条件中含有{0},请检查!(clsvFunction4CodeDA:GetObjLst)", objException.Message));
}
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = TransNullToInt(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunction4CodeDA: GetObjLst)", objException.Message));
}
objvFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunction4CodeEN);
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
public List<clsvFunction4CodeEN> GetObjLstByTabName(string strCondition, string strTabName)
{
 try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000074)在输入条件中含有{0},请检查!(clsvFunction4CodeDA:GetObjLstByTabName)", objException.Message));
}
List<clsvFunction4CodeEN> arrObjLst = new List<clsvFunction4CodeEN>(); 
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = string.Format("Select * from {0} where {1}", strTabName, strCondition);
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return arrObjLst;
}
foreach(DataRow objRow in objDT.Rows)
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = TransNullToInt(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取对象列表时,发生:{0},请检查!(clsvFunction4CodeDA: GetObjLst)", objException.Message));
}
objvFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
	arrObjLst.Add(objvFunction4CodeEN);
	}
return arrObjLst;
}

 #endregion 获取数据表的多个对象列表

 #region 获取一个实体对象

 /// <summary>
 /// 获取当前关键字的记录对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:GenGetRecValue)
 /// </summary>
 /// <param name = "objvFunction4CodeEN">需要添加到数据库中的对象</param>
 /// <returns>是否成功</returns>
public bool GetvFunction4Code(ref clsvFunction4CodeEN objvFunction4CodeEN)
{
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where FuncId4Code = " + "'"+ objvFunction4CodeEN.FuncId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return false;
}
try
{
 objvFunction4CodeEN.FuncId4Code = objDT.Rows[0][convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4CodeEN.FuncName4Code = objDT.Rows[0][convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4CodeEN.FuncCHName4Code = objDT.Rows[0][convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvFunction4CodeEN.PrevFuncId = objDT.Rows[0][convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvFunction4CodeEN.RootFuncId = objDT.Rows[0][convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvFunction4CodeEN.ApplicationTypeId = TransNullToInt(objDT.Rows[0][convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvFunction4CodeEN.ApplicationTypeName = objDT.Rows[0][convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunction4CodeEN.FuncGCTypeId = objDT.Rows[0][convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncGCTypeName = objDT.Rows[0][convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4CodeEN.FuncGCTypeENName = objDT.Rows[0][convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4CodeEN.FunctionSignature = objDT.Rows[0][convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4CodeEN.FunctionSignatureSim = objDT.Rows[0][convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4CodeEN.ReturnType = objDT.Rows[0][convFunction4Code.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4CodeEN.ReturnTypeId = objDT.Rows[0][convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvFunction4CodeEN.ReturnTypeNameCustom = objDT.Rows[0][convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4CodeEN.CodeTypeId = objDT.Rows[0][convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4CodeEN.CodeTypeName = objDT.Rows[0][convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunction4CodeEN.ProgLangTypeId = objDT.Rows[0][convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncAccessModeId = objDT.Rows[0][convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncAccessModeName = objDT.Rows[0][convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunction4CodeEN.TabName = objDT.Rows[0][convFunction4Code.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4CodeEN.TabId = objDT.Rows[0][convFunction4Code.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4CodeEN.FuncPurposeId = objDT.Rows[0][convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncPurposeName = objDT.Rows[0][convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4CodeEN.FuncTypeId = objDT.Rows[0][convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncTypeName = objDT.Rows[0][convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4CodeEN.IsAsyncFunc = TransNullToBool(objDT.Rows[0][convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4CodeEN.IsSysFunction = TransNullToBool(objDT.Rows[0][convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4CodeEN.OrderNum = TransNullToInt(objDT.Rows[0][convFunction4Code.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunction4CodeEN.PrjId = objDT.Rows[0][convFunction4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4CodeEN.UpdDate = objDT.Rows[0][convFunction4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4CodeEN.UpdUser = objDT.Rows[0][convFunction4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4CodeEN.Memo = objDT.Rows[0][convFunction4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunction4CodeEN.ReturnTypeName = objDT.Rows[0][convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunction4CodeEN.TabName2 = objDT.Rows[0][convFunction4Code.TabName2].ToString().Trim(); //TabName2(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunction4CodeEN.Func4GCCount = TransNullToInt(objDT.Rows[0][convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4CodeEN.ParaNum = TransNullToInt(objDT.Rows[0][convFunction4Code.ParaNum].ToString().Trim()); //参数个数(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4CodeEN.FeatureCount = TransNullToInt(objDT.Rows[0][convFunction4Code.FeatureCount].ToString().Trim()); //功能数(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4CodeEN.ClsName = objDT.Rows[0][convFunction4Code.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据关键字获取对象时,发生:{0},请检查!(clsvFunction4CodeDA: GetvFunction4Code)", objException.Message));
}
return true;
}

 /// <summary>
 /// 根据关键字获取相关对象,用对象的形式表示.
 /// (AutoGCLib.DALCode4CSharp:Gen_GetObjByKeyId)
 /// </summary>
 /// <param name = "strFuncId4Code">表关键字</param>
 /// <returns>表对象</returns>
public clsvFunction4CodeEN GetObjByFuncId4Code(string strFuncId4Code)
{
CheckPrimaryKey(strFuncId4Code);
string strSQL ;
System.Data.DataTable objDT ; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where FuncId4Code = " + "'"+ strFuncId4Code+"'";
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
 DataRow objRow = objDT.Rows[0];
clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
 objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code(字段类型:varchar,字段长度:200,是否可空:True)
 objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id(字段类型:char,字段长度:8,是否可空:True)
 objvFunction4CodeEN.ApplicationTypeId = Int32.Parse(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID(字段类型:int,字段长度:4,是否可空:False)
 objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称(字段类型:varchar,字段长度:30,是否可空:False)
 objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型(字段类型:varchar,字段长度:500,是否可空:False)
 objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID(字段类型:char,字段长度:2,是否可空:True)
 objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名(字段类型:varchar,字段长度:50,是否可空:True)
 objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名(字段类型:varchar,字段长度:50,是否可空:False)
 objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名(字段类型:varchar,字段长度:100,是否可空:False)
 objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID(字段类型:char,字段长度:8,是否可空:False)
 objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id(字段类型:char,字段长度:2,是否可空:False)
 objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名(字段类型:varchar,字段长度:20,是否可空:False)
 objvFunction4CodeEN.IsAsyncFunc = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4CodeEN.IsSysFunction = clsEntityBase2.TransNullToBool_S(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数(字段类型:bit,字段长度:1,是否可空:True)
 objvFunction4CodeEN.OrderNum = Int32.Parse(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号(字段类型:int,字段长度:4,是否可空:False)
 objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id(字段类型:char,字段长度:4,是否可空:False)
 objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者(字段类型:varchar,字段长度:20,是否可空:True)
 objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明(字段类型:varchar,字段长度:1000,是否可空:True)
 objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2(字段类型:varchar,字段长度:100,是否可空:True)
 objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : clsEntityBase2.TransNullToInt_S(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数(字段类型:int,字段长度:4,是否可空:True)
 objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名(字段类型:varchar,字段长度:100,是否可空:False)
}
 catch(Exception objException)
{
throw new Exception(string.Format("根据关键字获取相关对象时,发生:{0},请检查!(clsvFunction4CodeDA: GetObjByFuncId4Code)", objException.Message));
}
return objvFunction4CodeEN;
}

 /// <summary>
 /// 获取第一条满足条件的记录,以对象形式表示
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetFirstCondRecObj)
 /// </summary>
 /// <param name = "strCondition">给定条件</param>
 /// <returns>返回满足条件的第一个对象</returns>
public clsvFunction4CodeEN GetFirstObj(string strCondition)
{
try
{
 clsCheckSql.CheckStrSQL_Weak(strCondition);
 strCondition = clsString.RemoveElementValue(strCondition, "exclude");
}
catch (Exception objException)
{
throw new Exception(string.Format("(errid:Data000039)在输入条件中含有{0},请检查!(clsvFunction4CodeDA: GetFirstObj)", objException.Message));
}
string strSQL; 
System.Data.DataTable objDT; 
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
strSQL = "Select * from vFunction4Code where " + strCondition;
objDT = objSQL.GetDataTable(strSQL);
if (objDT.Rows.Count  ==  0)
{
return null;
}
DataRow objRow = objDT.Rows[0];
try
{
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN()
{
FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(), //函数Id4Code
FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(), //函数名4Code
FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(), //函数中文名4Code
PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(), //前函数Id
RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(), //根函数Id
ApplicationTypeId = TransNullToInt(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()), //应用程序类型ID
ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(), //应用程序类型名称
FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(), //函数生成代码类型Id
FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(), //函数生成代码类型名
FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(), //函数生成代码类型英文名
FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(), //函数签名
FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(), //函数签名_Sim
ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(), //返回类型
ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(), //返回类型ID
ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(), //定制返回类型名
CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(), //代码类型Id
CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(), //代码类型名
ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(), //编程语言类型Id
FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(), //函数操作模式Id
FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(), //函数操作模式名
TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(), //表名
TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(), //表ID
FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(), //函数用途Id
FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(), //函数用途名
FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(), //函数类型Id
FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(), //函数类型名
IsAsyncFunc = TransNullToBool(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()), //是否异步函数
IsSysFunction = TransNullToBool(objRow[convFunction4Code.IsSysFunction].ToString().Trim()), //是否系统函数
OrderNum = TransNullToInt(objRow[convFunction4Code.OrderNum].ToString().Trim()), //序号
PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(), //工程Id
UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(), //修改日期
UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(), //修改者
Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(), //说明
ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(), //返回类型名
TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(), //TabName2
Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.Func4GCCount].ToString().Trim()), //函数4GC数
ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.ParaNum].ToString().Trim()), //参数个数
FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.FeatureCount].ToString().Trim()), //功能数
ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim() //类名
};
objvFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4CodeEN;
}
 catch(Exception objException)
{
throw new Exception(string.Format("在根据条件获取第一个对象时,发生:{0},请检查!(clsvFunction4CodeDA: GetFirstObj)", objException.Message));
}
}

 /// <summary>
 /// 把DataRow转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRow</param>
 /// <returns>记录对象</returns>
public clsvFunction4CodeEN GetObjByDataRow(DataRow objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = TransNullToInt(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRow转换成记录对象时,发生:{0},请检查!(clsvFunction4CodeDA: GetObjByDataRowvFunction4Code)", objException.Message));
}
objvFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4CodeEN;
}
 /// <summary>
 /// 把DataRowView转换成记录对象.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenGetRecValueObjByDataRow)
 /// </summary>
 /// <param name = "objRow">所给的DataRowView</param>
 /// <returns>记录对象</returns>
public clsvFunction4CodeEN GetObjByDataRow(DataRowView objRow)
{
if (objRow  ==  null)
{
return null;
}
	clsvFunction4CodeEN objvFunction4CodeEN = new clsvFunction4CodeEN();
try
{
objvFunction4CodeEN.FuncId4Code = objRow[convFunction4Code.FuncId4Code].ToString().Trim(); //函数Id4Code
objvFunction4CodeEN.FuncName4Code = objRow[convFunction4Code.FuncName4Code].ToString().Trim(); //函数名4Code
objvFunction4CodeEN.FuncCHName4Code = objRow[convFunction4Code.FuncCHName4Code] == DBNull.Value ? null : objRow[convFunction4Code.FuncCHName4Code].ToString().Trim(); //函数中文名4Code
objvFunction4CodeEN.PrevFuncId = objRow[convFunction4Code.PrevFuncId] == DBNull.Value ? null : objRow[convFunction4Code.PrevFuncId].ToString().Trim(); //前函数Id
objvFunction4CodeEN.RootFuncId = objRow[convFunction4Code.RootFuncId] == DBNull.Value ? null : objRow[convFunction4Code.RootFuncId].ToString().Trim(); //根函数Id
objvFunction4CodeEN.ApplicationTypeId = TransNullToInt(objRow[convFunction4Code.ApplicationTypeId].ToString().Trim()); //应用程序类型ID
objvFunction4CodeEN.ApplicationTypeName = objRow[convFunction4Code.ApplicationTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ApplicationTypeName].ToString().Trim(); //应用程序类型名称
objvFunction4CodeEN.FuncGCTypeId = objRow[convFunction4Code.FuncGCTypeId].ToString().Trim(); //函数生成代码类型Id
objvFunction4CodeEN.FuncGCTypeName = objRow[convFunction4Code.FuncGCTypeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeName].ToString().Trim(); //函数生成代码类型名
objvFunction4CodeEN.FuncGCTypeENName = objRow[convFunction4Code.FuncGCTypeENName] == DBNull.Value ? null : objRow[convFunction4Code.FuncGCTypeENName].ToString().Trim(); //函数生成代码类型英文名
objvFunction4CodeEN.FunctionSignature = objRow[convFunction4Code.FunctionSignature].ToString().Trim(); //函数签名
objvFunction4CodeEN.FunctionSignatureSim = objRow[convFunction4Code.FunctionSignatureSim] == DBNull.Value ? null : objRow[convFunction4Code.FunctionSignatureSim].ToString().Trim(); //函数签名_Sim
objvFunction4CodeEN.ReturnType = objRow[convFunction4Code.ReturnType].ToString().Trim(); //返回类型
objvFunction4CodeEN.ReturnTypeId = objRow[convFunction4Code.ReturnTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeId].ToString().Trim(); //返回类型ID
objvFunction4CodeEN.ReturnTypeNameCustom = objRow[convFunction4Code.ReturnTypeNameCustom] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeNameCustom].ToString().Trim(); //定制返回类型名
objvFunction4CodeEN.CodeTypeId = objRow[convFunction4Code.CodeTypeId] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeId].ToString().Trim(); //代码类型Id
objvFunction4CodeEN.CodeTypeName = objRow[convFunction4Code.CodeTypeName] == DBNull.Value ? null : objRow[convFunction4Code.CodeTypeName].ToString().Trim(); //代码类型名
objvFunction4CodeEN.ProgLangTypeId = objRow[convFunction4Code.ProgLangTypeId] == DBNull.Value ? null : objRow[convFunction4Code.ProgLangTypeId].ToString().Trim(); //编程语言类型Id
objvFunction4CodeEN.FuncAccessModeId = objRow[convFunction4Code.FuncAccessModeId] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeId].ToString().Trim(); //函数操作模式Id
objvFunction4CodeEN.FuncAccessModeName = objRow[convFunction4Code.FuncAccessModeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncAccessModeName].ToString().Trim(); //函数操作模式名
objvFunction4CodeEN.TabName = objRow[convFunction4Code.TabName] == DBNull.Value ? null : objRow[convFunction4Code.TabName].ToString().Trim(); //表名
objvFunction4CodeEN.TabId = objRow[convFunction4Code.TabId] == DBNull.Value ? null : objRow[convFunction4Code.TabId].ToString().Trim(); //表ID
objvFunction4CodeEN.FuncPurposeId = objRow[convFunction4Code.FuncPurposeId].ToString().Trim(); //函数用途Id
objvFunction4CodeEN.FuncPurposeName = objRow[convFunction4Code.FuncPurposeName] == DBNull.Value ? null : objRow[convFunction4Code.FuncPurposeName].ToString().Trim(); //函数用途名
objvFunction4CodeEN.FuncTypeId = objRow[convFunction4Code.FuncTypeId].ToString().Trim(); //函数类型Id
objvFunction4CodeEN.FuncTypeName = objRow[convFunction4Code.FuncTypeName].ToString().Trim(); //函数类型名
objvFunction4CodeEN.IsAsyncFunc = TransNullToBool(objRow[convFunction4Code.IsAsyncFunc].ToString().Trim()); //是否异步函数
objvFunction4CodeEN.IsSysFunction = TransNullToBool(objRow[convFunction4Code.IsSysFunction].ToString().Trim()); //是否系统函数
objvFunction4CodeEN.OrderNum = TransNullToInt(objRow[convFunction4Code.OrderNum].ToString().Trim()); //序号
objvFunction4CodeEN.PrjId = objRow[convFunction4Code.PrjId] == DBNull.Value ? null : objRow[convFunction4Code.PrjId].ToString().Trim(); //工程Id
objvFunction4CodeEN.UpdDate = objRow[convFunction4Code.UpdDate] == DBNull.Value ? null : objRow[convFunction4Code.UpdDate].ToString().Trim(); //修改日期
objvFunction4CodeEN.UpdUser = objRow[convFunction4Code.UpdUser] == DBNull.Value ? null : objRow[convFunction4Code.UpdUser].ToString().Trim(); //修改者
objvFunction4CodeEN.Memo = objRow[convFunction4Code.Memo] == DBNull.Value ? null : objRow[convFunction4Code.Memo].ToString().Trim(); //说明
objvFunction4CodeEN.ReturnTypeName = objRow[convFunction4Code.ReturnTypeName] == DBNull.Value ? null : objRow[convFunction4Code.ReturnTypeName].ToString().Trim(); //返回类型名
objvFunction4CodeEN.TabName2 = objRow[convFunction4Code.TabName2] == DBNull.Value ? null : objRow[convFunction4Code.TabName2].ToString().Trim(); //TabName2
objvFunction4CodeEN.Func4GCCount = objRow[convFunction4Code.Func4GCCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.Func4GCCount].ToString().Trim()); //函数4GC数
objvFunction4CodeEN.ParaNum = objRow[convFunction4Code.ParaNum] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.ParaNum].ToString().Trim()); //参数个数
objvFunction4CodeEN.FeatureCount = objRow[convFunction4Code.FeatureCount] == DBNull.Value ? (int?)null : TransNullToInt(objRow[convFunction4Code.FeatureCount].ToString().Trim()); //功能数
objvFunction4CodeEN.ClsName = objRow[convFunction4Code.ClsName] == DBNull.Value ? null : objRow[convFunction4Code.ClsName].ToString().Trim(); //类名
}
 catch(Exception objException)
{
throw new Exception(string.Format("把DataRowView转换成记录对象时,发生:{0},请检查!(clsvFunction4CodeDA: GetObjByDataRow)", objException.Message));
}
objvFunction4CodeEN.ClearUpdateState();//清除修改状态,即清除脏字段信息
return objvFunction4CodeEN;
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
objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunction4CodeEN._CurrTabName, convFunction4Code.FuncId4Code, 8, "");
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
objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
string strMaxValue = objSQL.GetMaxStrId(clsvFunction4CodeEN._CurrTabName, convFunction4Code.FuncId4Code, 8, strPrefix);
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
string strKeyValue; 
strSQL = "Select FuncId4Code from vFunction4Code where " + strCondition;
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
int iRow, iCol; 
string strKeyValue; 
strSQL = "Select FuncId4Code from vFunction4Code where " + strCondition;
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
 /// <param name = "strFuncId4Code">给定的关键字值</param>
 /// <returns>返回是否存在?</returns>
public bool IsExist(string strFuncId4Code)
{
CheckPrimaryKey(strFuncId4Code);
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunction4Code", "FuncId4Code = " + "'"+ strFuncId4Code+"'"))
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
throw new Exception(string.Format("(errid:Data000041)在输入条件中含有{0},请检查!(clsvFunction4CodeDA:IsExistCondRec)", objException.Message));
}
 clsSpecSQLforSql objSQL;
 //获取连接对象
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
if (objSQL.IsExistRecord("vFunction4Code", strCondition))
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
objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
bool bolIsExist = objSQL.IsExistTable("vFunction4Code");
return bolIsExist;
}

 #endregion 判断记录是否存在

 #region 克隆复制对象

 /// <summary>
 /// 把同一个类的对象,复制到另一个对象
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCopyObj_S)
 /// </summary>
 /// <param name = "objvFunction4CodeENS">源对象</param>
 /// <param name = "objvFunction4CodeENT">目标对象</param>
public void CopyTo(clsvFunction4CodeEN objvFunction4CodeENS, clsvFunction4CodeEN objvFunction4CodeENT)
{
objvFunction4CodeENT.FuncId4Code = objvFunction4CodeENS.FuncId4Code; //函数Id4Code
objvFunction4CodeENT.FuncName4Code = objvFunction4CodeENS.FuncName4Code; //函数名4Code
objvFunction4CodeENT.FuncCHName4Code = objvFunction4CodeENS.FuncCHName4Code; //函数中文名4Code
objvFunction4CodeENT.PrevFuncId = objvFunction4CodeENS.PrevFuncId; //前函数Id
objvFunction4CodeENT.RootFuncId = objvFunction4CodeENS.RootFuncId; //根函数Id
objvFunction4CodeENT.ApplicationTypeId = objvFunction4CodeENS.ApplicationTypeId; //应用程序类型ID
objvFunction4CodeENT.ApplicationTypeName = objvFunction4CodeENS.ApplicationTypeName; //应用程序类型名称
objvFunction4CodeENT.FuncGCTypeId = objvFunction4CodeENS.FuncGCTypeId; //函数生成代码类型Id
objvFunction4CodeENT.FuncGCTypeName = objvFunction4CodeENS.FuncGCTypeName; //函数生成代码类型名
objvFunction4CodeENT.FuncGCTypeENName = objvFunction4CodeENS.FuncGCTypeENName; //函数生成代码类型英文名
objvFunction4CodeENT.FunctionSignature = objvFunction4CodeENS.FunctionSignature; //函数签名
objvFunction4CodeENT.FunctionSignatureSim = objvFunction4CodeENS.FunctionSignatureSim; //函数签名_Sim
objvFunction4CodeENT.ReturnType = objvFunction4CodeENS.ReturnType; //返回类型
objvFunction4CodeENT.ReturnTypeId = objvFunction4CodeENS.ReturnTypeId; //返回类型ID
objvFunction4CodeENT.ReturnTypeNameCustom = objvFunction4CodeENS.ReturnTypeNameCustom; //定制返回类型名
objvFunction4CodeENT.CodeTypeId = objvFunction4CodeENS.CodeTypeId; //代码类型Id
objvFunction4CodeENT.CodeTypeName = objvFunction4CodeENS.CodeTypeName; //代码类型名
objvFunction4CodeENT.ProgLangTypeId = objvFunction4CodeENS.ProgLangTypeId; //编程语言类型Id
objvFunction4CodeENT.FuncAccessModeId = objvFunction4CodeENS.FuncAccessModeId; //函数操作模式Id
objvFunction4CodeENT.FuncAccessModeName = objvFunction4CodeENS.FuncAccessModeName; //函数操作模式名
objvFunction4CodeENT.TabName = objvFunction4CodeENS.TabName; //表名
objvFunction4CodeENT.TabId = objvFunction4CodeENS.TabId; //表ID
objvFunction4CodeENT.FuncPurposeId = objvFunction4CodeENS.FuncPurposeId; //函数用途Id
objvFunction4CodeENT.FuncPurposeName = objvFunction4CodeENS.FuncPurposeName; //函数用途名
objvFunction4CodeENT.FuncTypeId = objvFunction4CodeENS.FuncTypeId; //函数类型Id
objvFunction4CodeENT.FuncTypeName = objvFunction4CodeENS.FuncTypeName; //函数类型名
objvFunction4CodeENT.IsAsyncFunc = objvFunction4CodeENS.IsAsyncFunc; //是否异步函数
objvFunction4CodeENT.IsSysFunction = objvFunction4CodeENS.IsSysFunction; //是否系统函数
objvFunction4CodeENT.OrderNum = objvFunction4CodeENS.OrderNum; //序号
objvFunction4CodeENT.PrjId = objvFunction4CodeENS.PrjId; //工程Id
objvFunction4CodeENT.UpdDate = objvFunction4CodeENS.UpdDate; //修改日期
objvFunction4CodeENT.UpdUser = objvFunction4CodeENS.UpdUser; //修改者
objvFunction4CodeENT.Memo = objvFunction4CodeENS.Memo; //说明
objvFunction4CodeENT.ReturnTypeName = objvFunction4CodeENS.ReturnTypeName; //返回类型名
objvFunction4CodeENT.TabName2 = objvFunction4CodeENS.TabName2; //TabName2
objvFunction4CodeENT.Func4GCCount = objvFunction4CodeENS.Func4GCCount; //函数4GC数
objvFunction4CodeENT.ParaNum = objvFunction4CodeENS.ParaNum; //参数个数
objvFunction4CodeENT.FeatureCount = objvFunction4CodeENS.FeatureCount; //功能数
objvFunction4CodeENT.ClsName = objvFunction4CodeENS.ClsName; //类名
}

 #endregion 克隆复制对象

 #region 检查对象属性

 /// <summary>
 /// 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
 /// (AutoGCLib.clsGeneCodeBase4Tab:GenCheckProperty4Condition)
 /// </summary>
public void CheckProperty4Condition(clsvFunction4CodeEN objvFunction4CodeEN)
{
//检查字段长度
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncId4Code, 8, convFunction4Code.FuncId4Code);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncName4Code, 100, convFunction4Code.FuncName4Code);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncCHName4Code, 200, convFunction4Code.FuncCHName4Code);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.PrevFuncId, 8, convFunction4Code.PrevFuncId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.RootFuncId, 8, convFunction4Code.RootFuncId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ApplicationTypeName, 30, convFunction4Code.ApplicationTypeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncGCTypeId, 2, convFunction4Code.FuncGCTypeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncGCTypeName, 50, convFunction4Code.FuncGCTypeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncGCTypeENName, 50, convFunction4Code.FuncGCTypeENName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FunctionSignature, 500, convFunction4Code.FunctionSignature);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FunctionSignatureSim, 500, convFunction4Code.FunctionSignatureSim);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ReturnType, 500, convFunction4Code.ReturnType);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ReturnTypeId, 2, convFunction4Code.ReturnTypeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ReturnTypeNameCustom, 50, convFunction4Code.ReturnTypeNameCustom);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.CodeTypeId, 4, convFunction4Code.CodeTypeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.CodeTypeName, 50, convFunction4Code.CodeTypeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ProgLangTypeId, 2, convFunction4Code.ProgLangTypeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncAccessModeId, 2, convFunction4Code.FuncAccessModeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncAccessModeName, 50, convFunction4Code.FuncAccessModeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.TabName, 100, convFunction4Code.TabName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.TabId, 8, convFunction4Code.TabId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncPurposeId, 2, convFunction4Code.FuncPurposeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncPurposeName, 20, convFunction4Code.FuncPurposeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncTypeId, 2, convFunction4Code.FuncTypeId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.FuncTypeName, 20, convFunction4Code.FuncTypeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.PrjId, 4, convFunction4Code.PrjId);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.UpdDate, 20, convFunction4Code.UpdDate);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.UpdUser, 20, convFunction4Code.UpdUser);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.Memo, 1000, convFunction4Code.Memo);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ReturnTypeName, 100, convFunction4Code.ReturnTypeName);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.TabName2, 100, convFunction4Code.TabName2);
clsCheckSql.CheckFieldLen(objvFunction4CodeEN.ClsName, 100, convFunction4Code.ClsName);
//检查Sql注入
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncId4Code, convFunction4Code.FuncId4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncName4Code, convFunction4Code.FuncName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncCHName4Code, convFunction4Code.FuncCHName4Code);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.PrevFuncId, convFunction4Code.PrevFuncId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.RootFuncId, convFunction4Code.RootFuncId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ApplicationTypeName, convFunction4Code.ApplicationTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncGCTypeId, convFunction4Code.FuncGCTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncGCTypeName, convFunction4Code.FuncGCTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncGCTypeENName, convFunction4Code.FuncGCTypeENName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FunctionSignature, convFunction4Code.FunctionSignature);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FunctionSignatureSim, convFunction4Code.FunctionSignatureSim);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ReturnType, convFunction4Code.ReturnType);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ReturnTypeId, convFunction4Code.ReturnTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ReturnTypeNameCustom, convFunction4Code.ReturnTypeNameCustom);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.CodeTypeId, convFunction4Code.CodeTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.CodeTypeName, convFunction4Code.CodeTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ProgLangTypeId, convFunction4Code.ProgLangTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncAccessModeId, convFunction4Code.FuncAccessModeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncAccessModeName, convFunction4Code.FuncAccessModeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.TabName, convFunction4Code.TabName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.TabId, convFunction4Code.TabId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncPurposeId, convFunction4Code.FuncPurposeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncPurposeName, convFunction4Code.FuncPurposeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncTypeId, convFunction4Code.FuncTypeId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.FuncTypeName, convFunction4Code.FuncTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.PrjId, convFunction4Code.PrjId);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.UpdDate, convFunction4Code.UpdDate);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.UpdUser, convFunction4Code.UpdUser);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.Memo, convFunction4Code.Memo);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ReturnTypeName, convFunction4Code.ReturnTypeName);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.TabName2, convFunction4Code.TabName2);
clsCheckSql.CheckSqlInjection4Field(objvFunction4CodeEN.ClsName, convFunction4Code.ClsName);
//检查外键字段长度
 objvFunction4CodeEN._IsCheckProperty = true;
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunction4CodeEN._CurrTabName);
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
int intRecCount = objSQL.GetRecCount(clsvFunction4CodeEN._CurrTabName, strCondition);
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
 objSQL = clsvFunction4CodeDA.GetSpecSQLObj();
 List<string> arrList = objSQL.GetFldDataOfTable(strTabName, strFldName, strCondition);
return arrList;
}


 #endregion 表操作常用函数
}
}